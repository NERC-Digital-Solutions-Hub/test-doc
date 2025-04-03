
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 03:19, @gisvlasta.
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
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Derived.UnitsOfMeasure {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Measure_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Measure_PropertyType")]
  public class Measure_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Measure_PropertyType"/>.
    /// </summary>
    public Measure_PropertyType() {
      _measure  = default; //  new MeasureType();
    }

    #endregion

    #region Public Properties

    private MeasureType _measure;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Measure", Order = 0)]
    [JsonProperty("Measure", Order = 0)]
    public MeasureType Measure {
      get {
        return _measure;
      }
      set {
        if (_measure == value) {
          return;
        }
        if (_measure == null || _measure.Equals(value) != true) {
          _measure = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}