
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 20/03/2025, @gisvlasta
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

#endregion

namespace NDSH.Geospatial.Metadata {

  /// <summary>
  /// Indicates if a <see cref="MetadataObject"/> is decorated with a <see cref="ReferenceEntity"/>
  /// </summary>
  public interface IReferenced {

    /// <summary>
    /// Gets/Sets the <see cref="ReferenceEntity"/>.
    /// </summary>
    public ReferenceEntity? Reference {
      get;
      set;
    }

  }

}
