
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 02:55, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Measures {

  /// <summary>
  /// gml:MeasureType supports recording an amount encoded as a value of XML Schema double,
  /// together with a units of measure indicated by an attribute uom, short for “units Of measure”.
  /// The value of the uom attribute identifies a reference system for the amount,
  /// usually a ratio or interval scale.
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(AngleType))]
  [XmlInclude(typeof(SpeedType))]
  [XmlInclude(typeof(VolumeType))]
  [XmlInclude(typeof(AreaType))]
  [XmlInclude(typeof(GridLengthType))]
  [XmlInclude(typeof(TimeType))]
  [XmlInclude(typeof(ScaleType))]
  [XmlInclude(typeof(LengthType))]
  [XmlType("MeasureType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MeasureType")]
  public class MeasureType : ObservableModel {

    // gml:basicTypes.xsd

    //<complexType name="MeasureType">
    //  <annotation>
    //    <documentation>gml:MeasureType supports recording an amount encoded as a value of XML Schema double, together with a units of measure indicated by an attribute uom, short for “units Of measure”. The value of the uom attribute identifies a reference system for the amount, usually a ratio or interval scale.</documentation>
    //  </annotation>
    //  <simpleContent>
    //    <extension base="double">
    //      <attribute name="uom" type="gml:UomIdentifier" use="required"/>
    //    </extension>
    //  </simpleContent>
    //</complexType>
    //<simpleType name="UomIdentifier">
    //  <annotation>
    //    <documentation>The simple type gml:UomIdentifer defines the syntax and value space of the unit of measure identifier.</documentation>
    //  </annotation>
    //  <union memberTypes="gml:UomSymbol gml:UomURI"/>
    //</simpleType>

    #region Public Properties

    private string _uom;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("uom")]
    [JsonProperty("uom")]
    public string UoM { // TODO: Make sure that UoM is a UoMIdentifier etc.
      get {
        return _uom;
      }
      set {
        if (_uom == value) {
          return;
        }
        if (_uom == null || _uom.Equals(value) != true) {
          _uom = value;
          OnPropertyChanged();
        }
      }
    }

    private double _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText(DataType = "double")]
    [JsonProperty("Value")]
    public double Value {
      get {
        return _value;
      }
      set {
        if (_value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
