
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 19:09, @fdq09eca, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("Parent_MD_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("Parent_MD_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("Parent_MD_ReferenceSystem")]
  public class Parent_MD_ReferenceSystem : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Parent_MD_ReferenceSystem"/>.
    /// </summary>
    public Parent_MD_ReferenceSystem() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _item = default; // TODO: Is this correct ???

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
    [XmlElement("MD_CRS", typeof(MD_CRS), Order = 0)]
    [XmlElement("MD_ReferenceSystem", typeof(MD_ReferenceSystem), Order = 0)]
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
