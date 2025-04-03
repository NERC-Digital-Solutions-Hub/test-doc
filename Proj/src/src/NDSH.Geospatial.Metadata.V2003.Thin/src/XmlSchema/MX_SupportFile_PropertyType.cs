
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 16:37, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
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
using System.ComponentModel;
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
  [XmlType("MX_SupportFile_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("MX_SupportFile_PropertyType")]
  public class MX_SupportFile_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_SupportFile_PropertyType"/>.
    /// </summary>
    public MX_SupportFile_PropertyType() {
      _mx_SupportFile  = default; //  new MX_SupportFile_Type();
    }

    #endregion

    #region Public Proeprties

    private MX_SupportFile_Type _mx_SupportFile;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MX_SupportFile", Order = 0)]
    [JsonProperty("MX_SupportFile", Order = 0)]
    public MX_SupportFile_Type MX_SupportFile {
      get {
        return _mx_SupportFile;
      }
      set {
        if (_mx_SupportFile == value) {
          return;
        }
        if (_mx_SupportFile == null || _mx_SupportFile.Equals(value) != true) {
          _mx_SupportFile = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
