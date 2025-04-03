
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
// <simpleType name="FileValueModelType">
//   <restriction base="string">
//     <enumeration value="Record Interleaved"/>
//   </restriction>
// </simpleType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coverage {

  [IsoType("FileValueModelType", IsoType = IsoTypes.SimpleType)]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  public enum FileValueModelType {

    [XmlEnumAttribute("Record Interleaved")]
    [EnumMember(Value = "Record Interleaved")]
    RecordInterleaved,

  }

}
