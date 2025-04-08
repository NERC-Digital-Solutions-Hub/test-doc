
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : @@Implemented?
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Primitive.Text {

  /// <summary>
  /// 
  /// </summary>
  // TODO: Check basicTypes.xsd / gco.xsd / gcoBase.xsd for the validity of this implementation.
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(DataType = "string", Namespace = "http://www.isotc211.org/2005/gco", IsNullable = false)]
  [XmlType("CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("CharacterString")]
  public class CharacterString : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CharacterString"/>.
    /// </summary>
    public CharacterString() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gco", "http://www.isotc211.org/2005/gco");

      _value = default;

    }

    /// <summary>
    /// Initializes the <see cref="CharacterString"/> with the specified value.
    /// </summary>
    /// <param name="value">The value of the <see cref="CharacterString"/>.</param>
    public CharacterString(string value) {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gco", "http://www.isotc211.org/2005/gco");
      
      this.Value = value;

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
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// The static Create method ensures that if a <see cref="null"/> <see cref="string"/>
    /// value is supplied then a <see cref="null"/> <see cref="CharacterString"/> is returned.
    /// </summary>
    /// <param name="value">The <see cref="string"/> used to create a CharacterSTring.</param>
    /// <returns>A <see cref="CharacterString"/> object.</returns>
    public static CharacterString Create(string value) {
      CharacterString cs = null;

      if (value != null) {
        cs = new CharacterString(value);
      }

      return cs;
    }

    #endregion
    
  }

}
