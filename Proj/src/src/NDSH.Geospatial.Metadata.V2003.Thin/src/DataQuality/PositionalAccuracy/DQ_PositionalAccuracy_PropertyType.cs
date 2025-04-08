
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:30, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.PositionalAccuracy {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_PositionalAccuracy_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_PositionalAccuracy_PropertyType")]
  public class DQ_PositionalAccuracy_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractDQ_PositionalAccuracy_Type _abstractDQ_PositionalAccuracy;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractDQ_PositionalAccuracy", Order = 0)]
    [JsonProperty("AbstractDQ_PositionalAccuracy", Order = 0)]
    public AbstractDQ_PositionalAccuracy_Type AbstractDQ_PositionalAccuracy
    {
      get
      {
        return _abstractDQ_PositionalAccuracy;
      }
      set
      {
        if (_abstractDQ_PositionalAccuracy == value)
        {
          return;
        }
        if (_abstractDQ_PositionalAccuracy == null || _abstractDQ_PositionalAccuracy.Equals(value) != true)
        {
          _abstractDQ_PositionalAccuracy = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
