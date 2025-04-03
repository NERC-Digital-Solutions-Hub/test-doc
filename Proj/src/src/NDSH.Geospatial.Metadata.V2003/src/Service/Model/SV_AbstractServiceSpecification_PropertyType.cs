
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 11/01/2023, 02:01, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ApplicationSchema;
using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_AbstractServiceSpecification_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_AbstractServiceSpecification_PropertyType")]
  public class SV_AbstractServiceSpecification_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractSV_AbstractServiceSpecification_Type _sv_AbstractServiceSpecification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractSV_AbstractServiceSpecification", Order = 0)]
    [JsonProperty("AbstractSV_AbstractServiceSpecification", Order = 0)]
    public AbstractSV_AbstractServiceSpecification_Type AbstractSV_AbstractServiceSpecification {
      get {
        return _sv_AbstractServiceSpecification;
      }
      set {
        if (_sv_AbstractServiceSpecification == value) {
          return;
        }
        if (_sv_AbstractServiceSpecification == null || _sv_AbstractServiceSpecification.Equals(value) != true) {
          _sv_AbstractServiceSpecification = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
