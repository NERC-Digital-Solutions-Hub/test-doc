
#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Systems {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ObliqueCartesianCSPropertyType")]
  public class ObliqueCartesianCSPropertyType : ObservableModel {

    #region Private fields
    private ObliqueCartesianCSType _obliqueCartesianCS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// ObliqueCartesianCSPropertyType class constructor
    /// </summary>
    public ObliqueCartesianCSPropertyType() {
      _obliqueCartesianCS = new ObliqueCartesianCSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("ObliqueCartesianCS", Order = 0)]
    public ObliqueCartesianCSType ObliqueCartesianCS {
      get {
        return _obliqueCartesianCS;
      }
      set {
        if (_obliqueCartesianCS == value) {
          return;
        }
        if (_obliqueCartesianCS == null || _obliqueCartesianCS.Equals(value) != true) {
          _obliqueCartesianCS = value;
          OnPropertyChanged("ObliqueCartesianCS");
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
