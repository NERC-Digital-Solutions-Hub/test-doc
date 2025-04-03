
#region Header
// Title Name        : MD_CoverageContentTypeCodeValue
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The specific type of information represented in the cell.
// Created by        : 19/09/2022, 19:02, @gisvlasta
// Updated by        : 18/12/2022, 01:59, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Content {

  /// <summary>
  /// The specific type of information represented in the cell.
  /// </summary>
  [Serializable]
  public enum MD_CoverageContentTypeCodeValue {

    /// <summary>
    /// Numerical representation of a physical parameter that is not the actual value
    /// of the physical parameter.
    /// </summary>
    [XmlEnum(Name = "image")]
    [EnumMember(Value = "image")]
    Image = 1,

    /// <summary>
    /// Code value with no quantitative meaning, used to represent a physical quantity.
    /// </summary>
    [XmlEnum(Name = "thematicClassification")]
    [EnumMember(Value = "thematicClassification")]
    ThematicClassification = 2,

    /// <summary>
    /// Value in physical units of the quantity being measured.
    /// </summary>
    [XmlEnum(Name = "physicalMeasurement")]
    [EnumMember(Value = "physicalMeasurement")]
    PhysicalMeasurement = 3,

  }

}
