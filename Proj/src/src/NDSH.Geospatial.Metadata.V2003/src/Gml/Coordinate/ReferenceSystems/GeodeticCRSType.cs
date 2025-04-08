
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Systems;
using NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems;
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.ReferenceSystems {

  /// <summary>
  /// gml:GeodeticCRS is a coordinate reference system based on a geodetic datum.
  /// </summary>
  [XmlInclude(typeof(ML_GeodeticCRS_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeodeticCRSType")]
  public class GeodeticCRSType : AbstractCRSType {

    #region Private fields
    private object _item;
    private GeodeticDatumPropertyType _geodeticDatum;
    #endregion

    /// <summary>
    /// GeodeticCRSType class constructor
    /// </summary>
    public GeodeticCRSType() {
      _geodeticDatum = new GeodeticDatumPropertyType();
    }

    [XmlElement("cartesianCS", typeof(CartesianCSPropertyType), Order = 0)]
    [XmlElement("ellipsoidalCS", typeof(EllipsoidalCSPropertyType), Order = 0)]
    [XmlElement("sphericalCS", typeof(SphericalCSPropertyType), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("geodeticDatum", Order = 1)]
    public GeodeticDatumPropertyType GeodeticDatum {
      get {
        return _geodeticDatum;
      }
      set {
        if (_geodeticDatum == value) {
          return;
        }
        if (_geodeticDatum == null || _geodeticDatum.Equals(value) != true) {
          _geodeticDatum = value;
          OnPropertyChanged("GeodeticDatum");
        }
      }
    }

  }

}
