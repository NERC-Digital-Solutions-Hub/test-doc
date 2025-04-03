
#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("CodeListValue_Type", Namespace = "http://www.isotc211.org/2005/gco", IsNullable = false)]
  [XmlType("CodeListValue_Type", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("CodeListValue_Type")]
  public class CodeListValue_Type : Model {

    #region Public Properties

    private string _codeList;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "anyURI", AttributeName = "codeList")]
    [JsonProperty("codeList")]
    [Required]
    public string CodeList {
      get {
        return _codeList;
      }
      set {
        if (_codeList == value) {
          return;
        }
        if (_codeList == null || _codeList.Equals(value) != true) {
          _codeList = value;
          OnPropertyChanged();
        }
      }
    }

    private string _codeListValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "anyURI", AttributeName = "codeListValue")]
    [JsonProperty("codeListValue")]
    [Required]
    public string CodeListValue {
      get {
        return _codeListValue;
      }
      set {
        if (_codeListValue == value) {
          return;
        }
        if (_codeListValue == null || _codeListValue.Equals(value) != true) {
          _codeListValue = value;
          OnPropertyChanged();
        }
      }
    }

    private string _codeSpace;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "anyURI", AttributeName = "codeSpace")]
    [JsonProperty("codeSpace")]
    public string CodeSpace {
      get {
        return _codeSpace;
      }
      set {
        if (_codeSpace == value) {
          return;
        }
        if (_codeSpace == null || _codeSpace.Equals(value) != true) {
          _codeSpace = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText]
    [JsonProperty()]
    public string Value {
      get {
        return _value;
      }
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || _value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
