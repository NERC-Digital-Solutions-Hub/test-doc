
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
// <element name="AbstractObject" abstract="true">
//   <annotation>
//     <documentation>
//       This element has no type defined, and is therefore implicitly (according to the rules of W3C XML Schema)
//       an XML Schema anyType. It is used as the head of an XML Schema substitution group which unifies
//       complex content and certain simple content elements used for datatypes in GML,
//       including the gml:AbstractGML substitution group.
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

  // WARNING: Rename from AbstractObject to GmlBase.

  /// <summary>
  /// The <see cref="GmlObject"/> serves as a common root for all complex content elements in GML.
  /// <br></br>
  /// Represents the abstract base class for all objects that participate in the GML substitution group.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AbstractObject</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [IsoType("AbstractObject", IsAbstract = true, IsoType = IsoTypes.Element)]
  public abstract class GmlObject : ObservableDbEntity {

  }

}
