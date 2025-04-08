
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
// <xs:complexType name="Multiplicity_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="range" type="gco:MultiplicityRange_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="Multiplicity" type="gco:Multiplicity_Type"/>
// <xs:complexType name="Multiplicity_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:Multiplicity"/>
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
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Primitive.Multiplicities {

  /// <summary>
  /// Use to represent the possible cardinality of a relation.
  /// Represented by a set of simple multiplicity ranges.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     This class defines how many times an element may appear in a metadata structure.
  ///     A multiplicity is represented as a <b>set of multiplicity ranges</b>, where each
  ///     range specifies a lower and upper bound for occurrences.
  ///   </para>
  ///   <para>
  ///     In ISO 19115 metadata, <b>cardinality constraints</b> are expressed using
  ///     <see cref="MultiplicityRange_Type"/> instances stored in the <see cref="Range"/> collection.
  ///   </para>
  /// </remarks>
  /// <example>
  ///   A metadata element with a cardinality of <c>"0..1, 3..5"</c> would be modeled as:
  ///   <code>
  ///   var multiplicity = new Multiplicity_Type {
  ///     Range = new ObservableCollection&lt;MultiplicityRange_Type&gt; {
  ///       new MultiplicityRange_Type { Lower = 0, Upper = new UnlimitedIntegerDbEntity(1) },
  ///       new MultiplicityRange_Type { Lower = 3, Upper = new UnlimitedIntegerDbEntity(5) }
  ///     }
  ///   };
  ///   </code>
  /// </example>
  [Serializable]
  //[XmlType("Multiplicity", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot
  [JsonObject("Multiplicity")]
  public class Multiplicity_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Multiplicity_Type"/>.
    /// </summary>
    public Multiplicity_Type() {
      _range = [];
    }

    #endregion

    #region Public Properties

    private ObservableCollection<MultiplicityRange_Type> _range;

    /// <summary>
    /// Gets or sets the <see cref="ObservableCollection{MultiplicityRange_Type}"/>
    /// instances defining the allowed occurrences.
    /// </summary>
    /// <remarks>
    /// Each entry in this collection represents a <b>valid cardinality range</b>.
    /// <list type="bullet">
    ///   <item>
    ///     The <b>lower bound</b> of a range specifies the minimum number of times an element must occur.
    ///   </item>
    ///   <item>
    ///     The <b>upper bound</b> specifies the maximum number of times an element may occur.
    ///   </item>
    ///   <item>
    ///     An <b>unbounded upper limit</b> (∞) is represented by
    ///     <see cref="UnlimitedIntegerDbEntity"/> with <c>IsInfinite = true</c> and <c>Value = null</c>.
    ///   </item>
    /// </list>
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown if a <see langword="null"/> value is assigned.
    /// </exception>
    /// <example>
    ///   To define a <b>required single occurrence</b> (<c>1..1</c>):
    ///   <code>
    ///   multiplicity.Range.Add(new MultiplicityRange_Type { Lower = 1, Upper = new UnlimitedIntegerDbEntity(1) });
    ///   </code>
    /// </example>
    //[XmlElement("range", Order = 0)]
    [JsonProperty("range", Order = 0)]
    public ObservableCollection<MultiplicityRange_Type> Range {
      get => _range;
      set {
        if (value == null) {
          throw new ArgumentNullException(nameof(Range), $"{nameof(Range)} cannot be null."); // RESOURCE
        }
        SetProperty(ref _range, value);
      }
    }

    #endregion

  }

}
