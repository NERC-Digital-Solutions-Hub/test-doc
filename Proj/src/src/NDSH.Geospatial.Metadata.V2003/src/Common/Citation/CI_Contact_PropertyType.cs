
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
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

namespace NDSH.Geospatial.Metadata.V2003.Common.Citation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CI_Contact_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Contact_PropertyType")]
  public class CI_Contact_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Contact_PropertyType"/>.
    /// </summary>
    public CI_Contact_PropertyType() {
      _ci_Contact = default; //  new CI_Contact_Type();
    }

    #endregion

    #region Public Properties

    private CI_Contact_Type _ci_Contact;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CI_Contact", Order = 0)]
    [JsonProperty("CI_Contact", Order = 0)]
    public CI_Contact_Type CI_Contact {
      get => _ci_Contact;
      set {
        if (_ci_Contact == value) {
          return;
        }
        if (_ci_Contact == null || !_ci_Contact.Equals(value)) {
          _ci_Contact = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
