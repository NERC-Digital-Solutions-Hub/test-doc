
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 03:01, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Boolean", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("Boolean")]
  public class Boolean : NilReasonModel { // TODO: Name 'CodeList_PropertyType' does not make sense here.

    #region Public Properties

    private bool _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText] // TODO: Add DataType = here???
    [JsonProperty("Value")]
    public bool Value {
      get {
        return _value;
      }
      set {
        if (_value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
