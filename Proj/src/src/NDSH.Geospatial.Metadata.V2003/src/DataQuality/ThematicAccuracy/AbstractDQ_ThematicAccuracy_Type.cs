
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 20:51, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.DataQuality.ThematicAccuracy {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(DQ_ThematicClassificationCorrectness_Type))]
  [XmlInclude(typeof(DQ_NonQuantitativeAttributeAccuracy_Type))]
  [XmlInclude(typeof(DQ_QuantitativeAttributeAccuracy_Type))]
  [XmlType("AbstractDQ_ThematicAccuracy", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("AbstractDQ_ThematicAccuracy", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractDQ_ThematicAccuracy")]
  public abstract class AbstractDQ_ThematicAccuracy_Type : AbstractDQ_Element_Type {

  }

}
