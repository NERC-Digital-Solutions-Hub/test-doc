
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
// <xs:complexType name="SV_PlatformSpecificServiceSpecification_Type">
//   <xs:complexContent>
//     <xs:extension base="srv:AbstractSV_AbstractServiceSpecification_Type">
//       <xs:sequence>
//         <xs:element name="DCP" type="srv:DCPList_PropertyType"/>
//         <xs:element name="typeSpec" type="srv:SV_PlatformNeutralServiceSpecification_PropertyType"/>
//         <xs:element name="implementation" type="srv:SV_Service_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="SV_PlatformSpecificServiceSpecification"
//             type="srv:SV_PlatformSpecificServiceSpecification_Type"
//             substitutionGroup="srv:AbstractSV_AbstractServiceSpecification"/>
// <xs:complexType name="SV_PlatformSpecificServiceSpecification_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_PlatformSpecificServiceSpecification"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.Service.Metadata;
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
  //[XmlType("SV_PlatformSpecificServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("SV_PlatformSpecificServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_PlatformSpecificServiceSpecification")]
  public class SV_PlatformSpecificServiceSpecification_Type : AbstractSV_AbstractServiceSpecification_Type {

    #region Constructors =- Destructors

    /// <summary>
    /// Initializes the <see cref="SV_PlatformSpecificServiceSpecification_Type"/>.
    /// </summary>
    public SV_PlatformSpecificServiceSpecification_Type() {
      _DCP = default; // = new DCPList_PropertyType();
      _typeSpec = default; // = new SV_PlatformNeutralServiceSpecification_Type();
      _implementation = default; // = new List<SV_Service_Type>();
    }

    #endregion

    #region Public Properties

    private DCPList_CodeList _DCP;

    //[XmlElement("DCP", Order = 0)]
    [JsonProperty("DCP", Order = 0)]
    public DCPList_CodeList DCP {
      get => _DCP;
      set => SetProperty(ref _DCP, value);
    }

    private SV_PlatformNeutralServiceSpecification_Type _typeSpec;

    //[XmlElement("typeSpec", Order = 1)]
    [JsonProperty("typeSpec", Order = 1)]
    public SV_PlatformNeutralServiceSpecification_Type TypeSpec {
      get => _typeSpec;
      set => SetProperty(ref _typeSpec, value);
    }

    private ObservableCollection<SV_Service_Type> _implementation;

    //[XmlElement("implementation", Order = 2)]
    [JsonProperty("implementation", Order = 2)]
    public ObservableCollection<SV_Service_Type> Implementation {
      get => _implementation;
      set => SetProperty(ref _implementation, value);
    }

    #endregion

  }

}
