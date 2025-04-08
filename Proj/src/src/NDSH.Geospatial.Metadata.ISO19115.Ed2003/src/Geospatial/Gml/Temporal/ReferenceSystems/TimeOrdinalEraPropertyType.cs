
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
// XSD               : /2005/gml/temporalReferenceSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="TimeOrdinalEra" type="gml:TimeOrdinalEraType">
//   <annotation>
//     <documentation>
//       Its content model follows the pattern of gml:TimeEdge, inheriting standard
//       properties from gml:DefinitionType, and adding gml:start, gml:end and
//       gml:extent properties, a set of gml:member properties which indicate ordered
//       gml:TimeOrdinalEra elements, and a gml:group property which points to the parent era.
//       The recursive inclusion of gml:TimeOrdinalEra elements allow the construction of an
//       arbitrary depth hierarchical ordinal reference schema, such that an ordinal era at a
//       given level of the hierarchy includes a sequence of shorter, coterminous ordinal eras.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeOrdinalEraType">
//   <complexContent>
//     <extension base="gml:DefinitionType">
//       <sequence>
//         <element name="relatedTime" type="gml:RelatedTimeType" minOccurs="0" maxOccurs="unbounded"/>
//         <element name="start" type="gml:TimeNodePropertyType"/>
//         <element name="end" type="gml:TimeNodePropertyType"/>
//         <element name="extent" type="gml:TimePeriodPropertyType" minOccurs="0"/>
//         <element name="member" type="gml:TimeOrdinalEraPropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <element name="group" type="gml:ReferenceType" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimeOrdinalEraPropertyType">
//   <annotation>
//     <documentation>gml:TimeOrdinalEraPropertyType provides for associating a gml:TimeOrdinalEra with an object.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimeOrdinalEra"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Temporal.ReferenceSystems {


  /// <summary>
  /// gml:TimeOrdinalEraPropertyType provides for associating a gml:TimeOrdinalEra with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeOrdinalEraPropertyType")]
  public class TimeOrdinalEraPropertyType : ObservableModel {
    #region Private fields
    private TimeOrdinalEraType _timeOrdinalEra;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TimeOrdinalEraPropertyType class constructor
    /// </summary>
    public TimeOrdinalEraPropertyType() {
      _timeOrdinalEra = default; // new TimeOrdinalEraType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeOrdinalEra", Order = 0)]
    public TimeOrdinalEraType TimeOrdinalEra {
      get {
        return _timeOrdinalEra;
      }
      set {
        if (_timeOrdinalEra == value) {
          return;
        }
        if (_timeOrdinalEra == null || _timeOrdinalEra.Equals(value) != true) {
          _timeOrdinalEra = value;
          OnPropertyChanged("TimeOrdinalEra");
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
  }
}
