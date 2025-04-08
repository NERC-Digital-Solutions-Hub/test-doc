
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:32, @gisvlasta.
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
// <xs:complexType name="MI_Platform_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="citation" type="gmd:CI_Citation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="identifier" type="gmd:MD_Identifier_PropertyType"/>
//         <xs:element name="description" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="sponsor" type="gmd:CI_ResponsibleParty_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="instrument" type="gmi:MI_Instrument_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_Platform" type="gmi:MI_Platform_Type"/>
// <xs:complexType name="MI_Platform_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_Platform" minOccurs="0"/>
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
  /// Designations for the platform used to acquire the dataset.
  /// </summary>
  /// <remarks>ShortName: PltfrmId</remarks>
  [XmlType("MI_Platform", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Platform", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Platform")]
  public class MI_Platform_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Platform_Type"/>.
    /// </summary>
    public MI_Platform_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _citation = default; // new CI_Citation_Type();
      _identifier = default; // new MD_Identifier_Type();
      _description = default; // new CharacterString();
      _sponsor = default; // new CI_ResponsibleParty_Type();
      _instrument = default; // new MI_Instrument_Type();

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

    private CharacterString _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 2)]
    [JsonProperty("description", Order = 2)]
    public CharacterString Description {
      get {
        return _description;
      }
      set => SetProperty(ref _description, value);
    }

    private List<CI_ResponsibleParty_Type> _sponsor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sponsor", Order = 3)]
    [JsonProperty("sponsor", Order = 3)]
    public List<CI_ResponsibleParty_Type> Sponsor {
      get {
        return _sponsor;
      }
      set => SetProperty(ref _sponsor, value);
    }

    private List<MI_Instrument_Type> _instrument;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("instrument", Order = 4)]
    [JsonProperty("instrument", Order = 4)]
    public List<MI_Instrument_Type> Instrument {
      get {
        return _instrument;
      }
      set => SetProperty(ref _instrument, value);
    }

    #endregion

  }

}
