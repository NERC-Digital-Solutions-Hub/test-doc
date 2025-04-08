
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 02:43, @gisvlasta.
// Updated by        : 15/01/2022, 02:57, @gisvlasta.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common.Extent;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Names;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Constraint;
using NDSH.Geospatial.Metadata.V2003.Distribution;
using NDSH.Geospatial.Metadata.V2003.Identification;
using NDSH.Geospatial.Metadata.V2003.Service.Model;
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

namespace NDSH.Geospatial.Metadata.V2003.Service.Metadata {

  /// <summary>
  /// See 19119 for further info.
  /// </summary>
  // TODO: Add Documentation from 19119.
  [Serializable]
  [XmlType("SV_ServiceIdentification", Namespace = "http://www.isotc211.org/2005/srv")]
  [XmlRoot("SV_ServiceIdentification", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_ServiceIdentification")]
  public class SV_ServiceIdentification_Type : AbstractMD_Identification_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_ServiceIdentification_Type"/>
    /// </summary>
    public SV_ServiceIdentification_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _serviceType = default; // new GenericName_PropertyType();
      _serviceTypeVersion = default; // new List<CharacterString_PropertyType>();
      _accessProperties = default; // new MD_StandardOrderProcess_PropertyType();
      _restrictions = default; // new List<MD_Constraints_PropertyType>();
      _keywords = default; // new List<MD_Keywords_PropertyType>();
      _extent = default; // new List<EX_Extent_PropertyType>();
      _couplingType = default; // new SV_CouplingType_PropertyType();
      _coupledResource = default; // new List<SV_CoupledResource_PropertyType>();
      _containsOperations = default; // new List<SV_OperationMetadata_PropertyType>();
      _operatesOn = default; // new List<MD_DataIdentification_PropertyType>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public new XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properits

    private GenericName_PropertyType _serviceType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("serviceType", Order = 0)]
    [JsonProperty("serviceType", Order = 0)]
    public GenericName_PropertyType ServiceType {
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

    private List<CharacterString_PropertyType> _serviceTypeVersion;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("serviceTypeVersion", Order = 1)]
    [JsonProperty("serviceTypeVersion", Order = 1)]
    public List<CharacterString_PropertyType> ServiceTypeVersion {
      get {
        return _serviceTypeVersion;
      }
      set {
        if (_serviceTypeVersion == value) {
          return;
        }
        if (_serviceTypeVersion == null || _serviceTypeVersion.Equals(value) != true) {
          _serviceTypeVersion = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_StandardOrderProcess_PropertyType _accessProperties;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("accessProperties", Order = 2)]
    [JsonProperty("accessProperties", Order = 2)]
    public MD_StandardOrderProcess_PropertyType AccessProperties {
      get {
        return _accessProperties;
      }
      set {
        if (_accessProperties == value) {
          return;
        }
        if (_accessProperties == null || _accessProperties.Equals(value) != true) {
          _accessProperties = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Constraints_PropertyType> _restrictions;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("restrictions", Order = 3)]
    [JsonProperty("restrictions", Order = 3)]
    public List<MD_Constraints_PropertyType> Restrictions {
      get {
        return _restrictions;
      }
      set {
        if (_restrictions == value) {
          return;
        }
        if (_restrictions == null || _restrictions.Equals(value) != true) {
          _restrictions = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Keywords_PropertyType> _keywords;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("keywords", Order = 4)]
    [JsonProperty("keywords", Order = 4)]
    public List<MD_Keywords_PropertyType> Keywords {
      get {
        return _keywords;
      }
      set {
        if (_keywords == value) {
          return;
        }
        if (_keywords == null || _keywords.Equals(value) != true) {
          _keywords = value;
          OnPropertyChanged();
        }
      }
    }

    private List<EX_Extent_PropertyType> _extent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("extent", Order = 5)]
    [JsonProperty("extent", Order = 5)]
    public List<EX_Extent_PropertyType> Extent {
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

    private SV_CouplingType_PropertyType _couplingType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("couplingType", Order = 6)]
    [JsonProperty("couplingType", Order = 6)]
    public SV_CouplingType_PropertyType CouplingType {
      get {
        return _couplingType;
      }
      set {
        if (_couplingType == value) {
          return;
        }
        if (_couplingType == null || _couplingType.Equals(value) != true) {
          _couplingType = value;
          OnPropertyChanged();
        }
      }
    }

    private List<SV_CoupledResource_PropertyType> _coupledResource;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("coupledResource", Order = 7)]
    [JsonProperty("coupledResource", Order = 7)]
    public List<SV_CoupledResource_PropertyType> CoupledResource {
      get {
        return _coupledResource;
      }
      set {
        if (_coupledResource == value) {
          return;
        }
        if (_coupledResource == null || _coupledResource.Equals(value) != true) {
          _coupledResource = value;
          OnPropertyChanged();
        }
      }
    }

    private List<SV_OperationMetadata_PropertyType> _containsOperations;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("containsOperations", Order = 8)]
    [JsonProperty("containsOperations", Order = 8)]
    public List<SV_OperationMetadata_PropertyType> ContainsOperations {
      get {
        return _containsOperations;
      }
      set {
        if (_containsOperations == value) {
          return;
        }
        if (_containsOperations == null || _containsOperations.Equals(value) != true) {
          _containsOperations = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_DataIdentification_PropertyType> _operatesOn;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("operatesOn", Order = 9)]
    [JsonProperty("operatesOn", Order = 9)]
    public List<MD_DataIdentification_PropertyType> OperatesOn {
      get {
        return _operatesOn;
      }
      set {
        if (_operatesOn == value) {
          return;
        }
        if (_operatesOn == null || _operatesOn.Equals(value) != true) {
          _operatesOn = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
