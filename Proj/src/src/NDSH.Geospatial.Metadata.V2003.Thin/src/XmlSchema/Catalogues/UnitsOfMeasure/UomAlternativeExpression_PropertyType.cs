
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 04:14, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.UnitsOfMeasure {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("UomAlternativeExpression_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("UomAlternativeExpression_PropertyType")]
  public class UomAlternativeExpression_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UomAlternativeExpression_PropertyType"/>.
    /// </summary>
    public UomAlternativeExpression_PropertyType() {
      _uomAlternativeExpression  = default; //  new UomAlternativeExpression_Type();
    }

    #endregion

    #region Public Properties

    private UomAlternativeExpression_Type _uomAlternativeExpression;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("UomAlternativeExpression", Order = 0)]
    [JsonProperty("UomAlternativeExpression", Order = 0)]
    public UomAlternativeExpression_Type UomAlternativeExpression {
      get {
        return _uomAlternativeExpression;
      }
      set {
        if (_uomAlternativeExpression == value) {
          return;
        }
        if (_uomAlternativeExpression == null || _uomAlternativeExpression.Equals(value) != true) {
          _uomAlternativeExpression = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
