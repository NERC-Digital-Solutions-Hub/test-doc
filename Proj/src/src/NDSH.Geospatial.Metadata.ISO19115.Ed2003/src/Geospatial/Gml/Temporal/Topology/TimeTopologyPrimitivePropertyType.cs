
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
// <element name="AbstractTimeTopologyPrimitive" type="gml:AbstractTimeTopologyPrimitiveType" abstract="true" substitutionGroup="gml:AbstractTimePrimitive">
//   <annotation>
//     <documentation>
//       gml:TimeTopologyPrimitive acts as the head of a substitution group for topological temporal primitives.
//       Temporal topology primitives shall imply the ordering information between features or feature properties.
//       The temporal connection of features can be examined if they have temporal topology primitives as values
//       of their properties. Usually, an instantaneous feature associates with a time node, and a static feature
//       associates with a time edge.  A feature with both modes associates with the temporal topology primitive:
//       a supertype of time nodes and time edges.
//       A topological primitive is always connected to one or more other topological primitives, and is, therefore,
//       always a member of a topological complex. In a GML instance, this will often be indicated by the primitives
//       being described by elements that are descendents of an element describing a complex. However, in order to
//       support the case where a temporal topological primitive is described in another context, the optional complex
//       property is provided, which carries a reference to the parent temporal topological complex.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="AbstractTimeTopologyPrimitiveType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractTimePrimitiveType">
//       <sequence>
//         <element name="complex" type="gml:ReferenceType" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimeTopologyPrimitivePropertyType">
//   <annotation>
//     <documentation>gml:TimeTopologyPrimitivePropertyType provides for associating a gml:AbstractTimeTopologyPrimitive with an object.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractTimeTopologyPrimitive"/>
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
  /// gml:TimeTopologyPrimitivePropertyType provides for associating a gml:AbstractTimeTopologyPrimitive with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeTopologyPrimitivePropertyType")]
  public class TimeTopologyPrimitivePropertyType : ObservableModel {
    #region Private fields
    private AbstractTimeTopologyPrimitiveType _abstractTimeTopologyPrimitive;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// TimeTopologyPrimitivePropertyType class constructor
    /// </summary>
    public TimeTopologyPrimitivePropertyType() {
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractTimeTopologyPrimitive", Order = 0)]
    public AbstractTimeTopologyPrimitiveType AbstractTimeTopologyPrimitive {
      get {
        return _abstractTimeTopologyPrimitive;
      }
      set {
        if (_abstractTimeTopologyPrimitive == value) {
          return;
        }
        if (_abstractTimeTopologyPrimitive == null || _abstractTimeTopologyPrimitive.Equals(value) != true) {
          _abstractTimeTopologyPrimitive = value;
          OnPropertyChanged("AbstractTimeTopologyPrimitive");
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
