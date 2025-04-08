
#region Imported Namespaces

using MathNet.Numerics.Statistics.Mcmc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.ApplicationServices;
using NDSH.Accord.Math.Distances;
using NDSH.Database;
using NDSH.Geospatial.Metadata.Serializers;
using NDSH.Geospatial.Metadata.Serializers.Converters;
using NDSH.Geospatial.Metadata.Utilities;
using NDSH.Geospatial.Metadata.Utilities.DatabaseContext;
using NDSH.Geospatial.Metadata.Utilities.Models;
using NDSH.Geospatial.Metadata.V2003;
using NDSH.Geospatial.Metadata.V2003.Application;
using NDSH.Geospatial.Metadata.V2003.EntitySet;
using NDSH.Geospatial.Metadata.V2003.Thin;
using NDSH.Geospatial.Metadata.V2003.XLinks;
using NDSH.Geospatial.Metadata.V2005;
using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2005.Distribution;
using NDSH.Geospatial.Metadata.V2005.EntitySet;
using NDSH.Geospatial.Metadata.V2005.ReferenceSystem;
using NDSH.Geospatial.Metadata.V2005.Tests.Content;
using NDSH.Utilities.App.Models;
//using NDSH.Utils;
using Newtonsoft.Json;
using Serilog.Core;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Resolvers;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using static System.Resources.ResXFileRef;

#endregion

namespace NDSH.Utilities.App {

  /// <summary>
  /// 
  /// </summary>
  public partial class MainForm : Form {

    private const int _currentTabPageIndex = 4;

    #region Constructors - Destructors

    /// <summary>
    /// 
    /// </summary>
    public MainForm() {
      InitializeComponent();
    }

    #endregion

