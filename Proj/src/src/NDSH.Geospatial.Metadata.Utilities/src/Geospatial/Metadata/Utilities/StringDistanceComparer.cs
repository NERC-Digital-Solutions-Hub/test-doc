
#region Imported Namespaces

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NDSH.Accord.Math.Distances;
using NDSH.Geospatial.Metadata.Utilities.Models;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities {

  /// <summary>
  /// The StringDistanceComparer provides functionality to allow comparison of strings.
  /// </summary>
  public class StringDistanceComparer {

    #region Public Methods

    /// <summary>
    /// Writes the output Levenshtein distances between pairs of titles to a file.
    /// </summary>
    /// <param name="database">The SQLite database fro mwhere to load the titles.</param>
    /// <param name="logicalProcessors">The logical processors assigned to the task.</param>
    /// <param name="outputFile">The output file.</param>
    /// <param name="isBinaryFile">Indicates whether the file is binary or not.</param>
    public void WriteComparedTitlesToFile(string database, int logicalProcessors, string outputFile, bool isBinaryFile = true) {

      ImmutableSortedDictionary<int, string> titlesImmutableDictionary;
      ReadOnlyCollection<int> sortedReadonlyKeys;

      GetAllTitles(database, out titlesImmutableDictionary, out sortedReadonlyKeys);

      _ = AsyncWriteComparedTitlesToFile(logicalProcessors, sortedReadonlyKeys, titlesImmutableDictionary, outputFile, isBinaryFile);

    }

    /// <summary>
    /// Writes the output Levenshtein distances between pairs of titles to a text file and a binary file.
    /// </summary>
    /// <param name="database">The SQLite database fro mwhere to load the titles.</param>
    /// <param name="logicalProcessors">The logical processors assigned to the task.</param>
    /// <param name="outputBinFile">The output binary file.</param>
    /// <param name="outputTxtFile">The output text file.</param>
    public void WriteComparedTitlesToFiles(string database, int logicalProcessors, string outputBinFile, string outputTxtFile) {

      ImmutableSortedDictionary<int, string> titlesImmutableDictionary;
      ReadOnlyCollection<int> sortedReadonlyKeys;

      GetAllTitles(database, out titlesImmutableDictionary, out sortedReadonlyKeys);

      _ = AsyncWriteComparedTitlesToFiles(logicalProcessors, sortedReadonlyKeys, titlesImmutableDictionary, outputBinFile, outputTxtFile);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="database"></param>
    /// <param name="outputFile"></param>
    /// <param name="logicalProcessors"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void FastWriteComparedTitlesToFile(string database, string outputFile, int logicalProcessors) {

      throw new NotImplementedException();

      //if (!File.Exists(database)) {
      //  throw new FileNotFoundException(string.Format("Database {0} not found.", database));
      //}

      //MetadataDatabaseController controller = new MetadataDatabaseController();
      //controller.DatabaseFile = database;
      //controller.OpenDatabase();

      //// Get all the titles in an immutable sorted dictionary.
      //ImmutableSortedDictionary<int, string> titlesImmutableDictionary = controller.GetAllTitles();

      //// Get all the keys sorted.
      //List<int> sortedKeys = new List<int>();
      //foreach (var item in titlesImmutableDictionary) {
      //  sortedKeys.Add(item.Key);
      //}

      //ReadOnlyCollection<int> sortedReadonlyKeys = new ReadOnlyCollection<int>(sortedKeys);

      //controller.CloseDatabase();

      //_ = AsyncWriteComparedTitlesToFile(logicalProcessors, sortedReadonlyKeys, titlesImmutableDictionary, outputFile);

    }

    /// <summary>
    /// Reads a file and returns a <see cref="List{LevenshteinTitleComparison}"/>.
    /// </summary>
    /// <param name="filePath">The path to the file.</param>
    /// <param name="isBinaryFile">Indicates whether the file is binary or text.</param>
    /// <returns>A <see cref="List{LevenshteinTitleComparison}"/>.</returns>
    public List<LevenshteinTitleComparison> GetComparedTitlesFromFile(string filePath, bool isBinaryFile = true) {

      if (string.IsNullOrEmpty(filePath)) {
        throw new ArgumentNullException(string.Format($"Argument {nameof(filePath)} could not be null or empty", nameof(filePath)));
      }

      if (isBinaryFile) {
        return GetComparedTitlesFromBinaryFile(filePath);
      }
      else {
        return GetComparedTitlesFromTextFile(filePath);
      }

    }

    /// <summary>
    /// Yields a <see cref="LevenshteinTitleComparison"/> each time a record is read from a binary file.
    /// </summary>
    /// <param name="filePath">The path to the binary file.</param>
    /// <param name="isBinaryFile">Indicates whether the file is binary or text.</param>
    /// <returns>A <see cref="LevenshteinTitleComparison"/> object.</returns>
    public IEnumerable<LevenshteinTitleComparison> YieldComparedTitlesFromFile(string filePath, bool isBinaryFile = true) {

      if (string.IsNullOrEmpty(filePath)) {
        throw new ArgumentNullException(string.Format($"Argument {nameof(filePath)} could not be null or empty", nameof(filePath)));
      }

      if (isBinaryFile) {
        foreach (LevenshteinTitleComparison comparison in YieldComparedTitlesFromBinaryFile(filePath)) {
          yield return comparison;
        }
      }
      else {
        foreach (LevenshteinTitleComparison comparison in YieldComparedTitlesFromTextFile(filePath)) {
          yield return comparison;
        }
      }

    }

    /// <summary>
    /// Exports <see cref="LevenshteinTitleComparison"/> records from the binary fiel to the text file.
    /// </summary>
    /// <param name="binaryFile">The binary file to read.</param>
    /// <param name="textFile">The text file to write.</param>
    public void ExportFromBinaryToTextFile(string binaryFile, string textFile) {

      using (StreamWriter writer = new StreamWriter(textFile)) {

        int recordCount = 0;
        int processStep = 1;
        int processReport = 1000000;

        NumberFormatInfo nfi = new NumberFormatInfo();
        nfi.NumberGroupSeparator = " ";

        StringBuilder sb = new StringBuilder();

        IEnumerable<LevenshteinTitleComparison> comparisons = this.YieldComparedTitlesFromFile(binaryFile, true);
        string header = "Id, BatchId, RecordId1, RecordId2, LevenshteinDistance, Percentile"; // for the sake of database
        writer.WriteLine(header);

        foreach (LevenshteinTitleComparison comparison in comparisons) {
          sb.Append(comparison.Id);
          sb.Append(",");
          sb.Append(comparison.BatchId);
          sb.Append(",");
          sb.Append(comparison.RecordId1);
          sb.Append(",");
          sb.Append(comparison.RecordId2);
          sb.Append(",");
          sb.Append(comparison.LevenshteinDistance);
          sb.Append(",");
          sb.Append(comparison.Percentile);

          writer.WriteLine(sb.ToString());

          sb.Clear();

          recordCount++;
          if (processStep == processReport) {
            processStep = 0;
            Debug.WriteLine(string.Format("Exported {0} LevenshteinDistanceComparisons...", recordCount.ToString("#,#", nfi)));
          }
          processStep++;
        }

      }

    }

    /// <summary>
    /// Exports <see cref="LevenshteinTitleComparison"/> records from the binary fiel to the text file.
    /// </summary>
    /// <param name="binaryFile">The binary file to read.</param>
    /// <param name="sqlFile">The sql file to write.</param>
    public void ExportFromBinaryToSqlFile(string binaryFile, string sqlFile) {

      using (StreamWriter writer = new StreamWriter(sqlFile)) {

        int recordCount = 0;
        int start = 1;
        int processStep = 1;
        int processReport = 1_000_000;

        NumberFormatInfo nfi = new NumberFormatInfo();
        nfi.NumberGroupSeparator = " ";

        //string createTable = "BEGIN TRANSACTION;\r\nCREATE TABLE IF NOT EXISTS \"LevenshteinTitleComparisons\" (\r\n    \"Id\" INTEGER NOT NULL CONSTRAINT \"PK_LevenshteinTitleComparisons\" PRIMARY KEY AUTOINCREMENT,\r\n    \"BatchId\" INTEGER NOT NULL,\r\n    \"RecordId1\" INTEGER NOT NULL,\r\n    \"RecordId2\" INTEGER NOT NULL,\r\n    \"LevenshteinDistance\" INTEGER NOT NULL,\r\n    \"Percentile\" INTEGER NOT NULL\r\n);";
        string createTable = "BEGIN TRANSACTION;\r\nCREATE TABLE IF NOT EXISTS \"LevenshteinTitleComparisonsFree\" (\r\n    \"Id\" INTEGER,\r\n    \"BatchId\" INTEGER,\r\n    \"RecordId1\" INTEGER,\r\n    \"RecordId2\" INTEGER,\r\n    \"LevenshteinDistance\" INTEGER,\r\n    \"Percentile\" INTEGER\r\n);";

        StringBuilder sb = new StringBuilder();
        sb.Append(createTable);
        writer.WriteLine(sb.ToString());
        sb.Clear();

        IEnumerable<LevenshteinTitleComparison> comparisons = this.YieldComparedTitlesFromFile(binaryFile, true);

        foreach (LevenshteinTitleComparison comparison in comparisons) {
          recordCount++;

          if (recordCount >= start && recordCount < start + 10_000_000) {
            //sb.Append("INSERT INTO \"LevenshteinTitleComparisons\" (\"BatchId\", \"RecordId1\", \"RecordId2\", \"LevenshteinDistance\", \"Percentile\") VALUES (");
            sb.Append("INSERT INTO \"LevenshteinTitleComparisonsFree\" (\"Id\", \"BatchId\", \"RecordId1\", \"RecordId2\", \"LevenshteinDistance\", \"Percentile\") VALUES (");
            //sb.Append(comparison.Id);
            sb.Append(recordCount);
            sb.Append(",");
            sb.Append(comparison.BatchId);
            sb.Append(",");
            sb.Append(comparison.RecordId1);
            sb.Append(",");
            sb.Append(comparison.RecordId2);
            sb.Append(",");
            sb.Append(comparison.LevenshteinDistance);
            sb.Append(",");
            sb.Append(comparison.Percentile);
            sb.Append(");");

            writer.WriteLine(sb.ToString());

            sb.Clear();
          }

          if (processStep == processReport) {
            processStep = 0;
            Debug.WriteLine(string.Format("Exported {0} LevenshteinDistanceComparisons...", recordCount.ToString("#,#", nfi)));
          }
          processStep++;
        }

        sb.AppendLine("COMMIT;");
        writer.WriteLine(sb.ToString());

      }

    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// Reads all the titles from the database and outputs a dictionary
    /// with the titles and a collection with the dictionary's keys sorted.
    /// </summary>
    /// <param name="database">The SQL database from which the titles will be read.</param>
    /// <param name="titlesImmutableDictionary">
    /// The immutable sorted dictionary having the titles.
    /// </param>
    /// <param name="sortedReadonlyKeys">
    /// A read only collection of the keys of the dictionary sorted in ascending order.
    /// </param>
    /// <exception cref="FileNotFoundException">
    /// Thrown when the database file is not found.
    /// </exception>
    private static void GetAllTitles(string database, out ImmutableSortedDictionary<int, string> titlesImmutableDictionary, out ReadOnlyCollection<int> sortedReadonlyKeys) {

      if (!File.Exists(database)) {
        throw new FileNotFoundException(string.Format("Database {0} not found.", database));
      }

      MetadataDatabaseController controller = new MetadataDatabaseController();
      controller.DatabasePath = database;
      controller.OpenDatabase();

      // Get all the titles in an immutable sorted dictionary.
      titlesImmutableDictionary = controller.GetAllTitles();

      // Get all the keys sorted.
      List<int> sortedKeys = new List<int>();
      foreach (var item in titlesImmutableDictionary) {
        sortedKeys.Add(item.Key);
      }

      sortedReadonlyKeys = new ReadOnlyCollection<int>(sortedKeys);
      controller.CloseDatabase();

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="keyToCompare"></param>
    /// <param name="sortedReadonlyKeys"></param>
    /// <param name="titlesImmutableDictionary"></param>
    /// <returns></returns>
    /// <remarks>
    /// The records returned are always for the titles that have not been processed already.
    /// </remarks>
    private static string GetLevenshteinDistanceRecords(int keyToCompare, ReadOnlyCollection<int> sortedReadonlyKeys, ImmutableSortedDictionary<int, string> titlesImmutableDictionary) {

      string records = String.Empty;

      LevenshteinAccord levenshtein = new LevenshteinAccord();

      // Get the string that will be compared against the rest in the dictionary.
      string target = titlesImmutableDictionary[keyToCompare];

      ImmutableList<int> restOfKeys = sortedReadonlyKeys.Where(k => k > keyToCompare).ToImmutableList();

      if (restOfKeys != null) {

        StringBuilder sb = new StringBuilder();

        foreach (int key in restOfKeys) {
          sb.AppendLine(string.Format("{0},{1},{2}", keyToCompare, key, levenshtein.Distance(target, titlesImmutableDictionary[key])));
        }

        records = sb.ToString();

      }

      return records;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="keyToCompare"></param>
    /// <param name="sortedReadonlyKeys"></param>
    /// <param name="titlesImmutableDictionary"></param>
    /// <returns></returns>
    private static Dictionary<int, double> GetLevenshteinDistances(int keyToCompare, ReadOnlyCollection<int> sortedReadonlyKeys, ImmutableSortedDictionary<int, string> titlesImmutableDictionary) {

      Dictionary<int, double> output = null;

      LevenshteinAccord levenshtein = new LevenshteinAccord();

      // Get the string that will be compared against the rest in the dictionary.
      string target = titlesImmutableDictionary[keyToCompare];

      ImmutableList<int> restOfKeys = sortedReadonlyKeys.Where(k => k > keyToCompare).ToImmutableList();

      if (restOfKeys != null) {

        // Create a dictionary to store the Levenshtein distances.
        output = new Dictionary<int, double>(restOfKeys.Count);

        foreach (int key in restOfKeys) {
          output.Add(key, levenshtein.Distance(target, titlesImmutableDictionary[key]));
        }

      }

      return output;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="logicalProcessors"></param>
    /// <param name="sortedReadonlyKeys"></param>
    /// <param name="titlesImmutableDictionary"></param>
    /// <param name="outputFilePath"></param>
    /// <param name="isBinaryFile"></param>
    /// <returns></returns>
    private static async Task AsyncWriteComparedTitlesToFile(
      int logicalProcessors,
      ReadOnlyCollection<int> sortedReadonlyKeys,
      ImmutableSortedDictionary<int, string> titlesImmutableDictionary,
      string outputFilePath,
      bool isBinaryFile = true
    ) {

      Debug.WriteLine(string.Format("Calculating Levenshtein distances ..."));

      DateTime start = DateTime.Now;

      // Assign logical processors to the task.
      ParallelOptions parallelOptions = new ParallelOptions();
      parallelOptions.MaxDegreeOfParallelism = logicalProcessors;

      // Create a blocking collection to store the dictionaries of title pairs.
      BlockingCollection<Dictionary<int, Dictionary<int, double>>> blockingCollection = new();

      // Create the first task to populate the blocking collection with title pairs and levenshtein distances.
      Task populateBlockingCollectionTask = Task.Run(() => {

        int index = 0;
        int processStep = 0;
        int processReport = 99;

        ParallelLoopState state; // Used to stop the ForEach Loop.

        Parallel.ForEach(sortedReadonlyKeys, parallelOptions, (key, state) => {
          index++;
          if (processStep++ == processReport) {
            processStep = 0;
            Debug.WriteLine(string.Format("Processing index: {0}", index));
          }

          //if (index > 100) {
          //  state.Stop();
          //}

          Dictionary<int, double> levenshteinDistances = GetLevenshteinDistances(key, sortedReadonlyKeys, titlesImmutableDictionary);
          Dictionary<int, Dictionary<int, double>> titlePairs = new(1) {
            { key, levenshteinDistances }
          };
          blockingCollection.Add(titlePairs);
        });

      });

      // Await both tasks to run in parallel.
      await Task.WhenAll(populateBlockingCollectionTask);

      DateTime levenshteinEnd = DateTime.Now;

      Debug.WriteLine("*** Process: Levenshtein calculation. | Duration: {0}", TimeSpan.FromTicks(levenshteinEnd.Ticks - start.Ticks));
      Debug.WriteLine("");
      Debug.WriteLine("Writing Levenshtein title pairs in file ...");

      if (isBinaryFile) {
        WriteComparedTitlesToBinaryFile(outputFilePath, blockingCollection);
      }
      else {
        WriteComparedTitlesToTextFile(outputFilePath, blockingCollection);
      }

      DateTime end = DateTime.Now;

      Debug.WriteLine("*** Process: Write Levenshtein title pairs in file. | Duration: {0}", TimeSpan.FromTicks(end.Ticks - levenshteinEnd.Ticks));

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="logicalProcessors"></param>
    /// <param name="sortedReadonlyKeys"></param>
    /// <param name="titlesImmutableDictionary"></param>
    /// <param name="outputBinFilePath"></param>
    /// <param name="outputTxtFilePath"></param>
    /// <returns></returns>
    private static async Task AsyncWriteComparedTitlesToFiles(
      int logicalProcessors,
      ReadOnlyCollection<int> sortedReadonlyKeys,
      ImmutableSortedDictionary<int, string> titlesImmutableDictionary,
      string outputBinFilePath,
      string outputTxtFilePath
    ) {

      Debug.WriteLine(string.Format("Calculating Levenshtein distances ..."));

      DateTime start = DateTime.Now;

      // Assign logical processors to the task.
      ParallelOptions parallelOptions = new ParallelOptions();
      parallelOptions.MaxDegreeOfParallelism = logicalProcessors;

      // Create a blocking collection to store the dictionaries of title pairs.
      BlockingCollection<Dictionary<int, Dictionary<int, double>>> blockingCollection = new();

      // Create the first task to populate the blocking collection with title pairs and levenshtein distances.
      Task populateBlockingCollectionTask = Task.Run(() => {

        int index = 0;
        int processStep = 0;
        int processReport = 99;

        ParallelLoopState state; // Used to stop the ForEach Loop.

        Parallel.ForEach(sortedReadonlyKeys, parallelOptions, (key, state) => {
          index++;
          if (processStep++ == processReport) {
            processStep = 0;
            Debug.WriteLine(string.Format("Processing index: {0}", index));
          }

          //if (index > 100) {
          //  state.Stop();
          //}

          Dictionary<int, double> levenshteinDistances = GetLevenshteinDistances(key, sortedReadonlyKeys, titlesImmutableDictionary);
          Dictionary<int, Dictionary<int, double>> titlePairs = new(1) {
            { key, levenshteinDistances }
          };
          blockingCollection.Add(titlePairs);
        });

      });

      // Await both tasks to run in parallel.
      await Task.WhenAll(populateBlockingCollectionTask);

      DateTime levenshteinEnd = DateTime.Now;

      Debug.WriteLine("*** Process: Levenshtein calculation. | Duration: {0}", TimeSpan.FromTicks(levenshteinEnd.Ticks - start.Ticks));
      Debug.WriteLine("");
      Debug.WriteLine("Writing Levenshtein title pairs in file ...");

      WriteComparedTitlesToBinaryFile(outputBinFilePath, blockingCollection);
      WriteComparedTitlesToTextFile(outputTxtFilePath, blockingCollection);

      DateTime end = DateTime.Now;

      Debug.WriteLine("*** Process: Write Levenshtein title pairs in file. | Duration: {0}", TimeSpan.FromTicks(end.Ticks - levenshteinEnd.Ticks));

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="outputFilePath"></param>
    /// <param name="blockingCollection"></param>
    private static void WriteComparedTitlesToTextFile(
      string outputFilePath,
      BlockingCollection<Dictionary<int, Dictionary<int, double>>> blockingCollection
    ) {

      using (StreamWriter writer = new StreamWriter(outputFilePath)) {

        int percentile = -1;

        int index = 0;
        int processStep = 0;
        int processReport = 100;

        foreach (Dictionary<int, Dictionary<int, double>> titlePairs in blockingCollection) {

          // The outter dictionary has only one key.
          int recordId1 = titlePairs.Keys.FirstOrDefault();

          index++;
          processStep++;
          if (processStep == processReport) {
            processStep = 0;
            Debug.WriteLine(string.Format("Writing record: {0}", index));
          }

          Dictionary<int, double> titleDistances = titlePairs[recordId1];

          foreach (KeyValuePair<int, double> titleDistance in titleDistances) {
            int recordId2 = titleDistance.Key;
            double distance = titleDistance.Value;
            string record = $"{index},{recordId1},{recordId2},{distance},{percentile}";
            writer.WriteLine(record);
          }

        }

      }

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="outputFilePath"></param>
    /// <param name="blockingCollection"></param>
    private static void WriteComparedTitlesToBinaryFile(
      string outputFilePath,
      BlockingCollection<Dictionary<int, Dictionary<int, double>>> blockingCollection
    ) {

      using (FileStream fileStream = new FileStream(outputFilePath, FileMode.Append, FileAccess.Write, FileShare.None))
      using (BinaryWriter binaryWriter = new BinaryWriter(fileStream)) {

        int percentile = -1;

        int index = 0;
        int processStep = 0;
        int processReport = 100;

        foreach (Dictionary<int, Dictionary<int, double>> titlePairs in blockingCollection) {

          // The outter dictionary has only one key.
          int recordId1 = titlePairs.Keys.FirstOrDefault();

          index++;
          processStep++;
          if (processStep == processReport) {
            processStep = 0;
            Debug.WriteLine(string.Format("Writing record: {0}", index));
          }

          Dictionary<int, double> titleDistances = titlePairs[recordId1];

          foreach (KeyValuePair<int, double> titleDistance in titleDistances) {
            binaryWriter.Write(index);
            binaryWriter.Write(recordId1);
            binaryWriter.Write(titleDistance.Key);
            binaryWriter.Write(Convert.ToInt32(titleDistance.Value));
            binaryWriter.Write(percentile);
          }

        }

      }

    }

    /// <summary>
    /// Reads a binary file and returns a <see cref="List{LevenshteinTitleComparison}"/>.
    /// </summary>
    /// <param name="filePath">The path to the file.</param>
    /// <returns>A <see cref="List{LevenshteinTitleComparison}"/>.</returns>
    private static List<LevenshteinTitleComparison> GetComparedTitlesFromBinaryFile(string filePath) {

      List<LevenshteinTitleComparison> comparisons = new List<LevenshteinTitleComparison>();

      using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
      using (BinaryReader binaryReader = new BinaryReader(fileStream)) {

        long length = binaryReader.BaseStream.Length;

        while (binaryReader.BaseStream.Position != length) {

          comparisons.Add(
            new LevenshteinTitleComparison {
              BatchId = binaryReader.ReadInt32(),
              RecordId1 = binaryReader.ReadInt32(),
              RecordId2 = binaryReader.ReadInt32(),
              LevenshteinDistance = binaryReader.ReadInt32(),
              Percentile = binaryReader.ReadInt32()
            }
          );

        }
      }

      return comparisons;

    }

    /// <summary>
    /// Yields a <see cref="LevenshteinTitleComparison"/> each time a record is read from a binary file.
    /// </summary>
    /// <param name="filePath">The path to the binary file.</param>
    /// <returns>A <see cref="LevenshteinTitleComparison"/> object.</returns>
    private static IEnumerable<LevenshteinTitleComparison> YieldComparedTitlesFromBinaryFile(string filePath) {

      using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
      using (BinaryReader binaryReader = new BinaryReader(fileStream)) {

        long length = fileStream.Length;

        while (fileStream.Position < length) {

          var comparison = new LevenshteinTitleComparison {
            BatchId = binaryReader.ReadInt32(),
            RecordId1 = binaryReader.ReadInt32(),
            RecordId2 = binaryReader.ReadInt32(),
            LevenshteinDistance = binaryReader.ReadInt32(),
            Percentile = binaryReader.ReadInt32()
          };

          yield return comparison;

        }

      }

    }

    /// <summary>
    /// Reads a text file and returns a <see cref="List{LevenshteinTitleComparison}"/>.
    /// </summary>
    /// <param name="filePath">The path to the file.</param>
    /// <returns>A <see cref="List{LevenshteinTitleComparison}"/>.</returns>
    private static List<LevenshteinTitleComparison> GetComparedTitlesFromTextFile(string filePath) {

      List<LevenshteinTitleComparison> comparisons = new List<LevenshteinTitleComparison>();

      using (StreamReader reader = new StreamReader(filePath)) {

        string line;

        while ((line = reader.ReadLine()) != null) {
          LevenshteinTitleComparison comparison = LevenshteinTitleComparison.Create(line);
          comparisons.Add(comparison);
        }

      }

      return comparisons;

    }

    /// <summary>
    /// Yields a <see cref="LevenshteinTitleComparison"/> each time a record is read from a text file.
    /// </summary>
    /// <param name="filePath">The path to the text file.</param>
    /// <returns>A <see cref="LevenshteinTitleComparison"/> object.</returns>
    private static IEnumerable<LevenshteinTitleComparison> YieldComparedTitlesFromTextFile(string filePath) {

      using (var reader = new StreamReader(filePath)) {

        string line;

        while ((line = reader.ReadLine()) != null) {

          var values = line.Split(',');
          yield return new LevenshteinTitleComparison {
            BatchId = Convert.ToInt32(values[0]),
            RecordId1 = Convert.ToInt32(values[1]),
            RecordId2 = Convert.ToInt32(values[2]),
            LevenshteinDistance = Convert.ToInt32(values[3]),
            Percentile = Convert.ToInt32(values[4])
          };

        }

      }

    }

    #endregion

  }

}
