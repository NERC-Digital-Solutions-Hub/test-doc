
#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Names {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("TypeName_PropertyType", Namespace = "http://www.isotc211.org/2005/gco", IsNullable = false)]
  [XmlType("TypeName_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("TypeName_PropertyType")]
  public class TypeName_PropertyType : Model {

    #region Private fields
    private TypeName_Type _typeName;
    private string _uuidref;
    private string _nilReason;
    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// TypeName_PropertyType class constructor
    /// </summary>
    public TypeName_PropertyType() {
      _typeName = new TypeName_Type();
    }

    #endregion



    [XmlElement(Order = 0)]
    [JsonProperty(Order = 0)]
    public TypeName_Type TypeName {
      get {
        return _typeName;
      }
      set {
        if (_typeName == value) {
          return;
        }
        if (_typeName == null
                    || _typeName.Equals(value) != true) {
          _typeName = value;
          OnPropertyChanged("TypeName");
        }
      }
    }

    [XmlAttribute(AttributeName = "uuidref")]
    [JsonProperty("uuidref")]
    public string Uuidref {
      get {
        return _uuidref;
      }
      set {
        if (_uuidref == value) {
          return;
        }
        if (_uuidref == null
                    || _uuidref.Equals(value) != true) {
          _uuidref = value;
          OnPropertyChanged("Uuidref");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, AttributeName = "nilReason")]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null
                    || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged("NilReason");
        }
      }
    }
  }

}
