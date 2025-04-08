
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 14/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;

//using NDSH.Geospatial.Metadata.V2003.Localisation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text {

  // TODO: Check if this class is for REMOVAL

  //[XmlInclude(typeof(LanguageCode_PropertyType))]
  [XmlInclude(typeof(CharacterString_PropertyType))]
  [Serializable]
  [XmlType("SubstitutableText", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("SubstitutableText")]
  public abstract class SubstitutableText : NilReasonModel {

  }

}
