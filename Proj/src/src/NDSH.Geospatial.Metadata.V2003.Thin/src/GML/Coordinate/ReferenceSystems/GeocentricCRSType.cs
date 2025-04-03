
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.ReferenceSystems
{

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeocentricCRSType")]
  public class GeocentricCRSType : AbstractCRSType
  {
    #region Private fields
    private object _item;
    private GeodeticDatumPropertyType _usesGeodeticDatum;
    #endregion

    /// <summary>
    /// GeocentricCRSType class constructor
    /// </summary>
    public GeocentricCRSType()
    {
      _usesGeodeticDatum = new GeodeticDatumPropertyType();
    }

    [XmlElement("usesCartesianCS", typeof(CartesianCSPropertyType), Order = 0)]
    [XmlElement("usesSphericalCS", typeof(SphericalCSPropertyType), Order = 0)]
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
    [JsonProperty("usesGeodeticDatum", Order = 1)]
    public GeodeticDatumPropertyType usesGeodeticDatum
    {
      get
      {
        return _usesGeodeticDatum;
      }
      set
      {
        if (_usesGeodeticDatum == value)
        {
          return;
        }
        if (_usesGeodeticDatum == null || _usesGeodeticDatum.Equals(value) != true)
        {
          _usesGeodeticDatum = value;
          OnPropertyChanged("usesGeodeticDatum");
        }
      }
    }
  }
}