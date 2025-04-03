
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:21, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          :
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmi/acquisitionInformation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MI_Instrument_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="citation" type="gmd:CI_Citation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="identifier" type="gmd:MD_Identifier_PropertyType"/>
//         <xs:element name="type" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="description" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="mountedOn" type="gmi:MI_Platform_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_Instrument" type="gmi:MI_Instrument_Type"/>
// <xs:complexType name="MI_Instrument_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_Instrument" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;

using NDSH.Geospatial.Metadata.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Imagery.Acquisition {

  /// <summary>
  /// Designations for the measuring instruments.
  /// </summary>
  /// <remarks>
  /// <para>FGDC: Platform_and_Instrument_Identification</para>
  /// <para>ShortName: PltfrmInstId</para>
  /// </remarks>
  [XmlType("MI_Instrument", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Instrument", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Instrument")]
  public class MI_Instrument_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Instrument_Type"/>.
    /// </summary>
    public MI_Instrument_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _citation = default; // new CI_Citation_Type();
      _identifier = default; // new MD_Identifier_Type();
      _type = default; // new CharacterString();
      _description = default; // new CharacterString();
      _mountedOn = default; // new MI_Platform_Type();

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

    private List<CI_Citation_Type> _citation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("citation", Order = 0)]
    [JsonProperty("citation", Order = 0)]
    public List<CI_Citation_Type> Citation {
      get {
        return _citation;
      }
      set => SetProperty(ref _citation, value);
    }

    private MD_Identifier_Type _identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 1)]
    [JsonProperty("identifier", Order = 1)]
    public MD_Identifier_Type Identifier {
      get {
        return _identifier;
      }
      set => SetProperty(ref _identifier, value);
    }

    private CharacterString _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("type", Order = 2)]
    [JsonProperty("type", Order = 2)]
    public CharacterString Type {
      get {
        return _type;
      }
      set => SetProperty(ref _type, value);
    }

    private CharacterString _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 3)]
    [JsonProperty("description", Order = 3)]
    public CharacterString Description {
      get {
        return _description;
      }
      set => SetProperty(ref _description, value);
    }

    private MI_Platform_Type _mountedOn;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("mountedOn", Order = 4)]
    [JsonProperty("mountedOn", Order = 4)]
    public MI_Platform_Type MountedOn {
      get {
        return _mountedOn;
      }
      set => SetProperty(ref _mountedOn, value);
    }

    #endregion

  }

}
