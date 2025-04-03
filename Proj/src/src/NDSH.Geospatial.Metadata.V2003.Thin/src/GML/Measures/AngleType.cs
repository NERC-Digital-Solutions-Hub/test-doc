
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 03:17, @gisvlasta.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Measures {

  /// <summary>
  /// The AngleType is used to record the value of an angle quantity as a single number, with its units.
  /// </summary>
  [Serializable]
  [XmlType("AngleType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AngleType")]
  public class AngleType : MeasureType {

  }

}
