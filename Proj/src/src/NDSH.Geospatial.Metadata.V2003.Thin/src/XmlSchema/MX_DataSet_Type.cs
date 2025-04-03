
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 00:01, @gisvlasta.
// Updated by        : 10/01/2023, 01:09, @gisvlasta. - 1.0.1: Added xmlns field.
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
  [XmlType("MX_DataSet", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("MX_DataSet", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("MX_DataSet")]
  public class MX_DataSet_Type : DS_DataSet_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_DataSet_Type"/>.
    /// </summary>
    public MX_DataSet_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _dataFile  = default; //  new List<MX_DataFile_PropertyType>();
      _datasetCatalogue  = default; //  new List<CT_Catalogue_PropertyType>();
      _supportFile  = default; //  new List<MX_SupportFile_PropertyType>();

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

    private List<MX_DataFile_PropertyType> _dataFile;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dataFile", Order = 0)]
    [JsonProperty("dataFile", Order = 0)]
    public List<MX_DataFile_PropertyType> DataFile {
      get {
        return _dataFile;
      }
      set {
        if (_dataFile == value) {
          return;
        }
        if (_dataFile == null || _dataFile.Equals(value) != true) {
          _dataFile = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CT_Catalogue_PropertyType> _datasetCatalogue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("datasetCatalogue", Order = 1)]
    [JsonProperty("datasetCatalogue", Order = 1)]
    public List<CT_Catalogue_PropertyType> DatasetCatalogue {
      get {
        return _datasetCatalogue;
      }
      set {
        if (_datasetCatalogue == value) {
          return;
        }
        if (_datasetCatalogue == null || _datasetCatalogue.Equals(value) != true) {
          _datasetCatalogue = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MX_SupportFile_PropertyType> _supportFile;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("supportFile", Order = 2)]
    [JsonProperty("supportFile", Order = 2)]
    public List<MX_SupportFile_PropertyType> SupportFile {
      get {
        return _supportFile;
      }
      set {
        if (_supportFile == value) {
          return;
        }
        if (_supportFile == null || _supportFile.Equals(value) != true) {
          _supportFile = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
