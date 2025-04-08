
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 02:15, @gisvlasta.
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes {

  /// <summary>
  /// gml:MeasureListType provides for a list of quantities.
  /// </summary>
  [Serializable]
  [XmlType("MeasureListType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MeasureListType")]
  public class MeasureListType : ObservableModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MeasureListType"/>.
    /// </summary>
    public MeasureListType() {
      _text = default; //  new List<double>();
    }

    #endregion

    #region Public Properties

    private string _uom;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("uom")]
    [JsonProperty("uom")]
    public string Uom {
      get {
        return _uom;
      }
      set {
        if (_uom == value) {
          return;
        }
        if (_uom == null || _uom.Equals(value) != true) {
          _uom = value;
          OnPropertyChanged();
        }
      }
    }

    private List<double> _text;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("Text")]
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
