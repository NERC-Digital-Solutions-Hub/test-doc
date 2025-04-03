
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 03:22, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Gml.Units;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.UnitsOfMeasure {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DerivedUnit_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("DerivedUnit_PropertyType")]
  public class DerivedUnit_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DerivedUnit_PropertyType"/>.
    /// </summary>
    public DerivedUnit_PropertyType() {
      _derivedUnit = default; //  new DerivedUnitType();
    }

    #endregion

    #region Public Properties

    private DerivedUnitType _derivedUnit;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DerivedUnit", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("DerivedUnit", Order = 0)]
    public DerivedUnitType DerivedUnit {
      get {
        return _derivedUnit;
      }
      set {
        if (_derivedUnit == value) {
          return;
        }
        if (_derivedUnit == null || _derivedUnit.Equals(value) != true) {
          _derivedUnit = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
