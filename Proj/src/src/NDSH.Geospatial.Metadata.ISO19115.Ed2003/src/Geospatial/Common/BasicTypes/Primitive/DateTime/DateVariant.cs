
#region
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 27/02/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : The XSD is provided to explain the role of this enumeration in the definition of
//                     the DateDbEntity.
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:simpleType name="Date_Type">
//   <xs:union memberTypes="xs:date xs:gYearMonth xs:gYear"/>
// </xs:simpleType>
// <xs:element name="Date" type="gco:Date_Type" nillable="true"/>
// <xs:complexType name="Date_PropertyType">
//   <xs:choice minOccurs="0">
//     <xs:element ref="gco:Date"/>
//     <xs:element ref="gco:DateTime"/>
//   </xs:choice>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime {

  /// <summary>
  /// Specifies the date/time granularity in alignment with the ISO 19115 <c>Date_PropertyType</c> definitions. 
  /// </summary>
  /// <remarks>
  /// This enumeration distinguishes whether only the year is set (<c>gYear</c>), 
  /// the year and month (<c>gYearMonth</c>), a complete date (<c>xs:date</c>), 
  /// or both date and time (<c>xs:dateTime</c>).
  /// </remarks>
  public enum DateVariant {

    /// <summary>
    /// Represents the full date (year, month, and day).
    /// </summary>
    FullDate,

    /// <summary>
    /// Represents only the year (gYear).
    /// </summary>
    Year,

    /// <summary>
    /// Represents the year and month (gYearMonth).
    /// </summary>
    YearMonth,

    /// <summary>
    /// Represents the full date and time.
    /// </summary>
    DateAndTime,

  }

}
