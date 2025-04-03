
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:35, @gisvlasta.
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Acquisition {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_AcquisitionInformation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_AcquisitionInformation_PropertyType")]
  public class MI_AcquisitionInformation_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_AcquisitionInformation_PropertyType"/>.
    /// </summary>
    public MI_AcquisitionInformation_PropertyType() {
      _mi_AcquisitionInformation = default; // new MI_AcquisitionInformation_Type();
    }

    #endregion

    #region Public Properties

    private MI_AcquisitionInformation_Type _mi_AcquisitionInformation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_AcquisitionInformation", Order = 0)]
    [JsonProperty("MI_AcquisitionInformation", Order = 0)]
    public MI_AcquisitionInformation_Type MI_AcquisitionInformation {
      get {
        return _mi_AcquisitionInformation;
      }
      set {
        if (_mi_AcquisitionInformation == value) {
          return;
        }
        if (_mi_AcquisitionInformation == null || _mi_AcquisitionInformation.Equals(value) != true) {
          _mi_AcquisitionInformation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}