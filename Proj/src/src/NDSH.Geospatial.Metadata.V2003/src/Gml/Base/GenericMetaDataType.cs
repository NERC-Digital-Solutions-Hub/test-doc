
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 04:08, @gisvlasta.
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Base {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("GenericMetaDataType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GenericMetaDataType")]
  public class GenericMetaDataType : AbstractMetaDataType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GenericMetaDataType"/>.
    /// </summary>
    public GenericMetaDataType() {
      _any = default; //  new List<System.Xml.XmlElement>();
    }

    #endregion

    #region Public Properties

    private List<XmlElement> _any;

    /// <summary>
    /// 
    /// </summary>
    [XmlAnyElement("Any", Order = 0)]
    [JsonProperty("Any")]
    public List<XmlElement> Any {
      get {
        return _any;
      }
      set {
        if (_any == value) {
          return;
        }
        if (_any == null || _any.Equals(value) != true) {
          _any = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
