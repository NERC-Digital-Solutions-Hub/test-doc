
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 30/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// --------------------------------------------------------------------------------
// <xs:attribute name="id" type="xs:ID"/>
// --------------------------------------------------------------------------------
#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common {

  /// <summary>
  /// Defines a contract for objects that require a unique identifier within an XML document.
  /// This interface aligns with the ISO 19115 metadata standard and ensures compliance with
  /// the gcoBase schema's ID attribute definition.
  /// </summary>
  public interface IId {

    /// <summary>
    /// Gets/Sets the unique identifier for the object.
    /// This attribute is defined in the schema as <c>ID</c> and must be unique within an XML document.
    /// </summary>
    //[XmlAttribute("id", DataType = "ID")]
    //[JsonProperty("id")]
    // TODO: The XmlAttribute is used to inform the way the Id is serialized. Needs removal.
    public string? Id {
      get;
      set;
    }

  }

}
