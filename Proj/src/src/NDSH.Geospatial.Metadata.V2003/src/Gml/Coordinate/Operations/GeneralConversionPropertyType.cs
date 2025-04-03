
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Operations {

  /// <summary>
  /// gml:GeneralConversionPropertyType is a property type for association roles to a general conversion,
  /// either referencing or containing the definition of that conversion.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeneralConversionPropertyType")]
  public class GeneralConversionPropertyType : ObservableModel {

    #region Private fields
    private AbstractGeneralConversionType _abstractGeneralConversion;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractGeneralConversion", Order = 0)]
    public AbstractGeneralConversionType AbstractGeneralConversion {
      get {
        return _abstractGeneralConversion;
      }
      set {
        if (_abstractGeneralConversion == value) {
          return;
        }
        if (_abstractGeneralConversion == null || _abstractGeneralConversion.Equals(value) != true) {
          _abstractGeneralConversion = value;
          OnPropertyChanged("AbstractGeneralConversion");
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
