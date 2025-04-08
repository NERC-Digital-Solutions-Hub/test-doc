
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 20:11, @gisvlasta.
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
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Numerics {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("UnlimitedInteger_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("UnlimitedInteger_PropertyType")]
  public class UnlimitedInteger_PropertyType : NilReasonModel {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UnlimitedInteger_PropertyType"/>.
    /// </summary>
    public UnlimitedInteger_PropertyType() {
      _unlimitedInteger  = default; //  new UnlimitedInteger_Type();
    }

    #endregion

    #region Private fields

    private UnlimitedInteger_Type _unlimitedInteger;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("UnlimitedInteger", IsNullable = true, Order = 0)]
    [JsonProperty("UnlimitedInteger", Order = 0)]
    public UnlimitedInteger_Type UnlimitedInteger {
      get {
        return _unlimitedInteger;
      }
      set {
        if (_unlimitedInteger == value) {
          return;
        }
        if (_unlimitedInteger == null || _unlimitedInteger.Equals(value) != true) {
          _unlimitedInteger = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}