
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
// <element name="DirectedObservationAtDistance" type="gml:DirectedObservationAtDistanceType" substitutionGroup="gml:DirectedObservation">
//   <annotation>
//     <documentation>
//       gml:DirectedObservationAtDistance adds an additional distance property.
//       This is the distance from the observer to the subject of the observation.
//       Clearly this applies only to certain types of observations such as visual
//       observations by people, or observations obtained from terrestrial cameras.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="DirectedObservationAtDistanceType">
//   <complexContent>
//     <extension base="gml:DirectedObservationType">
//       <sequence>
//         <element name="distance" type="gml:MeasureType"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Geospatial.Gml.Measures;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Observation {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectedObservationAtDistanceType")]
  public class DirectedObservationAtDistanceType : DirectedObservationType {
    #region Private fields
    private MeasureType _distance;
    #endregion

    /// <summary>
    /// DirectedObservationAtDistanceType class constructor
    /// </summary>
    public DirectedObservationAtDistanceType() {
      _distance = new MeasureType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("distance", Order = 0)]
    public MeasureType Distance {
      get {
        return _distance;
      }
      set {
        if (_distance == value) {
          return;
        }
        if (_distance == null || _distance.Equals(value) != true) {
          _distance = value;
          OnPropertyChanged("distance");
        }
      }
    }
  }
}
