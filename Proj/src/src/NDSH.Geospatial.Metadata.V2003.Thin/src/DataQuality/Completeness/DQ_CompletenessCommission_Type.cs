
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 02:45, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.Completeness {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_CompletenessCommission", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("DQ_CompletenessCommission", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DQ_CompletenessCommission")]
  public class DQ_CompletenessCommission_Type : AbstractDQ_Completeness_Type {

  }

}
