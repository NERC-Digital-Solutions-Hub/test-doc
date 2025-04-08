
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
// <xs:complexType name="SV_Operation_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="operationName" type="gco:MemberName_PropertyType"/>
//         <xs:element name="dependsOn" type="srv:SV_Operation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="parameter" type="srv:SV_Parameter_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="SV_Operation" type="srv:SV_Operation_Type"/>
// <xs:complexType name="SV_Operation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_Operation"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;

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
  //[XmlType("SV_Operation", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("SV_Operation", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_Operation")]
  public class SV_Operation_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Operation_Type"/>.
    /// </summary>
    public SV_Operation_Type() {
      _operationName = default; //new MemberName_Type();
      _dependsOn = default; //new List<SV_Operation_Type>();
      _parameter = default; //new SV_Parameter_Type();
    }

    #endregion

    #region Public Properties

    private MemberName_Type _operationName;

    //[XmlElement("operationName", Order = 0)]
    [JsonProperty("operationName", Order = 0)]
    public MemberName_Type OperationName {
      get => _operationName;
      set => SetProperty(ref _operationName, value);
    }

    private ObservableCollection<SV_Operation_Type> _dependsOn;

    //[XmlElement("dependsOn", Order = 1)]
    [JsonProperty("dependsOn", Order = 1)]
    public ObservableCollection<SV_Operation_Type> DependsOn {
      get => _dependsOn;
      set => SetProperty(ref _dependsOn, value);
    }

    private SV_Parameter_Type _parameter;

    //[XmlElement("parameter", Order = 2)]
    [JsonProperty("parameter", Order = 2)]
    public SV_Parameter_Type Parameter {
      get => _parameter;
      set => SetProperty(ref _parameter, value);
    }

    #endregion

  }

}
