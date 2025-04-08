
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 19:56, @gisvlasta.
// Updated by        : 09/01/2023, 19:09, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Numerics;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Distribution {

  /// <summary>
  /// Information about the media on which the data can be distributed.
  /// </summary>
  [Serializable]
  [XmlType("MD_Medium", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Medium", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Medium")]
  public class MD_Medium_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Medium_Type"/>.
    /// </summary>
    public MD_Medium_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _name  = default; //  new MD_MediumNameCode_PropertyType();
      _density  = default; //  new List<Real_PropertyType>();
      _densityUnits  = default; //  new CharacterString_PropertyType();
      _volumes  = default; //  new Integer_PropertyType();
      _mediumFormat  = default; //  new List<MD_MediumFormatCode_PropertyType>();
      _mediumNote  = default; //  new CharacterString_PropertyType();

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

    private MD_MediumNameCode_PropertyType _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public MD_MediumNameCode_PropertyType Name {
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

    private List<Real_PropertyType> _density;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("density", Order = 1)]
    [JsonProperty("density", Order = 1)]
    public List<Real_PropertyType> Density {
      get {
        return _density;
      }
      set {
        if (_density == value) {
          return;
        }
        if (_density == null || _density.Equals(value) != true) {
          _density = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _densityUnits;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("densityUnits", Order = 2)]
    [JsonProperty("densityUnits", Order = 2)]
    public CharacterString DensityUnits {
      get {
        return _densityUnits;
      }
      set {
        if (_densityUnits == value) {
          return;
        }
        if (_densityUnits == null || _densityUnits.Equals(value) != true) {
          _densityUnits = value;
          OnPropertyChanged();
        }
      }
    }

    private Integer_PropertyType _volumes;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("volumes", Order = 3)]
    [JsonProperty("volumes", Order = 3)]
    public Integer_PropertyType Volumes {
      get {
        return _volumes;
      }
      set {
        if (_volumes == value) {
          return;
        }
        if (_volumes == null || _volumes.Equals(value) != true) {
          _volumes = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_MediumFormatCode_PropertyType> _mediumFormat;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("mediumFormat", Order = 4)]
    [JsonProperty("mediumFormat", Order = 4)]
    public List<MD_MediumFormatCode_PropertyType> MediumFormat {
      get {
        return _mediumFormat;
      }
      set {
        if (_mediumFormat == value) {
          return;
        }
        if (_mediumFormat == null || _mediumFormat.Equals(value) != true) {
          _mediumFormat = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _mediumNote;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("mediumNote", Order = 5)]
    [JsonProperty("mediumNote", Order = 5)]
    public CharacterString MediumNote {
      get {
        return _mediumNote;
      }
      set {
        if (_mediumNote == value) {
          return;
        }
        if (_mediumNote == null || _mediumNote.Equals(value) != true) {
          _mediumNote = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}