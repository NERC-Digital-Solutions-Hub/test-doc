
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 12:35, @gisvlasta.
// Updated by        : 10/02/2023, 12:48, @gisvlasta.
//                     1.0.1 - Renamed to MX_ImgDataFile_PropertyType.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MX_DataFile_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MX_DataFile_PropertyType")]
  public class MX_ImgDataFile_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_ImgDataFile_PropertyType"/>.
    /// </summary>
    public MX_ImgDataFile_PropertyType() {
      _mx_DataFile = default; // new MX_DataFile_Type();
    }

    #endregion

    #region Public Properties

    private MX_ImgDataFile_Type _mx_DataFile;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MX_DataFile", Order = 0)]
    [JsonProperty("MX_DataFile", Order = 0)]
    public MX_ImgDataFile_Type MX_DataFile {
      get {
        return _mx_DataFile;
      }
      set {
        if (_mx_DataFile == value) {
          return;
        }
        if (_mx_DataFile == null || _mx_DataFile.Equals(value) != true) {
          _mx_DataFile = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
