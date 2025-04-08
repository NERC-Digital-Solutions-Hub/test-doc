using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Utilities.App.Examples {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  //[XmlRootAttribute(DataType = "string", Namespace = "http://www.isotc211.org/2005/gco", IsNullable = false)]
  //[XmlElement(DataType = "string", ElementName = "CharacterSTring", Namespace = "http://www.isotc211.org/2005/gco")]
  [XmlType("CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
  //public class CharacterString : INotifyPropertyChanged, IXmlSerializable {
  public class CharacterString : INotifyPropertyChanged {
    
    #region Constructors - Destructors

      /// <summary>
      /// Initializes the <see cref="CharacterString"/>.
      /// </summary>
    public CharacterString() {
      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gco", "http://www.isotc211.org/2005/gco");
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

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    //[XmlIgnore()]
    //[XmlElement(Order = 0, ElementName = "value")]
    [XmlText(DataType = "string")]
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
          OnPropertyChanged("Value");
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

    //public XmlSchema? GetSchema() {
    //  throw new NotImplementedException();
    //}

    //public void ReadXml(XmlReader reader) {
    //  throw new NotImplementedException();
    //}

    //public void WriteXml(XmlWriter writer) {
    //  throw new NotImplementedException();
    //}

    #endregion

  }



}
