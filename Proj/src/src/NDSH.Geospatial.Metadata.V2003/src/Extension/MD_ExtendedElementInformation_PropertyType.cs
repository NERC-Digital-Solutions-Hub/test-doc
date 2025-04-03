
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 00:32, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Extension {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_ExtendedElementInformation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ExtendedElementInformation_PropertyType")]
  public class MD_ExtendedElementInformation_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ExtendedElementInformation_PropertyType"/>.
    /// </summary>
    public MD_ExtendedElementInformation_PropertyType() {
      _md_ExtendedElementInformation  = default; //  new MD_ExtendedElementInformation_Type();
    }

    #endregion

    #region Public Properties

    private MD_ExtendedElementInformation_Type _md_ExtendedElementInformation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_ExtendedElementInformation", Order = 0)]
    [JsonProperty("MD_ExtendedElementInformation", Order = 0)]
    public MD_ExtendedElementInformation_Type MD_ExtendedElementInformation {
      get {
        return _md_ExtendedElementInformation;
      }
      set {
        if (_md_ExtendedElementInformation == value) {
          return;
        }
        if (_md_ExtendedElementInformation == null || _md_ExtendedElementInformation.Equals(value) != true) {
          _md_ExtendedElementInformation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}