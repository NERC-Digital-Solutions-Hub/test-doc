using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal.Topology
{


  /// <summary>
  /// gml:TimeNodePropertyType provides for associating a gml:TimeNode with an object
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeNodePropertyType")]
  public class TimeNodePropertyType : Model
  {
    #region Private fields
    private TimeNodeType _timeNode;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// TimeNodePropertyType class constructor
    /// </summary>
    public TimeNodePropertyType()
    {
      _timeNode = new TimeNodeType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeNode", Order = 0)]
    public TimeNodeType TimeNode
    {
      get
      {
        return _timeNode;
      }
      set
      {
        if (_timeNode == value)
        {
          return;
        }
        if (_timeNode == null || _timeNode.Equals(value) != true)
        {
          _timeNode = value;
          OnPropertyChanged("TimeNode");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("nilReason")]
    public string nilReason
    {
      get
      {
        return _nilReason;
      }
      set
      {
        if (_nilReason == value)
        {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true)
        {
          _nilReason = value;
          OnPropertyChanged("nilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string remoteSchema
    {
      get
      {
        return _remoteSchema;
      }
      set
      {
        if (_remoteSchema == value)
        {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true)
        {
          _remoteSchema = value;
          OnPropertyChanged("remoteSchema");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool owns
    {
      get
      {
        return _owns;
      }
      set
      {
        if (_owns.Equals(value) != true)
        {
          _owns = value;
          OnPropertyChanged("owns");
        }
      }
    }
  }

}
