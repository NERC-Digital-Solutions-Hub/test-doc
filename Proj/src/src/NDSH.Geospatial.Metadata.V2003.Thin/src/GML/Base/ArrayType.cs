
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 04:49, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Base {

  /// <summary>
  /// 
  /// </summary>
  [Obsolete()]
  [Serializable]
  [XmlType("ArrayType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ArrayType")]
  public class ArrayType : AbstractGMLType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ArrayType"/>.
    /// </summary>
    public ArrayType() {
      _members  = default; //  new ArrayAssociationType();
    }

    #endregion

    #region Public Properties

    private ArrayAssociationType _members;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("members", Order = 0)]
    [JsonProperty("members", Order = 0)]
    public ArrayAssociationType Members {
      get {
        return _members;
      }
      set {
        if (_members == value) {
          return;
        }
        if (_members == null || _members.Equals(value) != true) {
          _members = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}