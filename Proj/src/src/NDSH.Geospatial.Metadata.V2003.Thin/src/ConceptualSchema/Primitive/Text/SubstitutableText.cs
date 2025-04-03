
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 11/03/2022, 15:28, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Thin.Localisation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text {

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(LanguageCode_PropertyType))]
  //[XmlInclude(typeof(CharacterString_PropertyType))]
  [XmlInclude(typeof(CharacterString))]
  [Serializable]
  [XmlType("SubstitutableText", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("SubstitutableText")]
  public abstract class SubstitutableText : NilReasonModel {

  }

}
