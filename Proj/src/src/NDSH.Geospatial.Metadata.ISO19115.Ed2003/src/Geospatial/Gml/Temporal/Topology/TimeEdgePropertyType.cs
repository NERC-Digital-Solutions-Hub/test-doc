
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
// <element name="TimeEdge" type="gml:TimeEdgeType" substitutionGroup="gml:AbstractTimeTopologyPrimitive">
//   <annotation>
//     <documentation>
//       A time edge is a one-dimensional topological primitive. It is an open interval that starts and ends at a node.
//       The edge may be realised as a geometry whose value is a time period.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeEdgeType">
//   <complexContent>
//     <extension base="gml:AbstractTimeTopologyPrimitiveType">
//       <sequence>
//         <element name="start" type="gml:TimeNodePropertyType"/>
//         <element name="end" type="gml:TimeNodePropertyType"/>
//         <element name="extent" type="gml:TimePeriodPropertyType" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimeEdgePropertyType">
//   <annotation>
//     <documentation>gml:TimeEdgePropertyType provides for associating a gml:TimeEdge with an object.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimeEdge"/>
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
  /// gml:TimeEdgePropertyType provides for associating a gml:TimeEdge with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeEdgePropertyType")]
  public class TimeEdgePropertyType : ObservableModel {
    #region Private fields
    private TimeEdgeType _timeEdge;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// TimeEdgePropertyType class constructor
    /// </summary>
    public TimeEdgePropertyType() {
      _timeEdge = default; // new TimeEdgeType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeEdge", Order = 0)]
    public TimeEdgeType TimeEdge {
      get {
        return _timeEdge;
      }
      set {
        if (_timeEdge == value) {
          return;
        }
        if (_timeEdge == null || _timeEdge.Equals(value) != true) {
          _timeEdge = value;
          OnPropertyChanged("TimeEdge");
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
