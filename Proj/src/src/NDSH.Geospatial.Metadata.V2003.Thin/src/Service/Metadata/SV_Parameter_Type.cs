
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 02:28, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Names;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Truth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_Parameter", Namespace = "http://www.isotc211.org/2005/srv")]
  [XmlRoot("SV_Parameter", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_Parameter")]
  public class SV_Parameter_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Parameter_Type"/>.
    /// </summary>
    public SV_Parameter_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _name = default; // new MemberName_Type();
      _direction = default; // new SV_ParameterDirection_PropertyType();
      _description = default; // new CharacterString_PropertyType();
      _optionality = default; // new CharacterString_PropertyType();
      _repeatability = default; // new Boolean_PropertyType();
      _valueType = default; // new TypeName_PropertyType();

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

    private MemberName_Type _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public MemberName_Type Name {
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

    private SV_ParameterDirection_PropertyType _direction;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("direction", Order = 1)]
    [JsonProperty("direction", Order = 1)]
    public SV_ParameterDirection_PropertyType Direction {
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

    private CharacterString _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 2)]
    [JsonProperty("description", Order = 2)]
    public CharacterString Description {
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

    private CharacterString _optionality;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("optionality", Order = 3)]
    [JsonProperty("optionality", Order = 3)]
    public CharacterString Optionality {
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

    private Boolean_PropertyType _repeatability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("repeatability", Order = 4)]
    [JsonProperty("repeatability", Order = 4)]
    public Boolean_PropertyType Repeatability {
      get {
        return _repeatability;
      }
      set {
        if (_repeatability == value) {
          return;
        }
        if (_repeatability == null || _repeatability.Equals(value) != true) {
          _repeatability = value;
          OnPropertyChanged();
        }
      }
    }

    private TypeName_PropertyType _valueType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("valueType", Order = 5)]
    [JsonProperty("valueType", Order = 5)]
    public TypeName_PropertyType ValueType {
      get {
        return _valueType;
      }
      set {
        if (_valueType == value) {
          return;
        }
        if (_valueType == null || _valueType.Equals(value) != true) {
          _valueType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
