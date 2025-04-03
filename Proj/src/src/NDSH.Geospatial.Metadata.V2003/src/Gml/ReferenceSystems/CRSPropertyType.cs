
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 04/02/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/referenceSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="CRSPropertyType">
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractCRS"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// <element name="crsRef" type="gml:CRSPropertyType">
//   <annotation>
//     <documentation>
//       gml:crsRef is an association role either referencing or containing the definition of a CRS.
//       This property element has been deprecated.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems {

  /// <summary>
  /// Defines a property type for association roles to a CRS abstract coordinate reference system,
  /// either referencing or containing the definition of that CRS.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CRSPropertyType")]
  // WARNING: This class used to be part of the NDSH.Geospatial.Metadata.V2003 project and had the name 'SC_CRS_PropertyType'
  // WARNING: Pay attention that the XML serialization may need to be: CRSPropertyType > SC_CRS
  public class CRSPropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractCRSType _abstractCRS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractCRS", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractCRS", Order = 0)]
    public AbstractCRSType AbstractCRS {
      get => _abstractCRS;
      set {
        if (_abstractCRS == value) {
          return;
        }
        if (_abstractCRS == null || !_abstractCRS.Equals(value)) {
          _abstractCRS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
