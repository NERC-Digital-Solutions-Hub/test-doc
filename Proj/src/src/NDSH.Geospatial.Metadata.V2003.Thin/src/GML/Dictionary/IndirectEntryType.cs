
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Dictionary {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("IndirectEntryType")]
  public class IndirectEntryType : Model {
    #region Private fields
    private DefinitionProxyType _definitionProxy;
    #endregion

    /// <summary>
    /// IndirectEntryType class constructor
    /// </summary>
    public IndirectEntryType() {
      _definitionProxy = new DefinitionProxyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("DefinitionProxy", Order = 0)]
    public DefinitionProxyType DefinitionProxy {
      get {
        return _definitionProxy;
      }
      set {
        if (_definitionProxy == value) {
          return;
        }
        if (_definitionProxy == null || _definitionProxy.Equals(value) != true) {
          _definitionProxy = value;
          OnPropertyChanged("DefinitionProxy");
        }
      }
    }
  }
}