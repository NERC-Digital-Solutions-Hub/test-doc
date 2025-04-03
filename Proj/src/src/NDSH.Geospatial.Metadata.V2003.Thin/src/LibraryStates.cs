
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 14/01/2023, 21:43, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
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

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin {

  /// <summary>
  /// The states that the library can have when operating on metadata.
  /// The states are used by the <see cref="LibraryState"/> to allow code take decision
  /// on how to manipulate maetadata. For example when a deserialization operation
  /// takes place it may be needed to relax certain rules so that malformed XML
  /// metadata documents could be processed without raising exceptions.
  /// </summary>
  public enum LibraryStates {

    /// <summary>
    /// The library is used for metadata editing.
    /// </summary>
    Editing = 0,

    /// <summary>
    /// The library is used for metadata serialization.
    /// </summary>
    Serialization = 1,

    /// <summary>
    /// The library is used for metadata
    /// </summary>
    Deserialization = 2,

  }

}
