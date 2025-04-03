
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 04:48, @gisvlasta.
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
  [XmlType("DS_Series_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DS_Series_PropertyType")]
  public class DS_Series_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DS_Series_PropertyType"/>.
    /// </summary>
    public DS_Series_PropertyType() {
      _ds_Series  = default; //  new DS_Series_Type();
    }

    #endregion

    #region Public Properties

    private DS_Series_Type _ds_Series;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DS_Series", Order = 0)]
    [JsonProperty("DS_Series", Order = 0)]
    public DS_Series_Type DS_Series {
      get {
        return _ds_Series;
      }
      set {
        if (_ds_Series == value) {
          return;
        }
        if (_ds_Series == null || _ds_Series.Equals(value) != true) {
          _ds_Series = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}