
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 27/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : The following XSD definition is about MD_DataFile_Type. Image files defined in this class
//                     do not have features; therefore the featureTypes object should be absent.
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/gmxUsage.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MX_DataFile_Type">
//   <xs:complexContent>
//     <xs:extension base="gmx:AbstractMX_File_Type">
//       <xs:sequence>
//         <xs:element name="featureTypes" type="gco:GenericName_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="fileFormat" type="gmd:MD_Format_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MX_DataFile" type="gmx:MX_DataFile_Type" substitutionGroup="gmx:AbstractMX_File"/>
// <xs:complexType name="MX_DataFile_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:MX_DataFile"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.Distribution;
using NDSH.Geospatial.Metadata.XmlSchema;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Imagery.DataQuality {

  [Serializable]
  //[XmlType("MX_DataFile", Namespace = "http://www.isotc211.org/2005/gmi")]
  //[XmlRoot("MX_DataFile", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MX_DataFile")]
  public class MX_ImgDataFile_Type : AbstractMX_File_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_ImgDataFile_Type"/>
    /// </summary>
    public MX_ImgDataFile_Type() {
      _fileFormat = default; // new MD_Format_Type();
    }

    #endregion

    #region Public Properties

    private MD_Format_Type _fileFormat;

    /// <summary>
    /// Defines the format of the transfer data file.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("fileFormat", Order = 0)]
    [JsonProperty("fileFormat", Order = 0)]
    public MD_Format_Type FileFormat {
      get => _fileFormat;
      set => SetProperty(ref _fileFormat, value);
    }

    #endregion

  }

}
