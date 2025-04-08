
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 08/02/2022, 02:02, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.Imagery.SpatialRepresentation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.SpatialRepresentation {

  /// <summary>
  /// Digital mechanism used to represent spatial information.
  /// </summary>
  [XmlInclude(typeof(MI_Georectified_Type))]
  [XmlInclude(typeof(MI_Georeferenceable_Type))]
  [XmlInclude(typeof(MD_VectorSpatialRepresentation_Type))]
  [XmlInclude(typeof(MD_GridSpatialRepresentation_Type))]
  [XmlInclude(typeof(MD_Georectified_Type))]
  [XmlInclude(typeof(MD_Georeferenceable_Type))]
  [Serializable]
  [XmlType("AbstractMD_SpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("AbstractMD_SpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractMD_SpatialRepresentation")]
  public abstract class AbstractMD_SpatialRepresentation_Type : AbstractObject_Type {

  }

}
