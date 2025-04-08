
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 08/02/2022, 02:02, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/spatialRepresentation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="AbstractMD_SpatialRepresentation_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence/>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractMD_SpatialRepresentation"
//             type="gmd:AbstractMD_SpatialRepresentation_Type" abstract="true"/>
// <xs:complexType name="MD_SpatialRepresentation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:AbstractMD_SpatialRepresentation"/>
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

namespace NDSH.Geospatial.Metadata.SpatialRepresentation {

  /// <summary>
  /// Digital mechanism used to represent spatial information.
  /// </summary>
  //[XmlInclude(typeof(MI_Georectified_Type))]
  //[XmlInclude(typeof(MI_Georeferenceable_Type))]
  //[XmlInclude(typeof(MD_VectorSpatialRepresentation_Type))]
  //[XmlInclude(typeof(MD_GridSpatialRepresentation_Type))]
  //[XmlInclude(typeof(MD_Georectified_Type))]
  //[XmlInclude(typeof(MD_Georeferenceable_Type))]
  [Serializable]
  //[XmlType("AbstractMD_SpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("AbstractMD_SpatialRepresentation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractMD_SpatialRepresentation")]
  public abstract class AbstractMD_SpatialRepresentation_Type : MetadataObject {

  }

}
