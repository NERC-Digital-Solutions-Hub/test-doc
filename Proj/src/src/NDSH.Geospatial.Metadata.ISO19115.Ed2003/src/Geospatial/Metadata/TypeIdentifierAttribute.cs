
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 14/02/2025, @gisvlasta
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
  /// Defines an <see cref="int">integer</see> identifier for a type.
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
  public class TypeIdentifierAttribute : Attribute {

    /// <summary>
    /// Gets the identifier associated with the type.
    /// </summary>
    public int Identifier {
      get;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TypeIdentifierAttribute"/> class with the specified identifier.
    /// </summary>
    /// <param name="identifier">The identifier to associate with the type.</param>
    public TypeIdentifierAttribute(int identifier) {
      Identifier = identifier;
    }

  }

}
