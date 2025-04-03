
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 17:38, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.ApplicationSchema {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_ApplicationSchemaInformation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ApplicationSchemaInformation_PropertyType")]
  public class MD_ApplicationSchemaInformation_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ApplicationSchemaInformation_PropertyType"/>.
    /// </summary>
    public MD_ApplicationSchemaInformation_PropertyType() {
      _md_ApplicationSchemaInformation  = default; //  new MD_ApplicationSchemaInformation_Type();
    }

    #endregion

    #region Public Properties

    private MD_ApplicationSchemaInformation_Type _md_ApplicationSchemaInformation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_ApplicationSchemaInformation", Order = 0)]
    [JsonProperty("MD_ApplicationSchemaInformation", Order = 0)]
    public MD_ApplicationSchemaInformation_Type MD_ApplicationSchemaInformation {
      get {
        return _md_ApplicationSchemaInformation;
      }
      set {
        if (_md_ApplicationSchemaInformation == value) {
          return;
        }
        if (_md_ApplicationSchemaInformation == null || _md_ApplicationSchemaInformation.Equals(value) != true) {
          _md_ApplicationSchemaInformation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}