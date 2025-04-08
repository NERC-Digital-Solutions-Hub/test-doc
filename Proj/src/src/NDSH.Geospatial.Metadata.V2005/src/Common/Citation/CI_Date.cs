
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 19:14, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Common.Citation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("CI_Date", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("CI_Date", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Date")]
  public class CI_Date : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Date"/>.
    /// </summary>
    public CI_Date() {
      
      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _date = default;
      _dateType = default;

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

    private string _date;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "date")]
    [JsonProperty("date", Order = 0)]
    public string Date {
      get {
        return _date;
      }
      set {
        if (_date == value) {
          return;
        }
        if (_date == null || _date.Equals(value) != true) {
          _date = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_DateTypeCode _dateType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "dateType")]
    [JsonProperty("dateType", Order = 1)]
    public CI_DateTypeCode DateType {
      get {
        return _dateType;
      }
      set {
        if (_dateType == value) {
          return;
        }
        if (_dateType == null || _dateType.Equals(value) != true) {
          _dateType = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
    [XmlIgnore()]
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
    [XmlIgnore()]
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
