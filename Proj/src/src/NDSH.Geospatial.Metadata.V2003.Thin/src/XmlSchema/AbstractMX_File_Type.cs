
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 21:06, @gisvlasta.
// Updated by        : 09/01/2023, 21:33, @gisvlasta. - 1.0.1: Added xmlns field.
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
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Extended;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(MX_SupportFile_Type))]
  [XmlInclude(typeof(MX_DataFile_Type))]
  [XmlType("AbstractMX_File", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("AbstractMX_File", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("AbstractMX_File")]
  public abstract class AbstractMX_File_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractMX_File_Type"/>.
    /// </summary>
    public AbstractMX_File_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _fileName  = default; //  new FileName_PropertyType();
      _fileDescription  = default; //  new CharacterString_PropertyType();
      _fileType  = default; //  new MimeFileType_PropertyType();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Private fields
    
    private FileName_PropertyType _fileName;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileName", Order = 0)]
    [JsonProperty("fileName", Order = 0)]
    public FileName_PropertyType FileName {
      get {
        return _fileName;
      }
      set {
        if (_fileName == value) {
          return;
        }
        if (_fileName == null || _fileName.Equals(value) != true) {
          _fileName = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _fileDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileDescription", Order = 1)]
    [JsonProperty("fileDescription", Order = 1)]
    public CharacterString FileDescription {
      get {
        return _fileDescription;
      }
      set {
        if (_fileDescription == value) {
          return;
        }
        if (_fileDescription == null || _fileDescription.Equals(value) != true) {
          _fileDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private MimeFileType_PropertyType _fileType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileType", Order = 2)]
    [JsonProperty("fileType", Order = 2)]
    public MimeFileType_PropertyType FileType {
      get {
        return _fileType;
      }
      set {
        if (_fileType == value) {
          return;
        }
        if (_fileType == null || _fileType.Equals(value) != true) {
          _fileType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
