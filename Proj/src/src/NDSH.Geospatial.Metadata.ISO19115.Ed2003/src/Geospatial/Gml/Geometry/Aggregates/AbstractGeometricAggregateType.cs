
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/geometryAggregates.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AbstractGeometricAggregateType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractGeometryType">
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="AbstractGeometricAggregate" type="gml:AbstractGeometricAggregateType" abstract="true" substitutionGroup="gml:AbstractGeometry">
//   <annotation>
//     <documentation>gml:AbstractGeometricAggregate is the abstract head of the substitution group for all geometric aggregates.</documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Aggregates {


  //[XmlInclude(typeof(MultiSolidType))]
  //[XmlInclude(typeof(MultiSurfaceType))]
  //[XmlInclude(typeof(MultiCurveType))]
  //[XmlInclude(typeof(MultiPointType))]
  //[XmlInclude(typeof(MultiGeometryType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeometricAggregateType")]
  public abstract class AbstractGeometricAggregateType : AbstractGeometryType {
    #region Private fields
    private AggregationType _aggregationType;
    #endregion

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("AggregationType");
        }
      }
    }
  }
}
