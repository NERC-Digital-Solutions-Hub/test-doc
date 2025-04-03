
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Measures;
using NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems;
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

  [XmlInclude(typeof(ML_PrimeMeridian_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PrimeMeridianType")]
  public class PrimeMeridianType : IdentifiedObjectType {

    #region Private fields
    private AngleType _greenwichLongitude;
    #endregion

    /// <summary>
    /// PrimeMeridianType class constructor
    /// </summary>
    public PrimeMeridianType() {
      _greenwichLongitude = new AngleType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("greenwichLongitude", Order = 0)]
    public AngleType GreenwichLongitude {
      get {
        return _greenwichLongitude;
      }
      set {
        if (_greenwichLongitude == value) {
          return;
        }
        if (_greenwichLongitude == null || _greenwichLongitude.Equals(value) != true) {
          _greenwichLongitude = value;
          OnPropertyChanged("GreenwichLongitude");
        }
      }
    }
  }

}
