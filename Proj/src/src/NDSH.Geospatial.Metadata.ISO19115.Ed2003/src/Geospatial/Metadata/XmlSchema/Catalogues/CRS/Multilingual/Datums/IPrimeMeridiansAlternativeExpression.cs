﻿
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 06/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : 
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="PrimeMeridianAlt_Type">
//   <xs:annotation>
//     <xs:documentation>
//       XML attributes constraints:
//         - 1) Id is mandatory
//         - 2) codeSpace (type xsd:anyURI) is mandatory
//     </xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gml:IdentifiedObjectType">
//       <xs:sequence>
//         <xs:element name="locale" type="gmd:PT_Locale_PropertyType"/>
//       </xs:sequence>
//       <xs:attribute name="codeSpace" type="xs:anyURI" use="required"/>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="PrimeMeridianAlt" type="gmx:PrimeMeridianAlt_Type"/>
// <xs:complexType name="PrimeMeridianAlt_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:PrimeMeridianAlt"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS.Multilingual.Datums {

  public interface IPrimeMeridiansAlternativeExpression {

    //[XmlElement("alternativeExpression", Order = 0)] // TODO: Should [XmlElement be in this interface???
    [JsonProperty("alternativeExpression", Order = 0)]
    public List<PrimeMeridianAlt_Type> AlternativeExpression {
      get;
      set;
    }

  }

}
