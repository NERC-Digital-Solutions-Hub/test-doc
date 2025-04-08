
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 15:12, @EttoreM - Cleaned Xml Serialization Attributes.
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
using System.ComponentModel.DataAnnotations;
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
  [XmlRoot("MD_GeometricObjects", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_GeometricObjects", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_GeometricObjects")]
  public class MD_GeometricObjects : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_GeometricObjects"/>.
    /// </summary>
    public MD_GeometricObjects() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _geometricObjectType = default;
      _geometricObjectCount = default;
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

    private MD_GeometricObjectTypeCode _geometricObjectType;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "geometricObjectType")]
    [JsonProperty("geometricObjectType", Order = 0)]
    public MD_GeometricObjectTypeCode GeometricObjectType {
      get {
        return _geometricObjectType;
      }
      set {
        if (_geometricObjectType == value) {
          return;
        }
        if (_geometricObjectType == null || _geometricObjectType.Equals(value) != true) {
          _geometricObjectType = value;
          OnPropertyChanged();
        }
      }
    }

    private int _geometricObjectCount;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "geometricObjectCount")]
    [RequiredAttribute()]
    [JsonProperty("geometricObjectCount", Order = 1)]
    public int GeometricObjectCount {
      get {
        return _geometricObjectCount;
      }
      set {
        if (_geometricObjectCount.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "GeometricObjectCount";
          Validator.ValidateProperty(value, validatorPropContext);
          _geometricObjectCount = value;
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
        if ((_id == value)) {
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
        if ((_uuid == value)) {
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
