
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 19:21, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("EX_GeographicDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("EX_GeographicDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_GeographicDescription")]
  public class EX_GeographicDescription_Type : AbstractEX_GeographicExtent_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_GeographicDescription_Type"/>.
    /// </summary>
    public EX_GeographicDescription_Type() {
      _geographicIdentifier  = default; //  new MD_Identifier_PropertyType();
    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Private fields

    private MD_Identifier_PropertyType _geographicIdentifier;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("geographicIdentifier", Order = 0)]
    [JsonProperty("geographicIdentifier", Order = 0)]
    public MD_Identifier_PropertyType geographicIdentifier {
      get {
        return _geographicIdentifier;
      }
      set {
        if (_geographicIdentifier == value) {
          return;
        }
        if (_geographicIdentifier == null || _geographicIdentifier.Equals(value) != true) {
          _geographicIdentifier = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}