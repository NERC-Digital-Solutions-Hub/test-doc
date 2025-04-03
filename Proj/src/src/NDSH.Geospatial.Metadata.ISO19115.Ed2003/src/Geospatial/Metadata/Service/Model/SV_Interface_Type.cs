
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 15/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/src/serviceModel.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="SV_Interface_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="typeName" type="gco:TypeName_PropertyType"/>
//         <xs:element name="operation" type="srv:SV_Operation_PropertyType"/>
//         <xs:element name="theSV_PortSpecification" type="srv:SV_PortSpecification_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="SV_Interface" type="srv:SV_Interface_Type"/>
// <xs:complexType name="SV_Interface_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_Interface"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Service.Model {

  [Serializable]
  //[XmlType("SV_Interface", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("SV_Interface", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_Interface")]
  public class SV_Interface_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Interface_Type"/>.
    /// </summary>
    public SV_Interface_Type() {
      _typeName = default; // new TypeName_Type();
      _operation = default; // new SV_Operation_Type();
      _theSV_PortSpecification = default; // new SV_PortSpecification_Type();
    }

    #endregion

    #region Public Properties

    private TypeName_Type _typeName;

    //[XmlElement("typeName", Order = 0)]
    [JsonProperty("typeName", Order = 0)]
    public TypeName_Type TypeName {
      get => _typeName;
      set => SetProperty(ref _typeName, value);
    }

    private SV_Operation_Type _operation;

    //[XmlElement("operation", Order = 1)]
    [JsonProperty("operation", Order = 1)]
    public SV_Operation_Type Operation {
      get => _operation;
      set => SetProperty(ref _operation, value);
    }

    private SV_PortSpecification_Type _theSV_PortSpecification; //  " minOccurs="0"/>

    //[XmlElement("theSV_PortSpecification", Order = 2)]
    [JsonProperty("theSV_PortSpecification", Order = 2)]
    public SV_PortSpecification_Type TheSV_PortSpecification {
      get => _theSV_PortSpecification;
      set => SetProperty(ref _theSV_PortSpecification, value);
    }

    #endregion

  }

}
