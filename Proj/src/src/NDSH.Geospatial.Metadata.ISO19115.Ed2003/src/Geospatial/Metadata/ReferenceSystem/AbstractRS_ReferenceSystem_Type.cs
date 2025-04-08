
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 23:30, @gisvlasta.
// Updated by        : 09/01/2023, 20:48, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/referenceSystem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="AbstractRS_ReferenceSystem_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="name" type="gmd:RS_Identifier_PropertyType"/>
//         <xs:element name="domainOfValidity" type="gmd:EX_Extent_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractRS_ReferenceSystem" type="gmd:AbstractRS_ReferenceSystem_Type" abstract="true"/>
// <xs:complexType name="RS_ReferenceSystem_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:AbstractRS_ReferenceSystem"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.Extent;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.ReferenceSystem {

  /// <summary>
  /// Description of the spatial and temporal reference systems used in the dataset.
  /// </summary>
  [Serializable]
  [XmlType("AbstractRS_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("AbstractRS_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractRS_ReferenceSystem")]
  public abstract class AbstractRS_ReferenceSystem_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractRS_ReferenceSystem_Type"/>.
    /// </summary>
    public AbstractRS_ReferenceSystem_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _name = default; //  new RS_Identifier_Type();
      _domainOfValidity = default; //  new List<EX_Extent_Type>();

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

    private RS_Identifier_Type _name;

    /// <summary>
    /// Name of the reference system.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public RS_Identifier_Type Name {
      get {
        return _name;
      }
      set => SetProperty(ref _name, value);
    }

    private List<EX_Extent_Type> _domainOfValidity;

    /// <summary>
    /// Range which is valid for the reference system.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    [XmlElement("domainOfValidity", Order = 1)]
    [JsonProperty("domainOfValidity", Order = 1)]
    public List<EX_Extent_Type> DomainOfValidity {
      get {
        return _domainOfValidity;
      }
      set => SetProperty(ref _domainOfValidity, value);
    }

    #endregion

  }

}
