
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 21:10, @gisvlasta.
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MX_Aggregate_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("MX_Aggregate_PropertyType")]
  public class MX_Aggregate_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_Aggregate_PropertyType"/>.
    /// </summary>
    public MX_Aggregate_PropertyType() {
      _mx_Aggregate  = default; //  new MX_Aggregate_Type();
    }

    #endregion

    #region Public Properties

    private MX_Aggregate_Type _mx_Aggregate;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MX_Aggregate", Order = 0)]
    [JsonProperty("MX_Aggregate", Order = 0)]
    public MX_Aggregate_Type MX_Aggregate {
      get {
        return _mx_Aggregate;
      }
      set {
        if (_mx_Aggregate == value) {
          return;
        }
        if (_mx_Aggregate == null || _mx_Aggregate.Equals(value) != true) {
          _mx_Aggregate = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
