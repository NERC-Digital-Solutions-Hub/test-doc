
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 14:30, @gisvlasta.
// Updated by        : 09/01/2023, 20:47, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_ReferenceSystem")]
  public class MD_ReferenceSystem_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ReferenceSystem_Type"/>.
    /// </summary>
    public MD_ReferenceSystem_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _referenceSystemIdentifier  = default; //  new RS_Identifier_PropertyType();

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

    private RS_Identifier_PropertyType _referenceSystemIdentifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("referenceSystemIdentifier", Order = 0)]
    [JsonProperty("referenceSystemIdentifier", Order = 0)]
    public RS_Identifier_PropertyType ReferenceSystemIdentifier {
      get {
        return _referenceSystemIdentifier;
      }
      set {
        if (_referenceSystemIdentifier == value) {
          return;
        }
        if (_referenceSystemIdentifier == null || _referenceSystemIdentifier.Equals(value) != true) {
          _referenceSystemIdentifier = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
