
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 20:29, @gisvlasta.
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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Service.Metadata {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_ParameterDirection", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("SV_ParameterDirection", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)] // TODO: Should this XmlRoot be here???
  public enum SV_ParameterDirection_Type {

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "in")]
    [EnumMember(Value = "in")]
    In = 1,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "out")]
    [EnumMember(Value = "out")]
    Out = 2,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "in/out")]
    [EnumMember(Value = "in/out")]
    InOut = 3,

  }

}
