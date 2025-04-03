
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 01:51, @gisvlasta.
// Updated by        : 09/01/2023, 18:19, @gisvlasta. - 1.0.1: Added xmlns field.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Constraint {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_Constraints_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Constraints_PropertyType")]
  public class MD_Constraints_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Constraints_PropertyType"/>.
    /// </summary>
    public MD_Constraints_PropertyType() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _md_Constraints  = default; //  new MD_Constraints_Type();
      
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

    private MD_Constraints_Type _md_Constraints;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Constraints", Order = 0)]
    [JsonProperty("MD_Constraints", Order = 0)]
    public MD_Constraints_Type MD_Constraints {
      get {
        return _md_Constraints;
      }
      set {
        if (_md_Constraints == value) {
          return;
        }
        if (_md_Constraints == null || _md_Constraints.Equals(value) != true) {
          _md_Constraints = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}