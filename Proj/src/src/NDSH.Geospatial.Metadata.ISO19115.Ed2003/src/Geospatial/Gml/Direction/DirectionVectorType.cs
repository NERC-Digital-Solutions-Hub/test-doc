
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/directions.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="DirectionVectorType">
//   <annotation>
//     <documentation>Direction vectors are specified by providing components of a vector.</documentation>
//   </annotation>
//   <choice>
//     <element ref="gml:vector"/>
//     <sequence>
//       <annotation>
//         <appinfo>deprecated</appinfo>
//       </annotation>
//       <element name="horizontalAngle" type="gml:AngleType"/>
//       <element name="verticalAngle" type="gml:AngleType"/>
//     </sequence>
//   </choice>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using NDSH.Apps;
using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Gml.Measures;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Direction {

  /// <summary>
  /// Direction vectors are specified by providing components of a vector.
  /// </summary>
  [Serializable]
  [XmlType("DirectionVectorType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectionVectorType")]
  public class DirectionVectorType : ObservableModel {

    #region Public Properties

    private object[] _directionVector;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("horizontalAngle", typeof(AngleType), Order = 0)]
    [XmlElement("vector", typeof(VectorType), Order = 0)]
    [XmlElement("verticalAngle", typeof(AngleType), Order = 0)]
    [XmlChoiceIdentifier("DirectionVectorsElementName")]
    public object[] DirectionVectors {
      get {
        return _directionVector;
      }
      set {
        if (_directionVector == value) {
          return;
        }
        if (_directionVector == null || _directionVector.Equals(value) != true) {
          _directionVector = value;
          OnPropertyChanged();
        }
      }
    }

    private DirectionVectorEnumeration[] _directionVectorsElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DirectionVectorsElementName", Order = 1)]
    [XmlIgnore]
    public DirectionVectorEnumeration[] DirectionVectorsElementName {
      get {
        return _directionVectorsElementName;
      }
      set {
        if (_directionVectorsElementName == value) {
          return;
        }
        if (_directionVectorsElementName == null || _directionVectorsElementName.Equals(value) != true) {
          _directionVectorsElementName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
