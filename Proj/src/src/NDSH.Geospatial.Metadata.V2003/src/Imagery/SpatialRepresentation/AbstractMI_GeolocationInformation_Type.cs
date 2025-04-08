
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:46, @gisvlasta.
// Updated by        : 08/02/2023, 01:46, @gisvlasta. - 1.0.1: Added [XmlInclude]s.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.DataQuality;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(MI_GCPCollection_Type))]
  [Serializable]
  [XmlType("AbstractMI_GeolocationInformation", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("AbstractMI_GeolocationInformation", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("AbstractMI_GeolocationInformation")]
  public class AbstractMI_GeolocationInformation_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractMI_GeolocationInformation_Type"/>
    /// </summary>
    public AbstractMI_GeolocationInformation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _qualityInfo = default; // new List<DQ_DataQuality_PropertyType>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<DQ_DataQuality_PropertyType> _qualityInfo;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("qualityInfo", Order = 0)]
    [JsonProperty("qualityInfo", Order = 0)]
    public List<DQ_DataQuality_PropertyType> QualityInfo {
      get {
        return _qualityInfo;
      }
      set {
        if (_qualityInfo == value) {
          return;
        }
        if (_qualityInfo == null || _qualityInfo.Equals(value) != true) {
          _qualityInfo = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
