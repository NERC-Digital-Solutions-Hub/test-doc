
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/02/2023, 05:28, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Gml.Feature;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(EnvelopeWithTimePeriodType))]
  [Serializable]
  [XmlType("EnvelopeType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EnvelopeType")]
  public class EnvelopeType : ObservableModel {

    #region Public Properties

    private object[] _coordinatesOrPositionItems;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("coordinates", typeof(CoordinatesType), Order = 0)]
    [XmlElement("lowerCorner", typeof(DirectPositionType), Order = 0)]
    [XmlElement("pos", typeof(DirectPositionType), Order = 0)]
    [XmlElement("upperCorner", typeof(DirectPositionType), Order = 0)]
    [XmlChoiceIdentifier("CoordinatesOrPositionItemsElementName")]
    public object[] CoordinatesOrPositionItems {
      get {
        return _coordinatesOrPositionItems;
      }
      set {
        if (_coordinatesOrPositionItems == value) {
          return;
        }
        if (_coordinatesOrPositionItems == null || _coordinatesOrPositionItems.Equals(value) != true) {
          _coordinatesOrPositionItems = value;
          OnPropertyChanged();
        }
      }
    }

    private CoordinatesOrPositionEnumeration[] _coordinatesOrPositionItemsElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CoordinatesOrPositionItemsElementName", Order = 1)]
    [XmlIgnore]
    public CoordinatesOrPositionEnumeration[] CoordinatesOrPositionItemsElementName {
      get {
        return _coordinatesOrPositionItemsElementName;
      }
      set {
        if (_coordinatesOrPositionItemsElementName == value) {
          return;
        }
        if (_coordinatesOrPositionItemsElementName == null || _coordinatesOrPositionItemsElementName.Equals(value) != true) {
          _coordinatesOrPositionItemsElementName = value;
          OnPropertyChanged();
        }
      }
    }

    private string _srsName;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("srsName", DataType = "anyURI")]
    [JsonProperty("srsName")]
    public string SrsName {
      get {
        return _srsName;
      }
      set {
        if (_srsName == value) {
          return;
        }
        if (_srsName == null || _srsName.Equals(value) != true) {
          _srsName = value;
          OnPropertyChanged();
        }
      }
    }

    private string _srsDimension;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("srsDimension", DataType = "positiveInteger")]
    [JsonProperty("srsDimension")]
    public string SrsDimension {
      get {
        return _srsDimension;
      }
      set {
        if (_srsDimension == value) {
          return;
        }
        if (_srsDimension == null || _srsDimension.Equals(value) != true) {
          _srsDimension = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
