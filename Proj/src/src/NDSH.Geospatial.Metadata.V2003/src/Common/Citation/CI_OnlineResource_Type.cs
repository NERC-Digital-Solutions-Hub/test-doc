
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common.Citation {

  /// <summary>
  /// Information about online sources from which the dataset, specification,
  /// or community profile name and extended metadata elements can be obtained.
  /// </summary>
  [Serializable]
  [XmlType("CI_OnlineResource", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("CI_OnlineResource", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_OnlineResource")]
  public class CI_OnlineResource_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_OnlineResource_Type"/>.
    /// </summary>
    public CI_OnlineResource_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _linkage = default; //  new URL_PropertyType();
      _protocol = default; //  new CharacterString_PropertyType();
      _applicationProfile = default; //  new CharacterString_PropertyType();
      _name = default; //  new CharacterString_PropertyType();
      _description = default; //  new CharacterString_PropertyType();
      _function = default; //  new CI_OnLineFunctionCode_PropertyType();

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

    private URL_PropertyType _linkage;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("linkage", Order = 0)]
    [JsonProperty("linkage", Order = 0)]
    public URL_PropertyType Linkage {
      get => _linkage;
      set {
        if (_linkage == value) {
          return;
        }
        if (_linkage == null || !_linkage.Equals(value)) {
          _linkage = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _protocol;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("protocol", Order = 1)]
    [JsonProperty("protocol", Order = 1)]
    public CharacterString_PropertyType Protocol {
      get => _protocol;
      set {
        if (_protocol == value) {
          return;
        }
        if (_protocol == null || !_protocol.Equals(value)) {
          _protocol = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _applicationProfile;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("applicationProfile", Order = 2)]
    [JsonProperty("applicationProfile", Order = 2)]
    public CharacterString_PropertyType ApplicationProfile {
      get => _applicationProfile;
      set {
        if (_applicationProfile == value) {
          return;
        }
        if (_applicationProfile == null || !_applicationProfile.Equals(value)) {
          _applicationProfile = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 3)]
    [JsonProperty("name", Order = 3)]
    public CharacterString_PropertyType Name {
      get => _name;
      set {
        if (_name == value) {
          return;
        }
        if (_name == null || !_name.Equals(value)) {
          _name = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 4)]
    [JsonProperty("description", Order = 4)]
    public CharacterString_PropertyType Description {
      get => _description;
      set {
        if (_description == value) {
          return;
        }
        if (_description == null || !_description.Equals(value)) {
          _description = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_OnLineFunctionCode_PropertyType _function;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("function", Order = 5)]
    [JsonProperty("function", Order = 5)]
    public CI_OnLineFunctionCode_PropertyType Function {
      get => _function;
      set {
        if (_function == value) {
          return;
        }
        if (_function == null || !_function.Equals(value)) {
          _function = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
