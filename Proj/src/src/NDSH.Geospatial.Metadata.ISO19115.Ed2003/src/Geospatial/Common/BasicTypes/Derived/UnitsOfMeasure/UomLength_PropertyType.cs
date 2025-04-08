
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// History           : 27/02/2025, @gisvlasta - Updated inheritance and class documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="UomLength_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gml:UnitDefinition"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Units;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Derived.UnitsOfMeasure {

  /// <summary>
  /// Represents the ISO/OGC <c>UomLength_PropertyType</c> in geospatial metadata, as defined by 
  /// <see href="http://www.isotc211.org/2005/gco">ISO 19115</see> and leveraging 
  /// <see href="http://www.opengis.net/gml">GML</see> for unit definitions. 
  /// This class inherits from <see cref="UnitDefinitionType"/>, enabling detailed 
  /// descriptions of length-based units of measure (e.g., meters, feet).
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Instances whose properties are of <see cref="UomLength_PropertyType"/> 
  ///     may encode optional metadata such as a nil reason, reflecting the underlying 
  ///     XSD structure’s support for absent or unknown values.
  ///   </para>
  ///   <para>
  ///     By extending <see cref="UnitDefinitionType"/>, this class seamlessly integrates with 
  ///     ISO/GML-compliant systems, ensuring that length-based measurements are accurately 
  ///     documented and consistently interpretable in geospatial metadata records.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("UomLength", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("UomLength")]
  public class UomLength_PropertyType : UnitDefinitionType {

  }

}
