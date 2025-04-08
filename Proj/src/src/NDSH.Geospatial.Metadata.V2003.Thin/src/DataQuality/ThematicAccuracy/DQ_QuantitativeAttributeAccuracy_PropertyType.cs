
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:33, @gisvlasta.
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
  [XmlType("DQ_QuantitativeAttributeAccuracy_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_QuantitativeAttributeAccuracy_PropertyType")]
  public class DQ_QuantitativeAttributeAccuracy_PropertyType : ObjectReference_PropertyType
  {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_QuantitativeAttributeAccuracy_PropertyType"/>.
    /// </summary>
    public DQ_QuantitativeAttributeAccuracy_PropertyType()
    {
      _dq_QuantitativeAttributeAccuracy = new DQ_QuantitativeAttributeAccuracy_Type();
    }

    #endregion

    #region Public Properties

    private DQ_QuantitativeAttributeAccuracy_Type _dq_QuantitativeAttributeAccuracy;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_QuantitativeAttributeAccuracy", Order = 0)]
    [JsonProperty("DQ_QuantitativeAttributeAccuracy", Order = 0)]
    public DQ_QuantitativeAttributeAccuracy_Type DQ_QuantitativeAttributeAccuracy
    {
      get
      {
        return _dq_QuantitativeAttributeAccuracy;
      }
      set
      {
        if (_dq_QuantitativeAttributeAccuracy == value)
        {
          return;
        }
        if (_dq_QuantitativeAttributeAccuracy == null || _dq_QuantitativeAttributeAccuracy.Equals(value) != true)
        {
          _dq_QuantitativeAttributeAccuracy = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
