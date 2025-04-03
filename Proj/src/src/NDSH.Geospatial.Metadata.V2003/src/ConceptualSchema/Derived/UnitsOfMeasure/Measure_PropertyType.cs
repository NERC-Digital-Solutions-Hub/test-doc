
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

using NDSH.Geospatial.Metadata.V2003.Common;

using NDSH.Geospatial.Metadata.V2003.Gml.Measures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Derived.UnitsOfMeasure {

  [Serializable]
  [XmlType("Measure_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Measure_PropertyType")]
  public class Measure_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Measure_PropertyType"/>.
    /// </summary>
    public Measure_PropertyType() {
      _measure = default; //  new MeasureType();
    }

    #endregion

    #region Public Properties

    private MeasureType _measure;

    [XmlElement("Measure", Order = 0)]
    [JsonProperty("Measure", Order = 0)]
    public MeasureType Measure {
      get => _measure;
      set {
        if (_measure == value) {
          return;
        }
        if (_measure == null || !_measure.Equals(value)) {
          _measure = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
