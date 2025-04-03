
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

namespace NDSH.Geospatial.Metadata.V2005.EntitySet {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false)]
  [JsonObject("MD_MetadataSet")]
  public class MD_MetadataSet : EntityBase<MD_MetadataSet> {

    #region Constructors - Destructors

    /// <summary>
    /// Intializes the <see cref="MD_MetadataSet"/>
    /// </summary>
    public MD_MetadataSet() {
      _metadataList = new List<MD_Metadata>();
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

    private List<MD_Metadata> _metadataList;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_MetadataSet", Order = 0)]
    [JsonProperty("MD_MetadataSet", Order = 0)]
    public List<MD_Metadata> MD_MetadataList {
      get {
        return _metadataList;
      }
      set {
        if (_metadataList == value) {
          return;
        }
        if (_metadataList == null || _metadataList.Equals(value) != true) {
          _metadataList = value;
          OnPropertyChanged("MD_MetadataList");
        }
      }
    }

    #endregion

  }

}
