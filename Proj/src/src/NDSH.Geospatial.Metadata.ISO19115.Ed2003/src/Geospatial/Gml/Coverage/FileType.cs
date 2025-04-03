
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : 
// ---------------------------------------------------------------------------------------------------------------------
// <element name="File" type="gml:FileType" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <documentation>
//       for efficiency reasons, GML also provides a means of encoding the range set in an arbitrary external encoding,
//       such as a binary file.  This encoding may be “well-known” but this is not required.
//       This mode uses the gml:File element. The values of the coverage (attribute values in the range set)
//       are transmitted in a external file that is referenced from the XML structure described by gml:FileType.
//       The external file is referenced by the gml:fileReference property that is an anyURI
//       (the gml:fileName property has been deprecated). This means that the external file may be located remotely
//       from the referencing GML instance.
//       The gml:compression property points to a definition of a compression algorithm through an anyURI.
//       This may be a retrievable, computable definition or simply a reference to an unambiguous name
//       for the compression method.
//       The gml:mimeType property points to a definition of the file mime type.
//       The gml:fileStructure property is defined by the gml:FileValueModelType.
//       This is simple enumerated type restriction on string. The only value supported in GML is “Record Interleaved”.
//       Additional values may be supported in future releases of GML.
//       Note further that all values shall be enclosed in a single file. Multi-file structures
//       for values are not supported in GML. The semantics of the range set is described as above using
//       the gml:rangeParameters property.
//       Note that if any compression algorithm is applied, the structure above applies only to the pre-compression or
//       post-decompression structure of the file.
//       Note that the fields within a record match the gml:valueComponents of the gml:CompositeValue in document order.
//     </documentation>
//   </annotation>
// </element>

// <complexType name="FileType">
//   <sequence>
//     <element ref="gml:rangeParameters"/>
//     <choice>
//       <element name="fileName" type="anyURI"/>
//       <element name="fileReference" type="anyURI"/>
//     </choice>
//     <element name="fileStructure" type="gml:FileValueModelType"/>
//     <element name="mimeType" type="anyURI" minOccurs="0"/>
//     <element name="compression" type="anyURI" minOccurs="0"/>
//   </sequence>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 03:03, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coverage {

  /// <summary>
  /// 
  /// </summary>
  [IsoType("FileType", IsoType = IsoTypes.ComplexType)]
  [XmlType("FileType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("FileType")]
  public class FileType : ObservableModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="FileType"/>.
    /// </summary>
    public FileType() {
      _rangeParameters = new RangeParametersType();
    }

    #endregion

    #region Public Properties

    private RangeParametersType _rangeParameters;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("rangeParameters", Order = 0)]
    [JsonProperty("rangeParameters", Order = 0)]
    public RangeParametersType RangeParameters {
      get {
        return _rangeParameters;
      }
      set {
        if (_rangeParameters == value) {
          return;
        }
        if (_rangeParameters == null || _rangeParameters.Equals(value) != true) {
          _rangeParameters = value;
          OnPropertyChanged();
        }
      }
    }

    private string _fileItem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileName", DataType = "anyURI", Order = 1)]
    [XmlElement("fileReference", DataType = "anyURI", Order = 1)]
    [XmlChoiceIdentifier("FileItemElementName")]
    public string FileItem {
      get {
        return _fileItem;
      }
      set {
        if (_fileItem == value) {
          return;
        }
        if (_fileItem == null || _fileItem.Equals(value) != true) {
          _fileItem = value;
          OnPropertyChanged();
        }
      }
    }

    private FileEnumeration _fileItemElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("FileItemElementName", Order = 2)]
    [XmlIgnore]
    public FileEnumeration FileItemElementName {
      get {
        return _fileItemElementName;
      }
      set {
        if (_fileItemElementName.Equals(value) != true) {
          _fileItemElementName = value;
          OnPropertyChanged();
        }
      }
    }

    private FileValueModelType _fileStructure;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileStructure", Order = 3)]
    [JsonProperty("fileStructure", Order = 3)]
    public FileValueModelType FileStructure {
      get {
        return _fileStructure;
      }
      set {
        if (_fileStructure.Equals(value) != true) {
          _fileStructure = value;
          OnPropertyChanged();
        }
      }
    }

    private string _mimeType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("mimeType", DataType = "anyURI", Order = 4)]
    [JsonProperty("mimeType", Order = 4)]
    public string MimeType {
      get {
        return _mimeType;
      }
      set {
        if (_mimeType == value) {
          return;
        }
        if (_mimeType == null || _mimeType.Equals(value) != true) {
          _mimeType = value;
          OnPropertyChanged();
        }
      }
    }

    private string _compression;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("compression", DataType = "anyURI", Order = 5)]
    [JsonProperty("compression", Order = 5)]
    public string Compression {
      get {
        return _compression;
      }
      set {
        if (_compression == value) {
          return;
        }
        if (_compression == null || _compression.Equals(value) != true) {
          _compression = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
