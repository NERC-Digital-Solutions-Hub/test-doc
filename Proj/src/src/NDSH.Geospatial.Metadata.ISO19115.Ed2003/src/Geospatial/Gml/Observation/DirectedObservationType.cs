
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/observation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="DirectedObservation" type="gml:DirectedObservationType" substitutionGroup="gml:Observation">
//   <annotation>
//     <documentation>
//       A gml:DirectedObservation is the same as an observation except that it adds an
//       additional gml:direction property. This is the direction in which the observation
//       was acquired. Clearly this applies only to certain types of observations such as
//       visual observations by people, or observations obtained from terrestrial cameras.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="DirectedObservationType">
//   <complexContent>
//     <extension base="gml:ObservationType">
//       <sequence>
//         <element ref="gml:direction"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Geospatial.Gml.Direction;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Observation {

  //[XmlInclude(typeof(DirectedObservationAtDistanceType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectedObservationType")]
  public class DirectedObservationType : ObservationType {
    #region Private fields
    private DirectionPropertyType _direction;
    #endregion

    /// <summary>
    /// DirectedObservationType class constructor
    /// </summary>
    public DirectedObservationType() {
      _direction = new DirectionPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("direction", Order = 0)]
    public DirectionPropertyType Direction {
      get {
        return _direction;
      }
      set {
        if (_direction == value) {
          return;
        }
        if (_direction == null || _direction.Equals(value) != true) {
          _direction = value;
          OnPropertyChanged("Direction");
        }
      }
    }
  }
}
