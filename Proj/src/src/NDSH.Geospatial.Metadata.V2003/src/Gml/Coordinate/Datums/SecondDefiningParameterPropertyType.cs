
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 31/01/2023, 09:42, @gisvlasta.
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
  /// SecondDefiningParameterPropertyType is a property containing the definition of the second
  /// parameter that defines the shape of an ellipsoid. An ellipsoid requires two defining
  /// parameters: semi-major axis and inverse flattening or semi-major axis and semi-minor axis.
  /// When the reference body is a sphere rather than an ellipsoid, only a single defining parameter
  /// is required, namely the radius of the sphere; in that case, the semi-major axis "degenerates"
  /// into the radius of the sphere. The inverseFlattening element contains the inverse flattening
  /// value of the ellipsoid. This value is a scale factor (or ratio). It uses <see cref="LengthType"/>
  /// withthe restriction that the unit of measure referenced by the uom attribute must be suitable
  /// for a scale factor, such as percent, permil, or parts-per-million. The semiMinorAxis element
  /// contains the length of the semi-minor axis of the ellipsoid. When the isSphere element is
  /// included, the ellipsoid is degenerate and is actually a sphere. The sphere is completely
  /// defined by the semi-major axis, which is the radius of the sphere.
  /// </summary>
  [Serializable]
  [XmlType("secondDefiningParameter", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("secondDefiningParameter")]
  public class SecondDefiningParameterPropertyType : ObservableModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SecondDefiningParameterPropertyType"/>.
    /// </summary>
    public SecondDefiningParameterPropertyType() {
      _secondDefiningParameter = new SecondDefiningParameter();
    }

    #endregion

    #region Private fields

    private SecondDefiningParameter _secondDefiningParameter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SecondDefiningParameter", Order = 0)]
    [JsonProperty("SecondDefiningParameter", Order = 0)]
    public SecondDefiningParameter SecondDefiningParameter {
      get {
        return _secondDefiningParameter;
      }
      set {
        if (_secondDefiningParameter == value) {
          return;
        }
        if (_secondDefiningParameter == null || _secondDefiningParameter.Equals(value) != true) {
          _secondDefiningParameter = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
