
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
// XSD               : /2005/gml/topology.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="TopoSolidType">
//   <complexContent>
//     <extension base="gml:AbstractTopoPrimitiveType">
//       <sequence>
//         <element ref="gml:directedFace" maxOccurs="unbounded"/>
//         <element ref="gml:solidProperty" minOccurs="0"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="TopoSolid" type="gml:TopoSolidType" substitutionGroup="gml:AbstractTopoPrimitive">
//   <annotation>
//     <documentation>
//       gml:TopoSolid represents the 3-dimensional topology primitive. 
//       The topological boundary of a solid (gml:directedFace) consists of a set of directed faces.
//       A solid may optionally be realised by a 3-dimensional geometric primitive (gml:solidProperty).
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Geometry.Primitives;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoSolidType")]
  public class TopoSolidType : AbstractTopoPrimitiveType {

    #region Private fields
    private List<DirectedFacePropertyType> _directedFace;
    private SolidPropertyType _solidProperty;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// TopoSolidType class constructor
    /// </summary>
    public TopoSolidType() {
      _solidProperty = new SolidPropertyType();
      _directedFace = new List<DirectedFacePropertyType>();
    }

    [XmlElement("directedFace", Order = 0)]
    [JsonProperty("directedFace", Order = 0)]
    public List<DirectedFacePropertyType> DirectedFace {
      get {
        return _directedFace;
      }
      set {
        if (_directedFace == value) {
          return;
        }
        if (_directedFace == null || _directedFace.Equals(value) != true) {
          _directedFace = value;
          OnPropertyChanged("DirectedFace");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("solidProperty", Order = 1)]
    public SolidPropertyType SolidProperty {
      get {
        return _solidProperty;
      }
      set {
        if (_solidProperty == value) {
          return;
        }
        if (_solidProperty == null || _solidProperty.Equals(value) != true) {
          _solidProperty = value;
          OnPropertyChanged("SolidProperty");
        }
      }
    }

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
