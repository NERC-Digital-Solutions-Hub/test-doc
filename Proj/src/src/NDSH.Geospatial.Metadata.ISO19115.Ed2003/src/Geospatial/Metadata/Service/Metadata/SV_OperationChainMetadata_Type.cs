
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 14/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/srv/serviceMetadata.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="SV_OperationChainMetadata_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="name" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="description" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="operation" type="srv:SV_OperationMetadata_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="SV_OperationChainMetadata" type="srv:SV_OperationChainMetadata_Type"/>
// <xs:complexType name="SV_OperationChainMetadata_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_OperationChainMetadata"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

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
  //[XmlType("SV_OperationChainMetadata", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("SV_OperationChainMetadata", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_OperationChainMetadata")]
  public class SV_OperationChainMetadata_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_OperationChainMetadata_Type"/>.
    /// </summary>
    public SV_OperationChainMetadata_Type() {
      _name = default; //new CharacterString"/>
      _description = default; // new CharacterString();
      _operation = default; // new List<SV_OperationMetadata_Type>();
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
    [JsonProperty("description", Order = 0)]
    public CharacterString Description {
      get => _description;
      set => SetProperty(ref _description, value);
    }

    private ObservableCollection<SV_OperationMetadata_Type> _operation;

    //[XmlElement("operation", Order = 2)]
    [JsonProperty("operation", Order = 2)]
    public ObservableCollection<SV_OperationMetadata_Type> Operation {
      get => _operation;
      set => SetProperty(ref _operation, value);
    }

    #endregion

  }

}
