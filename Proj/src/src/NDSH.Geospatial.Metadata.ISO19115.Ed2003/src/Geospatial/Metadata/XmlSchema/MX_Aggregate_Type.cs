
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 21:18, @gisvlasta.
// Updated by        : 10/01/2023, 01:01, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/gmxUsage.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MX_Aggregate_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractDS_Aggregate_Type">
//       <xs:sequence>
//         <xs:element name="aggregateCatalogue" type="gmx:CT_Catalogue_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="aggregateFile" type="gmx:MX_SupportFile_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MX_Aggregate" type="gmx:MX_Aggregate_Type" substitutionGroup="gmd:AbstractDS_Aggregate"/>
// <xs:complexType name="MX_Aggregate_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:MX_Aggregate"/>
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
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MX_Aggregate", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("MX_Aggregate", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("MX_Aggregate")]
  public class MX_Aggregate_Type : AbstractDS_Aggregate_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_Aggregate_Type"/>.
    /// </summary>
    public MX_Aggregate_Type() {

      // Override the namespace. (It is different from that of AbstractDS_Aggregate_Type).
      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _aggregateCatalogue = default; //  new List<AbstractCT_Catalogue_Type>();
      _aggregateFile = default; //  new List<MX_SupportFile_Type>();

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

    private List<AbstractCT_Catalogue_Type>? _aggregateCatalogue;

    /// <summary>
    /// Provides the list of catalogues related to the transfer aggregate.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    [XmlElement("aggregateCatalogue", Order = 0)]
    [JsonProperty("aggregateCatalogue", Order = 0)]
    public List<AbstractCT_Catalogue_Type>? AggregateCatalogue {
      get {
        return _aggregateCatalogue;
      }
      set => SetProperty(ref _aggregateCatalogue, value);
    }

    private List<MX_SupportFile_Type>? _aggregateFile;

    /// <summary>
    /// Provides the list of support files related to the aggregate. The support files of the datasets composing the
    /// aggregate are not part of this list.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    [XmlElement("aggregateFile", Order = 1)]
    [JsonProperty("aggregateFile", Order = 1)]
    public List<MX_SupportFile_Type>? AggregateFile {
      get {
        return _aggregateFile;
      }
      set => SetProperty(ref _aggregateFile, value);
    }

    #endregion

  }

}
