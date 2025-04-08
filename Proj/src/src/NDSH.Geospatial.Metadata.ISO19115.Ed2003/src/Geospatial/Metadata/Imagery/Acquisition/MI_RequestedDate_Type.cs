
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:34, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          :
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmi/acquisitionInformation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MI_RequestedDate_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="requestedDateOfCollection" type="gco:DateTime_PropertyType"/>
//         <xs:element name="latestAcceptableDate" type="gco:DateTime_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MI_RequestedDate" type="gmi:MI_RequestedDate_Type"/>
// <xs:complexType name="MI_RequestedDate_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_RequestedDate" minOccurs="0"/>
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

namespace NDSH.Geospatial.Metadata.Imagery.Acquisition {

  /// <summary>
  /// Range of date validity.
  /// </summary>
  /// <remarks>ShortName: ReqstDate</remarks>
  [XmlType("MI_RequestedDate", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_RequestedDate", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_RequestedDate")]
  public class MI_RequestedDate_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_RequestedDate_Type"/>.
    /// </summary>
    public MI_RequestedDate_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _requestedDateOfCollection = default; // new DateTime_PropertyType();
      _latestAcceptableDate = default; // new DateTime_PropertyType();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private DateTimeDbEntity _requestedDateOfCollection;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("requestedDateOfCollection", Order = 0)]
    [JsonProperty("requestedDateOfCollection", Order = 0)]
    public DateTimeDbEntity RequestedDateOfCollection {
      get {
        return _requestedDateOfCollection;
      }
      set => SetProperty(ref _requestedDateOfCollection, value);
    }

    private DateTimeDbEntity _latestAcceptableDate;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("latestAcceptableDate", Order = 1)]
    [JsonProperty("latestAcceptableDate", Order = 1)]
    public DateTimeDbEntity LatestAcceptableDate {
      get {
        return _latestAcceptableDate;
      }
      set => SetProperty(ref _latestAcceptableDate, value);
    }

    #endregion

  }

}
