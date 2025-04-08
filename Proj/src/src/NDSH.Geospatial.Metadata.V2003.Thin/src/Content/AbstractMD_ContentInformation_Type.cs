
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 02:15, @gisvlasta.
// Updated by        : 09/01/2023, 18:25, @gisvlasta. - 1.0.1: Added xmlns field.
//                   : 08/02/2023, 00:53, @gisvlasta. - 1.0.2: Added [XmlInclude]s.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Content;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Content {

  // TODO: IMPORTANT - Move the XmlInclude Types in their correct places.

  /// <summary>
  /// 
  /// </summary>
  /// 
  [XmlInclude(typeof(MI_ImageDescription_Type))]
  [XmlInclude(typeof(MI_CoverageDescription_Type))]
  [XmlInclude(typeof(MD_CoverageDescription_Type))]
  [XmlInclude(typeof(MD_ImageDescription_Type))]
  [XmlInclude(typeof(MD_FeatureCatalogueDescription_Type))]
  [Serializable]
  [XmlType("AbstractMD_ContentInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("AbstractMD_ContentInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractMD_ContentInformation")]
  public abstract class AbstractMD_ContentInformation_Type : AbstractObject_Type {

  }

}
