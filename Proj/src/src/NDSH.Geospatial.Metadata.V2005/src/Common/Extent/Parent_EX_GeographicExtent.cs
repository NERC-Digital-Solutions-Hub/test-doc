
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 21:00, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ApplicationSchema;
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
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Common.Extent {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("Parent_EX_GeographicExtent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("Parent_EX_GeographicExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("Parent_EX_GeographicExtent")]
  public class Parent_EX_GeographicExtent : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Parent_EX_GeographicExtent"/>.
    /// </summary>
    public Parent_EX_GeographicExtent() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

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
    [XmlElement("EX_BoundingPolygon", typeof(EX_BoundingPolygon), Order = 0)]
    [XmlElement("EX_GeographicBoundingBox", typeof(EX_GeographicBoundingBox), Order = 0)]
    [XmlElement("EX_GeographicDescription", typeof(EX_GeographicDescription), Order = 0)]
    [XmlElement("EX_GeographicExtent", typeof(EX_GeographicExtent), Order = 0)]
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
