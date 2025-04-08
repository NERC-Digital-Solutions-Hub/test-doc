
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
// <xs:complexType name="SV_Parameter_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="name" type="gco:MemberName_Type"/>
//         <xs:element name="direction" type="srv:SV_ParameterDirection_PropertyType" minOccurs="0"/>
//         <xs:element name="description" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="optionality" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="repeatability" type="gco:Boolean_PropertyType"/>
//         <xs:element name="valueType" type="gco:TypeName_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="SV_Parameter" type="srv:SV_Parameter_Type"/>
// <xs:complexType name="SV_Parameter_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_Parameter"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Service.Metadata {

  [Serializable]
  //[XmlType("SV_Parameter", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("SV_Parameter", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_Parameter")]
  public class SV_Parameter_Type : MetadataObject {

    // WARNING: Check which value types need to be nullable.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Parameter_Type"/>.
    /// </summary>
    public SV_Parameter_Type() {
      _name = default; // new MemberName_Type();
      _direction = default; // new SV_ParameterDirection_Type();
      _description = default; // new CharacterString();
      _optionality = default; // new CharacterString();
      _repeatability = default; // new Boolean_PropertyType();
      _valueType = default; // new TypeName_Type();
    }

    #endregion

    #region Public Properties

    private MemberName_Type _name;

    //[XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public MemberName_Type Name {
      get => _name;
      set => SetProperty(ref _name, value);
    }

    private SV_ParameterDirections _direction;

    //[XmlElement("direction", Order = 1)]
    [JsonProperty("direction", Order = 1)]
    public SV_ParameterDirections Direction {
      get => _direction;
      // TODO: SetProperty
      set {
        if (_direction == value) {
          return;
        }
        if (_direction == null || !_direction.Equals(value)) { // TODO: Pay attention to this expression since it uses an enum.
          _direction = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _description;

    //[XmlElement("description", Order = 2)]
    [JsonProperty("description", Order = 2)]
    public CharacterString Description {
      get => _description;
      set => SetProperty(ref _description, value);
    }

    private CharacterString _optionality;

    //[XmlElement("optionality", Order = 3)]
    [JsonProperty("optionality", Order = 3)]
    public CharacterString Optionality {
      get => _optionality;
      set => SetProperty(ref _optionality, value);
    }

    private bool _repeatability;

    //[XmlElement("repeatability", Order = 4)]
    [JsonProperty("repeatability", Order = 4)]
    public bool Repeatability {
      get => _repeatability;
      // TODO: SetProperty
      set {
        if (_repeatability == value) {
          return;
        }
        if (/*_repeatability == null || */!_repeatability.Equals(value)) {
          _repeatability = value;
          OnPropertyChanged();
        }
      }
    }

    private TypeName_Type _valueType;

    //[XmlElement("valueType", Order = 5)]
    [JsonProperty("valueType", Order = 5)]
    public TypeName_Type ValueType {
      get => _valueType;
      set => SetProperty(ref _valueType, value);
    }

    #endregion

  }

}
