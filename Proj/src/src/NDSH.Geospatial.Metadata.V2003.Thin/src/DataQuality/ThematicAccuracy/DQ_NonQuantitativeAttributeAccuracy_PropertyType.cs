
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:28, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.ThematicAccuracy {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_NonQuantitativeAttributeAccuracy_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_NonQuantitativeAttributeAccuracy_PropertyType")]
  public class DQ_NonQuantitativeAttributeAccuracy_PropertyType : ObjectReference_PropertyType
  {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_NonQuantitativeAttributeAccuracy_PropertyType"/>.
    /// </summary>
    public DQ_NonQuantitativeAttributeAccuracy_PropertyType()
    {
      _dq_NonQuantitativeAttributeAccuracy = new DQ_NonQuantitativeAttributeAccuracy_Type();
    }

    #endregion

    #region Private fields

    private DQ_NonQuantitativeAttributeAccuracy_Type _dq_NonQuantitativeAttributeAccuracy;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_NonQuantitativeAttributeAccuracy", Order = 0)]
    [JsonProperty("DQ_NonQuantitativeAttributeAccuracy", Order = 0)]
    public DQ_NonQuantitativeAttributeAccuracy_Type DQ_NonQuantitativeAttributeAccuracy
    {
      get
      {
        return _dq_NonQuantitativeAttributeAccuracy;
      }
      set
      {
        if (_dq_NonQuantitativeAttributeAccuracy == value)
        {
          return;
        }
        if (_dq_NonQuantitativeAttributeAccuracy == null || _dq_NonQuantitativeAttributeAccuracy.Equals(value) != true)
        {
          _dq_NonQuantitativeAttributeAccuracy = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
