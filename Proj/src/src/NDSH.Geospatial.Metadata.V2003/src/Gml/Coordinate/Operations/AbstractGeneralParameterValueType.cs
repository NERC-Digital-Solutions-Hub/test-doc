
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


using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Operations {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(ParameterValueGroupType))]
  [XmlInclude(typeof(ParameterValueType))]
  [Serializable]
  [XmlType("AbstractGeneralParameterValueType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralParameterValueType")]
  public abstract class AbstractGeneralParameterValueType : ObservableModel {

  }

}
