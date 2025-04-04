﻿using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// gml:SurfacePatchArrayPropertyType is a container for a sequence of surface patches.
  /// </summary>
  [XmlInclude(typeof(TrianglePatchArrayPropertyType))]
  [XmlInclude(typeof(PolygonPatchArrayPropertyType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SurfacePatchArrayPropertyType")]
  public class SurfacePatchArrayPropertyType : ObservableModel {
    #region Private fields
    private List<AbstractSurfacePatchType> _abstractSurfacePatch;
    #endregion

    /// <summary>
    /// SurfacePatchArrayPropertyType class constructor
    /// </summary>
    public SurfacePatchArrayPropertyType() {
      _abstractSurfacePatch = new List<AbstractSurfacePatchType>();
    }

    [XmlElement("AbstractSurfacePatch", Order = 0)]
    [JsonProperty("AbstractSurfacePatch", Order = 0)]
    public List<AbstractSurfacePatchType> AbstractSurfacePatch {
      get {
        return _abstractSurfacePatch;
      }
      set {
        if (_abstractSurfacePatch == value) {
          return;
        }
        if (_abstractSurfacePatch == null || _abstractSurfacePatch.Equals(value) != true) {
          _abstractSurfacePatch = value;
          OnPropertyChanged("AbstractSurfacePatch");
        }
      }
    }
  }

}
