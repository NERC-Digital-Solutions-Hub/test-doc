
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:52, @gisvlasta.
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
  [XmlType("DQ_TemporalValidity_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_TemporalValidity_PropertyType")]
  public class DQ_TemporalValidity_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_TemporalValidity_PropertyType"/>.
    /// </summary>
    public DQ_TemporalValidity_PropertyType()
    {
      _dq_TemporalValidity = new DQ_TemporalValidity_Type();
    }

    #endregion

    #region Public Properties

    private DQ_TemporalValidity_Type _dq_TemporalValidity;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_TemporalValidity", Order = 0)]
    [JsonProperty("DQ_TemporalValidity", Order = 0)]
    public DQ_TemporalValidity_Type DQ_TemporalValidity
    {
      get
      {
        return _dq_TemporalValidity;
      }
      set
      {
        if (_dq_TemporalValidity == value)
        {
          return;
        }
        if (_dq_TemporalValidity == null || _dq_TemporalValidity.Equals(value) != true)
        {
          _dq_TemporalValidity = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
