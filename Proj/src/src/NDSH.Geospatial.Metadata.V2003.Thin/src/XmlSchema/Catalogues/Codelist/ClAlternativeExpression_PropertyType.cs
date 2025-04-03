
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 19:17, @gisvlasta.
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.Codelist {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ClAlternativeExpression_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ClAlternativeExpression_PropertyType")]
  public class ClAlternativeExpression_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ClAlternativeExpression_PropertyType"/>.
    /// </summary>
    public ClAlternativeExpression_PropertyType() {
      _clAlternativeExpression  = default; //  new ClAlternativeExpression_Type();
    }

    #endregion

    #region Public Properties

    private ClAlternativeExpression_Type _clAlternativeExpression;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ClAlternativeExpression", Order = 0)]
    [JsonProperty("ClAlternativeExpression", Order = 0)]
    public ClAlternativeExpression_Type ClAlternativeExpression {
      get {
        return _clAlternativeExpression;
      }
      set {
        if (_clAlternativeExpression == value) {
          return;
        }
        if (_clAlternativeExpression == null || _clAlternativeExpression.Equals(value) != true) {
          _clAlternativeExpression = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
