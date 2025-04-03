
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 11/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="abstractInlineProperty" type="gml:InlinePropertyType" abstract="true">
//   <annotation>
//     <documentation>
//       gml:abstractInlineProperty may be used as the head of a substitution group
//       of more specific elements providing a value in-line.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="InlinePropertyType">
//   <sequence>
//     <element ref="gml:AbstractObject"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from InlinePropertyType to InlineProperty.

  /// <summary>
  ///   <para>
  ///     Represents a property that provides an <b>in-line value</b> for a GML object.
  ///   </para>
  ///   <para>
  ///     The <see cref="InlinePropertyType"/> class is used to represent GML objects
  ///     that must be <b>provided in-line</b> rather than by reference.
  ///     It contains an instance of <see cref="AbstractObject"/>, which defines the actual object.  
  ///   </para>
  /// </summary>
  /// <remarks>
  /// Maps to: <c>InlinePropertyType</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [IsoType("InlinePropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("InlinePropertyType")]
  public class InlinePropertyType : AbstractInlineProperty {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="InlinePropertyType"/>.
    /// </summary>
    public InlinePropertyType() {
      _abstractObject = default;
    }

    #endregion

    #region Public Properties

    private GmlObject _abstractObject;

    /// <summary>
    /// Gets/Sets the <b>in-line</b> GML object associated with this property.
    /// </summary>
    /// <remarks>
    /// This property contains an instance of <see cref="AbstractObject"/> that is provided in-line.
    /// The value cannot be <see langword="null"/> if this element is used.
    /// </remarks>
    /// <value>
    /// A concrete instance of <see cref="AbstractObject"/> representing the in-line object.
    /// </value>
    //[XmlElement(Order = 0)]
    [JsonProperty("AbstractObject", Order = 0)]
    public GmlObject AbstractObject {
      get => _abstractObject;
      set {
        if (_abstractObject == value) {
          return;
        }
        if (_abstractObject == null || _abstractObject.Equals(value) != true) {
          _abstractObject = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
