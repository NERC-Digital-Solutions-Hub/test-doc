
#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.Temporal;
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coverage {

  [XmlInclude(typeof(RectifiedGridDomainType))]
  [XmlInclude(typeof(GridDomainType))]
  [XmlInclude(typeof(MultiSolidDomainType))]
  [XmlInclude(typeof(MultiSurfaceDomainType))]
  [XmlInclude(typeof(MultiCurveDomainType))]
  [XmlInclude(typeof(MultiPointDomainType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DomainSetType")]
  public class DomainSetType : ObservableModel {

    #region Private fields
    private AbstractGMLType _item;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// DomainSetType class constructor
    /// </summary>
    public DomainSetType() {
      _owns = false;
    }

    [XmlElement("AbstractGeometry", typeof(AbstractGeometryType), Order = 0)]
    [XmlElement("AbstractTimeObject", typeof(AbstractTimeObjectType), Order = 0)]
    public AbstractGMLType Item {
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

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("Owns");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged("NilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string RemoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged("RemoteSchema");
        }
      }
    }

  }

}
