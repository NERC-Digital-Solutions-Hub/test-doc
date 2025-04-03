
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 28/12/2022, @gisvlasta
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
  [XmlType("MD_Identifier_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Identifier_PropertyType")]
  public class MD_Identifier_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Identifier_PropertyType"/>.
    /// </summary>
    public MD_Identifier_PropertyType() {
      _md_Identifier = default; //  new MD_Identifier_Type();
    }

    #endregion

    #region Public Properties

    private MD_Identifier_Type _md_Identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Identifier", Order = 0)]
    [JsonProperty("MD_Identifier", Order = 0)]
    public MD_Identifier_Type MD_Identifier {
      get => _md_Identifier;
      set {
        if (_md_Identifier == value) {
          return;
        }
        if (_md_Identifier == null || !_md_Identifier.Equals(value)) {
          _md_Identifier = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
