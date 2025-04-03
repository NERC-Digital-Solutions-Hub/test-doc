
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 02:20, @gisvlasta.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_DataIdentification_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_DataIdentification_PropertyType")]
  public class MD_DataIdentification_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_DataIdentification_PropertyType"/>.
    /// </summary>
    public MD_DataIdentification_PropertyType() {
      _md_DataIdentification  = default; //  new MD_DataIdentification_Type();
    }

    #endregion

    #region Public Properties

    private MD_DataIdentification_Type _md_DataIdentification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_DataIdentification", Order = 0)]
    [JsonProperty("MD_DataIdentification", Order = 0)]
    public MD_DataIdentification_Type MD_DataIdentification {
      get {
        return _md_DataIdentification;
      }
      set {
        if (_md_DataIdentification == value) {
          return;
        }
        if (_md_DataIdentification == null || _md_DataIdentification.Equals(value) != true) {
          _md_DataIdentification = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
