
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic2D;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Aggregates {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiSurfaceType")]
  public class MultiSurfaceType : AbstractGeometricAggregateType
  {
    #region Private fields
    private List<SurfacePropertyType> _surfaceMember;
    private SurfaceArrayPropertyType _surfaceMembers;
    #endregion

    /// <summary>
    /// MultiSurfaceType class constructor
    /// </summary>
    public MultiSurfaceType()
    {
      _surfaceMembers = new SurfaceArrayPropertyType();
      _surfaceMember = new List<SurfacePropertyType>();
    }

    [XmlElement("surfaceMember", Order = 0)]
    [JsonProperty("surfaceMember", Order = 0)]
    public List<SurfacePropertyType> surfaceMember
    {
      get
      {
        return _surfaceMember;
      }
      set
      {
        if (_surfaceMember == value)
        {
          return;
        }
        if (_surfaceMember == null || _surfaceMember.Equals(value) != true)
        {
          _surfaceMember = value;
          OnPropertyChanged("surfaceMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("surfaceMembers", Order = 1)]
    public SurfaceArrayPropertyType surfaceMembers
    {
      get
      {
        return _surfaceMembers;
      }
      set
      {
        if (_surfaceMembers == value)
        {
          return;
        }
        if (_surfaceMembers == null || _surfaceMembers.Equals(value) != true)
        {
          _surfaceMembers = value;
          OnPropertyChanged("surfaceMembers");
        }
      }
    }
  }
}