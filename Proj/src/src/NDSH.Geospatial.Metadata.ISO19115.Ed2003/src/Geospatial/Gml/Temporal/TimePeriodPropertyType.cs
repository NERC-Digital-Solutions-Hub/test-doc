
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
// <element name="TimePeriod" type="gml:TimePeriodType" substitutionGroup="gml:AbstractTimeGeometricPrimitive">
//   <annotation>
//     <documentation>
//       gml:TimePeriod acts as a one-dimensional geometric primitive that represents an identifiable extent in time.
//       The location in of a gml:TimePeriod is described by the temporal positions of the instants at which it begins and ends.
//       The length of the period is equal to the temporal distance between the two bounding temporal positions. 
//       Both beginning and end may be described in terms of their direct position using gml:TimePositionType which is an
//       XML Schema simple content type, or by reference to an indentifiable time instant using gml:TimeInstantPropertyType.
//       Alternatively a limit of a gml:TimePeriod may use the conventional GML property model to make a reference to a
//       time instant described elsewhere, or a limit may be indicated as a direct position.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimePeriodType">
//   <complexContent>
//     <extension base="gml:AbstractTimeGeometricPrimitiveType">
//       <sequence>
//         <choice>
//           <element name="beginPosition" type="gml:TimePositionType"/>
//           <element name="begin" type="gml:TimeInstantPropertyType"/>
//         </choice>
//         <choice>
//           <element name="endPosition" type="gml:TimePositionType"/>
//           <element name="end" type="gml:TimeInstantPropertyType"/>
//         </choice>
//         <group ref="gml:timeLength" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimePeriodPropertyType">
//   <annotation>
//     <documentation>gml:TimePeriodPropertyType provides for associating a gml:TimePeriod with an object.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimePeriod"/>
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
  /// gml:TimePeriodPropertyType provides for associating a gml:TimePeriod with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimePeriodPropertyType")]
  public class TimePeriodPropertyType : ObservableModel {
    #region Private fields
    private TimePeriodType _timePeriod;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// TimePeriodPropertyType class constructor
    /// </summary>
    public TimePeriodPropertyType() {
      _timePeriod = default; // new TimePeriodType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimePeriod", Order = 0)]
    public TimePeriodType TimePeriod {
      get {
        return _timePeriod;
      }
      set {
        if (_timePeriod == value) {
          return;
        }
        if (_timePeriod == null || _timePeriod.Equals(value) != true) {
          _timePeriod = value;
          OnPropertyChanged("TimePeriod");
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
