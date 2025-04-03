
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 19:08, @gisvlasta.
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
  [XmlType("Angle_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Angle_PropertyType")]
  public class Angle_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Angle_PropertyType"/>.
    /// </summary>
    public Angle_PropertyType() {
      _angle  = default; //  new AngleType();
    }

    #endregion

    #region Public Properties

    private AngleType _angle;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Angle", Order = 0)]
    [JsonProperty("Angle", Order = 0)]
    public AngleType Angle {
      get {
        return _angle;
      }
      set {
        if (_angle == value) {
          return;
        }
        if (_angle == null || _angle.Equals(value) != true) {
          _angle = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}