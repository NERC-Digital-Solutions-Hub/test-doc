
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 04:29, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Application {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DS_Aggregate_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DS_Aggregate_PropertyType")]
  public class DS_Aggregate_PropertyType : ObjectReference_PropertyType {
    
    #region Public Properties

    private AbstractDS_Aggregate_Type _abstractDS_Aggregate;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractDS_Aggregate", Order = 0)]
    [JsonProperty("AbstractDS_Aggregate", Order = 0)]
    public AbstractDS_Aggregate_Type AbstractDS_Aggregate {
      get {
        return _abstractDS_Aggregate;
      }
      set {
        if (_abstractDS_Aggregate == value) {
          return;
        }
        if (_abstractDS_Aggregate == null || _abstractDS_Aggregate.Equals(value) != true) {
          _abstractDS_Aggregate = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
