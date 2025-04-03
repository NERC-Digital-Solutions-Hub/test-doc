
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 17:58, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Names;
using NDSH.Geospatial.Metadata.V2003.Service.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_Operation", Namespace = "http://www.isotc211.org/2005/srv")]
  [XmlRoot("SV_Operation", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_Operation")]
  public  class SV_Operation_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Operation_Type"/>.
    /// </summary>
    public SV_Operation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _operationName = default; //new MemberName_PropertyType();
      _dependsOn = default; //new List<SV_Operation_PropertyType>();
      _parameter = default; //new SV_Parameter_PropertyType();

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

    private MemberName_PropertyType _operationName;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("operationName", Order = 0)]
    [JsonProperty("operationName", Order = 0)]
    public MemberName_PropertyType OperationName {
      get {
        return _operationName;
      }
      set {
        if (_operationName == value) {
          return;
        }
        if (_operationName == null || _operationName.Equals(value) != true) {
          _operationName = value;
          OnPropertyChanged();
        }
      }
    }

    private List<SV_Operation_PropertyType> _dependsOn;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dependsOn", Order = 1)]
    [JsonProperty("dependsOn", Order = 1)]
    public List<SV_Operation_PropertyType> DependsOn {
      get {
        return _dependsOn;
      }
      set {
        if (_dependsOn == value) {
          return;
        }
        if (_dependsOn == null || _dependsOn.Equals(value) != true) {
          _dependsOn = value;
          OnPropertyChanged();
        }
      }
    }

    private SV_Parameter_PropertyType _parameter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("parameter", Order = 2)]
    [JsonProperty("parameter", Order = 2)]
    public SV_Parameter_PropertyType Parameter {
      get {
        return _parameter;
      }
      set {
        if (_parameter == value) {
          return;
        }
        if (_parameter == null || _parameter.Equals(value) != true) {
          _parameter = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
