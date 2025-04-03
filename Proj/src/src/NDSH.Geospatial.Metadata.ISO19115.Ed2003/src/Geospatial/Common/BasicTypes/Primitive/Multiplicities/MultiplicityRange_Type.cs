
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MultiplicityRange_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="lower" type="gco:Integer_PropertyType"/>
//         <xs:element name="upper" type="gco:UnlimitedInteger_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MultiplicityRange" type="gco:MultiplicityRange_Type"/>
// <xs:complexType name="MultiplicityRange_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:MultiplicityRange"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Numerics;
using NDSH.Geospatial.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Primitive.Multiplicities {

  /// <summary>
  /// A component of a multiplicity, consisting of an non-negative
  /// lower bound, and a potentially infinite upper bound.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     This class defines the lower and upper bounds of a multiplicity range,
  ///     specifying how many times an element can appear within a metadata structure.
  ///     <br></br>
  ///     It is commonly used in metadata schemas to enforce cardinality constraints.  
  ///   </para>
  ///   <para>
  ///     The <b>default value</b> is <c>"0..*"</c>.
  ///   </para>
  /// </remarks>
  /// <example>
  ///   For example, a metadata element with a multiplicity of <c>"1..*"</c> would be
  ///   represented as a <see cref="MultiplicityRange_Type"/> instance where:
  ///   <code>
  ///   MultiplicityRangeDbEntity range = new() {
  ///     Lower = 1,
  ///     Upper = new UnlimitedIntegerDbEntity(null, true)
  ///   };
  ///   </code>
  /// </example>
  [Serializable]
  //[XmlType("MultiplicityRange", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot???
  [JsonObject("MultiplicityRange")]
  public class MultiplicityRange_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MultiplicityRange_Type"/>.
    /// </summary>
    public MultiplicityRange_Type() {
      _lower = 0; // new Integer_PropertyType();
      _upper = new UnlimitedIntegerDbEntity(null, true); // new UnlimitedInteger_PropertyType();
    }

    #endregion

    #region Public Properties

    private int _lower;

    /// <summary>
    /// Gets/Sets the minimum number of times an element may appear.
    /// </summary>
    /// <remarks>
    /// This value must be greater than or equal to zero.
    /// It defines the required minimum occurrences of an element in a metadata structure.
    /// </remarks>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown if a negative value is assigned.
    /// </exception>
    //[XmlElement("lower", Order = 0)]
    [JsonProperty("lower", Order = 0)]
    public int Lower {
      get => _lower;
      set {
        if (value < 0) {
          throw new ArgumentOutOfRangeException(nameof(Lower), $"{nameof(Lower)} must not be negative."); // RESOURCE
        }
        SetProperty(ref _lower, value);
      }
    }

    private UnlimitedIntegerDbEntity _upper;

    /// <summary>
    /// Gets/Sets the maximum number of times an element may appear.
    /// </summary>
    //[XmlElement("upper", Order = 1)]
    [JsonProperty("upper", Order = 1)]
    public UnlimitedIntegerDbEntity Upper {
      get => _upper;
      set {
        if (value == null) {
          throw new ArgumentNullException(nameof(Upper), $"{nameof(Lower)} cannot be null."); // RESOURCE
        }
        SetProperty(ref _upper, value);
      }
    }

    #endregion

  }

}
