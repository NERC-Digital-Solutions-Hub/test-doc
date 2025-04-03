
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
// <xs:complexType name="SV_ServiceSpecification_Type">
//   <xs:complexContent>
//     <xs:extension base="srv:AbstractSV_AbstractServiceSpecification_Type">
//       <xs:sequence>
//         <xs:element name="typeSpec"
//                     type="srv:SV_PlatformNeutralServiceSpecification_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="SV_ServiceSpecification"
//             type="srv:SV_ServiceSpecification_Type"
//             substitutionGroup="srv:AbstractSV_AbstractServiceSpecification"/>
// <xs:complexType name="SV_ServiceSpecification_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_ServiceSpecification"/>
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
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Service.Model {

  [Serializable]
  //[XmlType("SV_ServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("SV_ServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_ServiceSpecification")]
  public class SV_ServiceSpecification_Type : AbstractSV_AbstractServiceSpecification_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_ServiceSpecification_Type"/>.
    /// </summary>
    public SV_ServiceSpecification_Type() {
      _typeSpec = default; //new List<SV_PlatformNeutralServiceSpecification_Type>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<SV_PlatformNeutralServiceSpecification_Type> _typeSpec;

    //[XmlElement("operationName", Order = 0)]
    [JsonProperty("operationName", Order = 0)]
    public ObservableCollection<SV_PlatformNeutralServiceSpecification_Type> TypeSpec {
      get => _typeSpec;
      set => SetProperty(ref _typeSpec, value);
    }

    #endregion

  }

}
