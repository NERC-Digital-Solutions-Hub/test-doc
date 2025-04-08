
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 00:53, @gisvlasta.
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
  [XmlType("DQ_AccuracyOfATimeMeasurement_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_AccuracyOfATimeMeasurement_PropertyType")]
  public class DQ_AccuracyOfATimeMeasurement_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_AccuracyOfATimeMeasurement_PropertyType"/>.
    /// </summary>
    public DQ_AccuracyOfATimeMeasurement_PropertyType()
    {
      _dq_AccuracyOfATimeMeasurement = new DQ_AccuracyOfATimeMeasurement_Type();
    }

    #endregion

    #region Public Properties

    private DQ_AccuracyOfATimeMeasurement_Type _dq_AccuracyOfATimeMeasurement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_AccuracyOfATimeMeasurement", Order = 0)]
    [JsonProperty("DQ_AccuracyOfATimeMeasurement", Order = 0)]
    public DQ_AccuracyOfATimeMeasurement_Type DQ_AccuracyOfATimeMeasurement
    {
      get
      {
        return _dq_AccuracyOfATimeMeasurement;
      }
      set
      {
        if (_dq_AccuracyOfATimeMeasurement == value)
        {
          return;
        }
        if (_dq_AccuracyOfATimeMeasurement == null || _dq_AccuracyOfATimeMeasurement.Equals(value) != true)
        {
          _dq_AccuracyOfATimeMeasurement = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
