
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 22/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/dataQuality.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="AbstractDQ_Result_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence/>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractDQ_Result" type="gmd:AbstractDQ_Result_Type" abstract="true"/>
// <xs:complexType name="DQ_Result_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:AbstractDQ_Result"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.DataQuality {

  #region XmlIncludes
  //[XmlInclude(typeof(QE_CoverageResult_Type))]
  //[XmlInclude(typeof(DQ_QuantitativeResult_Type))]
  //[XmlInclude(typeof(DQ_ConformanceResult_Type))]
  #endregion

  [Serializable]
  //[XmlType("AbstractDQ_Result", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("AbstractDQ_Result", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractDQ_Result")]
  public abstract class AbstractDQ_Result_Type : MetadataObject, IComparable<AbstractDQ_Result_Type>, IEquatable<AbstractDQ_Result_Type> {

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="AbstractDQ_Result_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="AbstractDQ_Result_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public virtual int CompareTo(AbstractDQ_Result_Type? other) {
      return 0; // TODO: Implement. This should be abstract.
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="AbstractDQ_Result_Type"/> is equal to the current <see cref="AbstractDQ_Result_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="AbstractDQ_Result_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public virtual bool Equals(AbstractDQ_Result_Type? other) {
      return false; // TODO: Implement. This should be abstract.
    }

    #endregion
  }

}
