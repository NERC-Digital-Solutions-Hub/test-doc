
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/02/2023, 02:14, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.Measures;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Direction {

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
