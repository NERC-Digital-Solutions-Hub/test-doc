
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 19:11, @gisvlasta.
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
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Derived.UnitsOfMeasure {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Scale_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Scale_PropertyType")]
  public class Scale_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Scale_PropertyType"/>.
    /// </summary>
    public Scale_PropertyType() {
      _scale  = default; //  new ScaleType();
    }

    #endregion

    #region Public Properties

    private ScaleType _scale;
    
    /// <summary>
    /// 
    /// </summary>
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
        if (_scale == null || _scale.Equals(value) != true) {
          _scale = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}