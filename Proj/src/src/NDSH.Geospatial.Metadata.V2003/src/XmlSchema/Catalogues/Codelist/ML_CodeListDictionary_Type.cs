
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 19:11, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.Codelist {

  /// <summary>
  /// 
  /// </summary>
  /// <remarks>
  /// Constraint: codeEntry.type = ML_CodeListDefinition
  /// </remarks>
  [Serializable]
  [XmlType("ML_CodeListDictionary", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("ML_CodeListDictionary", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_CodeListDictionary")]
  public class ML_CodeListDictionary_Type : CodeListDictionary_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_CodeListDictionary_Type"/>.
    /// </summary>
    public ML_CodeListDictionary_Type() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _alternativeExpression  = default; //  new List<ClAlternativeExpression_PropertyType>();

    }

    #endregion

    #region Public Fields

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlNamespaceDeclarations()]
    //public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<ClAlternativeExpression_PropertyType> _alternativeExpression;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("alternativeExpression", Order = 0)]
    [JsonProperty("alternativeExpression", Order = 0)]
    public List<ClAlternativeExpression_PropertyType> AlternativeExpression {
      get {
        return _alternativeExpression;
      }
      set {
        if (_alternativeExpression == value) {
          return;
        }
        if (_alternativeExpression == null || _alternativeExpression.Equals(value) != true) {
          _alternativeExpression = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
