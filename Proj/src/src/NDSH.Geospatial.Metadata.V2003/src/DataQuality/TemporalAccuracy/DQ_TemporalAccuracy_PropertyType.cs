
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:46, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.DataQuality.TemporalAccuracy {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_TemporalAccuracy_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_TemporalAccuracy_PropertyType")]
  public class DQ_TemporalAccuracy_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractDQ_TemporalAccuracy_Type _abstractDQ_TemporalAccuracy;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractDQ_TemporalAccuracy", Order = 0)]
    [JsonProperty("AbstractDQ_TemporalAccuracy", Order = 0)]
    public AbstractDQ_TemporalAccuracy_Type AbstractDQ_TemporalAccuracy
    {
      get
      {
        return _abstractDQ_TemporalAccuracy;
      }
      set
      {
        if (_abstractDQ_TemporalAccuracy == value)
        {
          return;
        }
        if (_abstractDQ_TemporalAccuracy == null || _abstractDQ_TemporalAccuracy.Equals(value) != true)
        {
          _abstractDQ_TemporalAccuracy = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
