
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 01/02/2023, @gisvlasta
// History           : 21/03/2025, @gisvlasta - Added IsoTypeAttribute, and implemented IAssociated interface.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/valueObjects.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="Quantity" substitutionGroup="gml:AbstractScalarValue" nillable="true">
//   <annotation>
//     <documentation>
//       An XML attribute uom (“unit of measure”) is required,
//       whose value is a URI which identifies the definition of a ratio scale
//       or units by which the numeric value shall be multiplied,
//       or an interval or position scale on which the value occurs.
//     </documentation>
//   </annotation>
//   <complexType>
//     <simpleContent>
//       <extension base="gml:MeasureType">
//         <attribute name="nilReason" type="gml:NilReasonType"/>
//       </extension>
//     </simpleContent>
//   </complexType>
// </element>
// 
// <complexType name="QuantityPropertyType">
//   <sequence minOccurs="0">
//     <element ref="gml:Quantity"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Measures;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.ValueObjects {

  /// <summary>
  /// An XML attribute uom (unit of measure) is required, whose value is a URI which identifies
  /// the definition of a ratio scale or units by which the numeric value shall be multiplied,
  /// or an interval or position scale on which the value occurs.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>Quantity</c> ( /2005/gml/valueObjects.xsd )
  /// </remarks>
  [IsoType("Quantity", WrapperName = "QuantityPropertyType", IsoType = IsoTypes.Element)]
  //[XmlType("Quantity", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("Quantity")]
  public class Quantity : MeasureType, IAssociated {

    #region IAssociated Interface

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see>.
    /// </summary>
    public AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

    #endregion

  }

}
