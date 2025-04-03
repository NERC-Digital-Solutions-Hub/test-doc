
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
// <complexType name="AbstractTopoPrimitiveType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractTopologyType">
//       <sequence>
//         <element ref="gml:isolated" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:container" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="AbstractTopoPrimitive" type="gml:AbstractTopoPrimitiveType" abstract="true" substitutionGroup="gml:AbstractTopology">
//   <annotation>
//     <documentation>
//       gml:AbstractTopoPrimitive acts as the base type for all topological primitives.
//       Topology primitives are the atomic (smallest possible) units of a topology complex. 
//       Each topology primitive may contain references to other topology primitives of
//       codimension 2 or more (gml:isolated). Conversely, nodes may have faces as containers
//       and nodes and edges may have solids as containers (gml:container).
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

  //[XmlInclude(typeof(TopoSolidType))]
  //[XmlInclude(typeof(NodeType))]
  //[XmlInclude(typeof(EdgeType))]
  //[XmlInclude(typeof(FaceType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTopoPrimitiveType")]
  public abstract class AbstractTopoPrimitiveType : AbstractTopologyType {

    #region Private fields
    private List<IsolatedPropertyType> _isolated;
    private ContainerPropertyType _container;
    #endregion

    /// <summary>
    /// AbstractTopoPrimitiveType class constructor
    /// </summary>
    public AbstractTopoPrimitiveType() {
      _container = new ContainerPropertyType();
      _isolated = new List<IsolatedPropertyType>();
    }

    [XmlElement("isolated", Order = 0)]
    [JsonProperty("isolated", Order = 0)]
    public List<IsolatedPropertyType> Isolated {
      get {
        return _isolated;
      }
      set {
        if (_isolated == value) {
          return;
        }
        if (_isolated == null || _isolated.Equals(value) != true) {
          _isolated = value;
          OnPropertyChanged("Isolated");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("container", Order = 1)]
    public ContainerPropertyType Container {
      get {
        return _container;
      }
      set {
        if (_container == value) {
          return;
        }
        if (_container == null || _container.Equals(value) != true) {
          _container = value;
          OnPropertyChanged("Container");
        }
      }
    }

  }

}
