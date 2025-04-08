
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 10/03/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="AbstractMetaData"
//          type="gml:AbstractMetaDataType" abstract="true" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <complexType name="AbstractMetaDataType" abstract="true" mixed="true">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence/>
//   <attribute ref="gml:id"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from AbstractMetaData to MetaDataBase.

  /// <summary>
  /// Represents the abstract base class for metadata elements in GML.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AbstractMetaData</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd")] // RESOURCE
  [IsoType("AbstractMetaData", IsAbstract = true, IsoType = IsoTypes.Element)]
  //[XmlInclude(typeof(AbstractMetaDataType))]
  public abstract class AbstractMetaData : GmlObject {

  }

}
