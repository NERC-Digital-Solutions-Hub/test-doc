
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 14/01/2023, 21:42, @gisvlasta.
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
  /// The LibraryState provides the overall state of the Library when
  /// it is used for certain manipulations of geospatial metadata.
  /// </summary>
  public static class LibraryState {

    #region Public Properties

    private static LibraryStates _state;

    /// <summary>
    /// Gets the current state of the library.
    /// </summary>
    public static LibraryStates State {
      get {
        return _state;
      }
    }

    #endregion

  }

}
