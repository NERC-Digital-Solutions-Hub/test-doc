
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:34, @gisvlasta.
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
// <xs:complexType name="MI_PlatformPass_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="identifier" type="gmd:MD_Identifier_PropertyType"/>
//         <xs:element name="extent" type="gss:GM_Object_PropertyType" minOccurs="0"/>
//         <xs:element name="relatedEvent" type="gmi:MI_Event_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_PlatformPass" type="gmi:MI_PlatformPass_Type"/>
// <xs:complexType name="MI_PlatformPass_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_PlatformPass" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.ReferenceSystem;
using NDSH.Geospatial.Schema;
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
  /// Identification of collection coverage.
  /// </summary>
  /// <remarks>ShortName: PlatformPass</remarks>
  [XmlType("MI_PlatformPass", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_PlatformPass", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_PlatformPass")]
  public class MI_PlatformPass_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_PlatformPass_Type"/>.
    /// </summary>
    public MI_PlatformPass_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _identifier = default; // new MD_Identifier_Type();
      _extent = default; // new GM_Object_PropertyType();
      _relatedEvent = default; // new MI_Event_Type();

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

    private MD_Identifier_Type _identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 0)]
    [JsonProperty("identifier", Order = 0)]
    public MD_Identifier_Type Identifier {
      get {
        return _identifier;
      }
      set => SetProperty(ref _identifier, value);
    }

    private GM_Object_PropertyType _extent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("extent", Order = 1)]
    [JsonProperty("extent", Order = 1)]
    public GM_Object_PropertyType Extent {
      get {
        return _extent;
      }
      set => SetProperty(ref _extent, value);
    }

    private List<MI_Event_Type> _relatedEvent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("relatedEvent", Order = 2)]
    [JsonProperty("relatedEvent", Order = 2)]
    public List<MI_Event_Type> RelatedEvent {
      get {
        return _relatedEvent;
      }
      set => SetProperty(ref _relatedEvent, value);
    }

    #endregion
  }

}
