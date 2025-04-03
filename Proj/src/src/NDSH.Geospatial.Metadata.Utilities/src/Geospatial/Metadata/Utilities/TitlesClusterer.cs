
#region Imported Namespaces

using MathNet.Numerics.Statistics;
using NDSH.Geospatial.Metadata.Utilities.DatabaseContext;
using NDSH.Geospatial.Metadata.Utilities.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities {

  /// <summary>
  /// 
  /// </summary>
  public class TitlesClusterer {

    private readonly MetadataDatabaseController _metadataDatabaseController;

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="TitlesClusterer"/>.
    /// </summary>
    public TitlesClusterer() {
      _metadataDatabaseController = new MetadataDatabaseController();
    }

    #endregion

    #region Public Properties

    private string _database;

    /// <summary>
    /// Gets/Sets the SQLite database.
    /// </summary>
    public string Database {
      get {
        return _database;
      }
      set {
        if (_database != value) {
          if (!File.Exists(value)) {
            throw new FileNotFoundException($"File {value} not found.");
          }
          _database = value;
        }
      }
    }

    private ImmutableSortedDictionary<int, string> _titles;

    /// <summary>
    /// Gets/Sets the titles.
    /// </summary>
    public ImmutableSortedDictionary<int, string> Titles {
      get {
        return _titles;
      }
      set {
        _titles = value;
      }
    }

    Dictionary<int, Dictionary<int, LevenshteinTitleComparison>> _levenshteinTitleComparisonDictionary;

    /// <summary>
    /// Gets/Sets the Levenshtein distance pairs.
    /// </summary>
    Dictionary<int, Dictionary<int, LevenshteinTitleComparison>> LevenshteinTitleComparisonDictionary {
      get {
        return _levenshteinTitleComparisonDictionary;
      }
      set {
        _levenshteinTitleComparisonDictionary = value;
      }
    }

    private Dictionary<int, LevenshteinTitleStatistics> _levenshteinTitleStatisticsDictionary;

    /// <summary>
    /// Gets/Sets the Levenshtein distances descriptive statistics of the population of pairs for each title.
    /// </summary>
    public Dictionary<int, LevenshteinTitleStatistics> LevenshteinTitleStatisticsDictionary {
      get {
        return _levenshteinTitleStatisticsDictionary;
      }
      set {
        _levenshteinTitleStatisticsDictionary = value;
      }
    }

    private Dictionary<int, int[]> _sortedLevenshteinDistancesPopulations;

    /// <summary>
    /// Gets/Sets the sorted population of Levenshtein distances for each title.
    /// </summary>
    public Dictionary<int, int[]> SortedLevenshteinDistancesPopulations {
      get {
        return _sortedLevenshteinDistancesPopulations;
      }
      private set {
        _sortedLevenshteinDistancesPopulations = value;
      }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Counts the records found in the text file holding the Levenshtein title distance pairs.
    /// </summary>
    /// <param name="filePath">The full path to the file.</param>
    /// <param name="isBinaryFile">Determines whether the file is binary or not.</param>
    /// <returns>An <see cref="int"/> with the number of records.</returns>
    public int CountLevenshteinDistanceFileRecords(string filePath, bool isBinaryFile = true) {

      if (!File.Exists(filePath)) {
        throw new FileNotFoundException("The Levenshtein distance file does not exist.");
      }

      if (isBinaryFile) {
        return CountLevenshteinDistanceBinaryFileRecords(filePath);
      }
      else {
        return CountLevenshteinDistanceTextFileRecords(filePath);
      }

    }

    /// <summary>
    /// Reads the records found in the text file holding the Levenshtein title distance pairs.
    /// </summary>
    /// <param name="databasePath">The full path to the database file.</param>
    /// <param name="filePath">The full path to the file.</param>
    /// <param name="isBinary">Indicates whether the file is binary or not.</param>
    /// <returns>An <see cref="int"/> with the number of records.</returns>
    public int ReadLevenshteinDistanceRecords(string databasePath, string filePath, bool isBinary = true) {

      if (!File.Exists(filePath)) {
        throw new FileNotFoundException("The Levenshtein distance file does not exist.");
      }

      int lineCount = 0;
      int processStep = 1;
      int processReport = 1000000;

      NumberFormatInfo nfi = new NumberFormatInfo();
      nfi.NumberGroupSeparator = " ";

      DateTime start = DateTime.Now;

      Debug.WriteLine(string.Format("Opening file ...", lineCount));

      // Make sure titles have been read.
      if (this.Titles == null || this.Titles.Count <= 0) {
        MetadataDatabaseController controller = new MetadataDatabaseController();
        controller.DatabasePath = databasePath;
        controller.OpenDatabase();
        this.Titles = controller.GetAllTitles();
        controller.CloseDatabase();
      }

      int totalTitles = this.Titles.Count;

      StringDistanceComparer stringDistanceComparer = new StringDistanceComparer();
      IEnumerable<LevenshteinTitleComparison> comparisons = stringDistanceComparer.YieldComparedTitlesFromFile(filePath, true);

      foreach (LevenshteinTitleComparison comparison in comparisons) {

        if (this.LevenshteinTitleComparisonDictionary == null) {
          this.LevenshteinTitleComparisonDictionary = new Dictionary<int, Dictionary<int, LevenshteinTitleComparison>>();
        }

        if (!this.LevenshteinTitleComparisonDictionary.ContainsKey(comparison.RecordId1)) {
          this.LevenshteinTitleComparisonDictionary.Add(
            comparison.RecordId1, new Dictionary<int, LevenshteinTitleComparison>(totalTitles)
          );
          this.LevenshteinTitleComparisonDictionary[comparison.RecordId1].Add(comparison.RecordId2, comparison);
        }
        else {
          if (!this.LevenshteinTitleComparisonDictionary[comparison.RecordId1].ContainsKey(comparison.RecordId2)) {
            this.LevenshteinTitleComparisonDictionary[comparison.RecordId1][comparison.RecordId2] = comparison;
          }
        }

        LevenshteinTitleComparison flippedComparison = new() {
          RecordId1 = comparison.RecordId2,
          RecordId2 = comparison.RecordId1,
          LevenshteinDistance = comparison.LevenshteinDistance,
        };

        if (!this.LevenshteinTitleComparisonDictionary.ContainsKey(flippedComparison.RecordId1)) {
          this.LevenshteinTitleComparisonDictionary.Add(
            flippedComparison.RecordId1, new Dictionary<int, LevenshteinTitleComparison>(totalTitles)
          );
          this.LevenshteinTitleComparisonDictionary[flippedComparison.RecordId1].Add(flippedComparison.RecordId2, flippedComparison);
        }
        else {
          if (!this.LevenshteinTitleComparisonDictionary[flippedComparison.RecordId1].ContainsKey(flippedComparison.RecordId2)) {
            this.LevenshteinTitleComparisonDictionary[flippedComparison.RecordId1][flippedComparison.RecordId2] = flippedComparison;
          }
        }

        lineCount++;
        if (processStep == processReport) {
          processStep = 0;
          Debug.WriteLine(string.Format("Read {0} lines...", lineCount.ToString("#,#", nfi)));
        }
        processStep++;

      }

      DateTime end = DateTime.Now;

      Debug.WriteLine("*** Process duration: {0}", TimeSpan.FromTicks(end.Ticks - start.Ticks));

      return lineCount;

    }

    /// <summary>
    /// 
    /// </summary>
    public void CalculateDescriptiveStatistics() {

      if (this.LevenshteinTitleComparisonDictionary == null) {
        throw new NullReferenceException("LevenshteinTitleComparisonDictionary is null.");
      }

      this.LevenshteinTitleStatisticsDictionary =
        new(this.LevenshteinTitleComparisonDictionary.Count);

      foreach (int recordId in this.LevenshteinTitleComparisonDictionary.Keys) {
        Dictionary<int, LevenshteinTitleComparison> titleComparisons = this.LevenshteinTitleComparisonDictionary[recordId];

        if (titleComparisons != null) {
          IEnumerable<double> distances = titleComparisons.Values.Select(v => Convert.ToDouble(v.LevenshteinDistance));
          DescriptiveStatistics ds = new DescriptiveStatistics(distances);

          this.LevenshteinTitleStatisticsDictionary.Add(
            recordId,
            new LevenshteinTitleStatistics() {
              Kurtosis = ds.Kurtosis,
              Max = Convert.ToInt32(ds.Maximum),
              Mean = ds.Mean,
              Median = Statistics.Median(distances),
              Min = Convert.ToInt32(ds.Minimum),
              RecordId = recordId,
              Skewness = ds.Skewness,
              StDev = ds.StandardDeviation,
              Variance = ds.Variance
            }
          );
        }
      }

    }

    /// <summary>
    /// Writes the values of the <see cref="LevenshteinTitleComparisonDictionary"/> in the specified file.
    /// </summary>
    /// <param name="filePath">The full path to the text file.</param>
    /// <exception cref="NullReferenceException">Thrown when the file is not foumd.</exception>
    public void WriteLevenshteinTitleStatisticsToTextFile(string filePath) {

      if (this.LevenshteinTitleStatisticsDictionary == null) {
        throw new NullReferenceException(string.Format("{0} is null.", nameof(this.LevenshteinTitleStatisticsDictionary)));
      }

      StringBuilder sb = new StringBuilder();

      using (StreamWriter writer = new StreamWriter(filePath)) {

        writer.WriteLine("RecordId,Min,Max,Mean,Median,Variance,StDev,Kurtosis,Skewness");

        foreach (LevenshteinTitleStatistics statistics in this.LevenshteinTitleStatisticsDictionary.Values) {

          sb.Clear();

          sb.Append(statistics.RecordId);
          sb.Append(",");
          sb.Append(statistics.Min);
          sb.Append(",");
          sb.Append(statistics.Max);
          sb.Append(",");
          sb.Append(statistics.Mean);
          sb.Append(",");
          sb.Append(statistics.Median);
          sb.Append(",");
          sb.Append(statistics.Variance);
          sb.Append(",");
          sb.Append(statistics.StDev);
          sb.Append(",");
          sb.Append(statistics.Kurtosis);
          sb.Append(",");
          sb.Append(statistics.Skewness);

          writer.WriteLine(sb.ToString());

        }

      }

    }

    /// <summary>
    /// Reads the values of the <see cref="LevenshteinTitleComparisonDictionary"/> from the specified file.
    /// </summary>
    /// <param name="filePath">The full path to the text file.</param>
    public void ReadLevenshteinTitleStatisticsFromTextFile(string filePath) {

      this.LevenshteinTitleStatisticsDictionary = new Dictionary<int, LevenshteinTitleStatistics>();

      using (StreamReader reader = new StreamReader(filePath)) {
        // Read and ignore the header row.
        reader.ReadLine();

        while (!reader.EndOfStream) {
          string line = reader.ReadLine();
          string[] values = line.Split(',');

          if (values.Length == 9) {
            LevenshteinTitleStatistics statistics = new LevenshteinTitleStatistics() {
              RecordId = int.Parse(values[0]),
              Min = int.Parse(values[1]),
              Max = int.Parse(values[2]),
              Mean = double.Parse(values[3]),
              Median = double.Parse(values[4]),
              Variance = double.Parse(values[5]),
              StDev = double.Parse(values[6]),
              Kurtosis = double.Parse(values[7]),
              Skewness = double.Parse(values[8])
            };

            this.LevenshteinTitleStatisticsDictionary.Add(statistics.RecordId, statistics);
          }
        }
      }

    }

    /// <summary>
    /// Writes the values of the <see cref="LevenshteinTitleComparisonDictionary"/> in the database.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Thrown when the <see cref="Database"/> property is null or empty.
    /// </exception>
    /// <exception cref="NullReferenceException">
    /// Thrown when the LevenshteinTitleStatisticsDictionary is null.
    /// </exception>
    public void WriteLevenshteinTitleStatisticsToDatabase() {

      if (string.IsNullOrEmpty(this.Database)) {
        throw new Exception($"{this.Database} file is null or empty.");
      }

      if (this.LevenshteinTitleStatisticsDictionary == null) {
        throw new NullReferenceException("LevenshteinTitleStatisticsDictionary is null.");
      }

      if (!_metadataDatabaseController.IsDbOpen) {
        _metadataDatabaseController.OpenDatabase();
      }

      _metadataDatabaseController.LoadLevenshteinTitleStatistics(
        this.LevenshteinTitleStatisticsDictionary.OrderBy(item => item.Key).Select(item => item.Value).ToList(),
        false
      );

    }

    /// <summary>
    /// Sorts the populations of Levenshtein title comparison distances and
    /// stores the results in the <see cref="SortedLevenshteinDistancesPopulations"/> property.
    /// </summary>
    public void SortLevenshteinTitleComparisonDistancesPopulations() {

      Debug.WriteLine("Sorting Levenshtein distances populations...");
      DateTime start = DateTime.Now;

      this.SortedLevenshteinDistancesPopulations = new Dictionary<int, int[]>();

      foreach (var pair in this.LevenshteinTitleComparisonDictionary) {
        int[] sortedPopulation = pair.Value.Select(kv => kv.Value.LevenshteinDistance)
                                           .OrderBy(v => v)
                                           .ToArray();

        this.SortedLevenshteinDistancesPopulations.Add(pair.Key, sortedPopulation);

      }

      DateTime end = DateTime.Now;
      Debug.WriteLine("*** Process duration: {0}", TimeSpan.FromTicks(end.Ticks - start.Ticks));

    }

    /// <summary>
    /// Updates the value of the percentile rank of each Levenshtein distance pair in the specified binary file.
    /// </summary>
    /// <param name="binaryFilePath">The file path of the binary file.</param>
    public void UpdateLevenshteinTitleComparisonPercentileRank(string binaryFilePath) {

      Debug.WriteLine("Updating Levenshtein percentile ranks in binary file...");
      DateTime start = DateTime.Now;

      int recordCount = 0;
      int processStep = 1;
      int processReport = 1000000;

      NumberFormatInfo nfi = new NumberFormatInfo();
      nfi.NumberGroupSeparator = " ";

      // Calculate the position of the record in the file
      //int recordSize = sizeof(int) * 5; // size of each record in bytes (excluding the Id field).
      //long recordPosition = 0;

      using (FileStream fileStream = new FileStream(binaryFilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
      using (BinaryReader binaryReader = new BinaryReader(fileStream))
      using (BinaryWriter binaryWriter = new BinaryWriter(fileStream)) {

        // Loop through the file records.
        while (fileStream.Position < fileStream.Length) {

          int batchId = binaryReader.ReadInt32();
          int recordId1 = binaryReader.ReadInt32();
          int recordId2 = binaryReader.ReadInt32();
          int levenshteinDistance = binaryReader.ReadInt32();

          int[] sortedPopulation = this.SortedLevenshteinDistancesPopulations[recordId1];
          int percentileRank = GetPercentileRank(levenshteinDistance, sortedPopulation);

          // Update the percentile field.
          binaryWriter.Seek(0, SeekOrigin.Current);
          binaryWriter.Write(percentileRank);

          //recordPosition = fileStream.Position;
          recordCount++;
          if (processStep == processReport) {
            processStep = 0;
            Debug.WriteLine(string.Format("Updated {0} records...", recordCount.ToString("#,#", nfi)));
          }
          processStep++;

        }

        binaryWriter.Flush();

      }

      DateTime end = DateTime.Now;
      Debug.WriteLine("*** Process duration: {0}", TimeSpan.FromTicks(end.Ticks - start.Ticks));

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="database"></param>
    /// <param name="binaryFile"></param>
    /// <param name="databaseOption"></param>
    public void LoadLevenshteinDistanceComparisonsToDatabase(string database, string binaryFile, DatabaseOption databaseOption) {

      Debug.WriteLine("Loading Levenshtein percentile ranks in binary file...");
      DateTime start = DateTime.Now;

      MetadataDatabaseController metadataDatabaseController = new MetadataDatabaseController();
      metadataDatabaseController.OpenDatabase(database, databaseOption);

      StringDistanceComparer stringDistanceComparer = new StringDistanceComparer();
      IEnumerable<LevenshteinTitleComparison> comparisons = stringDistanceComparer.YieldComparedTitlesFromFile(binaryFile, true);

      int recordCount = 0;
      int processStep = 1;
      int processReport = 1000000;

      NumberFormatInfo nfi = new NumberFormatInfo();
      nfi.NumberGroupSeparator = " ";

      List<LevenshteinTitleComparison> comparisonsRange = new List<LevenshteinTitleComparison>(processReport);

      foreach (LevenshteinTitleComparison comparison in comparisons) {

        comparisonsRange.Add(comparison);

        recordCount++;
        if (processStep == processReport) {
          processStep = 0;
          Debug.WriteLine(string.Format("Loaded {0} LevenshteinDistanceComparisons...", recordCount.ToString("#,#", nfi)));

          // Load the comparison in the database.
          metadataDatabaseController.LoadLevenshteinTitleComparisons(comparisonsRange, true);
        }
        processStep++;

      }

      metadataDatabaseController.CloseDatabase();

    }

    /// <summary>
    /// Closes the database.
    /// </summary>
    public void CloseDatabase() {
      if (_metadataDatabaseController.IsDbOpen) {
        _metadataDatabaseController.CloseDatabase();
      }
    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// Counts the records of the Levenshtein Distance text file.
    /// </summary>
    /// <param name="filePath">The full path of the file.</param>
    /// <returns>The <see cref="int">number</see> of the records.</returns>
    private static int CountLevenshteinDistanceTextFileRecords(string filePath) {

      int lineCount = 0;
      int processStep = 1;
      int processReport = 1000000;

      NumberFormatInfo nfi = new NumberFormatInfo();
      nfi.NumberGroupSeparator = " ";

      DateTime start = DateTime.Now;

      Debug.WriteLine(string.Format("Opening file ...", lineCount));

      using (var reader = File.OpenText(filePath)) {
        Debug.WriteLine("Reading lines ...");

        while (reader.ReadLine() != null) {
          lineCount++;
          if (processStep == processReport) {
            processStep = 0;
            Debug.WriteLine(string.Format("Read {0} lines...", lineCount.ToString("#,#", nfi)));
          }
          processStep++;
        }
      }

      DateTime end = DateTime.Now;

      Debug.WriteLine("*** Process duration: {0}", TimeSpan.FromTicks(end.Ticks - start.Ticks));

      return lineCount;

    }

    /// <summary>
    /// Counts the records of the Levenshtein Distance binary file.
    /// </summary>
    /// <param name="filePath">The full path of the file.</param>
    /// <returns>The <see cref="int">number</see> of the records.</returns>
    private static int CountLevenshteinDistanceBinaryFileRecords(string filePath) {

      int recordCount = 0;

      using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
      using (BinaryReader binaryReader = new BinaryReader(fileStream)) {

        long length = fileStream.Length;
        int recordSize = (sizeof(int) * 5);

        recordCount = Convert.ToInt32(length / recordSize);

      }

      return recordCount;

    }

    /// <summary>
    /// Gets the percentile rank when given a value and a sorted population of values.
    /// </summary>
    /// <param name="value">The value whose percentile will be ranked.</param>
    /// <param name="sortedPopulation">The sorted population of values.</param>
    /// <returns>An <see cref="int"/> with the percentile rank.</returns>
    private static int GetPercentileRank(int value, int[] sortedPopulation) {

      int count = sortedPopulation.Length;
      int index = Array.BinarySearch(sortedPopulation, value);
      if (index < 0) {
        index = ~index;
      }
      double dPercentileRank = (index + 0.5) / count * 100.0;
      int percentileRank = Convert.ToInt32(System.Math.Round(dPercentileRank, 0));

      return percentileRank;

    }

    #endregion

  }

}
