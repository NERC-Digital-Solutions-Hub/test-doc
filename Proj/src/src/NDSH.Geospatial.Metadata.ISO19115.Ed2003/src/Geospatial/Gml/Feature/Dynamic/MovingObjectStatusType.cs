
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
// XSD               : /2005/gml/dynamicFeature.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="MovingObjectStatus" type="gml:MovingObjectStatusType" substitutionGroup="gml:AbstractTimeSlice">
//   <annotation>
//     <documentation>
//       gml:MovingObjectStatus is one example of how gml:AbstractTimeSlice may be extended.
//       This element provides a standard method to capture a record of the status of a moving object.
//       A gml:MovingObjectStatus element allows the user to describe the present location,
//       along with the speed, bearing, acceleration and elevation of an object in a particular time slice.  
//       Additional information about the current status of the object may be recorded in the
//       gml:status or gml:statusReference property elements.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="MovingObjectStatusType">
//   <complexContent>
//     <extension base="gml:AbstractTimeSliceType">
//       <sequence>
//         <choice>
//           <element name="position" type="gml:GeometryPropertyType"/>
//           <element ref="gml:pos"/>
//           <element ref="gml:locationName"/>
//           <element ref="gml:locationReference"/>
//           <element ref="gml:location"/>
//         </choice>
//         <element name="speed" type="gml:MeasureType" minOccurs="0"/>
//         <element name="bearing" type="gml:DirectionPropertyType" minOccurs="0"/>
//         <element name="acceleration" type="gml:MeasureType" minOccurs="0"/>
//         <element name="elevation" type="gml:MeasureType" minOccurs="0"/>
//         <element ref="gml:status" minOccurs="0"/>
//         <element ref="gml:statusReference" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Direction;
using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Gml.Measures;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Feature.Dynamic {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MovingObjectStatusType")]
  public class MovingObjectStatusType : AbstractTimeSliceType {
    #region Private fields
    private object _item;
    private MeasureType _speed;
    private DirectionPropertyType _bearing;
    private MeasureType _acceleration;
    private MeasureType _elevation;
    private StringOrRefType _status;
    private ReferenceType _statusReference;
    #endregion

    /// <summary>
    /// MovingObjectStatusType class constructor
    /// </summary>
    public MovingObjectStatusType() {
      _statusReference = default; // new ReferenceType();
      _status = default; // new StringOrRefType();
      _elevation = default; // new MeasureType();
      _acceleration = default; // new MeasureType();
      _bearing = default; // new DirectionPropertyType();
      _speed = default; // new MeasureType();
    }

    [XmlElement("location", typeof(LocationPropertyType), Order = 0)]
    [XmlElement("locationName", typeof(CodeType), Order = 0)]
    [XmlElement("locationReference", typeof(ReferenceType), Order = 0)]
    [XmlElement("pos", typeof(DirectPositionType), Order = 0)]
    [XmlElement("position", typeof(GeometryPropertyType), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("speed", Order = 1)]
    public MeasureType Speed {
      get {
        return _speed;
      }
      set {
        if (_speed == value) {
          return;
        }
        if (_speed == null || _speed.Equals(value) != true) {
          _speed = value;
          OnPropertyChanged("Speed");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("bearing", Order = 2)]
    public DirectionPropertyType Bearing {
      get {
        return _bearing;
      }
      set {
        if (_bearing == value) {
          return;
        }
        if (_bearing == null || _bearing.Equals(value) != true) {
          _bearing = value;
          OnPropertyChanged("Bearing");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("acceleration", Order = 3)]
    public MeasureType Acceleration {
      get {
        return _acceleration;
      }
      set {
        if (_acceleration == value) {
          return;
        }
        if (_acceleration == null || _acceleration.Equals(value) != true) {
          _acceleration = value;
          OnPropertyChanged("Acceleration");
        }
      }
    }

    [XmlElement(Order = 4)]
    [JsonProperty("elevation", Order = 4)]
    public MeasureType Elevation {
      get {
        return _elevation;
      }
      set {
        if (_elevation == value) {
          return;
        }
        if (_elevation == null || _elevation.Equals(value) != true) {
          _elevation = value;
          OnPropertyChanged("Elevation");
        }
      }
    }

    [XmlElement(Order = 5)]
    [JsonProperty("status", Order = 5)]
    public StringOrRefType Status {
      get {
        return _status;
      }
      set {
        if (_status == value) {
          return;
        }
        if (_status == null || _status.Equals(value) != true) {
          _status = value;
          OnPropertyChanged("Status");
        }
      }
    }

    [XmlElement(Order = 6)]
    [JsonProperty("statusReference", Order = 6)]
    public ReferenceType StatusReference {
      get {
        return _statusReference;
      }
      set {
        if (_statusReference == value) {
          return;
        }
        if (_statusReference == null || _statusReference.Equals(value) != true) {
          _statusReference = value;
          OnPropertyChanged("StatusReference");
        }
      }
    }
  }
}
