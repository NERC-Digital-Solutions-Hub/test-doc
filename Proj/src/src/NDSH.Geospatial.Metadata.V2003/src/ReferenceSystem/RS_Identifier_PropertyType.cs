
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 27/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
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

namespace NDSH.Geospatial.Metadata.V2003.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("RS_Identifier_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("RS_Identifier_PropertyType")]
  public class RS_Identifier_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="RS_Identifier_PropertyType"/>.
    /// </summary>
    public RS_Identifier_PropertyType() {
      _rs_Identifier = default; //  new RS_Identifier_Type();
    }

    #endregion

    #region Public Properties

    private RS_Identifier_Type _rs_Identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("RS_Identifier", Order = 0)]
    [JsonProperty("RS_Identifier", Order = 0)]
    public RS_Identifier_Type RS_Identifier {
      get => _rs_Identifier;
      set {
        if (_rs_Identifier == value) {
          return;
        }
        if (_rs_Identifier == null || !_rs_Identifier.Equals(value)) {
          _rs_Identifier = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
