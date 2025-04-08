
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Dictionary {






  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DefinitionProxyType")]
  public class DefinitionProxyType : DefinitionType {
    #region Private fields
    private ReferenceType _definitionRef;
    #endregion

    /// <summary>
    /// DefinitionProxyType class constructor
    /// </summary>
    public DefinitionProxyType() {
      _definitionRef = new ReferenceType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("definitionRef", Order = 0)]
    public ReferenceType definitionRef {
      get {
        return _definitionRef;
      }
      set {
        if (_definitionRef == value) {
          return;
        }
        if (_definitionRef == null || _definitionRef.Equals(value) != true) {
          _definitionRef = value;
          OnPropertyChanged("definitionRef");
        }
      }
    }
  }
}