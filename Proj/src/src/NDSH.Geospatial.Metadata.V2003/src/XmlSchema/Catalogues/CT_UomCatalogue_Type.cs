
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 19:06, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.UnitsOfMeasure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CT_UomCatalogue", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("CT_UomCatalogue", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("CT_UomCatalogue")]
  public class CT_UomCatalogue_Type : AbstractCT_Catalogue_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_UomCatalogue_Type"/>.
    /// </summary>
    public CT_UomCatalogue_Type() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _uomItem  = default; //  new List<UnitDefinition_PropertyType>();

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

    private List<UnitDefinition_PropertyType> _uomItem;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("uomItem", Order = 0)]
    [JsonProperty("uomItem", Order = 0)]
    public List<UnitDefinition_PropertyType> UomItem {
      get {
        return _uomItem;
      }
      set {
        if (_uomItem == value) {
          return;
        }
        if (_uomItem == null || _uomItem.Equals(value) != true) {
          _uomItem = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
