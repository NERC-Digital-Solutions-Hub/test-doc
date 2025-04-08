
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 01:42, @gisvlasta.
// Updated by        : 09/01/2023, 19:37, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Identification {

  /// <summary>
  /// Encapsulates the dataset aggregation information.
  /// </summary>
  [Serializable]
  [XmlType("MD_AggregateInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_AggregateInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_AggregateInformation")]
  public class MD_AggregateInformation_Type : AbstractObject_Type {

    #region Imported Namespaces 

    /// <summary>
    /// Initializes the <see cref="MD_AggregateInformation_Type"/>.
    /// </summary>
    public MD_AggregateInformation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _aggregateDataSetName  = default; //  new CI_Citation_PropertyType();
      _aggregateDataSetIdentifier  = default; //  new MD_Identifier_PropertyType();
      _associationType  = default; //  new DS_AssociationTypeCode_PropertyType();
      _initiativeType  = default; //  new DS_InitiativeTypeCode_PropertyType();

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

    private CI_Citation_PropertyType _aggregateDataSetName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("aggregateDataSetName", Order = 0)]
    [JsonProperty("aggregateDataSetName", Order = 0)]
    public CI_Citation_PropertyType AggregateDataSetName {
      get {
        return _aggregateDataSetName;
      }
      set {
        if (_aggregateDataSetName == value) {
          return;
        }
        if (_aggregateDataSetName == null || _aggregateDataSetName.Equals(value) != true) {
          _aggregateDataSetName = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_Identifier_PropertyType _aggregateDataSetIdentifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("aggregateDataSetIdentifier", Order = 1)]
    [JsonProperty("aggregateDataSetIdentifier", Order = 1)]
    public MD_Identifier_PropertyType AggregateDataSetIdentifier {
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

    private DS_AssociationTypeCode_PropertyType _associationType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("associationType", Order = 2)]
    [JsonProperty("associationType", Order = 2)]
    public DS_AssociationTypeCode_PropertyType AssociationType {
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

    private DS_InitiativeTypeCode_PropertyType _initiativeType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("initiativeType", Order = 3)]
    [JsonProperty("initiativeType", Order = 3)]
    public DS_InitiativeTypeCode_PropertyType InitiativeType {
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

    #endregion

  }

}
