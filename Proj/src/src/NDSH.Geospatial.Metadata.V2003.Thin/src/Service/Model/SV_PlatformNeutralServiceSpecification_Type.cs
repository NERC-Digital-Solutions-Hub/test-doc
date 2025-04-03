
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 18:22, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

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
  [XmlType("SV_PlatformNeutralServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv")]
  [XmlRoot("SV_PlatformNeutralServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_PlatformNeutralServiceSpecification")]
  public class SV_PlatformNeutralServiceSpecification_Type : AbstractSV_AbstractServiceSpecification_Type {

    #region Constructors =- Destructors

    /// <summary>
    /// Initializes the <see cref="SV_PlatformNeutralServiceSpecification_Type"/>.
    /// </summary>
    public SV_PlatformNeutralServiceSpecification_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _serviceType = default; // new SV_ServiceType_PropertyType();
      _implSpec = default; // new List<SV_PlatformSpecificServiceSpecification_PropertyType>();

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

    private SV_ServiceType_PropertyType _serviceType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("serviceType", Order = 0)]
    [JsonProperty("serviceType", Order = 0)]
    public SV_ServiceType_PropertyType ServiceType {
      get {
        return _serviceType;
      }
      set {
        if (_serviceType == value) {
          return;
        }
        if (_serviceType == null || _serviceType.Equals(value) != true) {
          _serviceType = value;
          OnPropertyChanged();
        }
      }
    }

    private List<SV_PlatformSpecificServiceSpecification_PropertyType> _implSpec;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("implSpec", Order = 1)]
    [JsonProperty("implSpec", Order = 1)]
    public List<SV_PlatformSpecificServiceSpecification_PropertyType> ImplSpec {
      get {
        return _implSpec;
      }
      set {
        if (_implSpec == value) {
          return;
        }
        if (_implSpec == null || _implSpec.Equals(value) != true) {
          _implSpec = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
