
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/geometryPrimitives.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AffinePlacementType">
//   <sequence>
//     <element name="location" type="gml:DirectPositionType"/>
//     <element name="refDirection" type="gml:VectorType" maxOccurs="unbounded"/>
//     <element name="inDimension" type="positiveInteger"/>
//     <element name="outDimension" type="positiveInteger"/>
//   </sequence>
// </complexType>
// <element name="AffinePlacement" type="gml:AffinePlacementType" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <documentation>location, refDirection, inDimension and outDimension have the same meaning as specified in ISO 19107:2003, 6.4.21.</documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AffinePlacementType")]
  public class AffinePlacementType : ObservableModel {
    #region Private fields
    private DirectPositionType _location;
    private List<VectorType> _refDirection;
    private string _inDimension;
    private string _outDimension;
    #endregion

    /// <summary>
    /// AffinePlacementType class constructor
    /// </summary>
    public AffinePlacementType() {
      _refDirection = new List<VectorType>();
      _location = new DirectPositionType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("location", Order = 0)]
    public DirectPositionType Location {
      get {
        return _location;
      }
      set {
        if (_location == value) {
          return;
        }
        if (_location == null || _location.Equals(value) != true) {
          _location = value;
          OnPropertyChanged("Location");
        }
      }
    }

    [XmlElement("refDirection", Order = 1)]
    [JsonProperty("refDirection", Order = 1)]
    public List<VectorType> RefDirection {
      get {
        return _refDirection;
      }
      set {
        if (_refDirection == value) {
          return;
        }
        if (_refDirection == null || _refDirection.Equals(value) != true) {
          _refDirection = value;
          OnPropertyChanged("RefDirection");
        }
      }
    }

    [XmlElement(DataType = "positiveInteger", Order = 2)]
    [JsonProperty("inDimension", Order = 2)]
    public string InDimension {
      get {
        return _inDimension;
      }
      set {
        if (_inDimension == value) {
          return;
        }
        if (_inDimension == null || _inDimension.Equals(value) != true) {
          _inDimension = value;
          OnPropertyChanged("InDimension");
        }
      }
    }

    [XmlElement(DataType = "positiveInteger", Order = 3)]
    [JsonProperty("outDimension", Order = 3)]
    public string OutDimension {
      get {
        return _outDimension;
      }
      set {
        if (_outDimension == value) {
          return;
        }
        if (_outDimension == null || _outDimension.Equals(value) != true) {
          _outDimension = value;
          OnPropertyChanged("OutDimension");
        }
      }
    }
  }

}
