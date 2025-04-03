
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 04:33, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Application {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DS_DataSet_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DS_DataSet_PropertyType")]
  public class DS_DataSet_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DS_DataSet_PropertyType"/>.
    /// </summary>
    public DS_DataSet_PropertyType() {
      _ds_DataSet  = default; //  new DS_DataSet_Type();
    }

    #endregion

    #region Public Properties

    private DS_DataSet_Type _ds_DataSet;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DS_DataSet", Order = 0)]
    [JsonProperty("DS_DataSet", Order = 0)]
    public DS_DataSet_Type DS_DataSet {
      get {
        return _ds_DataSet;
      }
      set {
        if (_ds_DataSet == value) {
          return;
        }
        if (_ds_DataSet == null || _ds_DataSet.Equals(value) != true) {
          _ds_DataSet = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}