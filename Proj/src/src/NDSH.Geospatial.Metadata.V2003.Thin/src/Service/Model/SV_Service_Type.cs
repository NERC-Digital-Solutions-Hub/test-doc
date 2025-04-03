
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 19:36, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
  [XmlType("SV_Service", Namespace = "http://www.isotc211.org/2005/srv")]
  [XmlRoot("SV_Service", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_Service")]
  public class SV_Service_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Service_Type"/>.
    /// </summary>
    public SV_Service_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _specification = default; // new List<SV_PlatformSpecificServiceSpecification_PropertyType>();
      _theSV_Port = default; // new List<SV_Port_PropertyType>();

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

    private List<SV_PlatformSpecificServiceSpecification_PropertyType> _specification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("specification", Order = 0)]
    [JsonProperty("specification", Order = 0)]
    public List<SV_PlatformSpecificServiceSpecification_PropertyType> Specification {
      get {
        return _specification;
      }
      set {
        if (_specification == value) {
          return;
        }
        if (_specification == null || _specification.Equals(value) != true) {
          _specification = value;
          OnPropertyChanged();
        }
      }
    }

    private List<SV_Port_PropertyType> _theSV_Port;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("theSV_Port", Order = 1)]
    [JsonProperty("theSV_Port", Order = 1)]
    public List<SV_Port_PropertyType> TheSV_Port {
      get {
        return _theSV_Port;
      }
      set {
        if (_theSV_Port == value) {
          return;
        }
        if (_theSV_Port == null || _theSV_Port.Equals(value) != true) {
          _theSV_Port = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
