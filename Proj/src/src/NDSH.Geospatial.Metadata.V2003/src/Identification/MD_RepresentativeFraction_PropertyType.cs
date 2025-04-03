
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 02:32, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_RepresentativeFraction_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_RepresentativeFraction_PropertyType")]
  public class MD_RepresentativeFraction_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_RepresentativeFraction_PropertyType"/>.
    /// </summary>
    public MD_RepresentativeFraction_PropertyType() {
      _md_RepresentativeFraction  = default; //  new MD_RepresentativeFraction_Type();
    }

    #endregion

    #region Public Properties

    private MD_RepresentativeFraction_Type _md_RepresentativeFraction;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_RepresentativeFraction", Order = 0)]
    [JsonProperty("MD_RepresentativeFraction", Order = 0)]
    public MD_RepresentativeFraction_Type MD_RepresentativeFraction {
      get {
        return _md_RepresentativeFraction;
      }
      set {
        if (_md_RepresentativeFraction == value) {
          return;
        }
        if (_md_RepresentativeFraction == null || _md_RepresentativeFraction.Equals(value) != true) {
          _md_RepresentativeFraction = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
