
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:24, @gisvlasta.
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
  [XmlType("DQ_GriddedDataPositionalAccuracy_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_GriddedDataPositionalAccuracy_PropertyType")]
  public class DQ_GriddedDataPositionalAccuracy_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_GriddedDataPositionalAccuracy_PropertyType"/>.
    /// </summary>
    public DQ_GriddedDataPositionalAccuracy_PropertyType()
    {
      _dq_GriddedDataPositionalAccuracy = new DQ_GriddedDataPositionalAccuracy_Type();
    }

    #endregion

    #region Public Properties

    private DQ_GriddedDataPositionalAccuracy_Type _dq_GriddedDataPositionalAccuracy;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_GriddedDataPositionalAccuracy", Order = 0)]
    [JsonProperty("DQ_GriddedDataPositionalAccuracy", Order = 0)]
    public DQ_GriddedDataPositionalAccuracy_Type DQ_GriddedDataPositionalAccuracy
    {
      get
      {
        return _dq_GriddedDataPositionalAccuracy;
      }
      set
      {
        if (_dq_GriddedDataPositionalAccuracy == value)
        {
          return;
        }
        if (_dq_GriddedDataPositionalAccuracy == null || _dq_GriddedDataPositionalAccuracy.Equals(value) != true)
        {
          _dq_GriddedDataPositionalAccuracy = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
