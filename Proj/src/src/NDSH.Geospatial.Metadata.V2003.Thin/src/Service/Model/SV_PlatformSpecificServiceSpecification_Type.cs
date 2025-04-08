
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 18:33, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_PlatformSpecificServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv")]
  [XmlRoot("SV_PlatformSpecificServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_PlatformSpecificServiceSpecification")]
  public class SV_PlatformSpecificServiceSpecification_Type : AbstractSV_AbstractServiceSpecification_Type {

    #region Constructors =- Destructors

    /// <summary>
    /// Initializes the <see cref="SV_PlatformSpecificServiceSpecification_Type"/>.
    /// </summary>
    public SV_PlatformSpecificServiceSpecification_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _DCP = default; // = new DCPList_PropertyType();
      _typeSpec = default; // = new SV_PlatformNeutralServiceSpecification_PropertyType();
      _implementation = default; // = new List<SV_Service_PropertyType>();
      
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

    private DCPList_PropertyType _DCP;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DCP", Order = 0)]
    [JsonProperty("DCP", Order = 0)]
    public DCPList_PropertyType DCP {
      get {
        return _DCP;
      }
      set {
        if (_DCP == value) {
          return;
        }
        if (_DCP == null || _DCP.Equals(value) != true) {
          _DCP = value;
          OnPropertyChanged();
        }
      }
    }

    private SV_PlatformNeutralServiceSpecification_PropertyType _typeSpec;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("typeSpec", Order = 1)]
    [JsonProperty("typeSpec", Order = 1)]
    public SV_PlatformNeutralServiceSpecification_PropertyType TypeSpec {
      get {
        return _typeSpec;
      }
      set {
        if (_typeSpec == value) {
          return;
        }
        if (_typeSpec == null || _typeSpec.Equals(value) != true) {
          _typeSpec = value;
          OnPropertyChanged();
        }
      }
    }

    private List<SV_Service_PropertyType> _implementation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("implementation", Order = 2)]
    [JsonProperty("implementation", Order = 2)]
    public List<SV_Service_PropertyType> Implementation {
      get {
        return _implementation;
      }
      set {
        if (_implementation == value) {
          return;
        }
        if (_implementation == null || _implementation.Equals(value) != true) {
          _implementation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
