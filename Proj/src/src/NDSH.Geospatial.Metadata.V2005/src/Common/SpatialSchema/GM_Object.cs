
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 00:52, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
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

namespace NDSH.Geospatial.Metadata.V2005.Common.SpatialSchema {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("GM_Object", Namespace = "http://www.isotc211.org/2005/gss", IsNullable = false)]
  [XmlType("GM_Object", Namespace = "http://www.isotc211.org/2005/gss")]
  [JsonObject("GM_Object")]
  public class GM_Object : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GM_Object"/>.
    /// </summary>
    public GM_Object() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gss", "http://www.isotc211.org/2005/gss");

      _item = default;
      
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

    private object _item;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("GM_Point", typeof(GM_Point), Order = 0)]
    [XmlElement("GM_Polygon", typeof(GM_Polygon), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
