
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 03:36, @gisvlasta.
// Updated by        : 09/01/2023, 18:40, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent;
using NDSH.Geospatial.Metadata.V2003.Thin.Maintenance;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_Scope", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("DQ_Scope", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DQ_Scope")]
  public class DQ_Scope_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_Scope_Type"/>.
    /// </summary>
    public DQ_Scope_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _level  = default; //  new MD_ScopeCode_PropertyType();
      _extent  = default; //  new EX_Extent_PropertyType();
      _levelDescription  = default; //  new List<MD_ScopeDescription_PropertyType>();
      
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

    private MD_ScopeCode_PropertyType _level;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("level", Order = 0)]
    [JsonProperty("level", Order = 0)]
    public MD_ScopeCode_PropertyType Level {
      get {
        return _level;
      }
      set {
        if (_level == value) {
          return;
        }
        if (_level == null || _level.Equals(value) != true) {
          _level = value;
          OnPropertyChanged();
        }
      }
    }

    private EX_Extent_PropertyType _extent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("extent", Order = 1)]
    [JsonProperty("extent", Order = 1)]
    public EX_Extent_PropertyType Extent {
      get {
        return _extent;
      }
      set {
        if (_extent == value) {
          return;
        }
        if (_extent == null || _extent.Equals(value) != true) {
          _extent = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_ScopeDescription_PropertyType> _levelDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("levelDescription", Order = 2)]
    [JsonProperty("levelDescription", Order = 2)]
    public List<MD_ScopeDescription_PropertyType> LevelDescription {
      get {
        return _levelDescription;
      }
      set {
        if (_levelDescription == value) {
          return;
        }
        if (_levelDescription == null || _levelDescription.Equals(value) != true) {
          _levelDescription = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}