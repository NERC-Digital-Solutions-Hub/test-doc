
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.ReferenceSystems {

  /// <summary>
  /// gml:CompoundCRSPropertyType is a property type for association roles to a compound coordinate reference system, either referencing or containing the definition of that reference system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CompoundCRSPropertyType")]
  public class CompoundCRSPropertyType : ObservableModel {

    #region Private fields
    private CompoundCRSType _compoundCRS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// CompoundCRSPropertyType class constructor
    /// </summary>
    public CompoundCRSPropertyType() {
      _compoundCRS = new CompoundCRSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("CompoundCRS", Order = 0)]
    public CompoundCRSType CompoundCRS {
      get {
        return _compoundCRS;
      }
      set {
        if (_compoundCRS == value) {
          return;
        }
        if (_compoundCRS == null || _compoundCRS.Equals(value) != true) {
          _compoundCRS = value;
          OnPropertyChanged("CompoundCRS");
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
