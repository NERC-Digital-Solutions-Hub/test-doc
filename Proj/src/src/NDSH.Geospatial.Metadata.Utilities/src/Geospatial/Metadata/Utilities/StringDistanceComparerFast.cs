
#region Imported Namespaces

using NDSH.Geospatial.Metadata.Utilities.Models;
using NDSH.Math.Distances;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities {

  /// <summary>
  /// 
  /// </summary>
  public class StringDistanceComparerFast {

    #region Constructors - Destructors

    ///// <summary>
    ///// Initializes the <see cref="StringDistanceComparerFast"/>.
    ///// </summary>
    //public StringDistanceComparerFast() {

    //}

    #endregion

    #region Properties

    /// <summary>
    /// Gets/Sets the List of <see cref="PTaskArgs"/> used to create a <see cref="Thread"/>.
    /// </summary>
    private List<PTaskArgs> PTaskArgsList {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the record ids indicating the bins.
    /// </summary>
    private List<int> Bins {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    private int TitlesTotalLength {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    private Dictionary<int, TitleRecord> TitleRecords {
      get; set;
    }

    #endregion

    /// <summary>
    /// 
    /// </summary>
    /// <param name="databasePath"></param>
    public void LoadTitles(string databasePath) {

      MetadataDatabaseController controller = new MetadataDatabaseController();
      controller.DatabasePath = databasePath;
      controller.OpenDatabase();
      ImmutableSortedDictionary<int, string> titlesImmutableSortedDictionary = controller.GetAllTitles();

      int position = 0;

      this.TitleRecords = new Dictionary<int, TitleRecord>(titlesImmutableSortedDictionary.Count);

      foreach (var item in titlesImmutableSortedDictionary) {
        this.TitleRecords.Add(
          item.Key,
          new TitleRecord() {
            Id = item.Key,
            Title = item.Value,
            Length = (item.Value != null) ? item.Value.Length : 0,
            Position = position
          }
        );

        position += (item.Value != null) ? item.Value.Length : 0;
      }

      this.TitlesTotalLength = position;

      controller.CloseDatabase();

    }

    /// <summary>
    /// 
    /// </summary>
    public void CalculateAllPairs(int numberOfBins) {

      if (numberOfBins < 1 || numberOfBins > Environment.ProcessorCount) {
        throw new ArgumentOutOfRangeException("The number of bins should be a positive integer no more than the total number of logical processors.");
      }

      // Get the bins so that their number of string allocation results into
      // almost equal distribution of computation.
      this.Bins = GetEqualBins(this.TitleRecords.Count + 1, numberOfBins);

      // Create an array of threads.
      Thread[] threads = new Thread[numberOfBins];
      this.PTaskArgsList = new List<PTaskArgs>(numberOfBins);

      // Loop through the number of bins and create a thread for each bin.
      for (int i = 0; i < numberOfBins; i++) {
        PTaskArgs args = new PTaskArgs() { BinIndex = i };
        this.PTaskArgsList.Add(args);

        threads[i] = new Thread(new ParameterizedThreadStart(PTask));
        threads[i].Name = string.Format("Thread:{0} - RecordId:{1}", i, this.Bins[i]);
        threads[i].Start(args);
      }

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="pTaskArguments"></param>
    private void PTask(object pTaskArguments) {

      PTaskArgs pTaskArgs = (PTaskArgs)pTaskArguments;

      LevenshteinNdsh levenshtein2 = new LevenshteinNdsh();

      // Allocate a span in the stack to store the titles.
      int key = this.Bins[pTaskArgs.BinIndex];
      TitleRecord titleRecord = this.TitleRecords[key];
      int spanLength = this.TitlesTotalLength - titleRecord.Position;

      Span<char> titlesSpan = stackalloc char[spanLength];

      // Allocate a span for the Record Ids in the stack.
      Span<int> titleRecordIdsSpan = stackalloc int[this.TitleRecords.Count - titleRecord.Id - 1];

      // Allocate a span for the lengths in the stack.
      Span<int> titleLengthsSpan = stackalloc int[this.TitleRecords.Count - titleRecord.Id - 1];

      while (this.TitleRecords.ContainsKey(key)) {
        titleRecordIdsSpan[key] = key;
        titleLengthsSpan[key] = this.TitleRecords[key].Length;

        string title = this.TitleRecords[key].Title;
        title.AsSpan().CopyTo(titlesSpan.Slice(key, this.TitleRecords[key].Length));

        key++;
      }

      //// Create the read-only spans.
      //ReadOnlySpan<char> titles = titlesSpan; //.Slice(0, currentIndex);
      //ReadOnlySpan<int> titleIndices = titleIndicesSpan; //.Slice(0, titlesDictionary.Count);
      //ReadOnlySpan<int> titleRecordIds = titleRecordIdsSpan; //.Slice(0, titlesDictionary.Count);

      int startRecordId;
      int stopRecordId;

      startRecordId = this.Bins[pTaskArgs.BinIndex];

      if (pTaskArgs.BinIndex != this.Bins.Count - 1) {
        stopRecordId = this.Bins[pTaskArgs.BinIndex + 1] - 1;
      }
      else {
        stopRecordId = this.TitleRecords[this.TitleRecords.Count - 1].Id;
      }

      List<LevenshteinTitleComparison> comparisons = new List<LevenshteinTitleComparison>();

      // Loop through all the titles in the bin.
      for (int i = startRecordId; i <= stopRecordId; i++) {
        int leftLength = titleLengthsSpan[i - 1];

        Span<char> leftTitle = new char[leftLength];
        titlesSpan.Slice(i - 1, leftLength).CopyTo(leftTitle);

        for (int j = startRecordId; /* next of i-1 */ j < titleRecordIdsSpan.Length; j++) {

          int rightLength = titleLengthsSpan[j];

          Span<char> rightTitle = new char[rightLength];
          titlesSpan.Slice(i - 1, rightLength).CopyTo(rightTitle);

          comparisons.Add(
            new LevenshteinTitleComparison() {
              RecordId1 = i,
              RecordId2 = j,
              LevenshteinDistance = levenshtein2.DistanceUtf16(leftTitle, rightTitle),
              Percentile = -1
            }
          );

        }

        Debug.WriteLine(string.Format("Thread:{0} - {1}/{2}", pTaskArgs.BinIndex, i, stopRecordId));

      }

    }

    /// <summary>
    /// <para>
    /// Gets a list of integers with the first member in a bin whose Sums are as equal as possible.
    /// </para>
    /// <para>
    /// Assuming a sequence of integers (a subset of Natural Numbers) starting from 1 to <paramref name="maxInt"/>,
    /// the total sum of all (1 + 2 + 3 + ... + <paramref name="maxInt"/>) is given by the formula:<br></br>
    /// (<paramref name="maxInt"/> * (<paramref name="maxInt"/> - 1)) / 2<br></br>
    /// This procedure allocates the subsequences in bins whose Sums are as equal as possible.
    /// </para>
    /// </summary>
    /// <param name="maxInt">The maximum number in the sequence of <see cref="int"/>.</param>
    /// <param name="totalBins">The total number of bins.</param>
    /// <returns>
    /// A <see cref="List{int}"></see> with the indices of the first member of each bin.
    /// </returns>
    private List<int> GetEqualBins(int maxInt, int totalBins) {

      int[] numbers = Enumerable.Range(1, maxInt).ToArray();

      int totalSum = numbers.Sum();
      int groupSum = totalSum / totalBins;

      //List<List<int>> groups = new List<List<int>>();
      List<int> groups = new List<int>();
      List<int> groupSums = new List<int>();
      int currentSum = 0;
      //List<int> currentGroup = new List<int>();
      int currentGroup = 0;

      for (int i = 0; i < numbers.Length; i++) {
        currentSum += numbers[i];
        //currentGroup.Add(numbers[i]);
        if (currentGroup == 0) {
          currentGroup = numbers[i];
        }

        if (currentSum >= groupSum) {
          groups.Add(currentGroup);
          //currentGroup = new List<int>();
          currentGroup = 0;
          groupSums.Add(currentSum);
          currentSum = 0;
        }
      }

      // Add any remaining numbers to the last group.
      if (currentSum > 0) {
        groups.Add(currentGroup);
        groupSums.Add(currentSum);
      }
      //if (currentGroup.Count > 0) {
      //  groups.Add(currentGroup);
      //}

      //// Print the sum of each group
      //for (int i = 0; i < groups.Count; i++) {
      //  Debug.WriteLine($"Group {i + 1}: {groups[i]}  sum: {groupSums[i]}");
      //}

      return groups;

    }

    /// <summary>
    /// 
    /// </summary>
    public class PTaskArgs {

      /// <summary>
      /// Gets/Sets the index of the bin.
      /// </summary>
      public int BinIndex {
        get; set;
      }

    }

  }

}
