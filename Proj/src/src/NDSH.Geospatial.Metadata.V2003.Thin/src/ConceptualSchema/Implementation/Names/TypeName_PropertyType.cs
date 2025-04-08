
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 01:14, @gisvlasta.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Names {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("TypeName_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("TypeName_PropertyType")]
  public class TypeName_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="TypeName_PropertyType"/>.
    /// </summary>
    public TypeName_PropertyType() {
      _typeName  = default; //  new TypeName_Type();
    }

    #endregion

    #region Public Properties

    private TypeName_Type _typeName;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("TypeName", Order = 0)]
    [JsonProperty("TypeName", Order = 0)]
    public TypeName_Type TypeName {
      get {
        return _typeName;
      }
      set {
        if (_typeName == value) {
          return;
        }
        if (_typeName == null || _typeName.Equals(value) != true) {
          _typeName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}