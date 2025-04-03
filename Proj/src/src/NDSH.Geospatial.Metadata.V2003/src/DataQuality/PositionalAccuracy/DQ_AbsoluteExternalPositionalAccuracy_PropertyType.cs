
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 00:48, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.DataQuality.PositionalAccuracy {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_AbsoluteExternalPositionalAccuracy_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_AbsoluteExternalPositionalAccuracy_PropertyType")]
  public class DQ_AbsoluteExternalPositionalAccuracy_PropertyType : ObjectReference_PropertyType {

    #region Imported Namespaces

    /// <summary>
    /// Initializes the <see cref="DQ_AbsoluteExternalPositionalAccuracy_PropertyType"/>.
    /// </summary>
    public DQ_AbsoluteExternalPositionalAccuracy_PropertyType()
    {
      _dq_AbsoluteExternalPositionalAccuracy = new DQ_AbsoluteExternalPositionalAccuracy_Type();
    }

    #endregion

    #region Public Properties

    private DQ_AbsoluteExternalPositionalAccuracy_Type _dq_AbsoluteExternalPositionalAccuracy;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_AbsoluteExternalPositionalAccuracy", Order = 0)]
    [JsonProperty("DQ_AbsoluteExternalPositionalAccuracy", Order = 0)]
    public DQ_AbsoluteExternalPositionalAccuracy_Type DQ_AbsoluteExternalPositionalAccuracy
    {
      get
      {
        return _dq_AbsoluteExternalPositionalAccuracy;
      }
      set
      {
        if (_dq_AbsoluteExternalPositionalAccuracy == value)
        {
          return;
        }
        if (_dq_AbsoluteExternalPositionalAccuracy == null || _dq_AbsoluteExternalPositionalAccuracy.Equals(value) != true)
        {
          _dq_AbsoluteExternalPositionalAccuracy = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
