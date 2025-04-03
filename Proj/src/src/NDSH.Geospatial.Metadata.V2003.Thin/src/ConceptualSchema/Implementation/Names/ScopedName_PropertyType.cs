
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 19:54, @gisvlasta.
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
  [XmlType("ScopedName_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("ScopedName_PropertyType")]
  public class ScopedName_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ScopedName_PropertyType"/>.
    /// </summary>
    public ScopedName_PropertyType() {
      _scopedName  = default; //  new CodeType();
    }

    #endregion

    #region Public Properties

    private CodeType _scopedName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ScopedName", Order = 0)]
    [JsonProperty("ScopedName", Order = 0)]
    public CodeType ScopedName {
      get {
        return _scopedName;
      }
      set {
        if (_scopedName == value) {
          return;
        }
        if (_scopedName == null || _scopedName.Equals(value) != true) {
          _scopedName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }


}