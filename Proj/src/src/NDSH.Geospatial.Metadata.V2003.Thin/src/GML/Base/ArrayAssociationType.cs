
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 04:56, @gisvlasta.
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
using System.ComponentModel;
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
  [XmlType("ArrayAssociationType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ArrayAssociationType")]
  public class ArrayAssociationType : Model, IOwnershipAttributeGroup { // TODO: Extract Interfaces or Abstract Classes.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ArrayAssociationType"/>.
    /// </summary>
    public ArrayAssociationType() {
      _abstractObject  = default; //  new List<object>();
      _owns  = default; //  false;
    }

    #endregion

    #region Public Properties

    private List<object> _abstractObject;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractObject", Order = 0)]
    [JsonProperty("AbstractObject", Order = 0)]
    public List<object> AbstractObject {
      get {
        return _abstractObject;
      }
      set {
        if (_abstractObject == value) {
          return;
        }
        if (_abstractObject == null || _abstractObject.Equals(value) != true) {
          _abstractObject = value;
          OnPropertyChanged();
        }
      }
    }

    private bool _owns;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("owns")]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}