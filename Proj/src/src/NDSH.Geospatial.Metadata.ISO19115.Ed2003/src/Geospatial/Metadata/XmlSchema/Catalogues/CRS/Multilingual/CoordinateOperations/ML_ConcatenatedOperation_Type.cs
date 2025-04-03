
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
// <xs:complexType name="ML_ConcatenatedOperation_Type">
//   <xs:complexContent>
//     <xs:extension base="gml:ConcatenatedOperationType">
//       <xs:sequence>
//         <xs:element name="alternativeExpression" type="gmx:OperationAlt_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ML_ConcatenatedOperation" type="gmx:ML_ConcatenatedOperation_Type" substitutionGroup="gml:ConcatenatedOperation"/>
// <xs:complexType name="ML_ConcatenatedOperation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ML_ConcatenatedOperation"/>
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
  //[XmlType("ML_ConcatenatedOperation", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("ML_ConcatenatedOperation", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_ConcatenatedOperation")]
  public class ML_ConcatenatedOperation_Type : ConcatenatedOperationType, IOperationsAlternativeExpression {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_ConcatenatedOperation_Type"/>.
    /// </summary>
    public ML_ConcatenatedOperation_Type() {
      _alternativeExpression = default; //  new List<OperationAlt_Type>();
    }

    #endregion

    #region Public Properties

    private List<OperationAlt_Type> _alternativeExpression;

    //[XmlElement("alternativeExpression", Order = 0)]
    [JsonProperty("alternativeExpression", Order = 0)]
    public List<OperationAlt_Type> AlternativeExpression {
      get => _alternativeExpression;
      set => SetProperty(ref _alternativeExpression, value);
    }

    #endregion

  }

}
