
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 17:10, @gisvlasta.
// Updated by        : 09/01/2023, 20:11, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Localisation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("PT_FreeText", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("PT_FreeText", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("PT_FreeText")]
  public class PT_FreeText_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="PT_FreeText_Type"/>.
    /// </summary>
    public PT_FreeText_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _textGroup  = default; //  new List<LocalisedCharacterString_PropertyType>();

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

    private List<LocalisedCharacterString_PropertyType> _textGroup;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("textGroup", Order = 0)]
    [JsonProperty("textGroup", Order = 0)]
    public List<LocalisedCharacterString_PropertyType> TextGroup {
      get {
        return _textGroup;
      }
      set {
        if (_textGroup == value) {
          return;
        }
        if (_textGroup == null || _textGroup.Equals(value) != true) {
          _textGroup = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
