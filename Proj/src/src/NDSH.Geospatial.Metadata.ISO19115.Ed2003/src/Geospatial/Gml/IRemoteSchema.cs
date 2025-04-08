
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <attribute name="remoteSchema" type="anyURI">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </attribute>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml {

  /// <summary>
  /// Defines an interface for referencing an external schema in a geospatial metadata context.
  /// This interface provides a mechanism to specify a URI linking to a remote schema.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     The <see cref="IRemoteSchema"/> interface allows metadata objects to include a reference
  ///     to an external schema definition. This is primarily used in GML-based metadata structures.
  ///   </para>
  ///   <para>
  ///     <b>Considerations:</b>
  ///     <list type="bullet">
  ///       <item>The <see cref="RemoteSchema"/> property is deprecated in GML specifications.</item>
  ///       <item>Future implementations should consider alternative schema reference mechanisms.</item>
  ///       <item>Ensure compatibility with XML serialization when used in legacy systems.</item>
  ///     </list>
  ///   </para>
  /// </remarks>
  /// <seealso cref="https://www.ogc.org/standards/gml"/>
  [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd.")]
  public interface IRemoteSchema { // TODO: What should be done with this [Obsolete] (deprecated) Interface?

    /// <summary>
    /// Gets/Sets the URI reference to an external remote schema.
    /// This property is deprecated and should be used only for backward compatibility.
    /// </summary>
    /// <remarks>
    /// This is an obsolete property. (Marked deprecated in /gml/gmlBase.xsd).
    /// </remarks>
    //[XmlAttribute("remoteSchema", DataType = "anyURI", Form = XmlSchemaForm.Qualified)] // TODO: Does it need the [XmlAttribute] ???
    //[XmlIgnore]
    //[JsonProperty("remoteSchema")]
    // TODO: The XmlAttribute is used to inform the way the Id is serialized. Needs removal.
    public string? RemoteSchema {
      get;
      set;
    }

  }

}
