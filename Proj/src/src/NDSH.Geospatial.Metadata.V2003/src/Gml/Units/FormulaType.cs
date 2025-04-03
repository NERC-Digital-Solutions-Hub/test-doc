
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 31/01/2023, 18:10, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Units {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("FormulaType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("FormulaType")]
  public class FormulaType : ObservableModel {

    #region Public Properties

    private double _a;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("a", Order = 0)]
    [JsonProperty("a", Order = 0)]
    public double A {
      get {
        return _a;
      }
      set {
        if (_a.Equals(value) != true) {
          _a = value;
          OnPropertyChanged();
        }
      }
    }

    private double _b;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("b", Order = 1)]
    [JsonProperty("b", Order = 1)]
    public double B {
      get {
        return _b;
      }
      set {
        if (_b.Equals(value) != true) {
          _b = value;
          OnPropertyChanged();
        }
      }
    }

    private double _c;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("c", Order = 2)]
    [JsonProperty("c", Order = 2)]
    public double C {
      get {
        return _c;
      }
      set {
        if (_c.Equals(value) != true) {
          _c = value;
          OnPropertyChanged();
        }
      }
    }

    private double _d;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("d", Order = 3)]
    [JsonProperty("d", Order = 3)]
    public double D {
      get {
        return _d;
      }
      set {
        if (_d.Equals(value) != true) {
          _d = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
