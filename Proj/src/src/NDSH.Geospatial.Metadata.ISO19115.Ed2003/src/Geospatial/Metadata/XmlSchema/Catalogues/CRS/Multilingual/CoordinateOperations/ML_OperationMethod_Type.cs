
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 06/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/crsItem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="ML_OperationMethod_Type">
//   <xs:complexContent>
//     <xs:extension base="gml:OperationMethodType">
//       <xs:sequence>
//         <xs:element name="alternativeExpression" type="gmx:OperationMethodAlt_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ML_OperationMethod" type="gmx:ML_OperationMethod_Type" substitutionGroup="gml:OperationMethod"/>
// <xs:complexType name="ML_OperationMethod_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ML_OperationMethod"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Coordinate.Operations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations {

  [Serializable]
  //[XmlType("ML_OperationMethod", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("ML_OperationMethod", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_OperationMethod")]
  public class ML_OperationMethod_Type : OperationMethodType, IOperationMethodsAlternativeExpression {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_OperationMethod_Type"/>.
    /// </summary>
    public ML_OperationMethod_Type() {
      _alternativeExpression = default; //  new List<OperationMethodAlt_Type>();
    }

    #endregion

    #region Public Properties

    private List<OperationMethodAlt_Type> _alternativeExpression;

    //[XmlElement("alternativeExpression", Order = 0)]
    [JsonProperty("alternativeExpression", Order = 0)]
    public List<OperationMethodAlt_Type> AlternativeExpression {
      get => _alternativeExpression;
      set => SetProperty(ref _alternativeExpression, value);
    }

    #endregion

  }

}
