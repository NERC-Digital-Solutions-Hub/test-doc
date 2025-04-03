#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 07/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <attribute name="id" type="ID">
//   <annotation>
//     <documentation>
//       The attribute gml:id supports provision of a handle for the XML element representing a GML Object.
//       Its use is mandatory for all GML objects. It is of XML type ID, so is constrained to be unique
//       in the XML document within which it occurs.
//     </documentation>
//   </annotation>
// </attribute>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

namespace NDSH.Geospatial.Gml {

  /// <summary>
  /// Defines a contract for GML objects that require a unique identifier.
  /// This interface aligns with the GML standard and ensures compliance with
  /// the gmlBase schema's ID attribute definition.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>id</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  public interface IId {

    /// <summary>
    /// Gets/Sets the unique identifier for the object.
    /// This attribute is defined in the schema as <c>ID</c> and must be unique within an XML document.
    /// </summary>
    //[XmlAttribute("id", DataType = "ID")]
    //[JsonProperty("id")]
    // TODO: The XmlAttribute is used to inform the way the Id is serialized. Needs removal.
    public string Id {
      get;
      set;
    }

  }

}
