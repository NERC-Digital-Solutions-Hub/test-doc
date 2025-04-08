
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 20:57, @gisvlasta.
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
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D {

  /// <summary>
  /// posList instances (and other instances with the content model specified by
  /// DirectPositionListType) hold the coordinates for a sequence of direct positions
  /// within the same coordinate reference system (CRS). If no srsName attribute is given,
  /// the CRS shall be specified as part of the larger context this geometry element is part of,
  /// typically a geometric object like a point, curve, etc. The optional attribute count
  /// specifies the number of direct positions in the list. If the attribute count is present
  /// then the attribute srsDimension shall be present, too. The number of entries in the list
  /// is equal to the product of the dimensionality of the coordinate reference system
  /// (i.e. it is a derived value of the coordinate reference system definition)
  /// and the number of direct positions.
  /// </summary>
  [Serializable]
  [XmlType("DirectPositionListType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectPositionListType")]
  public class DirectPositionListType : ObservableModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DirectPositionListType"/>.
    /// </summary>
    public DirectPositionListType() {
      _text = new List<double>();
    }

    #endregion

    #region Public Properties

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

    private string _count;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("count", DataType = "positiveInteger")]
    [JsonProperty("count")]
    public string Count {
      get {
        return _count;
      }
      set {
        if (_count == value) {
          return;
        }
        if (_count == null || _count.Equals(value) != true) {
          _count = value;
          OnPropertyChanged();
        }
      }
    }

    private List<double> _text;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("Text")] // TODO: Check this one.
    public List<double> Text {
      get {
        return _text;
      }
      set {
        if (_text == value) {
          return;
        }
        if (_text == null || _text.Equals(value) != true) {
          _text = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
