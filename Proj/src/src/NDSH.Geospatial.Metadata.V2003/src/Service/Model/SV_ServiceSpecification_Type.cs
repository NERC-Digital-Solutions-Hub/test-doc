
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 20:09, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Names;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_ServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv")]
  [XmlRoot("SV_ServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_ServiceSpecification")]
  public class SV_ServiceSpecification_Type : AbstractSV_AbstractServiceSpecification_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_ServiceSpecification_Type"/>.
    /// </summary>
    public SV_ServiceSpecification_Type() {
      _typeSpec = default; //new List<SV_PlatformNeutralServiceSpecification_PropertyType>();
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

    private List<SV_PlatformNeutralServiceSpecification_PropertyType> _typeSpec;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("operationName", Order = 0)]
    [JsonProperty("operationName", Order = 0)]
    public List<SV_PlatformNeutralServiceSpecification_PropertyType> TypeSpec {
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

    #endregion

  }

}
