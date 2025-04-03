
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 07/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="abstractReference" type="gml:ReferenceType" abstract="true">
//   <annotation>
//     <documentation>
//       gml:abstractReference may be used as the head of a substitution group
//       of more specific elements providing a value by-reference.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from AbstractReference to ReferenceBase.

  /// <summary>
  /// Represents an abstract reference element that serves as the head of a substitution group.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AbstractReference</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [IsoType("abstractReference", IsAbstract = true, IsoType = IsoTypes.Element)]
  public abstract class AbstractReference : ObservableDbEntity {

  }

}
