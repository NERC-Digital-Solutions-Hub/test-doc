
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 20:48, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.LogicalConsistency {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(DQ_ConceptualConsistency_Type))]
  [XmlInclude(typeof(DQ_DomainConsistency_Type))]
  [XmlInclude(typeof(DQ_FormatConsistency_Type))]
  [XmlInclude(typeof(DQ_TopologicalConsistency_Type))]
  [XmlType("AbstractDQ_LogicalConsistency", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("AbstractDQ_LogicalConsistency", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractDQ_LogicalConsistency")]
  public abstract class AbstractDQ_LogicalConsistency_Type : AbstractDQ_Element_Type {

  }

}
