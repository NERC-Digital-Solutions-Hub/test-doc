
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coverage.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="FileType">
//   <sequence>
//     <element ref="gml:rangeParameters"/>
//     <choice>
//       <element name="fileName" type="anyURI"/>
//       <element name="fileReference" type="anyURI"/>
//     </choice>
//     <element name="fileStructure" type="gml:FileValueModelType"/>
//     <element name="mimeType" type="anyURI" minOccurs="0"/>
//     <element name="compression" type="anyURI" minOccurs="0"/>
//   </sequence>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

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

namespace NDSH.Geospatial.Gml.Coverage {

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
