
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 29/12/2022, @gisvlasta
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
  [XmlType("Distance_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Distance_PropertyType")]
  public class Distance_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Distance_PropertyType"/>.
    /// </summary>
    public Distance_PropertyType() {
      _distance = default; //  new LengthType();
    }

    #endregion

    #region Public Properties

    private LengthType _distance;

    [XmlElement("Distance", Order = 0)]
    [JsonProperty("Distance", Order = 0)]
    public LengthType Distance {
      get => _distance;
      set {
        if (_distance == value) {
          return;
        }
        if (_distance == null || !_distance.Equals(value)) {
          _distance = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
