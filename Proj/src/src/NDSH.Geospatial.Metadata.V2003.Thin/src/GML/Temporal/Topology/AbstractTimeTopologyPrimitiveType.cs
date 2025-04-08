using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal.Topology
{


  [XmlInclude(typeof(TimeEdgeType))]
  [XmlInclude(typeof(TimeNodeType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimeTopologyPrimitiveType")]
  public abstract class AbstractTimeTopologyPrimitiveType : AbstractTimePrimitiveType
  {
    #region Private fields
    private ReferenceType _complex;
    #endregion

    /// <summary>
    /// AbstractTimeTopologyPrimitiveType class constructor
    /// </summary>
    public AbstractTimeTopologyPrimitiveType()
    {
      _complex = new ReferenceType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("complex", Order = 0)]
    public ReferenceType complex
    {
      get
      {
        return _complex;
      }
      set
      {
        if (_complex == value)
        {
          return;
        }
        if (_complex == null || _complex.Equals(value) != true)
        {
          _complex = value;
          OnPropertyChanged("complex");
        }
      }
    }
  }

}
