
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 19:42, @gisvlasta.
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
  [XmlType("GenericName_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("GenericName_PropertyType")]
  public class GenericName_PropertyType : NilReasonModel { // TODO: GenericName seems to be an abstract? class which has LocalName as its child (ISO 19109:2006, p.12), possibly other childern as well.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GenericName_PropertyType"/>.
    /// </summary>
    public GenericName_PropertyType() {
      _abstractGenericName  = default; //  new CodeType();
    }

    #endregion

    #region Public Properties

    private CodeType _abstractGenericName;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractGenericName", Order = 0)]
    [JsonProperty("AbstractGenericName", Order = 0)]
    public CodeType AbstractGenericName {
      get {
        return _abstractGenericName;
      }
      set {
        if (_abstractGenericName == value) {
          return;
        }
        if (_abstractGenericName == null || _abstractGenericName.Equals(value) != true) {
          _abstractGenericName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}