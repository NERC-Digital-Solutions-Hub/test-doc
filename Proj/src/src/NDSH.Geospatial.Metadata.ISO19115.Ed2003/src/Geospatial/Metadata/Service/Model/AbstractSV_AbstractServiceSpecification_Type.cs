
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
// <xs:complexType name="AbstractSV_AbstractServiceSpecification_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="name" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="opModel" type="srv:SV_OperationModel_PropertyType"/>
//         <xs:element name="theSV_Interface" type="srv:SV_Interface_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractSV_AbstractServiceSpecification"
//             type="srv:AbstractSV_AbstractServiceSpecification_Type" abstract="true"/>
// <xs:complexType name="SV_AbstractServiceSpecification_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:AbstractSV_AbstractServiceSpecification"/>
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

namespace NDSH.Geospatial.Metadata.Service.Model {

  //[XmlInclude(typeof(SV_ServiceSpecification_Type))]
  //[XmlInclude(typeof(SV_PlatformNeutralServiceSpecification_Type))]
  //[XmlInclude(typeof(SV_PlatformSpecificServiceSpecification_Type))]
  [Serializable]
  //[XmlType("AbstractSV_AbstractServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("AbstractSV_AbstractServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("AbstractSV_AbstractServiceSpecification")]
  public abstract class AbstractSV_AbstractServiceSpecification_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractSV_AbstractServiceSpecification_Type"/>
    /// </summary>
    public AbstractSV_AbstractServiceSpecification_Type() {
      _name = default; // new CharacterString();
      _opModel = default; // new SV_OperationModel_Type();
      _theSV_Interface = default; // new List<SV_Interface_Type>();
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

    private SV_OperationModel_Type _opModel;

    //[XmlElement("opModel", Order = 1)]
    [JsonProperty("opModel", Order = 1)]
    public SV_OperationModel_Type OpModel {
      get => _opModel;
      // TODO: SetProperty
      set {
        if (_opModel == value) {
          return;
        }
        if (_opModel == null || _opModel.Equals(value) != true) { // WARNING: This expression uses an enum
          _opModel = value;
          OnPropertyChanged();
        }
      }
    }

    private ObservableCollection<SV_Interface_Type> _theSV_Interface;

    //[XmlElement("theSV_Interface", Order = 2)]
    [JsonProperty("theSV_Interface", Order = 2)]
    public ObservableCollection<SV_Interface_Type> TheSV_Interface {
      get => _theSV_Interface;
      set => SetProperty(ref _theSV_Interface, value);
    }

    #endregion

  }

}
