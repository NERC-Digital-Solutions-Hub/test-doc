
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

  [XmlInclude(typeof(ML_VerticalCRS_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("VerticalCRSType")]
  public class VerticalCRSType : AbstractCRSType {

    #region Private fields
    private VerticalCSPropertyType _verticalCS;
    private VerticalDatumPropertyType _verticalDatum;
    #endregion

    /// <summary>
    /// VerticalCRSType class constructor
    /// </summary>
    public VerticalCRSType() {
      _verticalDatum = new VerticalDatumPropertyType();
      _verticalCS = new VerticalCSPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("verticalCS", Order = 0)]
    public VerticalCSPropertyType VerticalCS {
      get {
        return _verticalCS;
      }
      set {
        if (_verticalCS == value) {
          return;
        }
        if (_verticalCS == null || _verticalCS.Equals(value) != true) {
          _verticalCS = value;
          OnPropertyChanged("VerticalCS");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("verticalDatum", Order = 1)]
    public VerticalDatumPropertyType VerticalDatum {
      get {
        return _verticalDatum;
      }
      set {
        if (_verticalDatum == value) {
          return;
        }
        if (_verticalDatum == null || _verticalDatum.Equals(value) != true) {
          _verticalDatum = value;
          OnPropertyChanged("VerticalDatum");
        }
      }
    }

  }

}
