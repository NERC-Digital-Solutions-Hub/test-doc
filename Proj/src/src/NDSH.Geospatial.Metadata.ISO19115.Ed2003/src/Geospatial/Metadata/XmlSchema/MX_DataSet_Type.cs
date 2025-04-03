
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 00:01, @gisvlasta.
// Updated by        : 10/01/2023, 01:09, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/gxmUsage.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MX_DataSet_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:DS_DataSet_Type">
//       <xs:sequence>
//         <xs:element name="dataFile" type="gmx:MX_DataFile_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="datasetCatalogue" type="gmx:CT_Catalogue_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="supportFile" type="gmx:MX_SupportFile_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MX_DataSet" type="gmx:MX_DataSet_Type" substitutionGroup="gmd:DS_DataSet"/>
// <xs:complexType name="MX_DataSet_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:MX_DataSet"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.Application;
using NDSH.Geospatial.Metadata.XmlSchema.Catalogues;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MX_DataSet", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("MX_DataSet", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("MX_DataSet")]
  public class MX_DataSet_Type : DS_DataSet_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_DataSet_Type"/>.
    /// </summary>
    public MX_DataSet_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _dataFile = default; //  new List<MX_DataFile_Type>();
      _datasetCatalogue = default; //  new List<AbstractCT_Catalogue_Type>();
      _supportFile = default; //  new List<MX_SupportFile_Type>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public new XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<MX_DataFile_Type> _dataFile;

    /// <summary>
    /// Provides the list of data files in which the data are stored.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    [XmlElement("dataFile", Order = 0)]
    [JsonProperty("dataFile", Order = 0)]
    public List<MX_DataFile_Type> DataFile {
      get {
        return _dataFile;
      }
      set => SetProperty(ref _dataFile, value);
    }

    private List<AbstractCT_Catalogue_Type> _datasetCatalogue;

    /// <summary>
    /// Provides the list of catalogues related to the transfer dataset.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    [XmlElement("datasetCatalogue", Order = 1)]
    [JsonProperty("datasetCatalogue", Order = 1)]
    public List<AbstractCT_Catalogue_Type> DatasetCatalogue {
      get {
        return _datasetCatalogue;
      }
      set => SetProperty(ref _datasetCatalogue, value);
    }

    private List<MX_SupportFile_Type> _supportFile;

    /// <summary>
    /// Provides the list of support files related to the dataset.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    [XmlElement("supportFile", Order = 2)]
    [JsonProperty("supportFile", Order = 2)]
    public List<MX_SupportFile_Type> SupportFile {
      get {
        return _supportFile;
      }
      set => SetProperty(ref _supportFile, value);
    }

    #endregion

  }

}
