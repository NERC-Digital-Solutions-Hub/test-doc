
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 17/02/2025, @gisvlasta
// History           : 03/03/2025, @gisvlasta - Updated inheritance, added constructors, and updated documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="ScopedName" type="gml:CodeType" substitutionGroup="gco:AbstractGenericName"/>
// <xs:complexType name="ScopedName_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:ScopedName"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Implementation.Names {

  /// <summary>
  /// Represents a fully qualified, hierarchical name within a namespace, as defined in ISO 19103.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     A <see cref="ScopedName"/> consists of a namespace (scope) and a local name.
  ///     It provides a structured naming mechanism that allows metadata elements to be referenced
  ///     in a hierarchical manner, supporting interoperability in geospatial metadata.
  ///   </para>
  ///   <para>
  ///     <see cref="CodeType.CodeSpace">CodeSpace</see> can have values from the following <b>three</b> categories:
  ///     <list type="bullet">
  ///       <item>
  ///         A simple name (e.g., a dictionary name, authority, or classification scheme).
  ///       </item>
  ///       <item>
  ///         A hierarchical namespace (it can be a dot . pattern, similar to programming namespaces).
  ///       </item>
  ///       <item>
  ///         A URI (Uniform Resource Identifier) (commonly used for globally unique references).
  ///       </item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     <b><i>EXAMPLES:</i></b>
  ///     <list type="number">
  ///       <item>
  ///         <b>Simple Name</b>
  ///         <list type="bullet">
  ///           <item><term>"ISO19115"</term><description>A metadata standard name</description></item>
  ///           <item><term>"EPSG"</term><description>A spatial reference system authority</description></item>
  ///           <item><term>"OGC"</term><description>Open Geospatial Consortium</description></item>
  ///         </list>
  ///       </item>
  ///       <item>
  ///         <b>Dot (.) Namespace Pattern</b>
  ///         <list type="bullet">
  ///           <item>
  ///             <term>"Geospatial.Metadata"</term>
  ///             <description>A structured namespace in a system</description>
  ///           </item>
  ///           <item>
  ///             <term>"Physical.Geology"</term>
  ///             <description>A hierarchical category in a geoscience dataset</description>
  ///           </item>
  ///           <item>
  ///             <term>"ISO.Geospatial.Metadata"</term>
  ///             <description>A structured ISO metadata namespace</description>
  ///           </item>
  ///         </list>
  ///       </item>
  ///       <item>
  ///         <b>URI (Web-based Reference)</b>
  ///         <list type="bullet">
  ///           <item>
  ///             <term>"https://www.opengis.net/def/namespaces"</term>
  ///             <description>A persistent web reference to a geospatial definition</description>
  ///           </item>
  ///           <item>
  ///             <term>"http://metadata.iso.org/19115"</term>
  ///             <description>A direct reference to ISO 19115 metadata</description>
  ///           </item>
  ///           <item>
  ///             <term>"http://www.epsg-registry.org/"</term>
  ///             <description>The EPSG coordinate reference system registry</description>
  ///           </item>
  ///         </list>
  ///       </item>
  ///       <item>
  ///         <b>URN (Uniform Resource Name)</b>
  ///         <list type="bullet">
  ///           <item>
  ///             <term>"urn:ogc:def:crs:EPSG::4326"</term>
  ///             <description>A structured identifier for an EPSG coordinate system</description>
  ///           </item>
  ///           <item>
  ///             <term>"urn:x-ogc:def:metadata:ISO19115:2003"</term>
  ///             <description>A URN reference to ISO 19115 metadata</description>
  ///           </item>
  ///         </list>
  ///       </item>
  ///       <item>
  ///         <b>UUID-based Identifier</b>
  ///           <list type="bullet">
  ///           <item>
  ///             <term>"urn:uuid:123e4567-e89b-12d3-a456-426614174000"</term>
  ///             <description>A globally unique identifier for a metadata record</description>
  ///           </item>
  ///         </list>
  ///       </item>
  ///     </list>
  ///   </para>
  /// </remarks>
  //[XmlType("ScopedName", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("ScopedName")]
  public class ScopedName : GenericName {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ScopedName"/>.
    /// </summary>
    public ScopedName() {

    }

    /// <summary>
    /// Initializes the <see cref="ScopedName"/>.
    /// </summary>
    /// <param name="name">
    /// The name used to set the <see cref="CodeType.Value">Value</see> of the <see cref="ScopedName"/>.
    /// </param>
    /// <param name="codeSpace">
    /// The codeSpace used to denote the namespace of the <see cref="ScopedName"/>.
    /// </param>
    public ScopedName(string name, string codeSpace) {
      CodeSpace = codeSpace;
      Value = name;
    }

    #endregion

  }

}
