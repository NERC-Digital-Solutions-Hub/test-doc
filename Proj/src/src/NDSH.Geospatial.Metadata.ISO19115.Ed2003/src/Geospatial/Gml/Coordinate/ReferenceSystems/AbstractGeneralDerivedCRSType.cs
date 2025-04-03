
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 18/03/2025, @gisvlasta
// History           : 24/03/2025, @gisvlasta - Added IsoTypeAttribute, updated code, and documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateReferenceSystems.xsd
//                     /2005/gml/coordinateOperations.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="AbstractGeneralDerivedCRS"
//          type="gml:AbstractGeneralDerivedCRSType" abstract="true" substitutionGroup="gml:AbstractSingleCRS">
//   <annotation>
//     <documentation>
//       gml:AbstractGeneralDerivedCRS is a coordinate reference system that is defined by its coordinate conversion
//       from another coordinate reference system. This abstract complex type shall not be used, extended,
//       or restricted, in a GML Application Schema, to define a concrete subtype with a meaning equivalent
//       to a concrete subtype specified in this document.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="AbstractGeneralDerivedCRSType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractCRSType">
//       <sequence>
//         <element ref="gml:conversion"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <element name="conversion" type="gml:GeneralConversionPropertyType">
//   <annotation>
//     <documentation>
//       gml:conversion is an association role to the coordinate conversion used to define the derived CRS.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="definedByConversion" type="gml:GeneralConversionPropertyType" substitutionGroup="gml:conversion">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Coordinate.Operations;
using NDSH.Geospatial.Gml.ReferenceSystems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.ReferenceSystems {

  /// <summary>
  /// The <see cref="AbstractGeneralDerivedCRSType"/> is a coordinate reference system that is defined by
  /// its coordinate conversion from another coordinate reference system. This abstract complex type shall not be used,
  /// extended, or restricted, in a GML Application Schema, to define a concrete subtype with a meaning equivalent
  /// to a concrete subtype specified in this document.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AbstractGeneralDerivedCRSType</c> ( /2005/gml/coordinateReferenceSystems.xsd )
  /// </remarks>
  //[XmlInclude(typeof(DerivedCRSType))]
  //[XmlInclude(typeof(ProjectedCRSType))]
  [IsoType("AbstractGeneralDerivedCRSType", IsAbstract = true, IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralDerivedCRSType")]
  public abstract class AbstractGeneralDerivedCRSType : AbstractCRSType, ISingleCRS {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractGeneralDerivedCRSType"/>.
    /// </summary>
    public AbstractGeneralDerivedCRSType() {
      _conversion = new GeneralConversionPropertyType();
    }

    #endregion

    #region Public Properties

    private GeneralConversionPropertyType _conversion;

    /// <summary>
    /// Gets/Sets the <see cref="GeneralConversionPropertyType"/>
    /// used to define the derived coordinate reference system.
    /// </summary>
    /// <remarks>
    /// Corresponds to the <c>gml:conversion</c> element in the XSD.
    /// This association identifies the coordinate conversion that defines the transformation
    /// from the source CRS to the derived CRS.
    /// </remarks>
    //[XmlElement(Order = 0)]
    [JsonProperty("conversion", Order = 0)]
    public GeneralConversionPropertyType Conversion {
      get => _conversion;
      set => SetProperty(ref _conversion, value);
    }

    #endregion

  }

}
