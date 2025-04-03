
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
// <complexType name="FaceType">
//   <complexContent>
//     <extension base="gml:AbstractTopoPrimitiveType">
//       <sequence>
//         <element ref="gml:directedEdge" maxOccurs="unbounded"/>
//         <element ref="gml:directedTopoSolid" minOccurs="0" maxOccurs="2"/>
//         <element ref="gml:surfaceProperty" minOccurs="0"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="Face" type="gml:FaceType" substitutionGroup="gml:AbstractTopoPrimitive">
//   <annotation>
//     <documentation>
//       gml:Face represents the 2-dimensional topology primitive.
//       The topological boundary of a face (gml:directedEdge) consists of a sequence
//       of directed edges. If provided, the aggregationType attribute shall have the value “sequence”.
//       The optional coboundary of a face (gml:directedTopoSolid) is a pair of directed solids
//       which are bounded by this face. A positively directed solid corresponds to a solid which lies
//       in the direction of the negatively directed normal to the face in any geometric realisation. 
//       A face may optionally be realised by a 2-dimensional geometric primitive (gml:surfaceProperty).
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Geometry.Basic2D;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("FaceType")]
  public class FaceType : AbstractTopoPrimitiveType {

    #region Private fields
    private List<DirectedEdgePropertyType> _directedEdge;
    private List<DirectedTopoSolidPropertyType> _directedTopoSolid;
    private SurfacePropertyType _surfaceProperty;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// FaceType class constructor
    /// </summary>
    public FaceType() {
      _surfaceProperty = new SurfacePropertyType();
      _directedTopoSolid = new List<DirectedTopoSolidPropertyType>();
      _directedEdge = new List<DirectedEdgePropertyType>();
    }

    [XmlElement("directedEdge", Order = 0)]
    [JsonProperty("directedEdge", Order = 0)]
    public List<DirectedEdgePropertyType> DirectedEdge {
      get {
        return _directedEdge;
      }
      set {
        if (_directedEdge == value) {
          return;
        }
        if (_directedEdge == null || _directedEdge.Equals(value) != true) {
          _directedEdge = value;
          OnPropertyChanged("DirectedEdge");
        }
      }
    }

    [XmlElement("directedTopoSolid", Order = 1)]
    [JsonProperty("directedTopoSolid", Order = 1)]
    public List<DirectedTopoSolidPropertyType> DirectedTopoSolid {
      get {
        return _directedTopoSolid;
      }
      set {
        if (_directedTopoSolid == value) {
          return;
        }
        if (_directedTopoSolid == null || _directedTopoSolid.Equals(value) != true) {
          _directedTopoSolid = value;
          OnPropertyChanged("DirectedTopoSolid");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("surfaceProperty", Order = 2)]
    public SurfacePropertyType SurfaceProperty {
      get {
        return _surfaceProperty;
      }
      set {
        if (_surfaceProperty == value) {
          return;
        }
        if (_surfaceProperty == null || _surfaceProperty.Equals(value) != true) {
          _surfaceProperty = value;
          OnPropertyChanged("SurfaceProperty");
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
