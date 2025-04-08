
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 05/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/valueObjects.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="CompositeValue" type="gml:CompositeValueType" substitutionGroup="gml:AbstractValue">
//   <annotation>
//     <documentation>
//       gml:CompositeValue is an aggregate value built from other values.
//       It contains zero or an arbitrary number of gml:valueComponent elements,
//       and zero or one gml:valueComponents property elements.
//       It may be used for strongly coupled aggregates (vectors, tensors)
//       or for arbitrary collections of values.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="CompositeValueType">
//   <complexContent>
//     <extension base="gml:AbstractGMLType">
//       <sequence>
//         <element ref="gml:valueComponent" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:valueComponents" minOccurs="0"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.ValueObjects {

  //[XmlInclude(typeof(ValueArrayType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CompositeValueType")]
  public class CompositeValueType : AbstractGMLType {

    #region Private fields
    private List<ValuePropertyType> _valueComponent;
    private ValueArrayPropertyType _valueComponents;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// CompositeValueType class constructor
    /// </summary>
    public CompositeValueType() {
      _valueComponents = new ValueArrayPropertyType();
      _valueComponent = new List<ValuePropertyType>();
    }

    [XmlElement("valueComponent", Order = 0)]
    [JsonProperty("valueComponent", Order = 0)]
    public List<ValuePropertyType> ValueComponent {
      get {
        return _valueComponent;
      }
      set {
        if (_valueComponent == value) {
          return;
        }
        if (_valueComponent == null || _valueComponent.Equals(value) != true) {
          _valueComponent = value;
          OnPropertyChanged("ValueComponent");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("valueComponents", Order = 1)]
    public ValueArrayPropertyType ValueComponents {
      get {
        return _valueComponents;
      }
      set {
        if (_valueComponents == value) {
          return;
        }
        if (_valueComponents == null || _valueComponents.Equals(value) != true) {
          _valueComponents = value;
          OnPropertyChanged("ValueComponents");
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
