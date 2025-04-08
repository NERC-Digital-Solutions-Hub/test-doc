
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/01/2023, @gisvlasta
// History           : 27/02/2025, @gisvlasta
//                     The class was renamed to BigIntegerDbEntity and now inherits from ObservableDbEntity.
//                   : 06/03/2025, @gisvlasta - Added constructors,validation logic and implemented IValue<BigInteger>.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <!--NB: The encoding mechanism below is based on the use of XCPT (see the usage of xsi:nil in XML instance).-->
// <xs:complexType name="UnlimitedInteger_Type">
//   <xs:simpleContent>
//     <xs:extension base="xs:nonNegativeInteger">
//       <xs:attribute name="isInfinite" type="xs:boolean"/>
//     </xs:extension>
//   </xs:simpleContent>
// </xs:complexType>
// <xs:element name="UnlimitedInteger" type="gco:UnlimitedInteger_Type" nillable="true"/>
// <xs:complexType name="UnlimitedInteger_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:UnlimitedInteger"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Geospatial.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Primitive.Numerics {

  /// <summary>
  /// Represents an entity that maps a <see cref="BigInteger"/> value to a dedicated database table,
  /// aligning with the ISO 19115 <c>UnlimitedInteger_Type</c> definition for geospatial metadata.
  /// </summary>
  /// <remarks>
  /// Use the <see cref="BigInteger"/> type whenever big integer values are required in a POCO.
  /// If the <see cref="BigInteger"/> property must be stored in its own table (for example, to satisfy
  /// advanced geospatial metadata requirements) map it to this <see cref="UnlimitedIntegerDbEntity"/>.
  /// This design helps ensure consistent handling of <see cref="BigInteger"/>
  /// values according to the ISO 19115 standard.
  /// </remarks>
  //[Serializable]
  //[XmlType("UnlimitedInteger", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("UnlimitedInteger")]
  public class UnlimitedIntegerDbEntity : ObservableDbEntity, INullableValue<BigInteger> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UnlimitedIntegerDbEntity"/>.
    /// </summary>
    public UnlimitedIntegerDbEntity() {
      _value = default;
      _isInfinite = false;
    }

    /// <summary>
    /// Initializes the <see cref="UnlimitedIntegerDbEntity"/>.
    /// </summary>
    /// <param name="value">The <b>non-negative</b> <see cref="BigInteger"/> value.</param>
    /// <param name="isInfinite">
    /// Indicates whether the <see cref="UnlimitedIntegerDbEntity"/> is infinite or not.
    /// </param>
    public UnlimitedIntegerDbEntity(BigInteger? value, bool isInfinite = false) {
      Value = value;
      IsInfinite = isInfinite;
    }

    #endregion

    #region Public Properties

    private bool _isInfinite;

    /// <summary>
    /// Gets/Sets whether this instance holds a positive infinity.
    /// </summary>
    /// <remarks>
    /// If <see cref="IsInfinite"/> is <see langword="true"/>, the <see cref="Value"/> of
    /// <see cref="UnlimitedIntegerDbEntity"/> is set to <see langword="null"/>.
    /// </remarks>
    //[XmlAttribute("isInfinite")]
    [JsonProperty("isInfinite")]
    public bool IsInfinite {
      get => _isInfinite;
      set {
        SetProperty(ref _isInfinite, value);

        // Make sure that when the instance indicates a positive infinity its Value is set to null.
        if (_isInfinite) {
          Value = null;
        }
      }
    }

    #endregion

    #region INullableValue<T> Interface

    private BigInteger? _value;

    /// <summary>
    /// Gets/Sets a non-negative <see cref="BigInteger"/> value.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown if a <c>negative</c> value is attempted to be set to the <see cref="Value"/>.
    /// </exception>
    //[XmlText(DataType = "nonNegativeInteger")]
    [JsonProperty("Value")]
    public BigInteger? Value {
      get => _value;
      set {
        if (value != null && BigInteger.IsNegative((BigInteger)value)) {
          throw new ArgumentOutOfRangeException(nameof(Value), "The value cannot be negative."); // RESOURCE
        }
        SetProperty(ref _value, value);
      }
    }

    #endregion

  }

}
