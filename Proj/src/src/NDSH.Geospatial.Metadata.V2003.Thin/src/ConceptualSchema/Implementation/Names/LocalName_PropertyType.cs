
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 19:51, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;
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
  [XmlType("LocalName_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("LocalName_PropertyType")]
  public class LocalName_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LocalName_PropertyType"/>.
    /// </summary>
    public LocalName_PropertyType() {
      _localName  = default; //  new CodeType();
    }

    #endregion

    #region Public Properties

    private CodeType _localName;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LocalName", Order = 0)]
    [JsonProperty("LocalName", Order = 0)]
    public CodeType LocalName {
      get {
        return _localName;
      }
      set {
        if (_localName == value) {
          return;
        }
        if (_localName == null || _localName.Equals(value) != true) {
          _localName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}