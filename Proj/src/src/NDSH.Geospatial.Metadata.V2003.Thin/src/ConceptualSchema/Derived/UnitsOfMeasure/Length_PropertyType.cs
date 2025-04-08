
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 18:56, @gisvlasta.
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
  [XmlType("Length_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Length_PropertyType")]
  public class Length_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Length_PropertyType"/>.
    /// </summary>
    public Length_PropertyType() {
      _length  = default; //  new LengthType();
    }

    #endregion

    #region Public Proeprties
    
    private LengthType _length;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Length", Order = 0)]
    [JsonProperty("Length", Order = 0)]
    public LengthType Length {
      get {
        return _length;
      }
      set {
        if (_length == value) {
          return;
        }
        if (_length == null || _length.Equals(value) != true) {
          _length = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}