
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 00:55, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.Completeness {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_Completeness_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_Completeness_PropertyType")]
  public class DQ_Completeness_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractDQ_Completeness_Type _abstractDQ_Completeness;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractDQ_Completeness", Order = 0)]
    [JsonProperty("AbstractDQ_Completeness", Order = 0)]
    public AbstractDQ_Completeness_Type AbstractDQ_Completeness
    {
      get
      {
        return _abstractDQ_Completeness;
      }
      set
      {
        if (_abstractDQ_Completeness == value)
        {
          return;
        }
        if (_abstractDQ_Completeness == null || _abstractDQ_Completeness.Equals(value) != true)
        {
          _abstractDQ_Completeness = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
