
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 14:49, @fdq09eca.
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("GF_Property_PropertyType")] // TODO: we do not know what is the namespace of it
  [JsonObject("GF_Property_PropertyType")]
  public class GF_Property_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GF_Property_PropertyType"/>.
    /// </summary>
    public GF_Property_PropertyType() {
      _gf_property  = default; //  new GF_PropertyType();
    }

    #endregion

    #region Public Properties

    private GF_PropertyType _gf_property;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("GF_Property", Order = 0)]
    [JsonProperty("GF_Property", Order = 0)]
    public GF_PropertyType GF_Property {
      get {
        return _gf_property;
      }
      set {
        if (_gf_property == value) {
          return;
        }
        if (_gf_property == null || _gf_property.Equals(value) != true) {
          _gf_property = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}