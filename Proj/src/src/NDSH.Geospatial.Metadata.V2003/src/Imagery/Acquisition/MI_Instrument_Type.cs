
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:21, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Acquisition {

  /// <summary>
  /// Designations for the measuring instruments.
  /// </summary>
  /// <remarks>
  /// <para>FGDC: Platform_and_Instrument_Identification</para>
  /// <para>ShortName: PltfrmInstId</para>
  /// </remarks>
  [XmlType("MI_Instrument", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Instrument", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Instrument")]
  public class MI_Instrument_Type : AbstractObject_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Instrument_Type"/>.
    /// </summary>
    public MI_Instrument_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _citation = default; // new CI_Citation_PropertyType();
      _identifier = default; // new MD_Identifier_PropertyType();
      _type = default; // new CharacterString_PropertyType();
      _description = default; // new CharacterString_PropertyType();
      _mountedOn = default; // new MI_Platform_PropertyType();

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
    
    private List<CI_Citation_PropertyType> _citation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("citation", Order = 0)]
    [JsonProperty("citation", Order = 0)]
    public List<CI_Citation_PropertyType> Citation {
      get {
        return _citation;
      }
      set {
        if (_citation == value) {
          return;
        }
        if (_citation == null || _citation.Equals(value) != true) {
          _citation = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_Identifier_PropertyType _identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 1)]
    [JsonProperty("identifier", Order = 1)]
    public MD_Identifier_PropertyType Identifier {
      get {
        return _identifier;
      }
      set {
        if (_identifier == value) {
          return;
        }
        if (_identifier == null || _identifier.Equals(value) != true) {
          _identifier = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("type", Order = 2)]
    [JsonProperty("type", Order = 2)]
    public CharacterString_PropertyType Type {
      get {
        return _type;
      }
      set {
        if (_type == value) {
          return;
        }
        if (_type == null || _type.Equals(value) != true) {
          _type = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 3)]
    [JsonProperty("description", Order = 3)]
    public CharacterString_PropertyType Description {
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

    private MI_Platform_PropertyType _mountedOn;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("mountedOn", Order = 4)]
    [JsonProperty("mountedOn", Order = 4)]
    public MI_Platform_PropertyType MountedOn {
      get {
        return _mountedOn;
      }
      set {
        if (_mountedOn == value) {
          return;
        }
        if (_mountedOn == null || _mountedOn.Equals(value) != true) {
          _mountedOn = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}