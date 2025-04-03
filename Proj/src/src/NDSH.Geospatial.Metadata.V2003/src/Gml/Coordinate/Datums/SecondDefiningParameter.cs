
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/02/2023, 17:45, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Gml.Measures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums {

  /// <summary>
  /// SecondDefiningParameter is a property containing the definition of the second parameter that
  /// defines the shape of an ellipsoid. An ellipsoid requires two defining parameters: semi-major axis
  /// and inverse flattening or semi-major axis and semi-minor axis. When the reference body is a sphere
  /// rather than an ellipsoid, only a single defining parameter is required, namely the radius of the sphere;
  /// in that case, the semi-major axis "degenerates" into the radius of the sphere. The inverseFlattening
  /// element contains the inverse flattening value of the ellipsoid. This value is a scale factor (or ratio).
  /// It uses gml:LengthType with the restriction that the unit of measure referenced by the uom attribute
  /// must be suitable for a scale factor, such as percent, permil, or parts-per-million. The semiMinorAxis
  /// element contains the length of the semi-minor axis of the ellipsoid. When the isSphere element is included,
  /// the ellipsoid is degenerate and is actually a sphere. The sphere is completely defined by the semi-major axis,
  /// which is the radius of the sphere.
  /// </summary>
  [Serializable]
  [XmlType("SecondDefiningParameter", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SecondDefiningParameter")]
  public class SecondDefiningParameter : ObservableModel {

    #region Public Properties

    private object _parameterItem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("inverseFlattening", typeof(MeasureType), Order = 0)]
    [XmlElement("isSphere", typeof(SecondDefiningParameterIsSphere), Order = 0)]
    [XmlElement("semiMinorAxis", typeof(LengthType), Order = 0)]
    public object ParameterItem {
      get {
        return _parameterItem;
      }
      set {
        if (_parameterItem == value) {
          return;
        }
        if (_parameterItem == null || _parameterItem.Equals(value) != true) {
          _parameterItem = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
