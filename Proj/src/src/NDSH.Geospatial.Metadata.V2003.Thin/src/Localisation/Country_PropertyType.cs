
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 17:59, @gisvlasta.
// Updated by        : 09/01/2023, 20:29, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Localisation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Country_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("Country_PropertyType")]
  public class Country_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Country_PropertyType"/>.
    /// </summary>
    public Country_PropertyType() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _country  = default; //  new CodeListValue_Type();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private CodeListValue_Type _country;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Country", Order = 0)]
    [JsonProperty("Country", Order = 0)]
    public CodeListValue_Type Country {
      get {
        return _country;
      }
      set {
        if (_country == value) {
          return;
        }
        if (_country == null || _country.Equals(value) != true) {
          _country = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
