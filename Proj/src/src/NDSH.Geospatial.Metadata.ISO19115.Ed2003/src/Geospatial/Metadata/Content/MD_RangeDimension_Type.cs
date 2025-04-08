
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/content.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_RangeDimension_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="sequenceIdentifier" type="gco:MemberName_PropertyType" minOccurs="0"/>
//         <xs:element name="descriptor" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_RangeDimension" type="gmd:MD_RangeDimension_Type"/>
// <xs:complexType name="MD_RangeDimension_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_RangeDimension"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Content {

  /// <summary>
  /// Set of adjacent wavelengths in the electro-magnetic spectrum
  /// with a common characteristic, such as the visible band.
  /// </summary>
  //[XmlInclude(typeof(MI_Band_Type))]
  //[XmlInclude(typeof(MD_Band_Type))]
  [Serializable]
  //[XmlType("MD_RangeDimension", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_RangeDimension", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_RangeDimension")]
  public class MD_RangeDimension_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_RangeDimension_Type"/>.
    /// </summary>
    public MD_RangeDimension_Type() {
      _sequenceIdentifier = default; //  new MemberName_Type();
      _descriptor = default; //  new CharacterString();
    }

    #endregion

    #region Public Properties

    private MemberName_Type? _sequenceIdentifier;

    /// <summary>
    /// Number that uniquely identifies instances of bands of wavelengths on which a sensor operates.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("sequenceIdentifier", Order = 0)]
    [JsonProperty("sequenceIdentifier", Order = 0)]
    public MemberName_Type? SequenceIdentifier {
      get => _sequenceIdentifier;
      set => SetProperty(ref _sequenceIdentifier, value);
    }

    private CharacterString? _descriptor;

    /// <summary>
    /// Description of the range of a cell measurement value.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("descriptor", Order = 1)]
    [JsonProperty("descriptor", Order = 1)]
    public CharacterString? Descriptor {
      get => _descriptor;
      set => SetProperty(ref _descriptor, value);
    }

    #endregion

  }

}
