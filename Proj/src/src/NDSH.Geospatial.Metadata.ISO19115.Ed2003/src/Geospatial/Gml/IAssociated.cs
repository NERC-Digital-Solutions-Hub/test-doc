
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 19/03/2025, @gisvlasta
// History           : 21/03/2025, @gisvlasta - Corrected XML documentation and code style.
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

namespace NDSH.Geospatial.Gml {

  /// <summary>
  /// Indicates if a <see cref="GmlObject"/> is decorated with an <see cref="Gml.AssociationEntity">Association</see>.
  /// </summary>
  public interface IAssociated {

    /// <summary>
    /// Gets/Set the <see cref="Gml.AssociationEntity">Association</see>.
    /// </summary>
    public AssociationEntity? Association {
      get;
      set;
    }

  }

}
