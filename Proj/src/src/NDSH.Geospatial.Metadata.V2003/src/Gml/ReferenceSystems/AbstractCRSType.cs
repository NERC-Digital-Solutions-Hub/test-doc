
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/referenceSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="AbstractCRS" type="gml:AbstractCRSType" abstract="true" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>
//       gml:AbstractCRS specifies a coordinate reference system which is usually single but may be compound.
//       This abstract complex type shall not be used, extended, or restricted, in a GML Application Schema,
//       to define a concrete subtype with a meaning equivalent to a concrete subtype specified in this document.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="AbstractCRSType" abstract="true">
//   <complexContent>
//     <extension base="gml:IdentifiedObjectType">
//       <sequence>
//         <element ref="gml:domainOfValidity" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:scope" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="domainOfValidity">
//   <annotation>
//     <documentation>
//       The gml:domainOfValidity property implements an association role to an EX_Extent object
//       as encoded in ISO/TS 19139, either referencing or containing the definition of that extent.
//     </documentation>
//   </annotation>
//   <complexType>
//     <sequence minOccurs="0">
//       <element ref="gmd:EX_Extent"/>
//     </sequence>
//     <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   </complexType>
// </element>
// <element name="scope" type="string">
//   <annotation>
//     <documentation>
//       The gml:scope property provides a description of the usage, or limitations of usage,
//       for which this CRS-related object is valid. If unknown, enter "not known".
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems {

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(CrsAlt_Type))] // GMX
  //[XmlInclude(typeof(ML_CompoundCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_DerivedCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_EngineeringCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_GeodeticCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_ImageCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_ProjectedCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_TemporalCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_VerticalCRS_Type))] // GMX
  //[XmlInclude(typeof(GeocentricCRSType))]
  //[XmlInclude(typeof(TemporalCRSType))]
  //[XmlInclude(typeof(ImageCRSType))]
  //[XmlInclude(typeof(EngineeringCRSType))]
  //[XmlInclude(typeof(VerticalCRSType))]
  //[XmlInclude(typeof(CompoundCRSType))]
  //[XmlInclude(typeof(GeographicCRSType))]
  //[XmlInclude(typeof(GeodeticCRSType))]
  //[XmlInclude(typeof(AbstractGeneralDerivedCRSType))]
  //[XmlInclude(typeof(DerivedCRSType))]
  //[XmlInclude(typeof(ProjectedCRSType))]
  [Serializable]
  [XmlType("AbstractCRSType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractCRSType")]
  public abstract class AbstractCRSType : IdentifiedObjectType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractCRSType"/>.
    /// </summary>
    public AbstractCRSType() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gml", "http://www.opengis.net/gml");

      _domainOfValidity = default; //  new List<domainOfValidity>();
      _scope = default; //  new List<string>();

    }

    #endregion

    #region Public Fields

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlNamespaceDeclarations()]
    //public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<DomainOfValidity> _domainOfValidity;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("domainOfValidity", Order = 0)]
    [JsonProperty("domainOfValidity", Order = 0)]
    public List<DomainOfValidity> DomainOfValidity {
      get => _domainOfValidity;
      set {
        if (_domainOfValidity == value) {
          return;
        }
        if (_domainOfValidity == null || !_domainOfValidity.Equals(value)) {
          _domainOfValidity = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _scope;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("scope", Order = 1)]
    [JsonProperty("scope", Order = 1)]
    // WARNING: This property is marked as string in 
    public List<string> Scope {
      get => _scope;
      set {
        if (_scope == value) {
          return;
        }
        if (_scope == null || !_scope.Equals(value)) {
          _scope = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
