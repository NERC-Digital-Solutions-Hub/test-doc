
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/content.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_CoverageDescription_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractMD_ContentInformation_Type">
//       <xs:sequence>
//         <xs:element name="attributeDescription" type="gco:RecordType_PropertyType"/>
//         <xs:element name="contentType" type="gmd:MD_CoverageContentTypeCode_PropertyType"/>
//         <xs:element name="dimension" type="gmd:MD_RangeDimension_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_CoverageDescription"
//             type="gmd:MD_CoverageDescription_Type" substitutionGroup="gmd:AbstractMD_ContentInformation"/>
// <xs:complexType name="MD_CoverageDescription_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_CoverageDescription"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Implementation.Records;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Content {

  #region XmlIncludes
  //[XmlInclude(typeof(MI_ImageDescription_Type))]
  //[XmlInclude(typeof(MI_CoverageDescription_Type))]
  //[XmlInclude(typeof(MD_ImageDescription_Type))]
  #endregion

  /// <summary>
  /// Information about the domain of the raster cell.
  /// </summary>
  [Serializable]
  //[XmlType("MD_CoverageDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_CoverageDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_CoverageDescription")]
  public class MD_CoverageDescription_Type : AbstractMD_ContentInformation_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_CoverageDescription_Type"/>.
    /// </summary>
    public MD_CoverageDescription_Type() {
      _attributeDescription = default; //  new RecordType_PropertyType();
      _contentType = default; //  new MD_CoverageContentTypeCode_PropertyType();
      _dimension = default; //  new List<MD_RangeDimension_Type>();
    }

    #endregion

    #region Public Properties

    private RecordType_PropertyType _attributeDescription;

    /// <summary>
    /// Description of the attribute described by the measurement value.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("attributeDescription", Order = 0)]
    [JsonProperty("attributeDescription", Order = 0)]
    public RecordType_PropertyType AttributeDescription {
      get => _attributeDescription;
      set => SetProperty(ref _attributeDescription, value);
    }

    private MD_CoverageContentTypeCode_CodeList _contentType;

    /// <summary>
    /// Type of information represented by the cell value.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("contentType", Order = 1)]
    [JsonProperty("contentType", Order = 1)]
    public MD_CoverageContentTypeCode_CodeList ContentType {
      get => _contentType;
      set => SetProperty(ref _contentType, value);
    }

    private ObservableCollection<MD_RangeDimension_Type>? _dimension;

    /// <summary>
    /// Information on the dimensions of the cell measurement value.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("dimension", Order = 2)]
    [JsonProperty("dimension", Order = 2)]
    public ObservableCollection<MD_RangeDimension_Type>? Dimension {
      get => _dimension;
      set => SetProperty(ref _dimension, value);
    }

    #endregion

  }

}
