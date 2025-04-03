
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
// <xs:complexType name="ML_PassThroughOperation_Type">
//   <xs:complexContent>
//     <xs:extension base="gml:PassThroughOperationType">
//       <xs:sequence>
//         <xs:element name="alternativeExpression" type="gmx:OperationAlt_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ML_PassThroughOperation" type="gmx:ML_PassThroughOperation_Type" substitutionGroup="gml:PassThroughOperation"/>
// <xs:complexType name="ML_PassThroughOperation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ML_PassThroughOperation"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Coordinate.Operations;
using NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS.Multilingual;
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
  //[XmlType("ML_PassThroughOperation", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("ML_PassThroughOperation", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_PassThroughOperation")]
  public class ML_PassThroughOperation_Type : PassThroughOperationType, IOperationsAlternativeExpression {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_PassThroughOperation_Type"/>.
    /// </summary>
    public ML_PassThroughOperation_Type() {
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
