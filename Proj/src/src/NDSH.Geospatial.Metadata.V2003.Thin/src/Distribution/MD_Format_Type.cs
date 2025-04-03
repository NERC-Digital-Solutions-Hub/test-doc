
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 20:43, @gisvlasta.
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
  /// Description of the form of the data to be distributed.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Format", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Format")]
  public class MD_Format_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Format_Type"/>.
    /// </summary>
    public MD_Format_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _name  = default; //  new CharacterString_PropertyType();
      _version  = default; //  new CharacterString_PropertyType();
      _amendmentNumber  = default; //  new CharacterString_PropertyType();
      _specification  = default; //  new CharacterString_PropertyType();
      _fileDecompressionTechnique  = default; //  new CharacterString_PropertyType();
      _formatDistributor  = default; //  new List<MD_Distributor_PropertyType>();

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

    private CharacterString _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString Name {
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

    private CharacterString _version;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("version", Order = 1)]
    [JsonProperty("version", Order = 1)]
    public CharacterString Version {
      get {
        return _version;
      }
      set {
        if (_version == value) {
          return;
        }
        if (_version == null || _version.Equals(value) != true) {
          _version = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _amendmentNumber;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("amendmentNumber", Order = 2)]
    [JsonProperty("amendmentNumber", Order = 2)]
    public CharacterString AmendmentNumber {
      get {
        return _amendmentNumber;
      }
      set {
        if (_amendmentNumber == value) {
          return;
        }
        if (_amendmentNumber == null || _amendmentNumber.Equals(value) != true) {
          _amendmentNumber = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _specification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("specification", Order = 3)]
    [JsonProperty("specification", Order = 3)]
    public CharacterString Specification {
      get {
        return _specification;
      }
      set {
        if (_specification == value) {
          return;
        }
        if (_specification == null || _specification.Equals(value) != true) {
          _specification = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _fileDecompressionTechnique;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileDecompressionTechnique", Order = 4)]
    [JsonProperty("fileDecompressionTechnique", Order = 4)]
    public CharacterString FileDecompressionTechnique {
      get {
        return _fileDecompressionTechnique;
      }
      set {
        if (_fileDecompressionTechnique == value) {
          return;
        }
        if (_fileDecompressionTechnique == null || _fileDecompressionTechnique.Equals(value) != true) {
          _fileDecompressionTechnique = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Distributor_PropertyType> _formatDistributor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("formatDistributor", Order = 5)]
    [JsonProperty("formatDistributor", Order = 5)]
    public List<MD_Distributor_PropertyType> FormatDistributor {
      get {
        return _formatDistributor;
      }
      set {
        if (_formatDistributor == value) {
          return;
        }
        if (_formatDistributor == null || _formatDistributor.Equals(value) != true) {
          _formatDistributor = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}