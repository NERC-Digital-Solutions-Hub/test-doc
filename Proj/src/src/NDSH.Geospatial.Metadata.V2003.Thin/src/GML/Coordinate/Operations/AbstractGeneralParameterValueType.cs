
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 01/02/2023, 20:47, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Operations
{

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(ParameterValueGroupType))]
  [XmlInclude(typeof(ParameterValueType))]
  [Serializable]
  [XmlType("AbstractGeneralParameterValueType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralParameterValueType")]
  public abstract class AbstractGeneralParameterValueType : Model
  {

  }

}
