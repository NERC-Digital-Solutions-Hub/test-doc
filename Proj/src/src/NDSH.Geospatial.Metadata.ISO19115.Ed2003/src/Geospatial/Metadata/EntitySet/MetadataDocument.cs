
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 18/02/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using System.Xml.Linq;

#endregion

namespace NDSH.Geospatial.Metadata.EntitySet {

  /// <summary>
  /// Represents a metadata document.
  /// </summary>
  public sealed class MetadataDocument : MetadataObject {

    private string _schema = null!;

    /// <summary>
    /// The schema used in the metadata document. E.g. ISO 19115.
    /// </summary>
    public required string Schema {
      get => _schema;
      set => SetProperty(ref _schema, value);
    }

    private Guid _uniqueIdentifier;

    /// <summary>
    /// The unique identifier for the metadata document.
    /// </summary>
    public required Guid UniqueIdentifier {
      get => _uniqueIdentifier;
      set => SetProperty(ref _uniqueIdentifier, value);
    }

    private string _data = null!;

    /// <summary>
    /// The entire metadata document.
    /// </summary>
    public required string Data {
      get => _data;
      set => SetProperty(ref _data, value);
    }

    private DateTime _createDate;

    /// <summary>
    /// The date the metadata document was created.
    /// </summary>
    public required DateTime CreateDate {
      get => _createDate;
      set => SetProperty(ref _createDate, value);
    }

    private DateTime _updateDate;

    /// <summary>
    /// The date the metadata document was last updated.
    /// </summary>
    public required DateTime UpdateDate {
      get => _updateDate;
      set => SetProperty(ref _updateDate, value);
    }

  }

}
