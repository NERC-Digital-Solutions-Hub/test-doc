
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/content.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_Band_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:MD_RangeDimension_Type">
//       <xs:sequence>
//         <xs:element name="maxValue" type="gco:Real_PropertyType" minOccurs="0"/>
//         <xs:element name="minValue" type="gco:Real_PropertyType" minOccurs="0"/>
//         <xs:element name="units" type="gco:UomLength_PropertyType" minOccurs="0"/>
//         <xs:element name="peakResponse" type="gco:Real_PropertyType" minOccurs="0"/>
//         <xs:element name="bitsPerValue" type="gco:Integer_PropertyType" minOccurs="0"/>
//         <xs:element name="toneGradation" type="gco:Integer_PropertyType" minOccurs="0"/>
//         <xs:element name="scaleFactor" type="gco:Real_PropertyType" minOccurs="0"/>
//         <xs:element name="offset" type="gco:Real_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_Band" type="gmd:MD_Band_Type" substitutionGroup="gmd:MD_RangeDimension"/>
// <xs:complexType name="MD_Band_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_Band"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Derived.UnitsOfMeasure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Content {

  //[XmlInclude(typeof(MI_Band_Type))]
  [Serializable]
  //[XmlType("MD_Band", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_Band", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Band")]
  public class MD_Band_Type : MD_RangeDimension_Type {

    // WARNING: Check which value types need to be nullable.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Band_Type"/>.
    /// </summary>
    public MD_Band_Type() {
      _maxValue = default; //  new Real_PropertyType();
      _minValue = default; //  new Real_PropertyType();
      _units = default; //  new UomLength_PropertyType();
      _peakResponse = default; //  new Real_PropertyType();
      _bitsPerValue = default; //  new Integer_PropertyType();
      _toneGradation = default; //  new Integer_PropertyType();
      _scaleFactor = default; //  new Real_PropertyType();
      _offset = default; //  new Real_PropertyType();
    }

    #endregion

    #region Public Properties

    private double? _maxValue;

    /// <summary>
    /// Longest wavelength that the sensor is capable of collecting within a designated band.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("maxValue", Order = 0)]
    [JsonProperty("maxValue", Order = 0)]
    public double? MaxValue {
      get => _maxValue;
      // TODO: SetProperty
      set {
        if (_maxValue == value) {
          return;
        }
        if (/*_maxValue == null || */_maxValue.Equals(value) != true) {
          _maxValue = value;
          OnPropertyChanged();
        }
      }
    }

    private double? _minValue;

    /// <summary>
    /// Shortest wavelength that the sensor is capable of collecting within a designated band.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("minValue", Order = 1)]
    [JsonProperty("minValue", Order = 1)]
    public double? MinValue {
      get => _minValue;
      // TODO: SetProperty
      set {
        if (_minValue == value) {
          return;
        }
        if (/*_minValue == null || */_minValue.Equals(value) != true) {
          _minValue = value;
          OnPropertyChanged();
        }
      }
    }

    private UomLength_PropertyType? _units;

    /// <summary>
    /// Units in which sensor wavelengths are expressed.
    /// </summary>
    // TODO: OBL - C (minValue or maxValue provided?)
    // TODO: CAR - 1
    //[XmlElement("units", Order = 2)]
    [JsonProperty("units", Order = 2)]
    public UomLength_PropertyType? Units {
      get => _units;
      set => SetProperty(ref _units, value);
    }

    private double? _peakResponse;

    /// <summary>
    /// Wavelength at which the response is the highest.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("peakResponse", Order = 3)]
    [JsonProperty("peakResponse", Order = 3)]
    public double? PeakResponse {
      get => _peakResponse;
      // TODO: SetProperty
      set {
        if (_peakResponse == value) {
          return;
        }
        if (/*_peakResponse == null || */_peakResponse.Equals(value) != true) {
          _peakResponse = value;
          OnPropertyChanged();
        }
      }
    }

    private int? _bitsPerValue;

    /// <summary>
    /// Maximum number of significant bits in the uncompressed representation for the value in each band of each pixel.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("bitsPerValue", Order = 4)]
    [JsonProperty("bitsPerValue", Order = 4)]
    public int? BitsPerValue {
      get => _bitsPerValue;
      // TODO: SetProperty
      set {
        if (_bitsPerValue == value) {
          return;
        }
        if (/*_bitsPerValue == null || */_bitsPerValue.Equals(value) != true) {
          _bitsPerValue = value;
          OnPropertyChanged();
        }
      }
    }

    private int? _toneGradation;

    /// <summary>
    /// Number of discrete numerical values in the grid data.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("toneGradation", Order = 5)]
    [JsonProperty("toneGradation", Order = 5)]
    public int? ToneGradation {
      get => _toneGradation;
      // TODO: SetProperty
      set {
        if (_toneGradation == value) {
          return;
        }
        if (/*_toneGradation == null || */_toneGradation.Equals(value) != true) {
          _toneGradation = value;
          OnPropertyChanged();
        }
      }
    }

    private double? _scaleFactor;

    /// <summary>
    /// Scale factor which has been applied to the cell value.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("scaleFactor", Order = 6)]
    [JsonProperty("scaleFactor", Order = 6)]
    public double? ScaleFactor {
      get => _scaleFactor;
      // TODO: SetProperty
      set {
        if (_scaleFactor == value) {
          return;
        }
        if (/*_scaleFactor == null || */_scaleFactor.Equals(value) != true) {
          _scaleFactor = value;
          OnPropertyChanged();
        }
      }
    }

    private double? _offset;

    /// <summary>
    /// The physical value corresponding to a cell value of zero.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("offset", Order = 7)]
    [JsonProperty("offset", Order = 7)]
    public double? Offset {
      get => _offset;
      // TODO: SetProperty
      set {
        if (_offset == value) {
          return;
        }
        if (/*_offset == null || */_offset.Equals(value) != true) {
          _offset = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
