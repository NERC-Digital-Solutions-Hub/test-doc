
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 19:31, @gisvlasta.
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
  [XmlType("CI_Series_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Series_PropertyType")]
  public class CI_Series_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Series_PropertyType"/>.
    /// </summary>
    public CI_Series_PropertyType() {
      _ci_Series  = default; //  new CI_Series_Type();
    }

    #endregion

    #region Public Properties

    private CI_Series_Type _ci_Series;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CI_Series", Order = 0)]
    [JsonProperty("CI_Series", Order = 0)]
    public CI_Series_Type CI_Series {
      get {
        return _ci_Series;
      }
      set {
        if (_ci_Series == value) {
          return;
        }
        if (_ci_Series == null || _ci_Series.Equals(value) != true) {
          _ci_Series = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}