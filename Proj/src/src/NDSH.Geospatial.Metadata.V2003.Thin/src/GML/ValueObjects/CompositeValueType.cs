
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.ValueObjects {


  [XmlInclude(typeof(ValueArrayType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
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
    public List<ValuePropertyType> valueComponent {
      get {
        return _valueComponent;
      }
      set {
        if (_valueComponent == value) {
          return;
        }
        if (_valueComponent == null || _valueComponent.Equals(value) != true) {
          _valueComponent = value;
          OnPropertyChanged("valueComponent");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("valueComponents", Order = 1)]
    public ValueArrayPropertyType valueComponents {
      get {
        return _valueComponents;
      }
      set {
        if (_valueComponents == value) {
          return;
        }
        if (_valueComponents == null || _valueComponents.Equals(value) != true) {
          _valueComponents = value;
          OnPropertyChanged("valueComponents");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType aggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("aggregationType");
        }
      }
    }
  }
}