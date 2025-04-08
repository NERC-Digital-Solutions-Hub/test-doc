
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 13/03/2025, @gisvlasta
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
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial {

  /// <summary>
  /// Defines the ISO types found in an XSD definition.
  /// </summary>
  public enum IsoTypes {

    /// <summary>
    /// The type is unknown.
    /// </summary>
    Unknown,

    /// <summary>
    /// An XSD complexType.
    /// </summary>
    ComplexType,

    /// <summary>
    /// An XSD simpleType.
    /// </summary>
    SimpleType,

    /// <summary>
    /// An XSD element.
    /// </summary>
    Element,

    /// <summary>
    /// An XSD attribute.
    /// </summary>
    Attribute,

    /// <summary>
    /// An XSD attributeGroup.
    /// </summary>
    AttributeGroup,

  }

}
