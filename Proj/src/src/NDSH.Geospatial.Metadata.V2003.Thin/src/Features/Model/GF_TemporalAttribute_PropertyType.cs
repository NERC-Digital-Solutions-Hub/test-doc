#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 08/01/2023, 01:00, @generated
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Features.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("GF_TemporalAttribute_PropertyType")] // TODO: we do not know what is the namespace of it
  [JsonObject("GF_TemporalAttribute_PropertyType")]
  public class GF_TemporalAttribute_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GF_TemporalAttribute_PropertyType"/>.
    /// </summary>
    public GF_TemporalAttribute_PropertyType() {
      _gf_temporalattribute  = default; //  new GF_TemporalAttributeType();
    }

    #endregion

    #region Public Properties

    private GF_TemporalAttributeType _gf_temporalattribute;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("GF_TemporalAttribute", Order = 0)]
    [JsonProperty("GF_TemporalAttribute", Order = 0)]
    public GF_TemporalAttributeType GF_TemporalAttribute {
      get {
        return _gf_temporalattribute;
      }
      set {
        if (_gf_temporalattribute == value) {
          return;
        }
        if (_gf_temporalattribute == null || _gf_temporalattribute.Equals(value) != true) {
          _gf_temporalattribute = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion
  }

}