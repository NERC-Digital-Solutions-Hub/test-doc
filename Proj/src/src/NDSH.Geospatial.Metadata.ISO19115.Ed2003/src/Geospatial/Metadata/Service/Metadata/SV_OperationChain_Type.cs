
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
// XSD               : /2005/srv/serviceMetadata.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="SV_CoupledResource_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="operationName" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="identifier" type="gco:CharacterString_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="SV_CoupledResource" type="srv:SV_CoupledResource_Type"/>
// <xs:complexType name="SV_CoupledResource_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_CoupledResource"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

using NDSH.Geospatial.Metadata.Service.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Service.Metadata {

  [Serializable]
  //[XmlType("SV_OperationChain", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("SV_OperationChain", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_OperationChain")]
  public class SV_OperationChain_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_OperationChain_Type"/>
    /// </summary>
    public SV_OperationChain_Type() {
      _name = default;
      _description = default;
      _operation = default;
    }

    #endregion

    #region Public Properties

    private CharacterString _name;

    //[XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString Name {
      get => _name;
      set => SetProperty(ref _name, value);
    }

    private CharacterString _description;

    //[XmlElement("description", Order = 1)]
    [JsonProperty("description", Order = 1)]
    public CharacterString Description {
      get => _description;
      set => SetProperty(ref _description, value);
    }

    private ObservableCollection<SV_Operation_Type> _operation;

    //[XmlElement("operation", Order = 2)]
    [JsonProperty("operation", Order = 2)]
    public ObservableCollection<SV_Operation_Type> Operation {
      get => _operation;
      set => SetProperty(ref _operation, value);
    }

    #endregion

  }

}
