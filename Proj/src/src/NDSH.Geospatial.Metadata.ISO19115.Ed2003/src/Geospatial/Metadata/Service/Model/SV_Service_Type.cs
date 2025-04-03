
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
// <xs:complexType name="SV_Service_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="specification"
//                     type="srv:SV_PlatformSpecificServiceSpecification_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="theSV_Port"
//                     type="srv:SV_Port_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="SV_Service" type="srv:SV_Service_Type"/>
// <xs:complexType name="SV_Service_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_Service"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Service.Model {

  [Serializable]
  //[XmlType("SV_Service", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("SV_Service", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_Service")]
  public class SV_Service_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Service_Type"/>.
    /// </summary>
    public SV_Service_Type() {
      _specification = default; // new List<SV_PlatformSpecificServiceSpecification_Type>();
      _theSV_Port = default; // new List<SV_Port_Type>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<SV_PlatformSpecificServiceSpecification_Type> _specification;

    //[XmlElement("specification", Order = 0)]
    [JsonProperty("specification", Order = 0)]
    public ObservableCollection<SV_PlatformSpecificServiceSpecification_Type> Specification {
      get => _specification;
      set => SetProperty(ref _specification, value);
    }

    private ObservableCollection<SV_Port_Type> _theSV_Port;

    //[XmlElement("theSV_Port", Order = 1)]
    [JsonProperty("theSV_Port", Order = 1)]
    public ObservableCollection<SV_Port_Type> TheSV_Port {
      get => _theSV_Port;
      set => SetProperty(ref _theSV_Port, value);
    }

    #endregion

  }

}
