
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 03:12, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.Lineage;
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
  [XmlType("DQ_DataQuality", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("DQ_DataQuality", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DQ_DataQuality")]
  public class DQ_DataQuality_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_DataQuality_Type"/>.
    /// </summary>
    public DQ_DataQuality_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _scope  = default; //  new DQ_Scope_PropertyType();
      _report  = default; //  new List<DQ_Element_PropertyType>();
      _lineage  = default; //  new LI_Lineage_PropertyType();
      
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

    private DQ_Scope_PropertyType _scope;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("scope", Order = 0)]
    [JsonProperty("scope", Order = 0)]
    public DQ_Scope_PropertyType Scope {
      get {
        return _scope;
      }
      set {
        if (_scope == value) {
          return;
        }
        if (_scope == null || _scope.Equals(value) != true) {
          _scope = value;
          OnPropertyChanged();
        }
      }
    }

    private List<DQ_Element_PropertyType> _report;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("report", Order = 1)]
    [JsonProperty("report", Order = 1)]
    public List<DQ_Element_PropertyType> Report {
      get {
        return _report;
      }
      set {
        if (_report == value) {
          return;
        }
        if (_report == null || _report.Equals(value) != true) {
          _report = value;
          OnPropertyChanged();
        }
      }
    }

    private LI_Lineage_PropertyType _lineage;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("lineage", Order = 2)]
    [JsonProperty("lineage", Order = 2)]
    public LI_Lineage_PropertyType Lineage {
      get {
        return _lineage;
      }
      set {
        if (_lineage == value) {
          return;
        }
        if (_lineage == null || _lineage.Equals(value) != true) {
          _lineage = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}