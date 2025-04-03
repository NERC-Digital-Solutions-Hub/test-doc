
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 24/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="CoordinateSystemAxis" type="gml:CoordinateSystemAxisType" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>gml:CoordinateSystemAxis is a definition of a coordinate system axis.</documentation>
//   </annotation>
// </element>
// 
// <complexType name="CoordinateSystemAxisType">
//   <complexContent>
//     <extension base="gml:IdentifiedObjectType">
//       <sequence>
//         <element ref="gml:axisAbbrev"/>
//         <element ref="gml:axisDirection"/>
//         <element ref="gml:minimumValue" minOccurs="0"/>
//         <element ref="gml:maximumValue" minOccurs="0"/>
//         <element ref="gml:rangeMeaning" minOccurs="0"/>
//       </sequence>
//       <attribute ref="gml:uom" use="required"/>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <element name="usesAxis" type="gml:CoordinateSystemAxisPropertyType" substitutionGroup="gml:axis">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <complexType name="CoordinateSystemAxisPropertyType">
// 	<annotation>
// 		<documentation>
//      gml:CoordinateSystemAxisPropertyType is a property type for association roles to a coordinate system axis,
//      either referencing or containing the definition of that axis.
//    </documentation>
// 	</annotation>
// 	<sequence minOccurs="0">
// 		<element ref="gml:CoordinateSystemAxis"/>
// 	</sequence>
// 	<attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.ReferenceSystems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Systems {

  /// <summary>
  /// The <see cref="CoordinateSystemAxisType"/> is a definition of a coordinate system axis.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>CoordinateSystemAxisType</c> ( /2005/gml/coordinateSystems.xsd )
  /// </remarks>
  [IsoType(
    "CoordinateSystemAxisType",
    WrapperName = "CoordinateSystemAxisPropertyType",
    IsoType = IsoTypes.ComplexType
  )]
  //[XmlInclude(typeof(CoordinateSystemAxisAlt_Type))] // GMX
  //[XmlInclude(typeof(ML_CoordinateSystemAxis_Type))] // GMX
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CoordinateSystemAxisType")]
  public class CoordinateSystemAxisType : IdentifiedObjectType, IAssociated {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CoordinateSystemAxisType"/>.
    /// </summary>
    public CoordinateSystemAxisType() {
      _axisAbbrev = new CodeType();
      _axisDirection = new CodeWithAuthorityType();
      _minimumValue = default;
      _maximumValue = default;
      _rangeMeaning = default; //  new CodeWithAuthorityType();
      //_uom = default; // WARNING: How to deal with it?
    }

    #endregion

    #region Public Properties

    private CodeType _axisAbbrev;

    /// <summary>
    /// Gets/Sets the abbreviation used for this coordinate system axis.
    /// </summary>
    /// <remarks>
    /// This typically contains a short label for the axis (e.g., "X", "Lat").
    /// </remarks>
    //[XmlElement(Order = 0)]
    [JsonProperty("axisAbbrev", Order = 0)]
    public CodeType AxisAbbrev {
      get => _axisAbbrev;
      set => SetProperty(ref _axisAbbrev, value);
    }

    private CodeWithAuthorityType _axisDirection;

    /// <summary>
    /// Gets/Sets the direction of this axis.
    /// </summary>
    /// <remarks>
    /// Examples include "north, "south", "east", "west", "up", "down", "future", or "past".
    /// </remarks>
    //[XmlElement(Order = 1)]
    [JsonProperty("axisDirection", Order = 1)]
    public CodeWithAuthorityType AxisDirection {
      get => _axisDirection;
      set => SetProperty(ref _axisDirection, value);
    }

    private double? _minimumValue;

    /// <summary>
    /// Gets/Sets the minimum value permitted along this axis.
    /// </summary>
    /// <remarks>
    /// Optional element. If omitted, no minimum is enforced.
    /// </remarks>
    //[XmlElement(Order = 2)]
    [JsonProperty("minimumValue", Order = 2)]
    public double? MinimumValue {
      get => _minimumValue;
      set => SetProperty(ref _minimumValue, value);
    }

    private double? _maximumValue;

    /// <summary>
    /// Gets/Sets the maximum value permitted along this axis.
    /// </summary>
    /// <remarks>
    /// Optional element. If omitted, no maximum is enforced.
    /// </remarks>
    //[XmlElement(Order = 3)]
    [JsonProperty("maximumValue", Order = 3)]
    public double? MaximumValue {
      get => _maximumValue;
      set => SetProperty(ref _maximumValue, value);
    }

    private CodeWithAuthorityType? _rangeMeaning;

    /// <summary>
    /// Gets/Sets the meaning of the axis value range.
    /// </summary>
    /// <remarks>
    /// Indicates whether the axis values wrap around (e.g., longitude from 0° to 360°).
    /// </remarks>
    //[XmlElement(Order = 4)]
    [JsonProperty("rangeMeaning", Order = 4)]
    // WARNING: Add validation here.
    public CodeWithAuthorityType? RangeMeaning {
      get => _rangeMeaning;
      set => SetProperty(ref _rangeMeaning, value);
    }

    //private string _uom;
    private UriReference _uom;

    /// <summary>
    /// Gets/Sets the unit of measure (UOM) for the axis values.
    /// </summary>
    /// <remarks>
    /// This is a required attribute. The value must be a valid URI referring to a
    /// unit of measure definition (e.g., "http://www.opengis.net/def/uom/OGC/1.0/metre").
    /// </remarks>
    [Required()]
    //[XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("uom")]
    // WARNING: This seems a URI, or it may accept URIs as well. Find out what is this and how to validate it.
    //public required string Uom {
    //  get => _uom;
    //  set => SetProperty(ref _uom, value);
    //}
    public required UriReference Uom {
      get => _uom;
      set => SetProperty(ref _uom, value);
    }

    #endregion

    #region IAssociated Interface

    private AssociationEntity? _association;

    // WARNING: The Association is implemented here through the IAssociated interface. It may be possible to be inherited using a clever inheritance path.

    /// <summary>
    /// Gets/Sets an <see cref="Gml.Association">Association</see> to a
    /// <see cref="CoordinateSystemAxisType">coordinate system axis</see>.
    /// </summary>
    public AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

    #endregion

  }

}
