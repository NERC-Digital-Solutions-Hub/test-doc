
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 18:10, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_OperationModel", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("SV_OperationModel", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)] // TODO: Should this XmlRoot be here???
  public enum SV_OperationModel_Type {

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "object")]
    [EnumMember(Value = "object")]
    @Object = 1,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "message")]
    [EnumMember(Value = "message")]
    Message = 2,

  }

}
