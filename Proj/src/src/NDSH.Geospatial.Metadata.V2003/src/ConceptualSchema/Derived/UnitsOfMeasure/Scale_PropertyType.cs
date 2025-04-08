
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
  [XmlType("Scale_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Scale_PropertyType")]
  public class Scale_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Scale_PropertyType"/>.
    /// </summary>
    public Scale_PropertyType() {
      _scale = default; //  new ScaleType();
    }

    #endregion

    #region Public Properties

    private ScaleType _scale;

    [XmlElement("Scale", Order = 0)]
    [JsonProperty("Scale", Order = 0)]
    public ScaleType Scale {
      get {
        return _scale;
      }
      set {
        if (_scale == value) {
          return;
        }
        if (_scale == null || !_scale.Equals(value)) {
          _scale = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
