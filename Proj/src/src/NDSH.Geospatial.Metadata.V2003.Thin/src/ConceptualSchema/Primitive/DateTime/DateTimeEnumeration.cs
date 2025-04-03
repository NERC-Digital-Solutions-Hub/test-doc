
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 16/01/2023, 20:41, @gisvlasta.
//                     10/02/2023, 21:36, @gisvlasta.
//                     1.0.1 - Removed item Time.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.DateTime {

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
