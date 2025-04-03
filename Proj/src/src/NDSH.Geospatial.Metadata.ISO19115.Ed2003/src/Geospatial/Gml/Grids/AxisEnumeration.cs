
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 05/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using System.Runtime.Serialization;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Grids {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
  public enum AxisEnumeration {

    [XmlEnum(Name = "axisLabels")]
    [EnumMember(Value = "axisLabels")]
    AxisLabels,

    [XmlEnum(Name = "axisName")]
    [EnumMember(Value = "axisName")]
    AxisName,

  }

}
