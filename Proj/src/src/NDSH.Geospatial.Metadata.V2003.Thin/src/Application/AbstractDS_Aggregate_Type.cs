
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 04:25, @gisvlasta.
// Updated by        : 09/01/2023, 15:27, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.EntitySet;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Application {

  /// <summary>
  /// Identifiable collection of datasets.
  /// </summary>
  [XmlInclude(typeof(DS_Initiative_Type))]
  [XmlInclude(typeof(DS_Series_Type))]
  [XmlInclude(typeof(DS_ProductionSeries_Type))]
  [XmlInclude(typeof(DS_Sensor_Type))]
  [XmlInclude(typeof(DS_Platform_Type))]
  [XmlInclude(typeof(DS_OtherAggregate_Type))]
  [XmlInclude(typeof(DS_StereoMate_Type))]
  [XmlInclude(typeof(MX_Aggregate_Type))]
  [Serializable]
  [XmlType("AbstractDS_Aggregate", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("AbstractDS_Aggregate", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractDS_Aggregate")]
  public abstract class AbstractDS_Aggregate_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractDS_Aggregate_Type"/>.
    /// </summary>
    public AbstractDS_Aggregate_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _composedOf  = default; //  new List<DS_DataSet_PropertyType>();
      _seriesMetadata  = default; //  new List<MD_Metadata_PropertyType>();
      _subset  = default; //  new List<DS_Aggregate_PropertyType>();
      _superset  = default; //  new List<DS_Aggregate_PropertyType>();
      
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

    private List<DS_DataSet_PropertyType> _composedOf;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("composedOf", Order = 0)]
    [JsonProperty("composedOf", Order = 0)]
    public List<DS_DataSet_PropertyType> ComposedOf {
      get {
        return _composedOf;
      }
      set {
        if (_composedOf == value) {
          return;
        }
        if (_composedOf == null || _composedOf.Equals(value) != true) {
          _composedOf = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Metadata_PropertyType> _seriesMetadata;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("seriesMetadata", Order = 1)]
    [JsonProperty("seriesMetadata", Order = 1)]
    public List<MD_Metadata_PropertyType> SeriesMetadata {
      get {
        return _seriesMetadata;
      }
      set {
        if (_seriesMetadata == value) {
          return;
        }
        if (_seriesMetadata == null || _seriesMetadata.Equals(value) != true) {
          _seriesMetadata = value;
          OnPropertyChanged();
        }
      }
    }

    private List<DS_Aggregate_PropertyType> _subset;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("subset", Order = 2)]
    [JsonProperty("subset", Order = 2)]
    public List<DS_Aggregate_PropertyType> Subset {
      get {
        return _subset;
      }
      set {
        if (_subset == value) {
          return;
        }
        if (_subset == null || _subset.Equals(value) != true) {
          _subset = value;
          OnPropertyChanged();
        }
      }
    }

    private List<DS_Aggregate_PropertyType> _superset;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("superset", Order = 3)]
    [JsonProperty("superset", Order = 3)]
    public List<DS_Aggregate_PropertyType> Superset {
      get {
        return _superset;
      }
      set {
        if (_superset == value) {
          return;
        }
        if (_superset == null || _superset.Equals(value) != true) {
          _superset = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}