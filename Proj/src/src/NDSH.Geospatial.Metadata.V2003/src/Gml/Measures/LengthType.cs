
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Measures {

  /// <summary>
  /// This is a prototypical definition for a specific measure type defined
  /// as a vacuous extension (i.e. aliases) of gml:MeasureType.
  /// In this case, the content model supports the description of a length
  /// (or distance) quantity, with its units. The unit of measure referenced
  /// by uom shall be suitable for a length, such as metres or feet.
  /// </summary>
  [Serializable]
  [XmlType("LengthType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("LengthType")]
  public class LengthType : MeasureType {

  }

}
