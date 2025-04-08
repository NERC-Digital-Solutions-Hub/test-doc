
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 03:21, @gisvlasta.
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
  [XmlType("MemberName_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot???
  [JsonObject("MemberName_PropertyType")]
  public class MemberName_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MemberName_PropertyType"/>.
    /// </summary>
    public MemberName_PropertyType() {
      _memberName  = default; //  new MemberName_Type();
    }

    #endregion

    #region Public Properties

    private MemberName_Type _memberName;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MemberName", Order = 0)]
    [JsonProperty("MemberName", Order = 0)]
    public MemberName_Type MemberName {
      get {
        return _memberName;
      }
      set {
        if (_memberName == value) {
          return;
        }
        if (_memberName == null || _memberName.Equals(value) != true) {
          _memberName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}