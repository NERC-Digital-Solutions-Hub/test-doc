
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : data, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/feature.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="EnvelopeWithTimePeriod" type="gml:EnvelopeWithTimePeriodType" substitutionGroup="gml:Envelope">
//   <annotation>
//     <documentation>
//       gml:EnvelopeWithTimePeriod is provided for envelopes that include a temporal extent.
//       It adds two time position properties, gml:beginPosition and gml:endPosition,
//       which describe the extent of a time-envelope.  
//       Since gml:EnvelopeWithTimePeriod is assigned to the substitution group headed by
//       gml:Envelope, it may be used whenever gml:Envelope is valid.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="EnvelopeWithTimePeriodType">
//   <complexContent>
//     <extension base="gml:EnvelopeType">
//       <sequence>
//         <element name="beginPosition" type="gml:TimePositionType"/>
//         <element name="endPosition" type="gml:TimePositionType"/>
//       </sequence>
//       <attribute name="frame" type="anyURI" default="#ISO-8601"/>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Gml.Temporal;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Feature {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EnvelopeWithTimePeriodType")]
  public class EnvelopeWithTimePeriodType : EnvelopeType {
    #region Private fields
    private TimePositionType _beginPosition;
    private TimePositionType _endPosition;
    private string _frame;
    #endregion

    /// <summary>
    /// EnvelopeWithTimePeriodType class constructor
    /// </summary>
    public EnvelopeWithTimePeriodType() {
      _endPosition = new TimePositionType();
      _beginPosition = new TimePositionType();
      _frame = "#ISO-8601";
    }

    [XmlElement(Order = 0)]
    [JsonProperty("beginPosition", Order = 0)]
    public TimePositionType BeginPosition {
      get {
        return _beginPosition;
      }
      set {
        if (_beginPosition == value) {
          return;
        }
        if (_beginPosition == null || _beginPosition.Equals(value) != true) {
          _beginPosition = value;
          OnPropertyChanged("BeginPosition");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("endPosition", Order = 1)]
    public TimePositionType EndPosition {
      get {
        return _endPosition;
      }
      set {
        if (_endPosition == value) {
          return;
        }
        if (_endPosition == null || _endPosition.Equals(value) != true) {
          _endPosition = value;
          OnPropertyChanged("EndPosition");
        }
      }
    }

    [XmlAttribute(DataType = "anyURI")]
    [DefaultValue("#ISO-8601")]
    [JsonProperty("frame")]
    public string Frame {
      get {
        return _frame;
      }
      set {
        if (_frame == value) {
          return;
        }
        if (_frame == null || _frame.Equals(value) != true) {
          _frame = value;
          OnPropertyChanged("Frame");
        }
      }
    }
  }
}
