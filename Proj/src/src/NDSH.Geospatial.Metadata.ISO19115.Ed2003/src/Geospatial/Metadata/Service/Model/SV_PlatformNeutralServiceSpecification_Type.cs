
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
// <xs:complexType name="SV_PlatformNeutralServiceSpecification_Type">
//   <xs:complexContent>
//     <xs:extension base="srv:AbstractSV_AbstractServiceSpecification_Type">
//       <xs:sequence>
//         <xs:element name="serviceType"
//                     type="srv:SV_ServiceType_PropertyType"/>
//         <xs:element name="implSpec"
//                     type="srv:SV_PlatformSpecificServiceSpecification_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="SV_PlatformNeutralServiceSpecification"
//             type="srv:SV_PlatformNeutralServiceSpecification_Type"
//             substitutionGroup="srv:AbstractSV_AbstractServiceSpecification"/>
// <xs:complexType name="SV_PlatformNeutralServiceSpecification_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_PlatformNeutralServiceSpecification"/>
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
  //[XmlType("SV_PlatformNeutralServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("SV_PlatformNeutralServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_PlatformNeutralServiceSpecification")]
  public class SV_PlatformNeutralServiceSpecification_Type : AbstractSV_AbstractServiceSpecification_Type {

    #region Constructors =- Destructors

    /// <summary>
    /// Initializes the <see cref="SV_PlatformNeutralServiceSpecification_Type"/>.
    /// </summary>
    public SV_PlatformNeutralServiceSpecification_Type() {
      _serviceType = default; // new SV_ServiceType_PropertyType();
      _implSpec = default; // new List<SV_PlatformSpecificServiceSpecification_Type>();
    }

    #endregion

    #region Public Properties

    private SV_ServiceType_CodeList _serviceType;

    //[XmlElement("serviceType", Order = 0)]
    [JsonProperty("serviceType", Order = 0)]
    public SV_ServiceType_CodeList ServiceType {
      get => _serviceType;
      set => SetProperty(ref _serviceType, value);
    }

    private ObservableCollection<SV_PlatformSpecificServiceSpecification_Type> _implSpec;

    //[XmlElement("implSpec", Order = 1)]
    [JsonProperty("implSpec", Order = 1)]
    public ObservableCollection<SV_PlatformSpecificServiceSpecification_Type> ImplSpec {
      get => _implSpec;
      set => SetProperty(ref _implSpec, value);
    }

    #endregion

  }

}
