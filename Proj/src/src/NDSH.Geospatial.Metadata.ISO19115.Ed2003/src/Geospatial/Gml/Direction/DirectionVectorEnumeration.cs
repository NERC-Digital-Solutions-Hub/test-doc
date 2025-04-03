
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 01/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
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

namespace NDSH.Geospatial.Gml.Direction {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
  public enum DirectionVectorEnumeration {

    [XmlEnum(Name = "horizontalAngle")]
    [EnumMember(Value = "horizontalAngle")]
    HorizontalAngle,

    [XmlEnum(Name = "vector")]
    [EnumMember(Value = "vector")]
    Vector,

    [XmlEnum(Name = "verticalAngle")]
    [EnumMember(Value = "verticalAngle")]
    VerticalAngle,

  }

}
