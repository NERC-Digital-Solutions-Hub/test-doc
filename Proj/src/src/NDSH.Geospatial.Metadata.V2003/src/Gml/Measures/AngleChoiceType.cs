
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 01/02/2023, 19:36, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Measures {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("AngleChoiceType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AngleChoiceType")]
  [Obsolete]
  public class AngleChoiceType : ObservableModel {

    #region Public Properties

    private object _item;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("angle", typeof(AngleType), Order = 0)]
    [XmlElement("dmsAngle", typeof(DMSAngleType), Order = 0)]
    public object Angle {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
