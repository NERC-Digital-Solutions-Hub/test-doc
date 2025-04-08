
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 16/01/2023, @gisvlasta
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
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime {

  /// <summary>
  /// The DateTimeEnumeration defines the types of DateTime used for serialization.
  /// </summary>
  [XmlType(IncludeInSchema = false)]
  public enum DateTimeEnumeration {

    /// <summary>
    /// A date is used in serialization/deserialization.
    /// </summary>
    Date,

    /// <summary>
    /// A datetime is used in serialization/deserialization.
    /// </summary>
    DateTime,

  }

}
