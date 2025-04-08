
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
using NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Systems;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Datums;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.ReferenceSystems
{


  /// <summary>
  /// gml:GeodeticCRS is a coordinate reference system based on a geodetic datum.
  /// </summary>
  [XmlInclude(typeof(ML_GeodeticCRS_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeodeticCRSType")]
  public class GeodeticCRSType : AbstractCRSType
  {
    #region Private fields
    private object _item;
    private GeodeticDatumPropertyType _geodeticDatum;
    #endregion

    /// <summary>
    /// GeodeticCRSType class constructor
    /// </summary>
    public GeodeticCRSType()
    {
      _geodeticDatum = new GeodeticDatumPropertyType();
    }

    [XmlElement("cartesianCS", typeof(CartesianCSPropertyType), Order = 0)]
    [XmlElement("ellipsoidalCS", typeof(EllipsoidalCSPropertyType), Order = 0)]
    [XmlElement("sphericalCS", typeof(SphericalCSPropertyType), Order = 0)]
    public object Item
    {
      get
      {
        return _item;
      }
      set
      {
        if (_item == value)
        {
          return;
        }
        if (_item == null || _item.Equals(value) != true)
        {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("geodeticDatum", Order = 1)]
    public GeodeticDatumPropertyType geodeticDatum
    {
      get
      {
        return _geodeticDatum;
      }
      set
      {
        if (_geodeticDatum == value)
        {
          return;
        }
        if (_geodeticDatum == null || _geodeticDatum.Equals(value) != true)
        {
          _geodeticDatum = value;
          OnPropertyChanged("geodeticDatum");
        }
      }
    }
  }
}