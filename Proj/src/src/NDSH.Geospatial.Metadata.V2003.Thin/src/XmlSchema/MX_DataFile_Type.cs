
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 21:27, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Names;
using NDSH.Geospatial.Metadata.V2003.Thin.Distribution;
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
  [XmlType("MX_DataFile", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("MX_DataFile", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("MX_DataFile")]
  public class MX_DataFile_Type : AbstractMX_File_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_DataFile_Type"/>.
    /// </summary>
    public MX_DataFile_Type() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _featureTypes  = default; //  new List<GenericName_PropertyType>();
      _fileFormat  = default; //  new MD_Format_PropertyType();

    }

    #endregion

    #region Public Fields

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlNamespaceDeclarations()]
    //public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<GenericName_PropertyType> _featureTypes;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("featureTypes", Order = 0)]
    [JsonProperty("featureTypes", Order = 0)]
    public List<GenericName_PropertyType> FeatureTypes {
      get {
        return _featureTypes;
      }
      set {
        if (_featureTypes == value) {
          return;
        }
        if (_featureTypes == null || _featureTypes.Equals(value) != true) {
          _featureTypes = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_Format_PropertyType _fileFormat;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileFormat", Order = 1)]
    [JsonProperty("fileFormat", Order = 1)]
    public MD_Format_PropertyType FileFormat {
      get {
        return _fileFormat;
      }
      set {
        if (_fileFormat == value) {
          return;
        }
        if (_fileFormat == null || _fileFormat.Equals(value) != true) {
          _fileFormat = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
