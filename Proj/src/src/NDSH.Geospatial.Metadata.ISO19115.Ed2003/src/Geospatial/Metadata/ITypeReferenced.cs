
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

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata {

  /// <summary>
  /// Indicates if a <see cref="MetadataObject"/> provides a
  /// <see cref="Metadata.TypeReferenceMetadata">union reference</see> of
  /// <see cref="ReferenceEntity"/> or <see cref="NilReasonEntity"/>.
  /// </summary>
  public interface ITypeReferenced {

    /// <summary>
    /// Gets/Sets the <see cref="Metadata.TypeReferenceMetadata">union reference</see>.
    /// </summary>
    public TypeReferenceMetadata? TypeReferenceMetadata {
      get;
      set;
    }

  }

}

