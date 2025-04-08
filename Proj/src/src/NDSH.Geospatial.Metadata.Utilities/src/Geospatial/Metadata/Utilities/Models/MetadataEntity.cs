
#region Imported Namespaces

using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities.Models {

  /// <summary>
  /// 
  /// </summary>
  [Table("MetadataEntities")]
  [PrimaryKey(nameof(Id))]
  public class MetadataEntity {

    #region Public Properties

    /// <summary>
    /// Gets/Sets the internal Id.
    /// </summary>
    public int Id {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the record id of the original XML record. This is a swquence number starting from 0.
    /// </summary>
    public int RecordId {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the metadata file identifier.
    /// src xpath: MD_Metadata/fileIdentifier
    /// </summary>
    public string? FileIdentifier {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the title of the metadata entity.
    /// src xpath: (if 1 is null then 2)
    /// 1. MD_Metadata/identificationInfo/MD_DataIdentification/citation/CI_Citation/title.Value
    /// 2. MD_Metadata/identificationInfo/SV_ServiceIdentification/citation/CI_Citation/title.Value
    /// </summary>
    public string? Title {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the abstract of the metadata entity.
    /// src xpath: MD_Metadata/identificationInfo/MD_DataIdentification/abstract.Value
    /// </summary>
    public string? Abstract {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the hierarchy level of the metadata entity.
    /// src xpath: MD_Metadata/hierarchyLevel.Value
    /// </summary>
    public string? HierarchyLevel {
      get; set;
    }
    /// <summary>
    /// Gets/Sets the organistaion of the metadata entity.
    /// src xpath: MD_Metadata/contact/CI_ResponsibleParty/organisationName.Value
    /// </summary>
    public string? Organisation {
      get; set;
    }

    ///// <summary>
    ///// uncomment when you need to run LoadAllFileTypes
    ///// </summary>
    //public string? FileType {
    //  get; set;
    //}

    /// <summary>
    /// wrap scrap from https://www2.bgs.ac.uk/nationalgeosciencedatacentre/citeddata/catalogue.html
    /// match by <see cref="MetadataEntity.FileIdentifier"/>
    /// </summary>
    public string? DC {
      get; set;
    }

    #endregion

  }

}
