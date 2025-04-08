
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 19:2, @gisvlasta.
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
  [XmlType("CodeAlternativeExpression_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CodeAlternativeExpression_PropertyType")]
  public class CodeAlternativeExpression_PropertyType : ObjectReference_PropertyType {

    #region Cosntructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CodeAlternativeExpression_PropertyType"/>.
    /// </summary>
    public CodeAlternativeExpression_PropertyType() {
      _codeAlternativeExpression  = default; //  new CodeAlternativeExpression_Type();
    }

    #endregion

    #region Public Properties

    private CodeAlternativeExpression_Type _codeAlternativeExpression;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CodeAlternativeExpression", Order = 0)]
    [JsonProperty("CodeAlternativeExpression", Order = 0)]
    public CodeAlternativeExpression_Type CodeAlternativeExpression {
      get {
        return _codeAlternativeExpression;
      }
      set {
        if (_codeAlternativeExpression == value) {
          return;
        }
        if (_codeAlternativeExpression == null || _codeAlternativeExpression.Equals(value) != true) {
          _codeAlternativeExpression = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
