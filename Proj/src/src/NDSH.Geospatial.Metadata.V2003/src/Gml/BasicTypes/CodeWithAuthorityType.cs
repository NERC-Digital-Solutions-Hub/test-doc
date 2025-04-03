
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 02:02, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes {

  /// <summary>
  /// gml:CodeWithAuthorityType requires that the codeSpace attribute is provided in an instance.
  /// </summary>
  [Serializable]
  [XmlType("CodeWithAuthorityType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CodeWithAuthorityType")]
  public class CodeWithAuthorityType : CodeType {

  }

}
