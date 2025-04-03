
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 01:10, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Extension {

  /// <summary>
  /// Obligation of the element or entity.
  /// </summary>
  [Serializable]
  [XmlType("MD_ObligationCode", Namespace = "http://www.isotc211.org/2005/gmd")] // TODO: Should it be AnonymousType???
  [XmlRoot("MD_ObligationCode", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)] // TODO: Should this XmlRoot be here???
  public enum MD_ObligationCode_Type {

    /// <summary>
    /// Element is always required.
    /// </summary>
    [XmlEnum(Name = "mandatory")]
    [EnumMember(Value = "mandatory")]
    Mandatory = 1,

    /// <summary>
    /// Element is not required.
    /// </summary>
    [XmlEnum(Name = "optional")]
    [EnumMember(Value = "optional")]
    Optional = 2,

    /// <summary>
    /// Element is required when a specific condition is met.
    /// </summary>
    [XmlEnum(Name = "conditional")]
    [EnumMember(Value = "conditional")]
    Conditional = 3,

  }

}
