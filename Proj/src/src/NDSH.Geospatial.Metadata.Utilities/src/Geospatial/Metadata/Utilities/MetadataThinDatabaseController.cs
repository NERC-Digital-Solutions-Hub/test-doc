
#region Imported Namespaces

using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using NDSH.Geospatial.Metadata.Utilities.DatabaseContext;
using NDSH.Geospatial.Metadata.Utilities.Models;
using NDSH.Geospatial.Metadata.V2003.Thin.EntitySet;
using Serilog.Core;
using Serilog.Filters;
using System.Collections.Immutable;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Mime;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Xml.Linq;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities {

  /// <summary>
  /// Provides control over the metadata thin database.
  /// </summary>
  public class MetadataThinDatabaseController {

    #region Member Variables

    private static int _sequenceId = 0;
    private MetadataThinContext _context;
    private DatabaseOption _dbOption;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets/Sets the file path to the database file.
    /// </summary>
    /// <remarks>
    /// This is the path to a file when a file database like SQLite,
    /// or a connection string if a database like an RDBMS.
    /// </remarks>
    public string DatabasePath {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the <see cref="DatabaseContext.DatabaseOption"/>.
    /// </summary>
    public DatabaseOption DatabaseOption {
      get {
        return _dbOption;
      }
      set {
        _dbOption = value;
      }
    }

    /// <summary>
    /// Gets whether the database is open or not.
    /// </summary>
    public bool IsDbOpen {
      get {
        return (_context != null);
      }
    }

    /// <summary>
    /// Gets the PostgreSQL path retrieving the environment variable's 'pgSqlPath' value.
    /// </summary>
    /// <exception cref="NullReferenceException">
    /// Thrown when the 'pgSqlPath' environment variable isassigned a null value.
    /// </exception>
    public static string GetPgSqlPathFromEnvironmentVariable {
      get {
        string? connectionString = Environment.GetEnvironmentVariable("pgSqlPath");
        if (connectionString == null) {
          throw new NullReferenceException("pgSqlPath is null. Please set the enviroment variable [pgSqlPath] and its value in the debug profile.");
        }
        return connectionString;
      }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Opens the SQLite database.
    /// </summary>
    public void OpenDatabase() {
      OpenDatabase(this.DatabasePath, this.DatabaseOption);
    }

    /// <summary>
    /// Opens the SQLite database.
    /// </summary>
    /// <param name="databaseFile">The database file.</param>
    /// <param name="databaseOption">The <see cref="DatabaseOption.DatabaseOption"/>.</param>
    public void OpenDatabase(string databaseFile, DatabaseOption databaseOption) {
      this.DatabasePath = databaseFile;
      this.DatabaseOption = databaseOption;
      _context = new MetadataThinContext(this.DatabasePath, this.DatabaseOption);
    }

    /// <summary>
    /// Closes the SQLite database.
    /// </summary>
    public void CloseDatabase() {

      if (_context == null) {
        throw new Exception($"{nameof(_context)} is null");
      }

      _context.Dispose();

    }

    /// <summary>
    /// Deletes the SQLite database.
    /// </summary>
    public void DeleteDatabase() {

      if (_context == null) {
        throw new Exception($"{nameof(_context)} is null");
      }

      _context.Database.EnsureDeleted();

    }

    /// <summary>
    /// Creates a new SQLite database.
    /// </summary>
    public void CreateDatabase() {

      if (_context == null) {
        throw new Exception($"{nameof(_context)} is null");
      }

      if (System.IO.File.Exists(this.DatabasePath)) {
        throw new Exception("File already exists.");
      }

      _context.Database.EnsureCreated();

    }

    /// <summary>
    /// Recreates the SQLite database.
    /// </summary>
    public void RecreateDatabase() {

      if (_context == null) {
        throw new Exception($"{nameof(_context)} is null");
      }

      _context.Database.EnsureDeleted();
      _context.Database.EnsureCreated();

    }

    /// <summary>
    /// 
    /// </summary>
    public void EnsureCreated() {
      _context.Database.EnsureCreated();
    }

    /// <summary>
    /// Loads the metadata entities into the Sqlite database.
    /// </summary>
    /// <exception cref="NullReferenceException"></exception>
    public void LoadMetadataEntitiesToSqliteDb() {

      List<MD_Metadata_Type>? mds = new List<MD_Metadata_Type>();

      //if (mds == null) {
      //  throw new NullReferenceException(nameof(mds));
      //}

      mds.Add(new MD_Metadata_Type() {
        FileIdentifier = "ide-1",
        //Id = 1,
        Uuid = Guid.NewGuid().ToString(),
      });
      mds.Add(new MD_Metadata_Type() {
        FileIdentifier = "ide-2",
        //Id = 2,
        Uuid = Guid.NewGuid().ToString(),
      });
      mds.Add(new MD_Metadata_Type() {
        FileIdentifier = "ide-3",
        //Id = 3,
        Uuid = Guid.NewGuid().ToString(),
      });
      mds.Add(new MD_Metadata_Type() {
        FileIdentifier = "ide-4",
        //Id = 4,
        Uuid = Guid.NewGuid().ToString(),
      });

      //_context.MD_Metadata_Types.AddRange(mds);
      _context.AddRange(mds);
      _context.SaveChanges();
      //Debug.WriteLine(string.Format($"Added {mds.Count} metadata to db from file: {xmlFilePath}"));

    }



    ///// <summary>
    ///// Gets metadata entities from an XML file.
    ///// </summary>
    ///// <param name="xmlFilePath">
    ///// The XML file path having the metadata entity records.
    ///// </param>
    ///// <returns>A List of <see cref="MetadataEntity"/> instances.</returns>
    //public List<MetadataEntity>? GetMetadataEntities(string xmlFilePath) {

    //  string cswNS = "http://www.opengis.net/cat/csw/2.0.2";
    //  string gmdNS = "http://www.isotc211.org/2005/gmd";
    //  string gcoNS = "http://www.isotc211.org/2005/gco";
    //  string srvNS = "http://www.isotc211.org/2005/srv";

    //  string getTitle(XElement md) {
    //    if (md is null) {
    //      throw new ArgumentNullException(nameof(md));
    //    }

    //    string? Title_MD_DataIdentification = md?.Element(XName.Get("identificationInfo", gmdNS))?
    //                            .Element(XName.Get("MD_DataIdentification", gmdNS))?
    //                            .Element(XName.Get("citation", gmdNS))?
    //                            .Element(XName.Get("CI_Citation", gmdNS))?
    //                            .Element(XName.Get("title", gmdNS))?.Value;
    //    if (Title_MD_DataIdentification is not null) {
    //      return Title_MD_DataIdentification;
    //    }

    //    string? Title_SV_ServiceIdentification = md?.Element(XName.Get("identificationInfo", gmdNS))?
    //                            .Element(XName.Get("SV_ServiceIdentification", srvNS))?
    //                            .Element(XName.Get("citation", gmdNS))?
    //                            .Element(XName.Get("CI_Citation", gmdNS))?
    //                            .Element(XName.Get("title", gmdNS))?.Value;

    //    if (Title_SV_ServiceIdentification is not null) {
    //      return Title_SV_ServiceIdentification;
    //    }

    //    return null;
    //  }

    //  var xe = XElement.Load(xmlFilePath);
    //  XName searchResultXName = XName.Get("SearchResults", cswNS);

    //  XElement? sr = xe.Element(searchResultXName);

    //  List<MetadataEntity> mds = sr?.Elements().Select(
    //    md => new MetadataEntity {
    //      RecordId = GetSequenceId(),

    //      FileIdentifier = md?.Element(XName.Get("fileIdentifier", gmdNS))?.Value,

    //      Organisation = md?.Element(XName.Get("contact", gmdNS))?
    //                        .Element(XName.Get("CI_ResponsibleParty", gmdNS))?
    //                        .Element(XName.Get("organisationName", gmdNS))?.Value,

    //      Title = getTitle(md),

    //      Abstract = md?.Element(XName.Get("identificationInfo", gmdNS))?
    //                            .Element(XName.Get("MD_DataIdentification", gmdNS))?
    //                            .Element(XName.Get("abstract", gmdNS))?.Value,

    //      HierarchyLevel = md?.Element(XName.Get("hierarchyLevel", gmdNS))?.Value
    //    }
    //  ).ToList();

    //  return mds;

    //}

    ///// <summary>
    ///// Loads all the contents of the metadata files in the database.
    ///// </summary>
    ///// <param name="directory"></param>
    //public void LoadAllXmlFiles(string directory, Logger logger) {

    //  List<string> xmlFilePaths = Directory.GetFiles(
    //    path: directory, searchPattern: "*.xml").ToList();

    //  // Make sure that the sequence id is reset.
    //  ResetSequenceId();

    //  foreach (string xmlFilePath in xmlFilePaths) {
    //    _sequenceId = Convert.ToInt32((Path.GetFileName(xmlFilePath).Replace(".xml", "").Replace("nerc_", ""))) - 1;
    //    LoadMetadataEntitiesToSqliteDb(xmlFilePath: xmlFilePath, context: _context);
    //    LoadBgsLayersToSqliteDb(xmlFilePath: xmlFilePath, context: _context, logger: logger);
    //  }
    //  LoadBgsArcGisMapServerJsonsToSqliteDb(context: _context, logger: logger);
    //  LoadBgsArcGisLayerJsonsToSqliteDb(context: _context, logger: logger);
    //  // match the bgs layer with metadata entity by fileId for recordID
    //  // match the layerJson with the bgs layer by url and for the bgsLayerID

    //}

    #endregion

    #region Private Procedures

    /// <summary>
    /// Gets the sequence id.
    /// </summary>
    private static int GetSequenceId() {
      return ++_sequenceId;
    }

    /// <summary>
    /// Resets the sequence id.
    /// </summary>
    private static void ResetSequenceId() {
      _sequenceId = 0;
    }

    #endregion

  }

}
