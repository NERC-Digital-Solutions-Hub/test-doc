
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/01/2023, 01:57, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmi/dataQualityInformation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="LE_Algorithm_Type">
//   <xs:annotation>
//     <xs:documentation>Description: Details of the methodology by which geographic information was derived from the instrument readings - FGDC: Algorithm_Information - shortName: Algorithm</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="citation" type="gmd:CI_Citation_PropertyType"/>
//         <xs:element name="description" type="gco:CharacterString_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="LE_Algorithm" type="gmi:LE_Algorithm_Type"/>
// <xs:complexType name="LE_Algorithm_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:LE_Algorithm" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Imagery.DataQuality {

  /// <summary>
  /// Details of the methodology by which geographic information was derived from the instrument readings.
  /// </summary>
  /// <remarks>
  /// <para>FGDC: Algorithm_Information</para>
  /// <para>ShortName: Algorithm</para>
  /// </remarks>
  [Serializable]
  [XmlType("LE_Algorithm", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("LE_Algorithm", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("LE_Algorithm")]
  public class LE_Algorithm_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_Algorithm_Type"/>
    /// </summary>
    public LE_Algorithm_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _citation = default; // new CI_Citation_Type();
      _description = default; // new CharacterString();

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

    private CI_Citation_Type _citation;

    /// <summary>
    /// Information identifying the algorithm and version or date.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("citation", Order = 0)]
    [JsonProperty("citation", Order = 0)]
    public CI_Citation_Type Citation {
      get {
        return _citation;
      }
      set => SetProperty(ref _citation, value);
    }

    private CharacterString _description;

    /// <summary>
    /// Information describing the algorithm used to generate the data.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("description", Order = 1)]
    [JsonProperty("description", Order = 1)]
    public CharacterString Description {
      get {
        return _description;
      }
      set => SetProperty(ref _description, value);
    }

    #endregion

  }

}
