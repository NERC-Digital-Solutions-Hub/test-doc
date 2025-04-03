
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:11, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          :
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmi/acquisitionInformation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MI_EnvironmentalRecord_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="averageAirTemperature" type="gco:Real_PropertyType"/>
//         <xs:element name="maxRelativeHumidity" type="gco:Real_PropertyType"/>
//         <xs:element name="maxAltitude" type="gco:Real_PropertyType"/>
//         <xs:element name="meterologicalConditions" type="gco:CharacterString_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_EnvironmentalRecord" type="gmi:MI_EnvironmentalRecord_Type"/>
// <xs:complexType name="MI_EnvironmentalRecord_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_EnvironmentalRecord" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Imagery.Acquisition {

  //[XmlType("MI_EnvironmentalRecord", Namespace = "http://www.isotc211.org/2005/gmi")]
  //[XmlRoot("MI_EnvironmentalRecord", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_EnvironmentalRecord")]
  public class MI_EnvironmentalRecord_Type : MetadataObject {

    // WARNING: VALUE TYPE

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_EnvironmentalRecord_Type"/>.
    /// </summary>
    public MI_EnvironmentalRecord_Type() {
      _averageAirTemperature = default; // new Real_PropertyType();
      _maxRelativeHumidity = default; // new Real_PropertyType();
      _maxAltitude = default; // new Real_PropertyType();
      _meterologicalConditions = default; // new CharacterString();
    }

    #endregion

    #region Public Properties

    private double _averageAirTemperature;

    //[XmlElement("averageAirTemperature", Order = 0)]
    [JsonProperty("averageAirTemperature", Order = 0)]
    public double AverageAirTemperature {
      get => _averageAirTemperature;
      // TODO: SetProperty
      set {
        if (_averageAirTemperature == value) {
          return;
        }
        if (/*_averageAirTemperature == null || */_averageAirTemperature.Equals(value) != true) {
          _averageAirTemperature = value;
          OnPropertyChanged();
        }
      }
    }

    private double _maxRelativeHumidity;

    //[XmlElement("maxRelativeHumidity", Order = 1)]
    [JsonProperty("maxRelativeHumidity", Order = 1)]
    public double MaxRelativeHumidity {
      get => _maxRelativeHumidity;
      // TODO: SetProperty
      set {
        if (_maxRelativeHumidity == value) {
          return;
        }
        if (/*_maxRelativeHumidity == null || */_maxRelativeHumidity.Equals(value) != true) {
          _maxRelativeHumidity = value;
          OnPropertyChanged();
        }
      }
    }

    private double _maxAltitude;

    //[XmlElement("maxAltitude", Order = 2)]
    [JsonProperty("maxAltitude", Order = 2)]
    public double MaxAltitude {
      get => _maxAltitude;
      // TODO: SetProperty
      set {
        if (_maxAltitude == value) {
          return;
        }
        if (/*_maxAltitude == null || */_maxAltitude.Equals(value) != true) {
          _maxAltitude = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _meterologicalConditions;

    //[XmlElement("meterologicalConditions", Order = 3)]
    [JsonProperty("meterologicalConditions", Order = 3)]
    public CharacterString MeterologicalConditions {
      get => _meterologicalConditions;
      set => SetProperty(ref _meterologicalConditions, value);
    }

    #endregion

  }

}
