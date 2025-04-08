using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Utilities.App.Examples {

  /// <summary>
  /// 
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategoryAttribute("code")]
  [XmlRootAttribute("CI_Telephone", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("CI_Telephone", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Telephone")]
  public class CI_Telephone : INotifyPropertyChanged {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Telephone"/>.
    /// </summary>
    public CI_Telephone() {
      xmlns = new XmlSerializerNamespaces();
      // TODO: Check namespaces here.
      //xmlns.Add("gco", "http://www.isotc211.org/2005/gco");
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _facsimile = new List<string>();
      _voice = new List<string>();
    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<string> _voice;

    /// <summary>
    /// 
    /// </summary>
    [XmlArray("voice", Order = 0, ElementName = "voice", Namespace = "http://www.isotc211.org/2005/gmd")]
    [XmlArrayItem("CharacterString", ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
    [JsonProperty("voice", Order = 0)]
    public List<string> Voice {
      get {
        return _voice;
      }
      set {
        if (_voice == value) {
          return;
        }
        if (_voice == null || _voice.Equals(value) != true) {
          _voice = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _facsimile;

    /// <summary>
    /// 
    /// </summary>
    [XmlArray("facsimile", Order = 1, ElementName = "facsimile", Namespace = "http://www.isotc211.org/2005/gmd")]
    [XmlArrayItem("CharacterString", ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
    [JsonProperty("facsimile", Order = 1)]
    public List<string> Facsimile {
      get {
        return _facsimile;
      }
      set {
        if (_facsimile == value) {
          return;
        }
        if (_facsimile == null || _facsimile.Equals(value) != true) {
          _facsimile = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    //[XmlAttribute(DataType = "ID", AttributeName = "id")]
    [XmlIgnore()]
    [JsonProperty("id")]
    public string Id {
      get {
        return _id;
      }
      set {
        if (_id == value) {
          return;
        }
        if (_id == null || _id.Equals(value) != true) {
          _id = value;
          OnPropertyChanged();
        }
      }
    }

    private string _uuid;

    /// <summary>
    /// 
    /// </summary>
    //[XmlAttribute(AttributeName = "uuid")]
    [XmlIgnore()]
    [JsonProperty("uuid")]
    public string Uuid {
      get {
        return _uuid;
      }
      set {
        if (_uuid == value) {
          return;
        }
        if (_uuid == null || _uuid.Equals(value) != true) {
          _uuid = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region Public Events

    /// <summary>
    /// The event that is raised when a property value has been changed.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    #endregion

    #region Private Procedures

    /// <summary>
    /// Executed when a property value has been changed.
    /// The procedure is used to raise the <see cref="PropertyChanged"/> event.
    /// </summary>
    /// <param name="propertyName">
    /// The name of the property whose value has been changed.</param>
    public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "") {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion

  }

}
