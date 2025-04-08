
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:11, @gisvlasta.
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
  [XmlType("DQ_DataQuality_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_DataQuality_PropertyType")]
  public class DQ_DataQuality_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_DataQuality_PropertyType"/>.
    /// </summary>
    public DQ_DataQuality_PropertyType() {
      _dq_DataQuality  = default; //  new DQ_DataQuality_Type();
    }

    #endregion

    #region Public Properties
    
    private DQ_DataQuality_Type _dq_DataQuality;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_DataQuality", Order = 0)]
    [JsonProperty("DQ_DataQuality", Order = 0)]
    public DQ_DataQuality_Type DQ_DataQuality {
      get {
        return _dq_DataQuality;
      }
      set {
        if (_dq_DataQuality == value) {
          return;
        }
        if (_dq_DataQuality == null || _dq_DataQuality.Equals(value) != true) {
          _dq_DataQuality = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}