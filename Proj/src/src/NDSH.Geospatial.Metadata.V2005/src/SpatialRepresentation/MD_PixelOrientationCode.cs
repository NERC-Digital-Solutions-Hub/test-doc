
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 15:08, @EttoreM - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_PixelOrientationCode", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_PixelOrientationCode", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_PixelOrientationCode")]
  public class MD_PixelOrientationCode : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_PixelOrientationCode"/>.
    /// </summary>
    public MD_PixelOrientationCode() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _value = default; // TODO: Is this correct?

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

    private MD_PixelOrientationCodeValue _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "value")]
    [JsonProperty("value")]
    [JsonConverter(typeof(StringEnumConverter))]
    public MD_PixelOrientationCodeValue Value {
      get {
        return _value;
      }
      set {
        if ((_value.Equals(value) != true)) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
