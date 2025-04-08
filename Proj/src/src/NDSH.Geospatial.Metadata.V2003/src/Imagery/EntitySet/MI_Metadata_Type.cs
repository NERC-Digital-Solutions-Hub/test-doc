
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:29, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.EntitySet;
using NDSH.Geospatial.Metadata.V2003.Imagery.Acquisition;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.EntitySet {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_Metadata", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Metadata", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Metadata")]
  public class MI_Metadata_Type : MD_Metadata_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Metadata_Type"/>
    /// </summary>
    public MI_Metadata_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _acquisitionInformation = default; // new List<MI_AcquisitionInformation_PropertyType>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public new XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<MI_AcquisitionInformation_PropertyType> _acquisitionInformation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("acquisitionInformation", Order = 0)]
    [JsonProperty("acquisitionInformation", Order = 0)]
    public List<MI_AcquisitionInformation_PropertyType> AcquisitionInformation {
      get {
        return _acquisitionInformation;
      }
      set {
        if (_acquisitionInformation == value) {
          return;
        }
        if (_acquisitionInformation == null || _acquisitionInformation.Equals(value) != true) {
          _acquisitionInformation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
