
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 02:52, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Measures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Derived.UnitsOfMeasure {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Distance_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Distance_PropertyType")]
  public class Distance_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Distance_PropertyType"/>.
    /// </summary>
    public Distance_PropertyType() {
      _distance  = default; //  new LengthType();
    }

    #endregion

    #region Public Properties

    private LengthType _distance;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Distance", Order = 0)]
    [JsonProperty("Distance", Order = 0)]
    public LengthType Distance {
      get {
        return _distance;
      }
      set {
        if (_distance == value) {
          return;
        }
        if (_distance == null || _distance.Equals(value) != true) {
          _distance = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}