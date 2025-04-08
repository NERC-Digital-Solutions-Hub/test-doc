
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
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
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Primitive.Numerics {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false, ElementName = "value")]
  [JsonObject("Value")]
  public class Value : Model {

    #region Public Fields
    
    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private string _item;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Decimal", Order = 0)]
    [XmlElement("Integer", Order = 0)]
    [XmlElement("Number", Order = 0)]
    [XmlElement("Real", Order = 0)]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged();
        }
      }
    }

    // TODO: Change name ItemChoiceType

    private ValueChoiceType _itemElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    [XmlIgnore]
    public ValueChoiceType ItemElementName {
      get {
        return _itemElementName;
      }
      set {
        if (_itemElementName.Equals(value) != true) {
          _itemElementName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
