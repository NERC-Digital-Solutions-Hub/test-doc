
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/01/2023, 01:43, @gisvlasta.
// Updated by        : 10/02/2023, 12:48, @gisvlasta.
//                     1.0.1 - Renamed to MX_ImgDataFile_Type.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Distribution;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MX_DataFile", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MX_DataFile", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MX_DataFile")]
  public class MX_ImgDataFile_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_ImgDataFile_Type"/>
    /// </summary>
    public MX_ImgDataFile_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _fileFormat = default; // new MD_Format_PropertyType();

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

    private MD_Format_PropertyType _fileFormat;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileFormat", Order = 0)]
    [JsonProperty("fileFormat", Order = 0)]
    public MD_Format_PropertyType FileFormat {
      get {
        return _fileFormat;
      }
      set {
        if (_fileFormat == value) {
          return;
        }
        if (_fileFormat == null || _fileFormat.Equals(value) != true) {
          _fileFormat = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
