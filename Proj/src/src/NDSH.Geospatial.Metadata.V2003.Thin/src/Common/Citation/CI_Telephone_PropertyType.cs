
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 19:32, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CI_Telephone_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Telephone_PropertyType")]
  public class CI_Telephone_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Telephone_PropertyType"/>.
    /// </summary>
    public CI_Telephone_PropertyType() {
      _ci_Telephone  = default; //  new CI_Telephone_Type();
    }

    #endregion

    #region Private fields

    private CI_Telephone_Type _ci_Telephone;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CI_Telephone", Order = 0)]
    [JsonProperty("CI_Telephone", Order = 0)]
    public CI_Telephone_Type CI_Telephone {
      get {
        return _ci_Telephone;
      }
      set {
        if (_ci_Telephone == value) {
          return;
        }
        if (_ci_Telephone == null || _ci_Telephone.Equals(value) != true) {
          _ci_Telephone = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}