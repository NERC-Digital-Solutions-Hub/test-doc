
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Measures;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Datums
{

  [XmlInclude(typeof(ML_PrimeMeridian_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PrimeMeridianType")]
  public class PrimeMeridianType : IdentifiedObjectType
  {
    #region Private fields
    private AngleType _greenwichLongitude;
    #endregion

    /// <summary>
    /// PrimeMeridianType class constructor
    /// </summary>
    public PrimeMeridianType()
    {
      _greenwichLongitude = new AngleType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("greenwichLongitude", Order = 0)]
    public AngleType greenwichLongitude
    {
      get
      {
        return _greenwichLongitude;
      }
      set
      {
        if (_greenwichLongitude == value)
        {
          return;
        }
        if (_greenwichLongitude == null || _greenwichLongitude.Equals(value) != true)
        {
          _greenwichLongitude = value;
          OnPropertyChanged("greenwichLongitude");
        }
      }
    }
  }
}