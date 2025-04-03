
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:00, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.DataQuality.Completeness {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_CompletenessCommission_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_CompletenessCommission_PropertyType")]
  public class DQ_CompletenessCommission_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_CompletenessCommission_PropertyType"/>.
    /// </summary>
    public DQ_CompletenessCommission_PropertyType()
    {
      _dq_CompletenessCommission = new DQ_CompletenessCommission_Type();
    }

    #endregion

    #region Public Properties

    private DQ_CompletenessCommission_Type _dq_CompletenessCommission;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_CompletenessCommission", Order = 0)]
    [JsonProperty("DQ_CompletenessCommission", Order = 0)]
    public DQ_CompletenessCommission_Type DQ_CompletenessCommission
    {
      get
      {
        return _dq_CompletenessCommission;
      }
      set
      {
        if (_dq_CompletenessCommission == value)
        {
          return;
        }
        if (_dq_CompletenessCommission == null || _dq_CompletenessCommission.Equals(value) != true)
        {
          _dq_CompletenessCommission = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
