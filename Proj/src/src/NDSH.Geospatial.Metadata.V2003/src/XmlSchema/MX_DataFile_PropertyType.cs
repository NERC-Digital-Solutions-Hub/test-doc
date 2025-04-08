
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 21:22, @gisvlasta.
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MX_DataFile_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("MX_DataFile_PropertyType")]
  public class MX_DataFile_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_DataFile_PropertyType"/>.
    /// </summary>
    public MX_DataFile_PropertyType() {
      _mx_DataFile  = default; //  new MX_DataFile_Type();
    }

    #endregion

    #region Public Properties

    private MX_DataFile_Type _mx_DataFile;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MX_DataFile", Order = 0)]
    [JsonProperty("MX_DataFile", Order = 0)]
    public MX_DataFile_Type MX_DataFile {
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
