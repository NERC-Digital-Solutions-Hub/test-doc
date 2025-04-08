
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 04:37, @gisvlasta.
// Updated by        : 09/01/2023, 15:27, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.EntitySet;
using NDSH.Geospatial.Metadata.V2003.XmlSchema;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Application {

  /// <summary>
  /// Identifiable collection of data.
  /// </summary>
  [XmlInclude(typeof(MX_DataSet_Type))]
  [Serializable]
  [XmlType("DS_DataSet", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("DS_DataSet", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DS_DataSet")]
  public class DS_DataSet_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DS_DataSet_Type"/>.
    /// </summary>
    public DS_DataSet_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");
      
      _has  = default; //  new List<MD_Metadata_PropertyType>();
      _partOf  = default; //  new List<DS_Aggregate_PropertyType>();
      
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

    private List<MD_Metadata_PropertyType> _has;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("has", Order = 0)]
    [JsonProperty("has", Order = 0)]
    public List<MD_Metadata_PropertyType> Has {
      get {
        return _has;
      }
      set {
        if (_has == value) {
          return;
        }
        if (_has == null || _has.Equals(value) != true) {
          _has = value;
          OnPropertyChanged();
        }
      }
    }

    private List<DS_Aggregate_PropertyType> _partOf;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("partOf", Order = 1)]
    [JsonProperty("partOf", Order = 1)]
    public List<DS_Aggregate_PropertyType> PartOf {
      get {
        return _partOf;
      }
      set {
        if (_partOf == value) {
          return;
        }
        if (_partOf == null || _partOf.Equals(value) != true) {
          _partOf = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
