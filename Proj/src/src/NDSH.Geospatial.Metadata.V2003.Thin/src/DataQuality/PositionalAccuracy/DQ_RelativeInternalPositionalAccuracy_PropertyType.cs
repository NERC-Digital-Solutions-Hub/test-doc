
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:38, @gisvlasta.
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
  [XmlType("DQ_RelativeInternalPositionalAccuracy_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_RelativeInternalPositionalAccuracy_PropertyType")]
  public class DQ_RelativeInternalPositionalAccuracy_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_RelativeInternalPositionalAccuracy_PropertyType"/>.
    /// </summary>
    public DQ_RelativeInternalPositionalAccuracy_PropertyType()
    {
      _dq_RelativeInternalPositionalAccuracy = new DQ_RelativeInternalPositionalAccuracy_Type();
    }

    #endregion

    #region Public Properties

    private DQ_RelativeInternalPositionalAccuracy_Type _dq_RelativeInternalPositionalAccuracy;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_RelativeInternalPositionalAccuracy", Order = 0)]
    [JsonProperty("DQ_RelativeInternalPositionalAccuracy", Order = 0)]
    public DQ_RelativeInternalPositionalAccuracy_Type DQ_RelativeInternalPositionalAccuracy
    {
      get
      {
        return _dq_RelativeInternalPositionalAccuracy;
      }
      set
      {
        if (_dq_RelativeInternalPositionalAccuracy == value)
        {
          return;
        }
        if (_dq_RelativeInternalPositionalAccuracy == null || _dq_RelativeInternalPositionalAccuracy.Equals(value) != true)
        {
          _dq_RelativeInternalPositionalAccuracy = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
