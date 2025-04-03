
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 12:47, @fdq09eca.
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
  [XmlType("GF_Attribute_PropertyType")] // TODO: we do not know what is the namespace of it
  [JsonObject("GF_Attribute_PropertyType")]
  public class GF_Attribute_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GF_Attribute_PropertyType"/>.
    /// </summary>
    public GF_Attribute_PropertyType() {
      _gf_attribute  = default; //  new GF_AttributeType();
    }

    #endregion

    #region Public Properties

    private GF_AttributeType _gf_attribute;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("GF_Attribute", Order = 0)]
    [JsonProperty("GF_Attribute", Order = 0)]
    public GF_AttributeType GF_Attribute {
      get {
        return _gf_attribute;
      }
      set {
        if (_gf_attribute == value) {
          return;
        }
        if (_gf_attribute == null || _gf_attribute.Equals(value) != true) {
          _gf_attribute = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}