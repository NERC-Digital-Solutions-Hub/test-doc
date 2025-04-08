
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 03:19, @gisvlasta.
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
  [XmlType("BaseUnit_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  public class BaseUnit_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="BaseUnit_PropertyType"/>.
    /// </summary>
    public BaseUnit_PropertyType() {
      _baseUnit = default; //  new BaseUnitType();
    }

    #endregion

    #region Public Properties

    private BaseUnitType _baseUnit;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("BaseUnit", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("BaseUnit", Order = 0)]
    public BaseUnitType BaseUnit {
      get {
        return _baseUnit;
      }
      set {
        if (_baseUnit == value) {
          return;
        }
        if (_baseUnit == null || _baseUnit.Equals(value) != true) {
          _baseUnit = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
