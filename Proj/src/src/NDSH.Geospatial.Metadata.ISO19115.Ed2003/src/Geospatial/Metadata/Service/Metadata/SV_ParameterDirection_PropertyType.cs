
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 11/02/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/src/serviceMetadata.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:simpleType name="SV_ParameterDirection_Type">
//   <xs:restriction base="xs:string">
//     <xs:enumeration value="in"/>
//     <xs:enumeration value="out"/>
//     <xs:enumeration value="in/out"/>
//   </xs:restriction>
// </xs:simpleType>
// <xs:element name="SV_ParameterDirection"
//             type="srv:SV_ParameterDirection_Type"
//             substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="SV_ParameterDirection_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_ParameterDirection"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Service.Metadata {

  public class SV_ParameterDirection_PropertyType : ObservableDbEntity { // WARNING: Should this be IdentifiableObject???

    private SV_ParameterDirections? _parameterDirection;

    public SV_ParameterDirections? ParemeterDirection {
      get => _parameterDirection;
      // TODO: SetProperty
      set {
        if (_parameterDirection == value) {
          return;
        }
        _parameterDirection = value;
        OnPropertyChanged();
      }
    }

  }

}
