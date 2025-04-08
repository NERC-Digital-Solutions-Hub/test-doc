
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 02:10, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.ValueObjects {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CategoryPropertyType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CategoryPropertyType")]
  public class CategoryPropertyType : Association {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CategoryPropertyType"/>.
    /// </summary>
    public CategoryPropertyType() {
      _category = new Category();
    }

    #endregion

    #region Public Properties

    private Category _category;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Category", IsNullable = true, Order = 0)]
    [JsonProperty("Category", Order = 0)]
    public Category Category {
      get {
        return _category;
      }
      set {
        if (_category == value) {
          return;
        }
        if (_category == null || _category.Equals(value) != true) {
          _category = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
