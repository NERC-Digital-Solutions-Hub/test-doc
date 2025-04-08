
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
// <element name="Observation" type="gml:ObservationType" substitutionGroup="gml:AbstractFeature">
//   <annotation>
//     <documentation>
//       The content model is a straightforward extension of gml:AbstractFeatureType;
//       it automatically has the gml:identifier, gml:description, gml:descriptionReference, gml:name, and gml:boundedBy properties. 
//       The gml:validTime element describes the time of the observation. Note that this may be a time instant or a time period.
//       The gml:using property contains or references a description of a sensor, instrument or procedure used for the observation.
//       The gml:target property contains or references the specimen, region or station which is the object of the observation.
//       This property is particularly useful for remote observations, such as photographs, where a generic location property
//       might apply to the location of the camera or the location of the field of view, and thus may be ambiguous.  
//       The gml:subject element is provided as a convenient synonym for gml:target. This is the term commonly used in phtotography.  
//       The gml:resultOf property indicates the result of the observation.  The value may be inline, or a reference to a value elsewhere.
//       If the value is inline, it shall be a member of the gml:AbstractObject substitution group.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="ObservationType">
//   <complexContent>
//     <extension base="gml:AbstractFeatureType">
//       <sequence>
//         <element ref="gml:validTime"/>
//         <element ref="gml:using" minOccurs="0"/>
//         <element ref="gml:target" minOccurs="0"/>
//         <element ref="gml:resultOf"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Geospatial.Gml.Feature;
using NDSH.Geospatial.Gml.Temporal;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Observation {

  //[XmlInclude(typeof(DirectedObservationType))]
  //[XmlInclude(typeof(DirectedObservationAtDistanceType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ObservationType")]
  public class ObservationType : AbstractFeatureType {
    #region Private fields
    private TimePrimitivePropertyType _validTime;
    private ProcedurePropertyType _using;
    private TargetPropertyType _target;
    private ResultType _resultOf;
    #endregion

    /// <summary>
    /// ObservationType class constructor
    /// </summary>
    public ObservationType() {
      _resultOf = new ResultType();
      _target = new TargetPropertyType();
      _using = new ProcedurePropertyType();
      _validTime = new TimePrimitivePropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("validTime", Order = 0)]
    public TimePrimitivePropertyType ValidTime {
      get {
        return _validTime;
      }
      set {
        if (_validTime == value) {
          return;
        }
        if (_validTime == null || _validTime.Equals(value) != true) {
          _validTime = value;
          OnPropertyChanged("ValidTime");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("using", Order = 1)]
    public ProcedurePropertyType Using {
      get {
        return _using;
      }
      set {
        if (_using == value) {
          return;
        }
        if (_using == null || _using.Equals(value) != true) {
          _using = value;
          OnPropertyChanged("Using");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("target", Order = 2)]
    public TargetPropertyType Target {
      get {
        return _target;
      }
      set {
        if (_target == value) {
          return;
        }
        if (_target == null || _target.Equals(value) != true) {
          _target = value;
          OnPropertyChanged("Target");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("resultOf", Order = 3)]
    public ResultType ResultOf {
      get {
        return _resultOf;
      }
      set {
        if (_resultOf == value) {
          return;
        }
        if (_resultOf == null || _resultOf.Equals(value) != true) {
          _resultOf = value;
          OnPropertyChanged("ResultOf");
        }
      }
    }
  }
}
