
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 03:03, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coverage {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("FileType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("FileType")]
  public class FileType : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="FileType"/>.
    /// </summary>
    public FileType() {
      _rangeParameters = new RangeParametersType();
    }

    #endregion

    #region Public Properties

    private RangeParametersType _rangeParameters;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("rangeParameters", Order = 0)]
    [JsonProperty("rangeParameters", Order = 0)]
    public RangeParametersType RangeParameters {
      get {
        return _rangeParameters;
      }
      set {
        if (_rangeParameters == value) {
          return;
        }
        if (_rangeParameters == null || _rangeParameters.Equals(value) != true) {
          _rangeParameters = value;
          OnPropertyChanged();
        }
      }
    }

    private string _fileItem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileName", DataType = "anyURI", Order = 1)]
    [XmlElement("fileReference", DataType = "anyURI", Order = 1)]
    [XmlChoiceIdentifier("FileItemElementName")]
    public string FileItem {
      get {
        return _fileItem;
      }
      set {
        if (_fileItem == value) {
          return;
        }
        if (_fileItem == null || _fileItem.Equals(value) != true) {
          _fileItem = value;
          OnPropertyChanged();
        }
      }
    }

    private FileEnumeration _fileItemElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("FileItemElementName", Order = 2)]
    [XmlIgnore]
    public FileEnumeration FileItemElementName {
      get {
        return _fileItemElementName;
      }
      set {
        if (_fileItemElementName.Equals(value) != true) {
          _fileItemElementName = value;
          OnPropertyChanged();
        }
      }
    }

    private FileValueModelType _fileStructure;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileStructure", Order = 3)]
    [JsonProperty("fileStructure", Order = 3)]
    public FileValueModelType FileStructure {
      get {
        return _fileStructure;
      }
      set {
        if (_fileStructure.Equals(value) != true) {
          _fileStructure = value;
          OnPropertyChanged();
        }
      }
    }

    private string _mimeType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("mimeType", DataType = "anyURI", Order = 4)]
    [JsonProperty("mimeType", Order = 4)]
    public string MimeType {
      get {
        return _mimeType;
      }
      set {
        if (_mimeType == value) {
          return;
        }
        if (_mimeType == null || _mimeType.Equals(value) != true) {
          _mimeType = value;
          OnPropertyChanged();
        }
      }
    }

    private string _compression;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("compression", DataType = "anyURI", Order = 5)]
    [JsonProperty("compression", Order = 5)]
    public string Compression {
      get {
        return _compression;
      }
      set {
        if (_compression == value) {
          return;
        }
        if (_compression == null || _compression.Equals(value) != true) {
          _compression = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
