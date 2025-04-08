
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 20:50, @gisvlasta.
// Updated by        : 08/02/2023, 01:22, @gisvlasta. - 1.0.1: Added [XmlInclude]s.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Imagery.DataQuality;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(QE_CoverageResult_Type))]
  [XmlInclude(typeof(DQ_QuantitativeResult_Type))]
  [XmlInclude(typeof(DQ_ConformanceResult_Type))]
  [Serializable]
  [XmlType("AbstractDQ_Result", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("AbstractDQ_Result", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractDQ_Result")]
  public abstract class AbstractDQ_Result_Type : AbstractObject_Type {

  }

}
