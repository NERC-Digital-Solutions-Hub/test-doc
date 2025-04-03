
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 31/03/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:attribute name="codeSpace" type="xs:anyURI"/>
// [XmlAttribute(AttributeName = "codeSpace", DataType = "anyURI")]
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
  /// Defines a contract for objects that require a reference to a code space.
  /// This interface ensures that implementing classes provide a structured mechanism
  /// for referencing a code space as per the ISO 19115 metadata standard.
  /// </summary>
  public interface ICodeSpace {

    /// <summary>
    /// Gets/Sets the URI reference to the code space authority.
    /// This property must be a valid URI, ensuring compliance with metadata schema definitions.
    /// </summary>
    public string CodeSpace {
      get;
      set;
    }

  }

}
