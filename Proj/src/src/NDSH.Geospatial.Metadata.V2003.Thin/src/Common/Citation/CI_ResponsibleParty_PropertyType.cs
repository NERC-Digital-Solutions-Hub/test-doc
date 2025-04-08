
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 19:24, @gisvlasta.
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
  [XmlType("CI_ResponsibleParty_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_ResponsibleParty_PropertyType")]
  public class CI_ResponsibleParty_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_ResponsibleParty_PropertyType"/>.
    /// </summary>
    public CI_ResponsibleParty_PropertyType() {
      _ci_ResponsibleParty  = default; //  new CI_ResponsibleParty_Type();
    }

    #endregion

    #region Public Properties

    private CI_ResponsibleParty_Type _ci_ResponsibleParty;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CI_ResponsibleParty", Order = 0)]
    [JsonProperty("CI_ResponsibleParty", Order = 0)]
    public CI_ResponsibleParty_Type CI_ResponsibleParty {
      get {
        return _ci_ResponsibleParty;
      }
      set {
        if (_ci_ResponsibleParty == value) {
          return;
        }
        if (_ci_ResponsibleParty == null || _ci_ResponsibleParty.Equals(value) != true) {
          _ci_ResponsibleParty = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}