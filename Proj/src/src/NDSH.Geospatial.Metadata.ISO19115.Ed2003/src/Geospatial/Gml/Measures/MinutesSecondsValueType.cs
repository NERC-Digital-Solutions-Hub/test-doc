
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 31/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Measures {

  /// <summary>
  /// Specifies how the minute and second portions of a degrees-minutes-seconds (DMS) angle 
  /// are stored or interpreted within a GML context. This enumeration allows for either 
  /// a single decimal value for minutes or separate integer fields for minutes and seconds.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Defined in <c>/2005/gml/measures.xsd</c>, these values are typically used alongside
  ///     the <see cref="DMSAngleType"/> to distinguish the format in which the <c>minute</c> and
  ///     <c>second</c> components are provided. For example, one might specify the <c>minutes</c>
  ///     portion as a decimal number in <see cref="DecimalMinutes"/>, or use integer <see cref="Minutes"/>
  ///     with optional integer <see cref="Seconds"/>.
  ///   </para>
  ///   <para>
  ///     Note that this approach to specifying angles is marked as deprecated in some GML 
  ///     definitions and may only be retained for backward compatibility with older datasets 
  ///     or schemas.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
  public enum MinutesSecondsValueType {

    /// <summary>
    /// Represents the minute portion of a DMS angle as a single decimal value 
    /// (e.g., 15.5 minutes).
    /// </summary>
    //[XmlEnum(Name = "decimalMinutes")]
    //[EnumMember(Value = "decimalMinutes")]
    DecimalMinutes,

    /// <summary>
    /// Represents the minute portion of a DMS angle as a whole-number integer.
    /// </summary>
    //[XmlEnum(Name = "minutes")]
    //[EnumMember(Value = "minutes")]
    Minutes,

    /// <summary>
    /// Represents the second portion of a DMS angle as a decimal or integer value.
    /// </summary>
    //[XmlEnum(Name = "seconds")]
    //[EnumMember(Value = "seconds")]
    Seconds,

  }

}
