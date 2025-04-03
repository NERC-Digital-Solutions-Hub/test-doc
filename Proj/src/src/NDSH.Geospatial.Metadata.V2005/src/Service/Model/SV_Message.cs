
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Names;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false)]
  [JsonObject("SV_Message")]
  public class SV_Message : EntityBase<SV_Message> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Message"/>.
    /// </summary>
    public SV_Message() {
      _operationMetadata = new SV_OperationMetadata();
      _repeatability = new Boolean();
      _direction = new SV_ParameterDirection();
      _name = new MemberName();
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

    private MemberName _name;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "name")]
    [JsonProperty("name", Order = 0)]
    public MemberName Name {
      get {
        return _name;
      }
      set {
        if (_name == value) {
          return;
        }
        if (_name == null || _name.Equals(value) != true) {
          _name = value;
          OnPropertyChanged();
        }
      }
    }

    private SV_ParameterDirection _direction;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "direction")]
    [JsonProperty("direction", Order = 1)]
    public SV_ParameterDirection Direction {
      get {
        return _direction;
      }
      set {
        if (_direction == value) {
          return;
        }
        if (_direction == null || _direction.Equals(value) != true) {
          _direction = value;
          OnPropertyChanged();
        }
      }
    }

    private string _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "description")]
    [JsonProperty("description", Order = 2)]
    public string Description {
      get {
        return _description;
      }
      set {
        if (_description == value) {
          return;
        }
        if (_description == null || _description.Equals(value) != true) {
          _description = value;
          OnPropertyChanged();
        }
      }
    }

    private string _optionality;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "optionality")]
    [JsonProperty("optionality", Order = 3)]
    public string Optionality {
      get {
        return _optionality;
      }
      set {
        if (_optionality == value) {
          return;
        }
        if (_optionality == null || _optionality.Equals(value) != true) {
          _optionality = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean _repeatability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "repeatability")]
    [JsonProperty("repeatability", Order = 4)]
    public Boolean Repeatability {
      get {
        return _repeatability;
      }
      set {
        if (_repeatability == value) {
          return;
        }
        // TODO: (CS0472) Check out if the spec has a 'Nullable' property named 'repeatability'.
        if (_repeatability == null || _repeatability.Equals(value) != true) {
          _repeatability = value;
          OnPropertyChanged();
        }
      }
    }

    private SV_OperationMetadata _operationMetadata;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5, ElementName = "operationMetadata")]
    [JsonProperty("operationMetadata", Order = 5)]
    public SV_OperationMetadata OperationMetadata {
      get {
        return _operationMetadata;
      }
      set {
        if (_operationMetadata == value) {
          return;
        }
        if (_operationMetadata == null || _operationMetadata.Equals(value) != true) {
          _operationMetadata = value;
          OnPropertyChanged();
        }
      }
    }

    // TODO: MISSING id and uuid properties???

    #endregion

  }

}