    #region Event Procedures

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainForm_Load(object sender, EventArgs e) {
      Debug.WriteLine("Form_Load");
      ReadConfiguration(ConfigurationManager.AppSettings["appConfigFile"]);
      this.MainTabControl.SelectedTab = this.MainTabControl.TabPages[_currentTabPageIndex];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainForm_Activated(object sender, EventArgs e) {
      Debug.WriteLine("MainForm_Activated");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MetadataCleanUpCodeButton_Click(object sender, EventArgs e) {

      this.OutputMetadataCodeRichTextBox.Text = CleanMetadataCodeV2003(this.InputMetadaCodeRichTextBox.Text);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SerializeV2005Button_Click(object sender, EventArgs e) {

      //V2005.SerializeEntity(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox);
      //V2005.SerializeCharacterString(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);
      //V2005.SerializeAddress(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);
      //V2005.SerializeCitation(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);
      //V2005.SerializeTelephone(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);
      V2005.SerializeMetadata(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SerializeV2003Button_Click(object sender, EventArgs e) {

      try {
        //V2003.SerializeCharacterStringPropertyType(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);

        //V2003.SerializeAddressPropertyType(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);
        //V2003.SerializeAddressType(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);

        //V2003.SerializeCitationPropertyType(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);
        //V2003.SerializeCitationType(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);

        //V2003.SerializeTelephonePropertyType(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);
        //V2003.SerializeTelephoneType(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);

        //V2003.SerializeMetadataType("gmd_metadata_01.xml", this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);
        //V2003.SerializeMetadataType("gmd_metadata_02.xml", this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);
        //V2003.SerializeMetadataType("gmd_metadata_03.xml", this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);

        //V2003.SerializeMetadata02PropertyType(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);
        //V2003.SerializeMetadata02Type(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);

        //V2003.SerializeMetadata03PropertyType(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);
        //V2003.SerializeMetadata03Type(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);

        //V2003.SerializeCT_ColdelistCatalogue(this.SerializationInputRichTextBox, this.SerializationOutputRichTextBox, this.IsIndentedCheckBox, this.UseEntityCheckBox);

      }
      catch (Exception ex) {
        string message = string.Format("An Error has occured\r\n\r\n{0}\r\n\r\n\r\n", ex.Message);
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Deserialize2005Button_Click(object sender, EventArgs e) {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeserializeV2003Button_Click(object sender, EventArgs e) {

      try {
        V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "gmd_metadata_01_deserialize_01.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "gmd_metadata_01.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "gmd_metadata_02.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "gmd_metadata_03.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "nerc00001.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "nerc00101.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "nerc00201.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "nerc00301.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "nerc00401.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "nerc00501.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "nerc00601.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "nerc00701.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "nerc00801.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "nerc00901.xml");
        //V2003.DeserializeMetadataType(this.DeserializationInputTextBox, this.MetadataPropertyGrid, "nerc01001.xml");
      }
      catch (Exception ex) {
        string message = string.Format("An Error has occured\r\n\r\n{0}\r\n\r\n\r\n", ex.Message);
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TestButton_Click(object sender, EventArgs e) {

      #region Finding fileType
      /// search "// uncomment when you need to run LoadAllFileTypes" 
      /// in MetadataDatabaseControllers.cs and MetadataEntry.cs
      MetadataDatabaseController controller = new MetadataDatabaseController();
      string xmlDirectory = @"C:\Users\ChrisLam\Downloads\NERC-2023-02-18\2023-02-18\2.0.2\GMD";

      var logger = MyLogger.InitLogger(@"C:\Users\ChrisLam\Documents\nerc-digital-solutions-hub\Hub\DotNet\Out\findFileType.log");

      var r = controller.LoadAllFileTypes(directory: xmlDirectory, logger: logger);

      Console.WriteLine("Done.");
      #endregion

      #region LoadAllXmlFiles - SQLite

      //// Load XML files into SQLite.
      //string xmlDirectory = @"C:\NDSH\GitHub\nerc-digital-solutions-hub\nerc-data-centres\Metadata\NERC\2023-02-18\2.0.2\GMD\";
      //string sqliteDbFilePath = $@"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\{DateTime.Now.ToString("yyyy-MM-dd")}-metadata.db";
      //Logger logger = MyLogger.InitLogger(@"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\Log\BgsLayerLog\GetBgsLayers.log");
      //MetadataDatabaseController controller = new MetadataDatabaseController();
      //controller.DatabasePath = sqliteDbFilePath;
      //controller.OpenDatabase();
      //controller.RecreateDatabase();
      //controller.LoadAllXmlFiles(xmlDirectory, logger);
      //controller.CloseDatabase();
      //Debug.WriteLine("Data loaded in db.");

      #endregion

      #region LoadAllXmlFiles - SQLite Chris

#if false // reload database
            MetadataDatabaseController controller = new MetadataDatabaseController();
            string xmlDirectory = @"C:\Users\ChrisLam\Downloads\NERC-2023-02-18\2023-02-18\2.0.2\GMD";
            string sqliteDbFilePath = $@"C:\Users\ChrisLam\Documents\nerc-digital-solutions-hub\Hub\DotNet\Out\Log\MetadataDB\{DateTime.Now.ToString("dd-MM-yyyy")}_metadata.db";
            var logger = MyLogger.InitLogger(@"C:\Users\ChrisLam\Documents\nerc-digital-solutions-hub\Hub\DotNet\Out\Log\BgsLayerLog\GetBgsLayers.log");
            controller.DatabasePath = sqliteDbFilePath;
            controller.OpenDatabase();
            controller.RecreateDatabase();
            controller.LoadAllXmlFiles(directory: xmlDirectory, logger: logger);
            controller.CloseDatabase();
            Console.WriteLine("Done.");

#endif

      #endregion

      #region LoadAllXmlFiles - PostgreSQL

      //// Load XML files into PostgreSQL.
      //MetadataDatabaseController controller = new MetadataDatabaseController();
      //controller.DatabasePath = MetadataDatabaseController.PgSqlPath;

      //controller.DbOption = DatabaseOption.PgSQL_Dev;
      //string xmlDirectory = @"C:\NDSH\GitHub\nerc-digital-solutions-hub\nerc-data-centres\Metadata\NERC\2023-02-18\2.0.2\GMD\";
      //Logger logger = MyLogger.InitLogger(@"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\Log\BgsLayerLog\GetBgsLayers.log");

      //controller.OpenDatabase();
      //controller.RecreateDatabase();
      //controller.LoadAllXmlFiles(directory: xmlDirectory, logger: logger);
      //controller.CloseDatabase();
      //Console.WriteLine("All XML files loaded in the database.");

      #endregion

      #region Select Test Query - PostgreSQL

      //MetadataDatabaseController controller = new MetadataDatabaseController();
      //controller.DatabasePath =
      //  AppEngine.Instance.ApplicationModel.DatabaseConnectionStrings
      //    .Where(cs => cs.Name == "PostgreSQL-AWS")?
      //    .First()
      //    .ToString();
      //controller.DatabaseOption = DatabaseOption.PgSQL_Dev;

      //controller.OpenDatabase();
      //var titles = controller.GetAllTitles();
      //controller.CloseDatabase();

      #endregion

      #region Experiments

      //String.Concat(); // ReadOnlySpan
      //String.Create(); // Span, SpanAction
      //String.GetHashCode(); // ReadOnlySpan

      //System.Buffers.MemoryHandle
      //System.Buffers.MemoryManager<string> mm; mm.
      //System.Buffers.MemoryPool<string> mp;mp.

      //System.Buffers.ReadOnlySequence<int> ros;ros.
      //System.Buffers.ReadOnlySequenceSegment<int> ros;ros.
      //System.Buffers.

      //System.Text.Rune
      //string s s.EnumerateRunes() // Maybe useful.

      //string s = "Vasilis";
      //char c = 'a';

      //Encoding.Unicode.GetBytes()


      //CreateEqualBins(15651, 16);

      //BenchmarkStringComparisons();

      //return;

      #endregion

      #region CalculateAllPairs

      //// Load Title Records.
      //StringDistanceComparerFast stringDistanceComparerFast = new StringDistanceComparerFast();
      //stringDistanceComparerFast.LoadTitles(@"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\metadata.db");
      //stringDistanceComparerFast.CalculateAllPairs(Environment.ProcessorCount);

      #endregion

      #region Create Levenshtein Titles Comparison File.

      //// Create Levenshtein Titles Comparison File.
      //StringDistanceComparer stringDistanceComparer = new StringDistanceComparer();
      //stringDistanceComparer.WriteComparedTitlesToFiles(
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\metadata.db",
      //  8, // Number of Logical Processors
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB.bin",
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB.txt"
      //);

      #endregion

      #region Load all Levenshtein Titles Comparisons from a file.

      //// Load all Levenshtein Titles Comparisons from a file.
      //DateTime start = DateTime.Now;
      //StringDistanceComparer stringDistanceComparer = new StringDistanceComparer();
      //List<LevenshteinTitleComparison> comparisons = stringDistanceComparer.GetComparedTitlesFromFile(
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB.bin"
      //);
      //DateTime end = DateTime.Now;
      //Debug.WriteLine("*** Process: Load Levenshtein Distance Comparisons. | Duration: {0}", TimeSpan.FromTicks(end.Ticks - start.Ticks));

      #endregion

      #region Load empty Titlecomparison records.

      //// Load empty Titlecomparison records.
      //MetadataDatabaseController controller = new MetadataDatabaseController();
      //controller.DatabaseFile = @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\metadata.db";
      //controller.OpenDatabase();
      //controller.LoadEmptyTitleComparisonRecords();
      //controller.CloseDatabase();

      #endregion

      #region Count the lines of the Levenshtein title distances file.

      //// Count the lines of the Levenshtein title distances file.
      //TitlesClusterer clusterer = new TitlesClusterer();
      //Cursor oldCursor = this.Cursor;
      //this.Cursor = Cursors.WaitCursor;
      //int count = clusterer.CountLevenshteinDistanceFileRecords(@"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB.bin");
      ////int count = clusterer.CountLevenshteinDistanceFileRecords(@"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB.txt", false);
      //this.Cursor = oldCursor;

      //Debug.WriteLine("Number of Records found: {0}", count);

      #endregion

      #region Yield Compared Titles From Text File

      //string file = @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB.txt";
      //StringDistanceComparer stringDistanceComparer = new StringDistanceComparer();
      //IEnumerable<LevenshteinTitleComparison> comparisons = stringDistanceComparer.YieldComparedTitlesFromFile(file, false);

      //foreach (LevenshteinTitleComparison comparison in comparisons) {
      //  Debug.WriteLine($"{comparison.BatchId},{comparison.RecordId1},{comparison.RecordId2},{comparison.LevenshteinDistance},{comparison.Percentile}");
      //}

      #endregion

      #region Yield Compared Titles From Binary File

      //string file = @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB.bin";
      //StringDistanceComparer stringDistanceComparer = new StringDistanceComparer();
      //IEnumerable<LevenshteinTitleComparison> comparisons = stringDistanceComparer.YieldComparedTitlesFromFile(file, true);

      //foreach (LevenshteinTitleComparison comparison in comparisons) {
      //  Debug.WriteLine($"{comparison.BatchId},{comparison.RecordId1},{comparison.RecordId2},{comparison.LevenshteinDistance},{comparison.Percentile}");
      //}

      #endregion

      #region TitlesClusterer - Calculate Descriptive Statistics - Write to text file - Write to database.

      //Cursor oldCursor = this.Cursor;
      //this.Cursor = Cursors.WaitCursor;

      //TitlesClusterer clusterer = new TitlesClusterer();

      //int count = clusterer.ReadLevenshteinDistanceRecords(
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\2023-03-06-metadata.db",
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB.bin"
      //);

      //Debug.WriteLine($"Number of Records found: {count}");

      //Debug.WriteLine("Calculating descriptive statistics...");
      //clusterer.CalculateDescriptiveStatistics();

      //Debug.WriteLine("Writing Levenshtein title statistics to text file...");
      //clusterer.WriteLevenshteinTitleStatisticsToTextFile(@"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB-Statistics.csv");

      //Debug.WriteLine("Writing Levenshtein title statistics to database...");
      //clusterer.Database = @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\2023-03-05-metadata.db";
      //clusterer.WriteLevenshteinTitleStatisticsToDatabase();

      //this.Cursor = oldCursor;

      #endregion

      #region TitlesClusterer - Read from text file - Write to database.

      //Cursor oldCursor = this.Cursor;
      //this.Cursor = Cursors.WaitCursor;

      //TitlesClusterer clusterer = new TitlesClusterer();

      //Debug.WriteLine("Reading Levenshtein title statistics from text file...");
      //clusterer.ReadLevenshteinTitleStatisticsFromTextFile(@"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB-Statistics.csv");

      //Debug.WriteLine("Writing Levenshtein title statistics to database...");
      //clusterer.Database = @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\2023-03-06-metadata.db";
      //clusterer.WriteLevenshteinTitleStatisticsToDatabase();

      //this.Cursor = oldCursor;

      #endregion

      #region TitlesClusterer - Update Levenshtein Title Comparison Percentile Rank.

      //Cursor oldCursor = this.Cursor;
      //this.Cursor = Cursors.WaitCursor;

      //TitlesClusterer clusterer = new TitlesClusterer();

      //int count = clusterer.ReadLevenshteinDistanceRecords(
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\2023-03-06-metadata.db",
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB.bin"
      //);

      //Debug.WriteLine($"Number of Records found: {count}");

      //clusterer.SortLevenshteinTitleComparisonDistancesPopulations();
      //clusterer.UpdateLevenshteinTitleComparisonPercentileRank(
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB.bin"
      //);

      //this.Cursor = oldCursor;

      #endregion

      #region TitlesClusterer - Load Levenshtein Title Comparisons in the database.

      //Cursor oldCursor = this.Cursor;
      //this.Cursor = Cursors.WaitCursor;

      //TitlesClusterer clusterer = new TitlesClusterer();

      //clusterer.LoadLevenshteinDistanceComparisonsToDatabase(
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\2023-03-07-metadata.db",
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB.bin"
      //);

      //this.Cursor = oldCursor;

      #endregion

      #region Export LevenshteinTitleComparisons from binary to text file.

      //StringDistanceComparer stringDistanceComparer = new StringDistanceComparer();
      //stringDistanceComparer.ExportFromBinaryToTextFile(
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB.bin",
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB-2.txt"
      //);

      #endregion

      #region Export LevenshteinTitleComparisons from binary to sql file.

      //StringDistanceComparer stringDistanceComparer = new StringDistanceComparer();
      //stringDistanceComparer.ExportFromBinaryToSqlFile(
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB.bin",
      //  @"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\levenshtein-FebDB-10M.sql"
      //);

      #endregion

      #region Select LevenshteinTitleComparison Query - PostgreSQL

      //MetadataDatabaseController controller = new MetadataDatabaseController();
      //controller.DatabasePath =
      //  AppEngine.Instance.ApplicationModel.DatabaseConnectionsInfo
      //    .Where(cs => cs.Name == "PostgreSQL-Local")?
      //    .First()
      //    .ToString();
      //controller.DatabaseOption = DatabaseOption.PgSqlDev;

      //controller.OpenDatabase();

      //int count = controller.Context.LevenshteinTitleComparisons.Count();

      //StringBuilder sb = new StringBuilder();
      //foreach (LevenshteinTitleComparison comparison in controller.Context.LevenshteinTitleComparisons) {
      //  sb.Append("Id: ");
      //  sb.Append(comparison.Id);
      //  sb.Append(", ");

      //  sb.Append("BatchId: ");
      //  sb.Append(comparison.BatchId);
      //  sb.Append(", ");

      //  sb.Append("RecordId1: ");
      //  sb.Append(comparison.RecordId1);
      //  sb.Append(", ");

      //  sb.Append("RecordId2: ");
      //  sb.Append(comparison.RecordId2);
      //  sb.Append(", ");

      //  sb.Append("Percentile: ");
      //  sb.Append(comparison.Percentile);

      //  Debug.WriteLine(sb.ToString());
      //  sb.Clear();
      //}

      //controller.CloseDatabase();

      #endregion

      //string s0 = AppEngine.Instance.ApplicationModel.DatabaseConnectionsInfo[0].GetType().ToString();
      //string s1 = AppEngine.Instance.ApplicationModel.DatabaseConnectionsInfo[1].GetType().ToString();
      //string s2 = AppEngine.Instance.ApplicationModel.DatabaseConnectionsInfo[2].GetType().ToString();




      // ================================================================================

      #region Metadata Thin

      //string sqliteDbFilePath = $@"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataThinDB\{DateTime.Now.ToString("dd-MM-yyyy")}-metadata-thin.db";
      //MetadataThinDatabaseController controller = new MetadataThinDatabaseController();
      //controller.DatabasePath = sqliteDbFilePath;
      //controller.DatabaseOption = DatabaseOption.Sqlite;
      ////controller.DatabasePath =
      ////  AppEngine.Instance.ApplicationModel.DatabaseConnectionStrings
      ////    .Where(cs => cs.Name == "PostgreSQL")?
      ////    .First()
      ////    .ToString();
      ////controller.DatabaseOption = DatabaseOption.PgSQL_Dev;
      //controller.OpenDatabase();
      //controller.EnsureCreated();
      ////controller.LoadAllXmlFiles(xmlDirectory, logger);
      //controller.LoadMetadataEntitiesToSqliteDb();
      //controller.CloseDatabase();

      //Debug.WriteLine("Metadata Thin: Metadata Entities loaded");

      #endregion

      // ================================================================================

      #region metadataContext

      //MetadataContext metadataContext = new MetadataContext(@"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\MetadataDB\2023-03-06-metadata.db");

      //metadataContext.LevenshteinTitleStatistics.Add(new LevenshteinTitleStatistics() {
      //  Kurtosis = 0.1,
      //  Max = 10,
      //  Mean = 8,
      //  Median = 8.1,
      //  Min = 3,
      //  RecordId = 1,
      //  Skewness = 0.2,
      //  StDev = 6,
      //  Variance = 0.8
      //});

      //metadataContext.LevenshteinTitleComparisons.Add(new LevenshteinTitleComparison() {
      //  Id = 1,
      //   BatchId= 1,
      //    LevenshteinDistance = 48,
      //     Percentile = -1,
      //      RecordId1= 1,
      //       RecordId2 = 2
      //});

      //metadataContext.MetadataEntities.Add(new MetadataEntity() {
      //   Abstract = "This is an abstact.",
      //    DC = "DC1",
      //     FileIdentifier = "guid-goes-here",
      //      HierarchyLevel = "dataset",
      //        Organisation = "BGS",
      //         RecordId = 1,
      //          Title = "The Title of the dataset"
      //});


      //metadataContext.SaveChanges();
      //metadataContext.Dispose();

      #endregion

      #region Write Configuration File

      //WriteConfiguration(@"C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Out\NDSH.Utilities.App\application-configuration.json");

      #endregion

      // ================================================================================

      #region Commented Out

      ////DateOnly date = DateOnly.Parse("2006");
      //DateOnly date = new DateOnly();
      //date = date.AddYears(2006);
      //string sdate = date.ToString();

      //return;

      //myHelper();

      //Assembly assembly = Assembly.GetExecutingAssembly();
      //string path = assembly.Location.Replace(assembly.GetName().Name + ".dll", "");
      //string testOutputDir = path + @"..\..\..\Out\Log\Checker\";

      //if (!Directory.Exists(testOutputDir)) {
      //  Directory.CreateDirectory(testOutputDir);
      //}
      //string typelogger = testOutputDir + "typeLogger.log";
      //string xmlIncludeslogger = testOutputDir + "xmlIncludesLogger.log";
      //XmlIncludeChecker x = new(typelogger, xmlIncludeslogger);

      //string typeLoggerFilePath = testOutputDir + "typeLogger.log";
      //string xmlIncludesLoggerFilePath = testOutputDir + "xmlIncludesLogger.log";

      //if (File.Exists(typeLoggerFilePath)) {
      //  File.Delete(typeLoggerFilePath);
      //}

      //if (File.Exists(xmlIncludesLoggerFilePath)) {
      //  File.Delete(xmlIncludesLoggerFilePath);
      //}

      //Checker x = new(
      //  typelogFilePath: typeLoggerFilePath, 
      //  xmlIncludeLogFilePath: xmlIncludesLoggerFilePath);
      //x.Check();



      //System.Xml.Schema.

      //string entity = CitationInformationResources.Entity_Placeholder;
      //string responsiblePartyXml = CitationInformationResources.X_CI_ResponsibleParty1;
      //entity = entity.Replace("@@@@", responsiblePartyXml);

      //this.SerializationInputTextBox.Text = entity;

      //XElement xElement = XElement.Parse(entity);
      //object b = IsoGmdXElementConverter.ToObjectChris(xElement);
      //JsonSerializer jsonSer = new JsonSerializer();
      //string json = jsonSer.SerializeJson(b);

      //this.SerializationOutputTextBox.Text = json;




      //Type t = xElement.GetType(); 

      //System.Xml.Linq.XNode rootNode = xElement.FirstNode;


      //typeof(XElement).getA

      #endregion

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TestDatabaseButton_Click(object sender, EventArgs e) {

      //DatabaseConnectionInfo? databaseConnectionInfo =
      //  AppEngine.Instance.ApplicationModel.DatabaseConnectionsInfo.Where(cs => cs.Name == "PostgreSQL-Local-Thin").FirstOrDefault();

      //if (databaseConnectionInfo == null) {
      //  throw new NullReferenceException("Database connection is null.");
      //}
      //PostgreSqlConnectionInfo postgreSqlConnectionInfo = (PostgreSqlConnectionInfo)databaseConnectionInfo;

      //MetadataDbContext metadataDbContext = new MetadataDbContext(postgreSqlConnectionInfo);
      //bool created = metadataDbContext.Database.EnsureCreated();

      #region MetadataTest Table
      //MetadataTest metadataTest1 = new MetadataTest() {
      //  Id = 1,
      //  FileIdentifier = "fid1"
      //};
      //metadataDbContext.MetadataTests.Add(metadataTest1);

      //MetadataTest metadataTest2 = new MetadataTest() {
      //  Id = 2,
      //  FileIdentifier = "fid2"
      //};
      //metadataDbContext.MetadataTests.Add(metadataTest2);

      //MetadataTest metadataTest3 = new MetadataTest() {
      //  Id = 3,
      //  FileIdentifier = "fid3"
      //};
      //metadataDbContext.MetadataTests.Add(metadataTest3);

      //MetadataTest metadataTest4 = new MetadataTest() {
      //  Id = 4,
      //  FileIdentifier = "fid4"
      //};
      //metadataDbContext.MetadataTests.Add(metadataTest4);

      //metadataDbContext.SaveChanges();
      #endregion

      #region MetadataEntities

      //NDSH.Geospatial.Metadata.V2003.Thin.EntitySet.MD_Metadata_Type mdMetadata1 = new NDSH.Geospatial.Metadata.V2003.Thin.EntitySet.MD_Metadata_Type() {
      //  Id = 1,
      //  FileIdentifier = "fid1"
      //};
      //metadataDbContext.MD_Metadata.Add(mdMetadata1);

      //NDSH.Geospatial.Metadata.V2003.Thin.EntitySet.MD_Metadata_Type mdMetadata2 = new NDSH.Geospatial.Metadata.V2003.Thin.EntitySet.MD_Metadata_Type() {
      //  Id = 2,
      //  FileIdentifier = "fid2"
      //};
      //metadataDbContext.MD_Metadata.Add(mdMetadata2);

      //NDSH.Geospatial.Metadata.V2003.Thin.EntitySet.MD_Metadata_Type mdMetadata3 = new NDSH.Geospatial.Metadata.V2003.Thin.EntitySet.MD_Metadata_Type() {
      //  Id = 3,
      //  FileIdentifier = "fid3"
      //};
      //metadataDbContext.MD_Metadata.Add(mdMetadata3);

      //NDSH.Geospatial.Metadata.V2003.Thin.EntitySet.MD_Metadata_Type mdMetadata4 = new NDSH.Geospatial.Metadata.V2003.Thin.EntitySet.MD_Metadata_Type() {
      //  Id = 4,
      //  FileIdentifier = "fid4"
      //};
      //metadataDbContext.MD_Metadata.Add(mdMetadata4);

      //metadataDbContext.SaveChanges();

      #endregion

      #region UniqueFileTypes

      //DatabaseConnectionInfo? databaseConnectionInfo =
      //  AppEngine.Instance.ApplicationModel.DatabaseConnectionsInfo.Where(cs => cs.Name == "SQLite").FirstOrDefault();

      //if (databaseConnectionInfo == null) {
      //  throw new NullReferenceException("Database connection is null.");
      //}
      //SqliteConnectionInfo sqliteConnectionInfo = (SqliteConnectionInfo)databaseConnectionInfo;

      //MetadataDatabaseController dbController = new MetadataDatabaseController();
      //dbController.OpenDatabase(sqliteConnectionInfo.FilePath, DatabaseOption.Sqlite);

      //DbSet<UniqueFileTypeSource> uniqueFileTypesSource = dbController.Context.UniqueFileTypesSource;

      //Dictionary<string, int> uniqueFileTypesDictionary = new Dictionary<string, int>();

      //foreach (UniqueFileTypeSource fileTypeSource in uniqueFileTypesSource) {
      //  string[] newFileTypes = fileTypeSource.NewFileType.Split(';', StringSplitOptions.RemoveEmptyEntries);

      //  if (newFileTypes != null) {
      //    for (int i = 0; i < newFileTypes.Length; i++) {
      //      string newFileType = newFileTypes[i].Trim();

      //      if (!uniqueFileTypesDictionary.ContainsKey(newFileType)) {
      //        uniqueFileTypesDictionary.Add(newFileType, int.Parse(fileTypeSource.FileTypesCount));
      //      }
      //      else {
      //        uniqueFileTypesDictionary[newFileType] += int.Parse(fileTypeSource.FileTypesCount);
      //      }
      //    }
      //  }
      //}

      //DbSet<UniqueFileType> uniqueFileTypes = dbController.Context.UniqueFileTypes;

      //foreach (var item in uniqueFileTypesDictionary) {
      //  uniqueFileTypes.Add(new UniqueFileType() {
      //    FileType = item.Key,
      //    RowsCount = item.Value
      //  });
      //}

      //dbController.Context.SaveChanges();

      #endregion

      #region MetadataEntries_FileTypes

      //DatabaseConnectionInfo? databaseConnectionInfo =
      //  AppEngine.Instance.ApplicationModel.DatabaseConnectionsInfo.Where(cs => cs.Name == "SQLite").FirstOrDefault();

      //if (databaseConnectionInfo == null) {
      //  throw new NullReferenceException("Database connection is null.");
      //}
      //SqliteConnectionInfo sqliteConnectionInfo = (SqliteConnectionInfo)databaseConnectionInfo;

      //MetadataDatabaseController dbController = new MetadataDatabaseController();
      //dbController.OpenDatabase(sqliteConnectionInfo.FilePath, DatabaseOption.Sqlite);

      //DbSet<UniqueFileTypeSource> uniqueFileTypesSource = dbController.Context.UniqueFileTypesSource;
      //DbSet<MetadataEntityFileTypeSource> metadataEntityFileTypesSource = dbController.Context.MetadataEntitiesFileTypesSource;
      //DbSet<MetadataEntityFileType> metadataEntityFileTypes = dbController.Context.MetadataEntitiesFileTypes;

      //Dictionary<string, UniqueFileTypeSource> uniqueFileTypesSourceDictionary = uniqueFileTypesSource.ToDictionary(k => k.FileType);

      //foreach (MetadataEntityFileTypeSource fileTypeSource in metadataEntityFileTypesSource) {

      //  UniqueFileTypeSource uniqueSource = uniqueFileTypesSourceDictionary[fileTypeSource.FileType];

      //  if (uniqueSource != null) {
      //    string[] newFileTypes = uniqueSource.NewFileType.Split(';', StringSplitOptions.RemoveEmptyEntries);

      //    if (newFileTypes != null) {
      //      for (int i = 0; i < newFileTypes.Length; i++) {
      //        string newFileType = newFileTypes[i].Trim();

      //        metadataEntityFileTypes.Add(new MetadataEntityFileType() {
      //          Abstract = fileTypeSource.Abstract,
      //          DC = fileTypeSource.DC,
      //          FileIdentifier = fileTypeSource.FileIdentifier,
      //          FileType = newFileType,                             // Here's the difference.
      //          HierarchyLevel = fileTypeSource.HierarchyLevel,
      //          Organisation = fileTypeSource.Organisation,
      //          RecordId = fileTypeSource.RecordId,
      //          Title = fileTypeSource.Title
      //        });
      //      }
      //    }
      //  }

      //}

      //dbController.Context.SaveChanges();

      #endregion

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void XsdToCodeButton_Click(object sender, EventArgs e) {

      string path = "NDSH.Geospatial.Metadata.V2003.Tests.EntitySet.Schemas";
      string resourceName = "metadataEntitySet.xsd";

      this.OutputCodeRichTextBox.Text = XsdToCode.GenerateTypesCode(
        XsdToCode.GetXmlSchema(path, resourceName, this.InputXsdRichTextBox),
        new XsdToCode.ClassTypeVariables() {
          Coder = "@gisvlasta",
          Namespace = "EntitySet",
          XmlNamespace = "http://www.isotc211.org/2005/gmi",
          XmlNamespacePrefix = "gmi"
        }
      );

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void XsdToCodeByStringButton_Click(object sender, EventArgs e) {

      Assembly assembly = Assembly.GetExecutingAssembly();
      string path = assembly.Location.Replace(assembly.GetName().Name + ".dll", "");

      var xsdToCode = new XsdToCodeByString(path + @"..\..\..\Out\SpatialRepresentation.log.txt");

      xsdToCode.XsdString = XsdToCodeByString.GetEmbeddedXsdFileResourceString("spatialRepresentationInformation.xsd");
      xsdToCode.AbstractObject_Type_FP = path + @"..\..\..\Proj\src\NDSH.Geospatial.Metadata.V2003\src\Common\AbstractObject_Type_TEMP.cs";

      string testOutputDir = path + @"..\..\..\Out\Imagery\SpatialRepresentation\";
      if (!Directory.Exists(testOutputDir)) {
        Directory.CreateDirectory(testOutputDir);
      }

      Debug.Assert(xsdToCode != null && xsdToCode.XsdString != null);

      xsdToCode.ParseXsdString(
        xsdString: xsdToCode.XsdString,
        startIdx: 0,
        recursive: true);

      xsdToCode.ToCsFiles(
        destinationDir: testOutputDir,
        xmlPrefix: "gmi",
        xmlNamespace: "http://www.isotc211.org/2005/gmi",
        @namespace: "NDSH.Geospatial.Metadata.V2003.Imagery.SpatialRepresentation",
        addXmlInclude: false,
        author: "@gisvlasta."
        );

    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// 
    /// </summary>
    /// <param name="metadataInputCode"></param>
    /// <returns></returns>
    private string CleanMetadataCode(string metadataInputCode) {

      string metadataOutputCode = metadataInputCode.Replace(
        "\r\n  [System.CodeDom.Compiler.GeneratedCodeAttribute(\"System.Xml\", \"4.8.4084.0\")]",
        "  \r\n  /// <summary>\r\n  /// \r\n  /// </summary>\r\n  [System.CodeDom.Compiler.GeneratedCodeAttribute(\"System.Xml\", \"4.8.4084.0\")]"
      ).Replace(
        " {\r\n    #region Private fields",
        " {\r\n    \r\n    #region Public Fields"
      ).Replace(
        "    [XmlElement(",
        "    /// <summary>\r\n    /// \r\n    /// </summary>\r\n    [XmlElement("
      ).Replace(
        "    [XmlAttribute(",
        "    /// <summary>\r\n    /// \r\n    /// </summary>\r\n    [XmlAttribute("
      )
      .Replace("if (((", "if (")
      .Replace("true))) {", "true) {")
      .Replace("if ((", "if (")
      .Replace("value)) {", "value) {")
      .Replace("null)\r\n                    || (", "null || ");

      //int insertIndex = metadataOutput.IndexOf("    /// <summary>\r\n    /// \r\n    /// </summary>\r\n    [XmlElement(Order");
      //metadataOutput = metadataOutput.Insert(insertIndex, "\r\n    #region Public Properties\r\n");

      //insertIndex = metadataOutput.LastIndexOf("        }\r\n      }\r\n    }");
      //metadataOutput = metadataOutput.Insert(insertIndex, "\r\n    \r\n#endregion\r\n    ");

      return metadataOutputCode;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="metadataInputCode"></param>
    /// <returns></returns>
    private string CleanMetadataCodeV2003(string metadataInputCode) {

      StringBuilder sb = new();

      sb.Append("\n");
      sb.Append("    public event PropertyChangedEventHandler PropertyChanged;\n");
      sb.Append("\n");
      sb.Append("    public virtual void OnPropertyChanged(string propertyName) {\n");
      sb.Append("      PropertyChangedEventHandler handler = PropertyChanged;\n");
      sb.Append("      if ((handler != null)) {\n");
      sb.Append("        handler(this, new PropertyChangedEventArgs(propertyName));\n");
      sb.Append("      }\n");
      sb.Append("    }\n");

      string propertyChangedEventPlusProcedure = sb.ToString();

      sb.Clear();

      sb.Append(")\n");
      sb.Append("                    || (_");

      string middleOr = sb.ToString();


      string metadataOutputCode = metadataInputCode.Replace(
          "[System.CodeDom.Compiler.GeneratedCodeAttribute(\"System.Xml\", \"4.8.9037.0\")]\n", ""
        ).Replace(
          "[DebuggerStepThrough]\n", ""
        ).Replace(
          "[DesignerCategoryAttribute(\"code\")]", ""
        ).Replace(
          "[XmlTypeAttribute(", "[XmlType("
        ).Replace(
          "XmlRootAttribute(", "XmlRoot("
        ).Replace(
          propertyChangedEventPlusProcedure, ""
        ).Replace(
          "INotifyPropertyChanged", "Model"
        ).Replace(
          "RequiredAttribute", "Required"
        ).Replace(
          "\n                    || (_", " || (_"
        ).Replace(
          "if (((_", "if (_"
        ).Replace(
          "))) {", ") {"
        ).Replace(
          middleOr, " || _"
        ).Replace(
          "if ((_", "if (_"
        ).Replace(
          ")) {", ") {"
        )


      ;

      return metadataOutputCode;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="address"></param>
    private void XSerializeAddress(CI_Address address) {

      //<gmd:CI_Address>
      //  <gmd:deliveryPoint>
      //    <gco:CharacterString>Environmental Science Centre, Keyworth</gco:CharacterString>
      //  </gmd:deliveryPoint>
      //  <gmd:city>
      //    <gco:CharacterString>NOTTINGHAM</gco:CharacterString>
      //  </gmd:city>
      //  <gmd:administrativeArea>
      //    <gco:CharacterString>NOTTINGHAMSHIRE</gco:CharacterString>
      //  </gmd:administrativeArea>
      //  <gmd:postalCode>
      //    <gco:CharacterString>NG12 5GG</gco:CharacterString>
      //  </gmd:postalCode>
      //  <gmd:country>
      //    <gco:CharacterString>United Kingdom</gco:CharacterString>
      //  </gmd:country>
      //  <gmd:electronicMailAddress>
      //    <gco:CharacterString> enquiries@bgs.ac.uk </ gco:CharacterString >
      //  </gmd:electronicMailAddress>
      //</gmd:CI_Address>

      //XNamespace gmdXNamespace = XNamespace.Get("http://www.isotc211.org/2005/gmd");
      //XNamespace gcoXNamespace = XNamespace.Get("http://www.isotc211.org/2005/gco");

      string gmdNS = "http://www.isotc211.org/2005/gmd";
      string gcoNS = "http://www.isotc211.org/2005/gco";

      XAttribute gmdXAttribute = new XAttribute(XNamespace.Xmlns + "gmd", gmdNS);
      XAttribute gcoXAttribute = new XAttribute(XNamespace.Xmlns + "gco", gcoNS);

      XName characterStringXName = XName.Get("CharacterString", gmdNS);

      XName addressXName = XName.Get("CI_Address", gmdNS);

      XName deliveryPointXName = XName.Get("deliveryPoint", gmdNS);
      XName cityXName = XName.Get("city", gmdNS);
      XName administrativeAreaXName = XName.Get("administrativeArea", gmdNS);
      XName postalCodeXName = XName.Get("postalCode", gmdNS);
      XName countryXName = XName.Get("country", gmdNS);
      XName electronicMailAddressXName = XName.Get("electronicMailAddress", gmdNS);

      XElement xAddress = new XElement(addressXName, gmdXAttribute,
        new XElement(deliveryPointXName,
          new XElement(characterStringXName, gcoXAttribute, address.DeliveryPoint)
        ),
        new XElement(cityXName,
          new XElement(characterStringXName, gcoXAttribute, address.City)
        ),
        new XElement(administrativeAreaXName,
          new XElement(characterStringXName, gcoXAttribute, address.AdministrativeArea)
        ),
        new XElement(postalCodeXName,
          new XElement(characterStringXName, gcoXAttribute, address.PostalCode)
        ),
        new XElement(countryXName,
          new XElement(characterStringXName, gcoXAttribute, address.Country)
        ),
        new XElement(electronicMailAddressXName,
          new XElement(characterStringXName, gcoXAttribute, address.ElectronicMailAddress)
        )
      );

      //string xml = xAddress.ToString(SaveOptions.None);
      string xml = xAddress.ToString(SaveOptions.DisableFormatting);

      this.SerializationOutputRichTextBox.Text = xml;

    }

    /// <summary>
    /// 
    /// </summary>
    private void myHelper() {

      var a = Assembly.GetAssembly(typeof(AbstractDS_Aggregate_Type));
      List<Type> publicClasses = a.GetTypes().Where(
        t => t.IsClass && !t.IsAbstract && t.Name.EndsWith("_Type")
      ).ToList();

      var attributeList = publicClasses.Select(cls => $"[InlineData(typeof({cls.FullName}))]".PadLeft(4));
      var attributeString = string.Join('\n', attributeList);
      this.OutputMetadataCodeRichTextBox.Text = attributeString;

    }

    private void CreateEqualBins(int maxInt, int binSize) {

      int[] numbers = Enumerable.Range(1, maxInt).ToArray();

      int totalSum = numbers.Sum();
      int groupSum = totalSum / binSize;

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

      // Add any remaining numbers to the last group
      if (currentSum > 0) {
        groups.Add(currentGroup);
        groupSums.Add(currentSum);
      }
      //if (currentGroup.Count > 0) {
      //  groups.Add(currentGroup);
      //}

      // Print the sum of each group
      for (int i = 0; i < groups.Count; i++) {
        Debug.WriteLine($"Group {i + 1}: {groups[i]}  sum: {groupSums[i]}");
      }

    }

    /// <summary>
    /// 
    /// </summary>
    private void BenchmarkStringComparisons() {

      Cursor previousCursor = this.Cursor;
      this.Cursor = Cursors.WaitCursor;

      string s1 = "Map based index (GeoIndex) landslides";
      string s2 = "BGS GeoIndex - Hazards data theme (OGC WxS INSPIRE)";

      LevenshteinAccord levenshetein = new LevenshteinAccord();

      DateTime start = DateTime.Now;

      //for (int i = 0; i < 1_000_000; i++) {
      //  double distance = levenshetein.Distance(s1, s2);
      //}

      Parallel.For(0, 1_000_000, (i) => {
        double distance = levenshetein.Distance(s1, s2);
      });

      DateTime end = DateTime.Now;

      Debug.WriteLine("*** Process: Accord Levenshtein | Duration: {0}", TimeSpan.FromTicks(end.Ticks - start.Ticks));

      start = DateTime.Now;

      //int s1Length = s1.Length;
      //Span<char> s1StackSpan = stackalloc char[s1Length];
      //// Copy the characters from the string to the stack-allocated span
      //s1.AsSpan().CopyTo(s1StackSpan);
      //// Create a ReadOnlySpan<char> that refers to the stack-allocated memory
      //ReadOnlySpan<char> s1ReadOnlyStackSpan = s1StackSpan;

      //int s2Length = s2.Length;
      //Span<char> s2StackSpan = stackalloc char[s2Length];
      //// Copy the characters from the string to the stack-allocated span
      //s2.AsSpan().CopyTo(s2StackSpan);
      //// Create a ReadOnlySpan<char> that refers to the stack-allocated memory
      //ReadOnlySpan<char> s2ReadOnlyStackSpan = s2StackSpan;

      //for (int i = 0; i < 1_000_000; i++) {
      //  int distance = LevenshteinDistanceUtf16(s1ReadOnlyStackSpan, s2ReadOnlyStackSpan);
      //  //int distance = LevenshteinDistanceUtf16BitShift(s1ReadOnlyStackSpan, s2ReadOnlyStackSpan);
      //}

      Parallel.For(0, 1_000_000, ParallelLev);

      end = DateTime.Now;

      Debug.WriteLine("*** Process: Levenshtein | Duration: {0}", TimeSpan.FromTicks(end.Ticks - start.Ticks));

      this.Cursor = previousCursor;

    }

    private static void ParallelLev(int i) {

      //string s1 = "Map based index (GeoIndex) landslides";
      //string s2 = "BGS GeoIndex - Hazards data theme (OGC WxS INSPIRE)";

      //int s1Length = s1.Length;
      //Span<char> s1StackSpan = stackalloc char[s1Length];
      //// Copy the characters from the string to the stack-allocated span
      //s1.AsSpan().CopyTo(s1StackSpan);
      //// Create a ReadOnlySpan<char> that refers to the stack-allocated memory
      //ReadOnlySpan<char> s1ReadOnlyStackSpan = s1StackSpan;

      //int s2Length = s2.Length;
      //Span<char> s2StackSpan = stackalloc char[s2Length];
      //// Copy the characters from the string to the stack-allocated span
      //s2.AsSpan().CopyTo(s2StackSpan);
      //// Create a ReadOnlySpan<char> that refers to the stack-allocated memory
      //ReadOnlySpan<char> s2ReadOnlyStackSpan = s2StackSpan;

      //int distance = LevenshteinDistanceUtf16(s1ReadOnlyStackSpan, s2ReadOnlyStackSpan);

    }

    /// <summary>
    /// Reads the configuration from the config file.
    /// </summary>
    /// <param name="jsonConfigFile">
    /// The full path to the JSON configuration file.
    /// </param>
    private static void ReadConfiguration(string? jsonConfigFile) {

      if (jsonConfigFile == null) {
        throw new ArgumentNullException($"Argument {nameof(jsonConfigFile)} is null.");
      }

      Newtonsoft.Json.JsonSerializer serializer = new() {
        Formatting = Newtonsoft.Json.Formatting.Indented,
        TypeNameHandling = TypeNameHandling.Objects
      };
      serializer.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

      using (var sr = new StreamReader(jsonConfigFile))
      using (var reader = new JsonTextReader(sr)) {
        AppEngine.Instance.ApplicationModel = serializer.Deserialize<ApplicationModel>(reader);
      }

    }

    /// <summary>
    /// Writes the configuration to the config file.
    /// </summary>
    /// <param name="jsonConfigFile">
    /// The full path to the JSON configuration file.
    /// </param>
    private static void WriteConfiguration(string jsonConfigFile) {

      //ApplicationModel applicationModel = new ApplicationModel() {
      //  DatabaseConnectionsInfo = new List<DatabaseConnectionInfo>(1) {
      //    new PostgreSqlConnectionInfo() {
      //      Database = "database",
      //      Host = "host",
      //      Name = "PostgreSQL connection",
      //      Password = "password",
      //      Username = "username"
      //    }
      //  }
      //};

      //AppEngine.Instance.ApplicationModel = applicationModel;

      //var serializer = new Newtonsoft.Json.JsonSerializer() {
      //  Formatting = Newtonsoft.Json.Formatting.Indented,
      //  TypeNameHandling = TypeNameHandling.Objects
      //};
      //serializer.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

      //using (var sw = new StreamWriter(jsonConfigFile))
      //using (JsonWriter writer = new JsonTextWriter(sw)) {
      //  serializer.Serialize(writer, AppEngine.Instance.ApplicationModel);
      //}

    }

    #endregion

  }

}
