
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 19:06, @gisvlasta.
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
  [XmlType("CI_Address_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Address_PropertyType")]
  public class CI_Address_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Address_PropertyType"/>.
    /// </summary>
    public CI_Address_PropertyType() {
      _ci_Address  = default; //  new CI_Address_Type();
    }

    #endregion

    #region Public Properties

    private CI_Address_Type _ci_Address;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CI_Address", Order = 0)]
    [JsonProperty("CI_Address", Order = 0)]
    public CI_Address_Type CI_Address {
      get {
        return _ci_Address;
      }
      set {
        if (_ci_Address == value) {
          return;
        }
        if (_ci_Address == null || _ci_Address.Equals(value) != true) {
          _ci_Address = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}