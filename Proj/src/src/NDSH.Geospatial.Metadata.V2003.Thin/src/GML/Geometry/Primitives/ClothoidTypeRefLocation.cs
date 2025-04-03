
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 04:05, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ClothoidTypeRefLocation", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ClothoidTypeRefLocation")]
  public class ClothoidTypeRefLocation : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ClothoidTypeRefLocation"/>.
    /// </summary>
    public ClothoidTypeRefLocation() {
      _affinePlacement = new AffinePlacementType();
    }

    #endregion

    #region Public Properties

    private AffinePlacementType _affinePlacement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AffinePlacement", Order = 0)]
    [JsonProperty("AffinePlacement", Order = 0)]
    public AffinePlacementType AffinePlacement {
      get {
        return _affinePlacement;
      }
      set {
        if (_affinePlacement == value) {
          return;
        }
        if (_affinePlacement == null || _affinePlacement.Equals(value) != true) {
          _affinePlacement = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
