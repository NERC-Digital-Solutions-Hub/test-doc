
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 20:21, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
  [XmlType("EX_VerticalExtent_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_VerticalExtent_PropertyType")]
  public class EX_VerticalExtent_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_VerticalExtent_PropertyType"/>.
    /// </summary>
    public EX_VerticalExtent_PropertyType() {
      _ex_VerticalExtent  = default; //  new EX_VerticalExtent_Type();
    }

    #endregion

    #region Public Properties

    private EX_VerticalExtent_Type _ex_VerticalExtent;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("EX_VerticalExtent", Order = 0)]
    [JsonProperty("EX_VerticalExtent", Order = 0)]
    public EX_VerticalExtent_Type EX_VerticalExtent {
      get {
        return _ex_VerticalExtent;
      }
      set {
        if (_ex_VerticalExtent == value) {
          return;
        }
        if (_ex_VerticalExtent == null || _ex_VerticalExtent.Equals(value) != true) {
          _ex_VerticalExtent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}