
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:40, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_Result_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_Result_PropertyType")]
  public class DQ_Result_PropertyType : ObjectReference_PropertyType {
    
    #region Public Properties
    
    private AbstractDQ_Result_Type _abstractDQ_Result;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractDQ_Result", Order = 0)]
    [JsonProperty("AbstractDQ_Result", Order = 0)]
    public AbstractDQ_Result_Type AbstractDQ_Result {
      get {
        return _abstractDQ_Result;
      }
      set {
        if (_abstractDQ_Result == value) {
          return;
        }
        if (_abstractDQ_Result == null || _abstractDQ_Result.Equals(value) != true) {
          _abstractDQ_Result = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
