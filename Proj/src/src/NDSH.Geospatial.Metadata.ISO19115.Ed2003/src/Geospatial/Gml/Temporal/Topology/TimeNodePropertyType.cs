
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
// <element name="TimeNode" type="gml:TimeNodeType" substitutionGroup="gml:AbstractTimeTopologyPrimitive">
//   <annotation>
//     <documentation>
//       A time node is a zero-dimensional topological primitive that represents an identifiable node in time
//       (it is equivalent to a point in space). A node may act as the termination or initiation of any number
//       of time edges. A time node may be realised as a geometry, its position, whose value is a time instant.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeNodeType">
//   <complexContent>
//     <extension base="gml:AbstractTimeTopologyPrimitiveType">
//       <sequence>
//         <element name="previousEdge" type="gml:TimeEdgePropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <element name="nextEdge" type="gml:TimeEdgePropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <element name="position" type="gml:TimeInstantPropertyType" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimeNodePropertyType">
//   <annotation>
//     <documentation>gml:TimeNodePropertyType provides for associating a gml:TimeNode with an object</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimeNode"/>
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
  /// gml:TimeNodePropertyType provides for associating a gml:TimeNode with an object
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeNodePropertyType")]
  public class TimeNodePropertyType : ObservableModel {
    #region Private fields
    private TimeNodeType _timeNode;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// TimeNodePropertyType class constructor
    /// </summary>
    public TimeNodePropertyType() {
      _timeNode = default; // new TimeNodeType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeNode", Order = 0)]
    public TimeNodeType TimeNode {
      get {
        return _timeNode;
      }
      set {
        if (_timeNode == value) {
          return;
        }
        if (_timeNode == null || _timeNode.Equals(value) != true) {
          _timeNode = value;
          OnPropertyChanged("TimeNode");
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
