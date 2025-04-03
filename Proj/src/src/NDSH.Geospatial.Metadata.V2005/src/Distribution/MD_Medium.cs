
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 03:09, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Derived.UnitsOfMeasure;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Distribution {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_Medium", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_Medium", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Medium")]
  public class MD_Medium : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Medium"/>.
    /// </summary>
    public MD_Medium() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _name = default; //new MD_MediumNameCode();
      _density = default; //new List<double>();
      _densityUnits = default;
      _volumes = default;
      _mediumFormat = default; //new List<MD_MediumFormatCode>();
      _mediumNote = default;

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

    private MD_MediumNameCode _name;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "name")]
    [JsonProperty("name", Order = 0)]
    public MD_MediumNameCode Name {
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

    private List<double> _density;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("density", Order = 1, ElementName = "density")]
    [JsonProperty("density", Order = 1)]
    public List<double> Density {
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

    private string _densityUnits;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "densityUnits")]
    [JsonProperty("densityUnits", Order = 2)]
    public string DensityUnits {
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

    private int _volumes;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "volumes")]
    [RequiredAttribute()]
    [JsonProperty("volumes", Order = 3)]
    public int Volumes {
      get {
        return _volumes;
      }
      set {
        if (_volumes.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "Volumes";
          Validator.ValidateProperty(value, validatorPropContext);
          _volumes = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_MediumFormatCode> _mediumFormat;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("mediumFormat", Order = 4, ElementName = "mediumFormat")]
    [JsonProperty("mediumFormat", Order = 4)]
    public List<MD_MediumFormatCode> MediumFormat {
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

    private string _mediumNote;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5, ElementName = "mediumNote")]
    [JsonProperty("mediumNote", Order = 5)]
    public string MediumNote {
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

    private string _id;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
    [XmlIgnore()]
    [JsonProperty("id")]
    public string Id {
      get {
        return _id;
      }
      set {
        if (_id == value) {
          return;
        }
        if (_id == null || _id.Equals(value) != true) {
          _id = value;
          OnPropertyChanged();
        }
      }
    }

    private string _uuid;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "uuid")]
    [XmlIgnore()]
    [JsonProperty("uuid")]
    public string Uuid {
      get {
        return _uuid;
      }
      set {
        if (_uuid == value) {
          return;
        }
        if (_uuid == null || _uuid.Equals(value) != true) {
          _uuid = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
