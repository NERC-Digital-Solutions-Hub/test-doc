
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 01:28, @gisvlasta - Cleaned Xml Serialization Attributes.
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
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_Usage", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_Usage", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Usage")]
  public class MD_Usage : Model {

    #region Cosntructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Usage"/>.
    /// </summary>
    public MD_Usage() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _specificUsage = default;
      _usageDateTime = default; // TODO: What about DateTime? Should this be a null in a nullable property?
      _userDeterminedLimitations = default;
      _userContactInfo = default; // new List<CI_ResponsibleParty>();

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

    private string _specificUsage;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "specificUsage")]
    [JsonProperty("specificUsage", Order = 0)]
    public string SpecificUsage {
      get {
        return _specificUsage;
      }
      set {
        if (_specificUsage == value) {
          return;
        }
        if (_specificUsage == null || _specificUsage.Equals(value) != true) {
          _specificUsage = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTime _usageDateTime;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "usageDateTime")]
    [RequiredAttribute()]
    [JsonProperty("usageDateTime", Order = 1)]
    public DateTime UsageDateTime {
      get {
        return _usageDateTime;
      }
      set {
        if (_usageDateTime.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "UsageDateTime";
          Validator.ValidateProperty(value, validatorPropContext);
          _usageDateTime = value;
          OnPropertyChanged();
        }
      }
    }

    private string _userDeterminedLimitations;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "userDeterminedLimitations")]
    [JsonProperty("userDeterminedLimitations", Order = 2)]
    public string UserDeterminedLimitations {
      get {
        return _userDeterminedLimitations;
      }
      set {
        if (_userDeterminedLimitations == value) {
          return;
        }
        if (_userDeterminedLimitations == null || _userDeterminedLimitations.Equals(value) != true) {
          _userDeterminedLimitations = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_ResponsibleParty> _userContactInfo;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("userContactInfo", Order = 3, ElementName = "userContactInfo")]
    [JsonProperty("userContactInfo", Order = 3)]
    public List<CI_ResponsibleParty> UserContactInfo {
      get {
        return _userContactInfo;
      }
      set {
        if (_userContactInfo == value) {
          return;
        }
        if (_userContactInfo == null || _userContactInfo.Equals(value) != true) {
          _userContactInfo = value;
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
