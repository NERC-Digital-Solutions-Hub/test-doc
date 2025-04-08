
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 27/02/2025, @gisvlasta
// History           : 14/03/2025, @gisvlasta - Renamed IValue<T> to InullableValue<T>.
//                   : 18/03/2025, @gisvlasta - Added struct constraint in the interface definition.
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
  /// Represents an interface for defining a standard value property in value types for geospatial metadata.
  /// This interface ensures that implementing classes provide a structured and serializable
  /// mechanism for handling values in compliance with the ISO 19115 standard.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     <b>Considerations:</b>
  ///     <list type="bullet">
  ///       <item>
  ///         The <see cref="Value"/> property is a value type and may require validation depending on usage.
  ///       </item>
  ///     </list>
  ///   </para>
  /// </remarks>
  public interface INullableValue<T> where T : struct {

    /// <summary>
    /// Gets/Sets the value associated with a metadata entity.
    /// </summary>
    public T? Value {
      get;
      set;
    }

  }

}
