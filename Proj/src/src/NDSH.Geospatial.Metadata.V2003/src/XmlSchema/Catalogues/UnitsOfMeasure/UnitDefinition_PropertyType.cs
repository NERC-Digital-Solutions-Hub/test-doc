
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 03:22, @gisvlasta.
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
  [XmlType("UnitDefinition_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("UnitDefinition_PropertyType")]
  public class UnitDefinition_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UnitDefinition_PropertyType"/>.
    /// </summary>
    public UnitDefinition_PropertyType() {
      _unitDefinition  = default; //  new UnitDefinitionType();
    }

    #endregion

    #region Public Properties

    private UnitDefinitionType _unitDefinition;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("UnitDefinition", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("UnitDefinition", Order = 0)]
    public UnitDefinitionType UnitDefinition {
      get {
        return _unitDefinition;
      }
      set {
        if (_unitDefinition == value) {
          return;
        }
        if (_unitDefinition == null || _unitDefinition.Equals(value) != true) {
          _unitDefinition = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
