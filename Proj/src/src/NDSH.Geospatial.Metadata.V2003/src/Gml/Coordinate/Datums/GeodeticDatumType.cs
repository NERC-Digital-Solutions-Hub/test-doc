
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.Datums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums {

  [XmlInclude(typeof(ML_GeodeticDatum_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeodeticDatumType")]
  public class GeodeticDatumType : AbstractDatumType {

    #region Private fields
    private PrimeMeridianPropertyType _primeMeridian;
    private EllipsoidPropertyType _ellipsoid;
    #endregion

    /// <summary>
    /// GeodeticDatumType class constructor
    /// </summary>
    public GeodeticDatumType() {
      _ellipsoid = new EllipsoidPropertyType();
      _primeMeridian = new PrimeMeridianPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("primeMeridian", Order = 0)]
    public PrimeMeridianPropertyType PrimeMeridian {
      get {
        return _primeMeridian;
      }
      set {
        if (_primeMeridian == value) {
          return;
        }
        if (_primeMeridian == null || _primeMeridian.Equals(value) != true) {
          _primeMeridian = value;
          OnPropertyChanged("PrimeMeridian");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("ellipsoid", Order = 1)]
    public EllipsoidPropertyType Ellipsoid {
      get {
        return _ellipsoid;
      }
      set {
        if (_ellipsoid == value) {
          return;
        }
        if (_ellipsoid == null || _ellipsoid.Equals(value) != true) {
          _ellipsoid = value;
          OnPropertyChanged("Ellipsoid");
        }
      }
    }
  }

}
