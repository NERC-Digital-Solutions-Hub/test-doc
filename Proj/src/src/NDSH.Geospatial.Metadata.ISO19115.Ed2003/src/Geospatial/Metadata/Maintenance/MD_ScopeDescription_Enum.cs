
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Maintenance {

  // WARNING - Should this enumeration be used in the ScopeDescriptions or should it be removed?

  [Serializable]
  //[XmlType(Namespace = "http://www.isotc211.org/2005/gmd", IncludeInSchema = false)]
  public enum MD_ScopeDescription_Enum {

    //[XmlEnum(Name = "attributeInstances")]
    [EnumMember(Value = "attributeInstances")]
    AttributeInstances,

    //[XmlEnum(Name = "attributes")]
    [EnumMember(Value = "attributes")]
    Attributes,

    //[XmlEnum(Name = "dataset")]
    [EnumMember(Value = "dataset")]
    Dataset,

    //[XmlEnum(Name = "featureInstances")]
    [EnumMember(Value = "featureInstances")]
    FeatureInstances,

    //[XmlEnum(Name = "features")]
    [EnumMember(Value = "features")]
    Features,

    //[XmlEnum(Name = "other")]
    [EnumMember(Value = "other")]
    Other,

  }

}
