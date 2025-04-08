using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Feature.Dynamic
{

  [XmlInclude(typeof(MovingObjectStatusType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimeSliceType")]
  public abstract class AbstractTimeSliceType : AbstractGMLType
  {
    #region Private fields
    private TimePrimitivePropertyType _validTime;
    private StringOrRefType _dataSource;
    #endregion

    /// <summary>
    /// AbstractTimeSliceType class constructor
    /// </summary>
    public AbstractTimeSliceType()
    {
      _dataSource = default; // new StringOrRefType();
      _validTime = default; // new TimePrimitivePropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("validTime", Order = 0)]
    public TimePrimitivePropertyType validTime
    {
      get
      {
        return _validTime;
      }
      set
      {
        if (_validTime == value)
        {
          return;
        }
        if (_validTime == null || _validTime.Equals(value) != true)
        {
          _validTime = value;
          OnPropertyChanged("validTime");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("dataSource", Order = 1)]
    public StringOrRefType dataSource
    {
      get
      {
        return _dataSource;
      }
      set
      {
        if (_dataSource == value)
        {
          return;
        }
        if (_dataSource == null || _dataSource.Equals(value) != true)
        {
          _dataSource = value;
          OnPropertyChanged("dataSource");
        }
      }
    }
  }
}