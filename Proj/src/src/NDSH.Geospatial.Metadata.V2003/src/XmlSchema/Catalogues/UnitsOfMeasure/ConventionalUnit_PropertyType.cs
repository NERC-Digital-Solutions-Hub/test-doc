
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 03:21, @gisvlasta.
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
  [XmlType("ConventionalUnit_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ConventionalUnit_PropertyType")]
  public class ConventionalUnit_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ConventionalUnit_PropertyType"/>.
    /// </summary>
    public ConventionalUnit_PropertyType() {
      _conventionalUnit = default; //  new ConventionalUnitType();
    }

    #endregion

    #region Public Properties

    private ConventionalUnitType _conventionalUnit;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ConventionalUnit", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("ConventionalUnit", Order = 0)]
    public ConventionalUnitType ConventionalUnit {
      get {
        return _conventionalUnit;
      }
      set {
        if (_conventionalUnit == value) {
          return;
        }
        if (_conventionalUnit == null || _conventionalUnit.Equals(value) != true) {
          _conventionalUnit = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
