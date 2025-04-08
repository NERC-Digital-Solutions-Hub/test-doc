
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 20:02, @gisvlasta.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Distribution {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_DigitalTransferOptions_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_DigitalTransferOptions_PropertyType")]
  public class MD_DigitalTransferOptions_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_DigitalTransferOptions_PropertyType"/>.
    /// </summary>
    public MD_DigitalTransferOptions_PropertyType() {
      _md_DigitalTransferOptions  = default; //  new MD_DigitalTransferOptions_Type();
    }

    #endregion

    #region Public Properties

    private MD_DigitalTransferOptions_Type _md_DigitalTransferOptions;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_DigitalTransferOptions", Order = 0)]
    [JsonProperty("MD_DigitalTransferOptions", Order = 0)]
    public MD_DigitalTransferOptions_Type MD_DigitalTransferOptions {
      get {
        return _md_DigitalTransferOptions;
      }
      set {
        if (_md_DigitalTransferOptions == value) {
          return;
        }
        if (_md_DigitalTransferOptions == null || _md_DigitalTransferOptions.Equals(value) != true) {
          _md_DigitalTransferOptions = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}