#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 23/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/dataQuality.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="DQ_DataQuality_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="scope" type="gmd:DQ_Scope_PropertyType"/>
//         <xs:element name="report" type="gmd:DQ_Element_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="lineage" type="gmd:LI_Lineage_PropertyType" minOccurs="0"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="DQ_DataQuality" type="gmd:DQ_DataQuality_Type"/>
// <xs:complexType name="DQ_DataQuality_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DQ_DataQuality"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.DataQuality.Lineage;
using NDSH.Hashing;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

#endregion

namespace NDSH.Geospatial.Metadata.DataQuality {

  [Serializable]
  //[XmlType("DQ_DataQuality", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("DQ_DataQuality", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DQ_DataQuality")]
  public class DQ_DataQuality_Type : MetadataObject, IComparable<DQ_DataQuality_Type>, IEquatable<DQ_DataQuality_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_DataQuality_Type"/>.
    /// </summary>
    public DQ_DataQuality_Type() {
      _scope = default; //  new DQ_Scope_PropertyType();
      _report = default; //  new List<AbstractDQ_Element_Type>();
      _lineage = default; //  new LI_Lineage_Type();
    }

    #endregion

    #region Public Properties

    private DQ_Scope_Type _scope;

    /// <summary>
    /// The specific data to which the data quality information applies.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("scope", Order = 0)]
    [JsonProperty("scope", Order = 0)]
    public DQ_Scope_Type Scope {
      get => _scope;
      set => SetProperty(ref _scope, value);
    }

    private ObservableCollection<AbstractDQ_Element_Type>? _report;

    /// <summary>
    /// Quantitative quality information for the data specified by the scope.
    /// </summary>
    // TODO: OBL - C (lineage not provided?)
    // TODO: CAR - N
    //[XmlElement("report", Order = 1)]
    [JsonProperty("report", Order = 1)]
    public ObservableCollection<AbstractDQ_Element_Type>? Report {
      get => _report;
      set => SetProperty(ref _report, value);
    }

    private LI_Lineage_Type? _lineage;

    /// <summary>
    /// Non-quantitative quality information about the lineage of the data specified by the scope.
    /// </summary>
    // TODO: OBL - C (report not provided?)
    // TODO: CAR - 1
    //[XmlElement("lineage", Order = 2)]
    [JsonProperty("lineage", Order = 2)]
    public LI_Lineage_Type? Lineage {
      get => _lineage;
      set => SetProperty(ref _lineage, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="DQ_DataQuality_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="DQ_DataQuality_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(DQ_DataQuality_Type? other) {
      int result;

      return
          (other is null) ? 1 :
          (result = Scope?.CompareTo(other.Scope) ?? 1) != 0 ? result :
          (result = Report?.Count.CompareTo(other.Report?.Count ?? 0) ?? 1) != 0 ? result :
          (result = Lineage?.CompareTo(other.Lineage) ?? 1) != 0 ? result : 0;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="DQ_DataQuality_Type"/> is equal to the current <see cref="DQ_DataQuality_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="DQ_DataQuality_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(DQ_DataQuality_Type? other) {
      return other != null &&
             Equals(Scope, other.Scope) &&
             Report.SequenceEqualOrdered(other.Report) &&
             Equals(Lineage, other.Lineage);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="DQ_DataQuality_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as DQ_DataQuality_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="DQ_DataQuality_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();
      hash.Add(Scope);
      foreach (AbstractDQ_Element_Type element in Report.SafeOrderBy()) {
        hash.Add(element);
      }
      hash.Add(Lineage);
      return hash.ToHashCode();
    }

    #endregion

  }

}
