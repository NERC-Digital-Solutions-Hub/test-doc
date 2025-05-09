﻿
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
// XSD               : /2005/gml/temporal.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="AbstractTimePrimitive" type="gml:AbstractTimePrimitiveType" abstract="true" substitutionGroup="gml:AbstractTimeObject">
//   <annotation>
//     <documentation>gml:AbstractTimePrimitive acts as the head of a substitution group for geometric and topological temporal primitives.</documentation>
//   </annotation>
// </element>
// <complexType name="AbstractTimePrimitiveType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractTimeObjectType">
//       <sequence>
//         <element name="relatedTime" type="gml:RelatedTimeType" minOccurs="0" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimePrimitivePropertyType">
//   <annotation>
//     <documentation>
//       gml:TimePrimitivePropertyType provides a standard content model for associations between an arbitrary member
//       of the substitution group whose head is gml:AbstractTimePrimitive and another object.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractTimePrimitive"/>
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

namespace NDSH.Geospatial.Gml.Temporal {

  /// <summary>
  /// gml:TimePrimitivePropertyType provides a standard content model for associations between an arbitrary member of the substitution group whose head is gml:AbstractTimePrimitive and another object.
  /// </summary>
  //[XmlInclude(typeof(RelatedTimeType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimePrimitivePropertyType")]
  public class TimePrimitivePropertyType : ObservableModel {
    #region Private fields
    private AbstractTimePrimitiveType _abstractTimePrimitive;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// TimePrimitivePropertyType class constructor
    /// </summary>
    public TimePrimitivePropertyType() {
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractTimePrimitive", Order = 0)]
    public AbstractTimePrimitiveType AbstractTimePrimitive {
      get {
        return _abstractTimePrimitive;
      }
      set {
        if (_abstractTimePrimitive == value) {
          return;
        }
        if (_abstractTimePrimitive == null || _abstractTimePrimitive.Equals(value) != true) {
          _abstractTimePrimitive = value;
          OnPropertyChanged("AbstractTimePrimitive");
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
