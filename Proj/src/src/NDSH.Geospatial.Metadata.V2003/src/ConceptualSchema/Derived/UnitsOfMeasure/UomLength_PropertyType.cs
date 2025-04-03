
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Gml.Units;
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
  [XmlType("UomLength_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("UomLength_PropertyType")]
  public class UomLength_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UomLength_PropertyType"/>.
    /// </summary>
    public UomLength_PropertyType() {
      _unitDefinition = default; //  new UnitDefinitionType();
    }

    #endregion

    #region Public Properties

    private UnitDefinitionType _unitDefinition;

    [XmlElement("UnitDefinition", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("UnitDefinition", Order = 0)]
    public UnitDefinitionType UnitDefinition {
      get => _unitDefinition;
      set {
        if (_unitDefinition == value) {
          return;
        }
        if (_unitDefinition == null || !_unitDefinition.Equals(value)) {
          _unitDefinition = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
