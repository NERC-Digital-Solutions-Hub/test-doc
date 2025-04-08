
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 08/01/2023, 02:18, @gisvlasta.
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
// <xs:complexType name="MimeFileType_Type">
//   <xs:simpleContent>
//     <xs:extension base="xs:string">
//       <xs:attribute name="type" type="xs:string" use="required"/>
//   </xs:extension>
//   </xs:simpleContent>
// </xs:complexType>
// <xs:element name="MimeFileType" type="gmx:MimeFileType_Type" substitutionGroup="gco:CharacterString"/>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Extended {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MimeFileType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("MimeFileType", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("MimeFileType")]
  public class MimeFileType_Type : ObservableModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MimeFileType_Type"/>.
    /// </summary>
    public MimeFileType_Type() {

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

    private string _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("type")]
    [JsonProperty("type")]
    public string Type {
      get {
        return _type;
      }
      set {
        if (_type == value) {
          return;
        }
        if (_type == null || _type.Equals(value) != true) {
          _type = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText]
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
