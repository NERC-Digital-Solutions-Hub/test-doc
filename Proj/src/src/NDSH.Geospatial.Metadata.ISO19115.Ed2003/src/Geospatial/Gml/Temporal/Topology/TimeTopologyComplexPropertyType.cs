
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 03:43, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/temporalTopology.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="TimeTopologyComplex" type="gml:TimeTopologyComplexType" substitutionGroup="gml:AbstractTimeComplex">
//   <annotation>
//     <documentation>
//       A temporal topology complex shall be the connected acyclic directed graph composed of temporal topological primitives,
//       i.e. time nodes and time edges. Because a time edge may not exist without two time nodes on its boundaries, static
//       features have time edges from a temporal topology complex as the values of their temporal properties, regardless of explicit declarations.
//       A temporal topology complex expresses a linear or a non-linear graph. A temporal linear graph, composed of a sequence
//       of time edges, provides a lineage described only by “substitution” of feature instances or feature element values.
//       A time node as the start or the end of the graph connects with at least one time edge. A time node other than the
//       start and the end shall connect to at least two time edges: one of starting from the node, and another ending at the node.
//       A temporal topological complex is a set of connected temporal topological primitives. The member primtives are indicated,
//       either by reference or by value, using the primitive property.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeTopologyComplexType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractTimeComplexType">
//       <sequence>
//         <element name="primitive" type="gml:TimeTopologyPrimitivePropertyType" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimeTopologyComplexPropertyType">
//   <annotation>
//     <documentation>gml:TimeTopologyComplexPropertyType provides for associating a gml:TimeTopologyComplex with an object.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimeTopologyComplex"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Temporal.Topology {


  /// <summary>
  /// gml:TimeTopologyComplexPropertyType provides for associating a gml:TimeTopologyComplex with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeTopologyComplexPropertyType")]
  public class TimeTopologyComplexPropertyType : ObservableModel {
    #region Private fields
    private TimeTopologyComplexType _timeTopologyComplex;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// TimeTopologyComplexPropertyType class constructor
    /// </summary>
    public TimeTopologyComplexPropertyType() {
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeTopologyComplex", Order = 0)]
    public TimeTopologyComplexType TimeTopologyComplex {
      get {
        return _timeTopologyComplex;
      }
      set {
        if (_timeTopologyComplex == value) {
          return;
        }
        if (_timeTopologyComplex == null || _timeTopologyComplex.Equals(value) != true) {
          _timeTopologyComplex = value;
          OnPropertyChanged("TimeTopologyComplex");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged("NilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string RemoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged("RemoteSchema");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("Owns");
        }
      }
    }
  }

}
