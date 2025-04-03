
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
  [JsonObject("TemporalCRSType")]
  public class TemporalCRSType : AbstractCRSType {

    #region Private fields
    private object _item;
    private TemporalDatumPropertyType _temporalDatum;
    #endregion

    /// <summary>
    /// TemporalCRSType class constructor
    /// </summary>
    public TemporalCRSType() {
      _temporalDatum = new TemporalDatumPropertyType();
    }

    [XmlElement("timeCS", typeof(TimeCSPropertyType), Order = 0)]
    [XmlElement("usesTemporalCS", typeof(TemporalCSPropertyType), Order = 0)]
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
    [JsonProperty("temporalDatum", Order = 1)]
    public TemporalDatumPropertyType TemporalDatum {
      get {
        return _temporalDatum;
      }
      set {
        if (_temporalDatum == value) {
          return;
        }
        if (_temporalDatum == null || _temporalDatum.Equals(value) != true) {
          _temporalDatum = value;
          OnPropertyChanged("TemporalDatum");
        }
      }
    }

  }

}
