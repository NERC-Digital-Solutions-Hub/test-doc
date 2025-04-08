#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/dataQuality.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="LI_Lineage_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="statement" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="processStep" type="gmd:LI_ProcessStep_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="source" type="gmd:LI_Source_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="LI_Lineage" type="gmd:LI_Lineage_Type"/>
// <xs:complexType name="LI_Lineage_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:LI_Lineage"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.DataQuality.Lineage {

  [Serializable]
  //[XmlType("LI_Lineage", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("LI_Lineage", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("LI_Lineage")]
  public class LI_Lineage_Type : MetadataObject, IComparable<LI_Lineage_Type>, IEquatable<LI_Lineage_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LI_Lineage_Type"/>.
    /// </summary>
    public LI_Lineage_Type() {
      _statement = default; //  new CharacterString();
      _processStep = default; //  new List<LI_ProcessStep_Type>();
      _source = default; //  new List<LI_Source_Type>();
    }

    #endregion

    #region Public Properties

    private CharacterString? _statement;

    /// <summary>
    /// General explanation of the data producer's knowledge about the lineage of a dataset.
    /// </summary>
    // TODO: OBL - C (DQ_DataQaulity.scope.DQ_Scope.level = "dataset" or "series"?)
    // TODO: CAR - 1
    //[XmlElement("statement", Order = 0)]
    [JsonProperty("statement", Order = 0)]
    public CharacterString? Statement {
      get => _statement;
      set => SetProperty(ref _statement, value);
    }

    private ObservableCollection<LI_ProcessStep_Type>? _processStep;

    /// <summary>
    /// Information about events in the life of a dataset specified by the scope.
    /// </summary>
    // TODO: C (mandatory if statement and source not provided?)
    // TODO: CAR - N
    //[XmlElement("processStep", Order = 1)]
    [JsonProperty("processStep", Order = 1)]
    public ObservableCollection<LI_ProcessStep_Type>? ProcessStep {
      get => _processStep;
      set => SetProperty(ref _processStep, value);
    }

    private ObservableCollection<LI_Source_Type>? _source;

    /// <summary>
    /// Information about the source data used in creating the data specified by the scope.
    /// </summary>
    // TODO: OBL - C (mandatory if statement and processStep not provided?)
    // TODO: CAR - N
    //[XmlElement("source", Order = 2)]
    [JsonProperty("source", Order = 2)]
    public ObservableCollection<LI_Source_Type>? Source {
      get => _source;
      set => SetProperty(ref _source, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="LI_Lineage_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="LI_Lineage_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(LI_Lineage_Type? other) {

      int result;

      return
        (other is null) ? 1 :
        (result = Statement?.CompareTo(other.Statement) ?? 1) != 0 ? result :
        (result = ProcessStep?.Count.CompareTo(other.ProcessStep?.Count ?? 0) ?? 1) != 0 ? result :
        Source?.Count.CompareTo(other.Source?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="LI_Lineage_Type"/> is equal to the current <see cref="LI_Lineage_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="LI_Lineage_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(LI_Lineage_Type? other) {
      return other != null &&
         Equals(Statement, other.Statement) &&
         ProcessStep.SequenceEqualOrdered(other.ProcessStep) &&
         Source.SequenceEqualOrdered(other.Source);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="LI_Lineage_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as LI_Lineage_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="LI_Lineage_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(Statement);

      foreach (LI_ProcessStep_Type step in ProcessStep.SafeOrderBy()) {
        hash.Add(step);
      }

      foreach (LI_Source_Type source in Source.SafeOrderBy()) {
        hash.Add(source);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
