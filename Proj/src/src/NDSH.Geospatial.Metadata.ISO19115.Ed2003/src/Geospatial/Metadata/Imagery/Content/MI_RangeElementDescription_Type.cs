
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 17:58, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmi/contentInformation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MI_RangeElementDescription_Type">
//   <xs:annotation>
//     <xs:documentation>Description: description of specific range elements - shortName: RgEltDesc</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="name" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="definition" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="rangeElement" type="gco:Record_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_RangeElementDescription" type="gmi:MI_RangeElementDescription_Type"/>
// <xs:complexType name="MI_RangeElementDescription_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_RangeElementDescription" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Implementation.Records;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Imagery.Content {

  /// <summary>
  /// Description of specific range elements.
  /// </summary>
  /// <remarks>ShortName: RgEltDesc</remarks>
  [Serializable]
  [XmlType("MI_RangeElementDescription", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_RangeElementDescription", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_RangeElementDescription")]
  public class MI_RangeElementDescription_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_RangeElementDescription_Type"/>
    /// </summary>
    public MI_RangeElementDescription_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _name = default; // new CharacterString();
      _definition = default; // new CharacterString();
      _rangeElement = default; // new List<Record_PropertyType>();

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

    private CharacterString _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString Name {
      get {
        return _name;
      }
      set => SetProperty(ref _name, value);
    }

    private CharacterString _definition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("definition", Order = 1)]
    [JsonProperty("definition", Order = 1)]
    public CharacterString Definition {
      get {
        return _definition;
      }
      set => SetProperty(ref _definition, value);
    }

    private List<Record_PropertyType> _rangeElement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("rangeElement", Order = 2)]
    [JsonProperty("rangeElement", Order = 2)]
    public List<Record_PropertyType> RangeElement {
      get {
        return _rangeElement;
      }
      set => SetProperty(ref _rangeElement, value);
    }

    #endregion

  }

}
