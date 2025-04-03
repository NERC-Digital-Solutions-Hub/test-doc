
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 17:38, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Application {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DS_ProductionSeries", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("DS_ProductionSeries", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DS_ProductionSeries")]
  public class DS_ProductionSeries_Type : DS_Series_Type {

  }

}
