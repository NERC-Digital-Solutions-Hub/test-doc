
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 03:07, @gisvlasta.
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
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coverage {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
  public enum FileEnumeration {

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "fileName")]
    [EnumMember(Value = "fileName")]
    FileName,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "fileReference")]
    [EnumMember(Value = "fileReference")]
    FileReference,

  }

}
