
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:03, @gisvlasta.
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
  [XmlType("DQ_CompletenessOmission_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_CompletenessOmission_PropertyType")]
  public class DQ_CompletenessOmission_PropertyType : ObjectReference_PropertyType   {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_CompletenessOmission_PropertyType"/>.
    /// </summary>
    public DQ_CompletenessOmission_PropertyType()
    {
      _dq_CompletenessOmission = new DQ_CompletenessOmission_Type();
    }

    #endregion

    #region Private fields

    private DQ_CompletenessOmission_Type _dq_CompletenessOmission;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_CompletenessOmission", Order = 0)]
    [JsonProperty("DQ_CompletenessOmission", Order = 0)]
    public DQ_CompletenessOmission_Type DQ_CompletenessOmission
    {
      get
      {
        return _dq_CompletenessOmission;
      }
      set
      {
        if (_dq_CompletenessOmission == value)
        {
          return;
        }
        if (_dq_CompletenessOmission == null || _dq_CompletenessOmission.Equals(value) != true)
        {
          _dq_CompletenessOmission = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
