
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

  [XmlInclude(typeof(ML_VerticalCRS_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("VerticalCRSType")]
  public class VerticalCRSType : AbstractCRSType
  {
    #region Private fields
    private VerticalCSPropertyType _verticalCS;
    private VerticalDatumPropertyType _verticalDatum;
    #endregion

    /// <summary>
    /// VerticalCRSType class constructor
    /// </summary>
    public VerticalCRSType()
    {
      _verticalDatum = new VerticalDatumPropertyType();
      _verticalCS = new VerticalCSPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("verticalCS", Order = 0)]
    public VerticalCSPropertyType verticalCS
    {
      get
      {
        return _verticalCS;
      }
      set
      {
        if (_verticalCS == value)
        {
          return;
        }
        if (_verticalCS == null || _verticalCS.Equals(value) != true)
        {
          _verticalCS = value;
          OnPropertyChanged("verticalCS");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("verticalDatum", Order = 1)]
    public VerticalDatumPropertyType verticalDatum
    {
      get
      {
        return _verticalDatum;
      }
      set
      {
        if (_verticalDatum == value)
        {
          return;
        }
        if (_verticalDatum == null || _verticalDatum.Equals(value) != true)
        {
          _verticalDatum = value;
          OnPropertyChanged("verticalDatum");
        }
      }
    }
  }
}