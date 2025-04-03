
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 18:39, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.Codelist;
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CT_CodelistCatalogue", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("CT_CodelistCatalogue", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("CT_CodelistCatalogue")]
  public class CT_CodelistCatalogue_Type : AbstractCT_Catalogue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_CodelistCatalogue_Type"/>.
    /// </summary>
    public CT_CodelistCatalogue_Type() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _codelistItem  = default; //  new List<CT_Codelist_PropertyType>();

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

    private List<CT_Codelist_PropertyType> _codelistItem;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("codelistItem", Order = 0)]
    [JsonProperty("codelistItem", Order = 0)]
    public List<CT_Codelist_PropertyType> CodelistItem {
      get {
        return _codelistItem;
      }
      set {
        if (_codelistItem == value) {
          return;
        }
        if (_codelistItem == null || _codelistItem.Equals(value) != true) {
          _codelistItem = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
