
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 02:54, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.UnitsOfMeasure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Units {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(ML_BaseUnit_Type))]
  [XmlType("BaseUnitType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("BaseUnitType")]
  public class BaseUnitType : UnitDefinitionType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="BaseUnitType"/>.
    /// </summary>
    public BaseUnitType() {
      _unitsSystem = default; //  new ReferenceType();
    }

    #endregion

    #region Public Properties

    private ReferenceType _unitsSystem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("unitsSystem", Order = 0)]
    [JsonProperty("unitsSystem", Order = 0)]
    public ReferenceType UnitsSystem {
      get {
        return _unitsSystem;
      }
      set {
        if (_unitsSystem == value) {
          return;
        }
        if (_unitsSystem == null || _unitsSystem.Equals(value) != true) {
          _unitsSystem = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
