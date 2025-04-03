
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

namespace NDSH.Geospatial.Metadata.V2005.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false)]
  [JsonObject("DQ_ConformanceResult")]
  public class DQ_ConformanceResult : EntityBase<DQ_ConformanceResult> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_ConformanceResult"/>.
    /// </summary>
    public DQ_ConformanceResult() {
      _pass = new Boolean();
      _specification = new CI_Citation();
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

    private CI_Citation _specification;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "specification")]
    [JsonProperty("specification", Order = 0)]
    public CI_Citation Specification {
      get {
        return _specification;
      }
      set {
        if (_specification == value) {
          return;
        }
        if (_specification == null || _specification.Equals(value) != true) {
          _specification = value;
          OnPropertyChanged();
        }
      }
    }

    private string _explanation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "explanation")]
    [JsonProperty("explanation", Order = 1)]
    public string Explanation {
      get {
        return _explanation;
      }
      set {
        if (_explanation == value) {
          return;
        }
        if (_explanation == null || _explanation.Equals(value) != true) {
          _explanation = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean _pass;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "pass")]
    [JsonProperty("pass", Order = 2)]
    public Boolean Pass {
      get {
        return _pass;
      }
      set {
        if (_pass == value) {
          return;
        }
        if (_pass == null || _pass.Equals(value) != true) { // TODO: Check out the CS0472 warning. This may need a fix.
          _pass = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
    [JsonProperty("id")]
    public string Id {
      get {
        return _id;
      }
      set {
        if (_id == value) {
          return;
        }
        if (_id == null || _id.Equals(value) != true) {
          _id = value;
          OnPropertyChanged();
        }
      }
    }

    private string _uuid;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "uuid")]
    [JsonProperty("uuid")]
    public string Uuid {
      get {
        return _uuid;
      }
      set {
        if (_uuid == value) {
          return;
        }
        if (_uuid == null || _uuid.Equals(value) != true) {
          _uuid = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
