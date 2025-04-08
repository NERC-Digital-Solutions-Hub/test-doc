
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 01/02/2023, 19:19, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.ValueObjects {
  
  /// <summary>
  /// Category has an optional XML attribute codeSpace, whose value is a URI
  /// which identifies a dictionary, codelist or authority for the term.
  /// </summary>
  [Serializable]
  [XmlType("Category", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("Category")]
  public class Category : CodeType, INilReason {

    #region Public Properties

    private string _nilReason;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("nilReason")]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
