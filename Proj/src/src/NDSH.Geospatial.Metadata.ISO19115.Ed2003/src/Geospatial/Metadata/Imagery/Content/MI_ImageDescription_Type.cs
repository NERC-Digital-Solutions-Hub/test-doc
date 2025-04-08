
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 11:40, @gisvlasta.
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
// <xs:complexType name="MI_ImageDescription_Type">
//   <xs:annotation>
//     <xs:documentation>Description: information about the content of an image, including the description of specific range elements - shortName: ICovDesc</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:MD_ImageDescription_Type">
//       <xs:sequence>
//         <xs:element name="rangeElementDescription" type="gmi:MI_RangeElementDescription_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_ImageDescription" type="gmi:MI_ImageDescription_Type" substitutionGroup="gmd:MD_ImageDescription"/>
// <xs:complexType name="MI_ImageDescription_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_ImageDescription" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>

// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.Content;
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
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_ImageDescription", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_ImageDescription", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_ImageDescription")]
  public class MI_ImageDescription_Type : MD_ImageDescription_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_ImageDescription_Type"/>
    /// </summary>
    public MI_ImageDescription_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _rangeElementDescription = default; // new List<MI_RangeElementDescription_Type>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public new XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<MI_RangeElementDescription_Type> _rangeElementDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("rangeElementDescription", Order = 0)]
    [JsonProperty("rangeElementDescription", Order = 0)]
    public List<MI_RangeElementDescription_Type> RangeElementDescription {
      get {
        return _rangeElementDescription;
      }
      set => SetProperty(ref _rangeElementDescription, value);
    }


    #endregion

  }

}
