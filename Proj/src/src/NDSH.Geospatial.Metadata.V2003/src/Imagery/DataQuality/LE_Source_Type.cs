
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/01/2023, 01:58, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.DataQuality.Lineage;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.DataQuality {

  /// <summary>
  /// Information on source of data sets for processing step.
  /// </summary>
  /// <remarks>ShortName: SrcDataset</remarks>
  [Serializable]
  [XmlType("LE_Source", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("LE_Source", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("LE_Source")]
  public class LE_Source_Type : LI_Source_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_Source_Type"/>
    /// </summary>
    public LE_Source_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _processedLevel = default; // new MD_Identifier_PropertyType();
      _resolution = default; // new LE_NominalResolution_PropertyType();

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

    private MD_Identifier_PropertyType _processedLevel;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("processedLevel", Order = 0)]
    [JsonProperty("processedLevel", Order = 0)]
    public MD_Identifier_PropertyType ProcessedLevel {
      get {
        return _processedLevel;
      }
      set {
        if (_processedLevel == value) {
          return;
        }
        if (_processedLevel == null || _processedLevel.Equals(value) != true) {
          _processedLevel = value;
          OnPropertyChanged();
        }
      }
    }

    private LE_NominalResolution_PropertyType _resolution;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("resolution", Order = 1)]
    [JsonProperty("resolution", Order = 1)]
    public LE_NominalResolution_PropertyType Resolution {
      get {
        return _resolution;
      }
      set {
        if (_resolution == value) {
          return;
        }
        if (_resolution == null || _resolution.Equals(value) != true) {
          _resolution = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
