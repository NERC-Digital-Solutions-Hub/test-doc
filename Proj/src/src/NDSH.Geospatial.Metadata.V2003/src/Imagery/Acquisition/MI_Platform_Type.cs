
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:32, @gisvlasta.
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
  /// Designations for the platform used to acquire the dataset.
  /// </summary>
  /// <remarks>ShortName: PltfrmId</remarks>
  [XmlType("MI_Platform", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Platform", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Platform")]
  public class MI_Platform_Type : AbstractObject_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Platform_Type"/>.
    /// </summary>
    public MI_Platform_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _citation = default; // new CI_Citation_PropertyType();
      _identifier = default; // new MD_Identifier_PropertyType();
      _description = default; // new CharacterString_PropertyType();
      _sponsor = default; // new CI_ResponsibleParty_PropertyType();
      _instrument = default; // new MI_Instrument_PropertyType();

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

    private CharacterString_PropertyType _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 2)]
    [JsonProperty("description", Order = 2)]
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

    private List<CI_ResponsibleParty_PropertyType> _sponsor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sponsor", Order = 3)]
    [JsonProperty("sponsor", Order = 3)]
    public List<CI_ResponsibleParty_PropertyType> Sponsor {
      get {
        return _sponsor;
      }
      set {
        if (_sponsor == value) {
          return;
        }
        if (_sponsor == null || _sponsor.Equals(value) != true) {
          _sponsor = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_Instrument_PropertyType> _instrument;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("instrument", Order = 4)]
    [JsonProperty("instrument", Order = 4)]
    public List<MI_Instrument_PropertyType> Instrument {
      get {
        return _instrument;
      }
      set {
        if (_instrument == value) {
          return;
        }
        if (_instrument == null || _instrument.Equals(value) != true) {
          _instrument = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
