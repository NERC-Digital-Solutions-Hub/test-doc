
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 23:39, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/referenceSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
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
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Coordinate.ReferenceSystems;
using NDSH.Geospatial.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS.Multilingual;
using NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems;
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
  //[XmlType("AbstractCRSType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractCRSType")]
  public abstract class AbstractCRSType : IdentifiedObjectType { // TODO: Are you sure that it needs to be here and not in GML ???

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
      get {
        return _domainOfValidity;
      }
      set => SetProperty(ref _domainOfValidity, value);
    }

    private List<string> _scope;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("scope", Order = 1)]
    [JsonProperty("scope", Order = 1)]
    public List<string> Scope {
      get {
        return _scope;
      }
      set => SetProperty(ref _scope, value);
    }

    #endregion

  }

}
