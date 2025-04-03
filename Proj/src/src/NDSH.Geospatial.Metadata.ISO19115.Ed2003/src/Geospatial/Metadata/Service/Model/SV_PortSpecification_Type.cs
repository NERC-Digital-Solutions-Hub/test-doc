
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
// <xs:complexType name="SV_PortSpecification_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="binding" type="srv:DCPList_PropertyType"/>
//         <xs:element name="address" type="gmd:URL_PropertyType"/>
//         <xs:element name="theSV_Port" type="srv:SV_Port_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="SV_PortSpecification" type="srv:SV_PortSpecification_Type"/>
// <xs:complexType name="SV_PortSpecification_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_PortSpecification"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.Citation;

using NDSH.Geospatial.Metadata.Service.Metadata;
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
  //[XmlType("SV_PortSpecification", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("SV_PortSpecification", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_PortSpecification")]
  public class SV_PortSpecification_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_PortSpecification_Type"/>.
    /// </summary>
    public SV_PortSpecification_Type() {
      _binding = default; // new DCPList_PropertyType();
      _address = default; // new URL_PropertyType();
      _theSV_Port = default; // new SV_Port_Type();
    }

    #endregion

    #region Public Properties

    private DCPList_CodeList _binding;

    //[XmlElement("binding", Order = 0)]
    [JsonProperty("binding", Order = 0)]
    public DCPList_CodeList Binding {
      get => _binding;
      set => SetProperty(ref _binding, value);
    }

    private URL_PropertyType _address;

    //[XmlElement("address", Order = 1)]
    [JsonProperty("address", Order = 1)]
    public URL_PropertyType Address {
      get => _address;
      set => SetProperty(ref _address, value);
    }

    private SV_Port_Type _theSV_Port;

    //[XmlElement("theSV_Port", Order = 2)]
    [JsonProperty("theSV_Port", Order = 2)]
    public SV_Port_Type TheSV_Port {
      get => _theSV_Port;
      set => SetProperty(ref _theSV_Port, value);
    }

    #endregion

  }

}
