
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Systems;
using NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
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

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeographicCRSType")]
  public class GeographicCRSType : AbstractCRSType {

    #region Private fields
    private EllipsoidalCSPropertyType _usesEllipsoidalCS;
    private GeodeticDatumPropertyType _usesGeodeticDatum;
    #endregion

    /// <summary>
    /// GeographicCRSType class constructor
    /// </summary>
    public GeographicCRSType() {
      _usesGeodeticDatum = new GeodeticDatumPropertyType();
      _usesEllipsoidalCS = new EllipsoidalCSPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("usesEllipsoidalCS", Order = 0)]
    public EllipsoidalCSPropertyType UsesEllipsoidalCS {
      get {
        return _usesEllipsoidalCS;
      }
      set {
        if (_usesEllipsoidalCS == value) {
          return;
        }
        if (_usesEllipsoidalCS == null || _usesEllipsoidalCS.Equals(value) != true) {
          _usesEllipsoidalCS = value;
          OnPropertyChanged("UsesEllipsoidalCS");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("usesGeodeticDatum", Order = 1)]
    public GeodeticDatumPropertyType UsesGeodeticDatum {
      get {
        return _usesGeodeticDatum;
      }
      set {
        if (_usesGeodeticDatum == value) {
          return;
        }
        if (_usesGeodeticDatum == null || _usesGeodeticDatum.Equals(value) != true) {
          _usesGeodeticDatum = value;
          OnPropertyChanged("UsesGeodeticDatum");
        }
      }
    }

  }

}
