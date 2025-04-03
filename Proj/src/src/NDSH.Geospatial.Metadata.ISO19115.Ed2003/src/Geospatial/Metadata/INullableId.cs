
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 30/12/2022, @gisvlasta
// History           : 14/03/2025, @gisvlasta - Renamed IId to INullableId.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:attribute name="id" type="xs:ID"/>
// 
// //[XmlAttribute("id", DataType = "ID")]
// ---------------------------------------------------------------------------------------------------------------------
#endregion

namespace NDSH.Geospatial.Metadata {

  /// <summary>
  /// Defines a contract for objects that require a unique identifier within an XML or GML document.
  /// </summary>
  public interface INullableId {

    /// <summary>
    /// Gets/Sets the unique identifier for the object.
    /// This attribute is defined in the schema as <c>ID</c> and must be unique within an XML document.
    /// </summary>
    public string? Id {
      get;
      set;
    }

  }

}
