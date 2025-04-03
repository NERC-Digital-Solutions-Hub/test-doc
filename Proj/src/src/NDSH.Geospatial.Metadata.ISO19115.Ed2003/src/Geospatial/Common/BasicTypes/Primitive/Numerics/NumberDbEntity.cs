
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/01/2023, @gisvlasta
// History           : 27/02/2025, @gisvlasta - Changed it to an abstract class inheriting from ObservableDbEntity.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="Number_PropertyType">
//   <xs:choice minOccurs="0">
//     <xs:element ref="gco:Real"/>
//     <xs:element ref="gco:Decimal"/>
//     <xs:element ref="gco:Integer"/>
//   </xs:choice>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Primitive.Numerics {

  #region XmlIncludes
  //[XmlElement("Decimal", typeof(decimal), Order = 0)]
  //[XmlElement("Integer", typeof(int), DataType = "integer", Order = 0)]
  //[XmlElement("Real", typeof(double), Order = 0)]
  #endregion

  /// <summary>
  /// Represents an entity that maps a number value to a dedicated database table,
  /// aligning with the ISO 19115 <c>Number_PropertyType</c> definition for geospatial metadata.
  /// </summary>
  //[Serializable]
  //[XmlType("Number_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("NumberDbEntity")]
  public abstract class NumberDbEntity : ObservableDbEntity {

  }

}
