
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 08/01/2023, 02:06, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gmx/extendedTypes.xsd
// --------------------------------------------------------------------------------
// <xs:complexType name="FileName_Type">
//   <xs:simpleContent>
//     <xs:extension base="xs:string">
//       <xs:attribute name="src" type="xs:anyURI"/>
//   </xs:extension>
//   </xs:simpleContent>
// </xs:complexType>
// <xs:element name="FileName" type="gmx:FileName_Type" substitutionGroup="gco:CharacterString"/>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Extended {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("FileName", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("FileName", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("FileName")]
  public class FileName_Type : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="FileName_Type"/>.
    /// </summary>
    public FileName_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private string _src;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("src", DataType = "anyURI")]
    [JsonProperty("src")]
    public string Src {
      get {
        return _src;
      }
      set {
        if (_src == value) {
          return;
        }
        if (_src == null || _src.Equals(value) != true) {
          _src = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText()]
    public string Value {
      get {
        return _value;
      }
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || _value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
