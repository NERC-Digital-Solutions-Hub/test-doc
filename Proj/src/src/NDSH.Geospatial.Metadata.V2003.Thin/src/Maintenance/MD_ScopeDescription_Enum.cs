
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 16:35, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Maintenance {
  
  // TODO: DANGER!!! - What about this enumeration???

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd", IncludeInSchema = false)]
  public enum MD_ScopeDescription_Enum {

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "attributeInstances")]
    [EnumMember(Value = "attributeInstances")]
    AttributeInstances,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "attributes")]
    [EnumMember(Value = "attributes")]
    Attributes,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "dataset")]
    [EnumMember(Value = "dataset")]
    Dataset,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "featureInstances")]
    [EnumMember(Value = "featureInstances")]
    FeatureInstances,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "features")]
    [EnumMember(Value = "features")]
    Features,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "other")]
    [EnumMember(Value = "other")]
    Other,

  }

}
