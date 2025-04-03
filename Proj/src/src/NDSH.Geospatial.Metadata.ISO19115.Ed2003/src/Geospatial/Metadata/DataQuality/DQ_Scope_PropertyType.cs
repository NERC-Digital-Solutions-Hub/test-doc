
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 23/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/dataQuality.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="DQ_Scope_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="level" type="gmd:MD_ScopeCode_PropertyType"/>
//         <xs:element name="extent" type="gmd:EX_Extent_PropertyType" minOccurs="0"/>
//         <xs:element name="levelDescription" type="gmd:MD_ScopeDescription_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DQ_Scope" type="gmd:DQ_Scope_Type"/>
// <xs:complexType name="DQ_Scope_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DQ_Scope"/>
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.DataQuality {

  [Serializable]
  //[XmlType("DQ_Scope_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_Scope_PropertyType")]
  public class DQ_Scope_PropertyType : ReferenceEntity {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_Scope_PropertyType"/>.
    /// </summary>
    public DQ_Scope_PropertyType() {
      _dq_Scope = default; //  new DQ_Scope_Type();
    }

    #endregion

    #region Public Properties

    private DQ_Scope_Type _dq_Scope;

    //[XmlElement("DQ_Scope", Order = 0)]
    [JsonProperty("DQ_Scope", Order = 0)]
    public DQ_Scope_Type DQ_Scope {
      get => _dq_Scope;
      set => SetProperty(ref _dq_Scope, value);
    }

    #endregion

  }

}
