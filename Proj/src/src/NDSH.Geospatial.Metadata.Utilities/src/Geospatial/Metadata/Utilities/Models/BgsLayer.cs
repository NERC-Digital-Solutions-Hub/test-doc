
#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities.Models {
  
  /// <summary>
  /// 
  /// </summary>
  [Table("BgsLayers")]
  public class BgsLayer {

    #region Public Properties

    /// <summary>
    /// 
    /// </summary>
    public int Id {
      get; set;
    }
    
    /// <summary>
    /// src from nerc_*.xml filename, start from 0.
    /// </summary>
    public int? RecordId { // TODO: match it with the metadataEntities Table
      get; set;
    }
    
    /// <summary>
    /// src xpath: MD_Metadata/fileIdentifier 
    /// </summary>
    public string FileIdentifier {
      get;set;
    }

    /// <summary>
    /// src: metadata xml
    /// operatesOn uuid
    /// </summary>
    public string? RelatedDataSetUuId {
      get; set;
    }

    /// <summary>
    /// src xpath: MD_Metadata/identificationInfo/SV_ServiceIdentification/operatesOn
    /// </summary>
    public string? OperatesOnTitle {
      get; set;
    }

    /// <summary>
    /// src: <see cref="BgsLayer.WmsGetCapabilityUrl"/> xml
    /// xpath: Capability/Layer/Layer[n]@queryable=1/Name.Value
    /// </summary>
    public string? WmsLayerName {
      get; set;
    }

    /// <summary>
    /// src: <see cref="BgsLayer.WmsGetCapabilityUrl"/> xml
    /// xpath: Capability/Layer/Layer[n]@queryable=1/Title.Value
    /// </summary>
    public string? WmsLayerTitle {
      get; set;
    }

    /// <summary>
    /// src: <see cref="BgsLayer.WmsGetCapabilityUrl"/> xml
    /// xpath: Capability/Layer/Layer[n]@queryable=1/Abstract.Value
    /// </summary>
    public string? WmsLayerAbstract {
      get; set;
    }


    /// <summary>
    /// src: metadata xml
    /// xpath: MD_Metadata/distributionInfo/MD_Distribution/transferOptions/MD_DigitalTransferOptions/onLine/CI_OnlineResource/linkage/URL.Value
    /// </summary>
    public string? WmsGetCapabilityUrl {
      get; set;
    }

    /// <summary>
    /// src: <see cref="BgsLayer.WmsGetCapabilityUrl"/> xml
    /// remove until MapServer, add rest after arcgis segment
    /// </summary>
    public string? ArcGisMapServerUrl {
      get; set;
    }

    /// <summary>
    /// src xpath:
    /// </summary>
    public string? ArcGisLayerUrl {
      get; set;
    }
    
    /// <summary>
    /// 
    /// </summary>
    public string? ArcGisLayerName {
      get; set;
    }

    #endregion

  }

}
