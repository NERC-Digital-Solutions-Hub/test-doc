
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Systems {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(CoordinateSystemAxisAlt_Type))] // GMX
  [XmlInclude(typeof(ML_CoordinateSystemAxis_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CoordinateSystemAxisType")]
  public class CoordinateSystemAxisType : IdentifiedObjectType {

    #region Private fields
    private CodeType _axisAbbrev;
    private CodeWithAuthorityType _axisDirection;
    private double _minimumValue;
    private double _maximumValue;
    private CodeWithAuthorityType _rangeMeaning;
    private string _uom;
    #endregion

    /// <summary>
    /// CoordinateSystemAxisType class constructor
    /// </summary>
    public CoordinateSystemAxisType() {
      _rangeMeaning = default; //  new CodeWithAuthorityType();
      _axisDirection = default; //  new CodeWithAuthorityType();
      _axisAbbrev = default; //  new CodeType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("axisAbbrev", Order = 0)]
    public CodeType AxisAbbrev {
      get {
        return _axisAbbrev;
      }
      set {
        if (_axisAbbrev == value) {
          return;
        }
        if (_axisAbbrev == null || _axisAbbrev.Equals(value) != true) {
          _axisAbbrev = value;
          OnPropertyChanged("AxisAbbrev");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("axisDirection", Order = 1)]
    public CodeWithAuthorityType AxisDirection {
      get {
        return _axisDirection;
      }
      set {
        if (_axisDirection == value) {
          return;
        }
        if (_axisDirection == null || _axisDirection.Equals(value) != true) {
          _axisDirection = value;
          OnPropertyChanged("AxisDirection");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("minimumValue", Order = 2)]
    public double MinimumValue {
      get {
        return _minimumValue;
      }
      set {
        if (_minimumValue.Equals(value) != true) {
          _minimumValue = value;
          OnPropertyChanged("MinimumValue");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("maximumValue", Order = 3)]
    public double MaximumValue {
      get {
        return _maximumValue;
      }
      set {
        if (_maximumValue.Equals(value) != true) {
          _maximumValue = value;
          OnPropertyChanged("MaximumValue");
        }
      }
    }

    [XmlElement(Order = 4)]
    [JsonProperty("rangeMeaning", Order = 4)]
    public CodeWithAuthorityType RangeMeaning {
      get {
        return _rangeMeaning;
      }
      set {
        if (_rangeMeaning == value) {
          return;
        }
        if (_rangeMeaning == null || _rangeMeaning.Equals(value) != true) {
          _rangeMeaning = value;
          OnPropertyChanged("RangeMeaning");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("uom")]
    public string Uom {
      get {
        return _uom;
      }
      set {
        if (_uom == value) {
          return;
        }
        if (_uom == null || _uom.Equals(value) != true) {
          _uom = value;
          OnPropertyChanged("Uom");
        }
      }

    }

  }

}
