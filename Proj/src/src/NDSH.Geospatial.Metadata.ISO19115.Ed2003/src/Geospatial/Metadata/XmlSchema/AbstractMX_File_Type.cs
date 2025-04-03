
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
// XSD               : /2005/gmx/gmxUsage.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="AbstractMX_File_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="fileName" type="gmx:FileName_PropertyType"/>
//         <xs:element name="fileDescription" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="fileType" type="gmx:MimeFileType_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractMX_File" type="gmx:AbstractMX_File_Type" abstract="true"/>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

using NDSH.Geospatial.Metadata.XmlSchema.Extended;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema {

  [Serializable]
  //[XmlInclude(typeof(MX_SupportFile_Type))]
  //[XmlInclude(typeof(MX_DataFile_Type))]
  //[XmlType("AbstractMX_File", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("AbstractMX_File", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("AbstractMX_File")]
  public abstract class AbstractMX_File_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractMX_File_Type"/>.
    /// </summary>
    public AbstractMX_File_Type() {
      _fileName = default; //  new FileName_PropertyType();
      _fileDescription = default; //  new CharacterString();
      _fileType = default; //  new MimeFileType_PropertyType();
    }

    #endregion

    #region Private fields

    private FileName_Type _fileName;

    /// <summary>
    /// Name of the transfer data file. This name is associated with a path to the physical file.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("fileName", Order = 0)]
    [JsonProperty("fileName", Order = 0)]
    public FileName_Type FileName {
      get => _fileName;
      set => SetProperty(ref _fileName, value);
    }

    private CharacterString _fileDescription;

    /// <summary>
    /// General description of the transfer data file.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("fileDescription", Order = 1)]
    [JsonProperty("fileDescription", Order = 1)]
    public CharacterString FileDescription {
      get => _fileDescription;
      set => SetProperty(ref _fileDescription, value);
    }

    private MimeFileType_Type _fileType;

    /// <summary>
    /// Type of the transfer data file. The textual description of the file type is associated with an indication of
    /// the MIME type.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("fileType", Order = 2)]
    [JsonProperty("fileType", Order = 2)]
    public MimeFileType_Type FileType {
      get => _fileType;
      set => SetProperty(ref _fileType, value);
    }

    #endregion

  }

}
