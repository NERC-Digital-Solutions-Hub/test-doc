
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 02/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Gml.Measures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Derived.UnitsOfMeasure {

  [Serializable]
  [XmlType("Angle_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Angle_PropertyType")]
  public class Angle_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Angle_PropertyType"/>.
    /// </summary>
    public Angle_PropertyType() {
      _angle = default; //  new AngleType();
    }

    #endregion

    #region Public Properties

    private AngleType _angle;

    [XmlElement("Angle", Order = 0)]
    [JsonProperty("Angle", Order = 0)]
    public AngleType Angle {
      get => _angle;
      set {
        if (_angle == value) {
          return;
        }
        if (_angle == null || !_angle.Equals(value)) {
          _angle = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
