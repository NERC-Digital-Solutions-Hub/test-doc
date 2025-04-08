
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 00:40, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using NDSH.Geospatial.Metadata.V2005.ReferenceSystem;
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

namespace NDSH.Geospatial.Metadata.V2005.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_AggregateInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_AggregateInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_AggregateInformation")]
  public class MD_AggregateInformation : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_AggregateInformation"/>.
    /// </summary>
    public MD_AggregateInformation() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _aggregateDatasetName = default;//new CI_Citation();
      _aggregateDataSetIdentifier = default;//new Parent_MD_Identifier();
      _associationType = default; //new DS_AssociationTypeCode();
      _initiativeType = default; //new DS_InitiativeTypeCode();

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

    private CI_Citation _aggregateDatasetName;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "aggregateDatasetName")]
    [JsonProperty("aggregateDatasetName", Order = 0)]
    public CI_Citation AggregateDatasetName {
      get {
        return _aggregateDatasetName;
      }
      set {
        if (_aggregateDatasetName == value) {
          return;
        }
        if (_aggregateDatasetName == null || _aggregateDatasetName.Equals(value) != true) {
          _aggregateDatasetName = value;
          OnPropertyChanged();
        }
      }
    }

    private Parent_MD_Identifier _aggregateDataSetIdentifier;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "aggregateDataSetIdentifier")]
    [JsonProperty("aggregateDataSetIdentifier", Order = 1)]
    public Parent_MD_Identifier AggregateDataSetIdentifier {
      get {
        return _aggregateDataSetIdentifier;
      }
      set {
        if (_aggregateDataSetIdentifier == value) {
          return;
        }
        if (_aggregateDataSetIdentifier == null || _aggregateDataSetIdentifier.Equals(value) != true) {
          _aggregateDataSetIdentifier = value;
          OnPropertyChanged();
        }
      }
    }

    private DS_AssociationTypeCode _associationType;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "associationType")]
    [JsonProperty("associationType", Order = 2)]
    public DS_AssociationTypeCode AssociationType {
      get {
        return _associationType;
      }
      set {
        if (_associationType == value) {
          return;
        }
        if (_associationType == null || _associationType.Equals(value) != true) {
          _associationType = value;
          OnPropertyChanged();
        }
      }
    }

    private DS_InitiativeTypeCode _initiativeType;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "initiativeType")]
    [JsonProperty("initiativeType", Order = 3)]
    public DS_InitiativeTypeCode InitiativeType {
      get {
        return _initiativeType;
      }
      set {
        if (_initiativeType == value) {
          return;
        }
        if (_initiativeType == null || _initiativeType.Equals(value) != true) {
          _initiativeType = value;
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
