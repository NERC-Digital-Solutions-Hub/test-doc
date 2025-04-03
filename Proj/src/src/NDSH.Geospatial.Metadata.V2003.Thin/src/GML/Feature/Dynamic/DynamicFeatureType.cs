using NDSH.Geospatial.Metadata.V2003.Thin.GML.Feature;
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

  [XmlInclude(typeof(DynamicFeatureCollectionType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DynamicFeatureType")]
  public class DynamicFeatureType : AbstractFeatureType
  {
    #region Private fields
    private TimePrimitivePropertyType _validTime;
    private HistoryPropertyType _history;
    private StringOrRefType _dataSource;
    private ReferenceType _dataSourceReference;
    #endregion

    /// <summary>
    /// DynamicFeatureType class constructor
    /// </summary>
    public DynamicFeatureType()
    {
      _dataSourceReference = default; // new ReferenceType();
      _dataSource = default; // new StringOrRefType();
      _history = default; // new HistoryPropertyType();
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
    [JsonProperty("history", Order = 1)]
    public HistoryPropertyType history
    {
      get
      {
        return _history;
      }
      set
      {
        if (_history == value)
        {
          return;
        }
        if (_history == null || _history.Equals(value) != true)
        {
          _history = value;
          OnPropertyChanged("history");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("dataSource", Order = 2)]
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

    [XmlElement(Order = 3)]
    [JsonProperty("dataSourceReference", Order = 3)]
    public ReferenceType dataSourceReference
    {
      get
      {
        return _dataSourceReference;
      }
      set
      {
        if (_dataSourceReference == value)
        {
          return;
        }
        if (_dataSourceReference == null || _dataSourceReference.Equals(value) != true)
        {
          _dataSourceReference = value;
          OnPropertyChanged("dataSourceReference");
        }
      }
    }
  }


}