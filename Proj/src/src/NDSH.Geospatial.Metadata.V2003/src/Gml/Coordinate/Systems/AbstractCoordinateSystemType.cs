
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/12/2022, 19:23, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Systems {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(ML_AffineCS_Type))] // GMX
  [XmlInclude(typeof(ML_CartesianCS_Type))] // GMX
  [XmlInclude(typeof(ML_CylindricalCS_Type))] // GMX
  [XmlInclude(typeof(ML_EllipsoidalCS_Type))] // GMX
  [XmlInclude(typeof(ML_LinearCS_Type))] // GMX
  [XmlInclude(typeof(ML_PolarCS_Type))] // GMX
  [XmlInclude(typeof(ML_SphericalCS_Type))] // GMX
  [XmlInclude(typeof(ML_TimeCS_Type))] // GMX
  [XmlInclude(typeof(ML_UserDefinedCS_Type))] // GMX
  [XmlInclude(typeof(ML_VerticalCS_Type))] // GMX
  [XmlInclude(typeof(ObliqueCartesianCSType))]
  [XmlInclude(typeof(AffineCSType))]
  [XmlInclude(typeof(CylindricalCSType))]
  [XmlInclude(typeof(PolarCSType))]
  [XmlInclude(typeof(SphericalCSType))]
  [XmlInclude(typeof(UserDefinedCSType))]
  [XmlInclude(typeof(LinearCSType))]
  [XmlInclude(typeof(TemporalCSType))]
  [XmlInclude(typeof(TimeCSType))]
  [XmlInclude(typeof(VerticalCSType))]
  [XmlInclude(typeof(CartesianCSType))]
  [XmlInclude(typeof(EllipsoidalCSType))]
  [Serializable]
  [XmlType("AbstractCoordinateSystemType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractCoordinateSystemType")]
  public abstract class AbstractCoordinateSystemType : IdentifiedObjectType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractCoordinateSystemType"/>.
    /// </summary>
    public AbstractCoordinateSystemType() {
      _axis = default; //  new List<CoordinateSystemAxisPropertyType>();
    }

    #endregion

    #region Public Properties

    private List<CoordinateSystemAxisPropertyType> _axis;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("axis", Order = 0)]
    [JsonProperty("axis", Order = 0)]
    public List<CoordinateSystemAxisPropertyType> Axis {
      get {
        return _axis;
      }
      set {
        if (_axis == value) {
          return;
        }
        if (_axis == null || _axis.Equals(value) != true) {
          _axis = value;
          OnPropertyChanged("Axis");
        }
      }
    }

    private AggregationType _aggregationType;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("aggregationType")]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
