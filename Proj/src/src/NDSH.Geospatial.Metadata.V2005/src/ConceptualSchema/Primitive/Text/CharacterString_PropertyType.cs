
#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Primitive.Text {

  [XmlInclude(typeof(PT_FreeText_PropertyType))]
  [Serializable]
  [XmlType(Namespace = "http://standards.iso.org/iso/19115/-3/gco/1.0")]
  [XmlRoot("CharacterString_PropertyType")]
  [JsonObject("CharacterString_PropertyType")]
  public class CharacterString_PropertyType : Model {


    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private string _characterString;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    [JsonProperty(Order = 0)]
    public string CharacterString {
      get {
        return _characterString;
      }
      set {
        if ((_characterString == value)) {
          return;
        }
        if (((_characterString == null)
                    || (_characterString.Equals(value) != true))) {
          _characterString = value;
          OnPropertyChanged("CharacterString");
        }
      }
    }

    private string _nilReason;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(Form = XmlSchemaForm.Qualified, AttributeName = "nilReason")]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if ((_nilReason == value)) {
          return;
        }
        if (((_nilReason == null)
                    || (_nilReason.Equals(value) != true))) {
          _nilReason = value;
          OnPropertyChanged("NilReason");
        }
      }
    }

    #endregion

  }

}
