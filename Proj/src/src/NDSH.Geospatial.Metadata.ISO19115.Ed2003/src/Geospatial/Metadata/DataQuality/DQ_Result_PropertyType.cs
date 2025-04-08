
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
// <xs:complexType name="AbstractDQ_Result_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence/>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractDQ_Result" type="gmd:AbstractDQ_Result_Type" abstract="true"/>
// <xs:complexType name="DQ_Result_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:AbstractDQ_Result"/>
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
  //[XmlType("DQ_Result_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_Result_PropertyType")]
  public class DQ_Result_PropertyType : ReferenceEntity {

    #region Public Properties

    private AbstractDQ_Result_Type _abstractDQ_Result;

    //[XmlElement("AbstractDQ_Result", Order = 0)]
    [JsonProperty("AbstractDQ_Result", Order = 0)]
    public AbstractDQ_Result_Type AbstractDQ_Result {
      get => _abstractDQ_Result;
      set => SetProperty(ref _abstractDQ_Result, value);
    }

    #endregion

  }

}
