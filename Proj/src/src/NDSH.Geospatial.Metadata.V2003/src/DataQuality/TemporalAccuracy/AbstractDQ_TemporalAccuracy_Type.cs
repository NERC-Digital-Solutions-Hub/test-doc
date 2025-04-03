
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 19:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namesapces

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
  [XmlInclude(typeof(DQ_AccuracyOfATimeMeasurement_Type))]
  [XmlInclude(typeof(DQ_TemporalConsistency_Type))]
  [XmlInclude(typeof(DQ_TemporalValidity_Type))]
  [XmlType("AbstractDQ_TemporalAccuracy", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("AbstractDQ_TemporalAccuracy", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractDQ_TemporalAccuracy")]
  public abstract class AbstractDQ_TemporalAccuracy_Type : AbstractDQ_Element_Type {

  }

}
