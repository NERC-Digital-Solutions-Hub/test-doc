
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 17:05, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
  [XmlType("PT_FreeText_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("PT_FreeText_PropertyType")]
  public class PT_FreeText_PropertyType : CharacterString_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="PT_FreeText_PropertyType"/>.
    /// </summary>
    public PT_FreeText_PropertyType() {
      _pt_FreeText  = default; //  new PT_FreeText_Type();
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// 
    /// </summary>
    private PT_FreeText_Type _pt_FreeText;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PT_FreeText", Order = 0)]
    [JsonProperty("PT_FreeText", Order = 0)]
    public PT_FreeText_Type PT_FreeText {
      get {
        return _pt_FreeText;
      }
      set {
        if (_pt_FreeText == value) {
          return;
        }
        if (_pt_FreeText == null || _pt_FreeText.Equals(value) != true) {
          _pt_FreeText = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
