
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 19:53, @gisvlasta.
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
  [XmlType("EX_Extent_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_Extent_PropertyType")]
  public class EX_Extent_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Desrtructors

    /// <summary>
    /// Initializes the <see cref="EX_Extent_PropertyType"/>.
    /// </summary>
    public EX_Extent_PropertyType() {
      _ex_Extent  = default; //  new EX_Extent_Type();
    }

    #endregion

    #region Public Properties

    private EX_Extent_Type _ex_Extent;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("EX_Extent", Order = 0)]
    [JsonProperty("EX_Extent", Order = 0)]
    public EX_Extent_Type EX_Extent {
      get {
        return _ex_Extent;
      }
      set {
        if (_ex_Extent == value) {
          return;
        }
        if (_ex_Extent == null || _ex_Extent.Equals(value) != true) {
          _ex_Extent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}