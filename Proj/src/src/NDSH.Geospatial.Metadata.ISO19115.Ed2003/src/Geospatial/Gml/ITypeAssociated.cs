
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 27/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  /// <summary>
  /// Indicates if a <see cref="GmlObject"/> provides a
  /// <see cref="TypeAssociationMetadata">union association</see> of
  /// <see cref="AssociationEntity"/> or <see cref="ReferenceEntity"/>.
  /// </summary>
  public interface ITypeAssociated {

    /// <summary>
    /// Gets/Set the <see cref="TypeAssociationMetadata">union association</see>.
    /// </summary>
    public TypeAssociationMetadata? TypeAssociation {
      get;
      set;
    }

  }

}
