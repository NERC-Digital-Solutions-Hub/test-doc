
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 21:18, @gisvlasta.
// Updated by        : 10/01/2023, 01:01, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Application;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MX_Aggregate", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("MX_Aggregate", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("MX_Aggregate")]
  public class MX_Aggregate_Type : AbstractDS_Aggregate_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_Aggregate_Type"/>.
    /// </summary>
    public MX_Aggregate_Type() {

      // Override the namespace. (It is different from that of AbstractDS_Aggregate_Type).
      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _aggregateCatalogue  = default; //  new List<CT_Catalogue_PropertyType>();
      _aggregateFile  = default; //  new List<MX_SupportFile_PropertyType>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public new XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<CT_Catalogue_PropertyType> _aggregateCatalogue;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("aggregateCatalogue", Order = 0)]
    [JsonProperty("aggregateCatalogue", Order = 0)]
    public List<CT_Catalogue_PropertyType> AggregateCatalogue {
      get {
        return _aggregateCatalogue;
      }
      set {
        if (_aggregateCatalogue == value) {
          return;
        }
        if (_aggregateCatalogue == null || _aggregateCatalogue.Equals(value) != true) {
          _aggregateCatalogue = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MX_SupportFile_PropertyType> _aggregateFile;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("aggregateFile", Order = 1)]
    [JsonProperty("aggregateFile", Order = 1)]
    public List<MX_SupportFile_PropertyType> AggregateFile {
      get {
        return _aggregateFile;
      }
      set {
        if (_aggregateFile == value) {
          return;
        }
        if (_aggregateFile == null || _aggregateFile.Equals(value) != true) {
          _aggregateFile = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
