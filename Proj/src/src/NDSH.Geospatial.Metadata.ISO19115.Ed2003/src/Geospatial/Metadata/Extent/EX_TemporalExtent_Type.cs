
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 22/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/extent.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="EX_TemporalExtent_Type">
//   <xs:annotation>
//     <xs:documentation>Time period covered by the content of the dataset</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="extent" type="gts:TM_Primitive_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="EX_TemporalExtent" type="gmd:EX_TemporalExtent_Type"/>
// <xs:complexType name="EX_TemporalExtent_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:EX_TemporalExtent"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Extent {

  /// <summary>
  /// Time period covered by the content of the dataset.
  /// </summary>
  [Serializable]
  //[XmlInclude(typeof(EX_SpatialTemporalExtent_Type))] // TODO: Check this XmlInclude
  //[XmlType("EX_TemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("EX_TemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_TemporalExtent")]
  public class EX_TemporalExtent_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_TemporalExtent_Type"/>.
    /// </summary>
    public EX_TemporalExtent_Type() {
      _extent = default; //  new TM_Primitive_PropertyType();
    }

    #endregion

    #region Public Properties

    private TM_Primitive_PropertyType _extent;

    /// <summary>
    /// Date and time for the content of the dataset.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("extent", Order = 0)]
    [JsonProperty("extent", Order = 0)]
    public TM_Primitive_PropertyType Extent {
      get => _extent;
      set => SetProperty(ref _extent, value);
    }

    #endregion

  }

}
