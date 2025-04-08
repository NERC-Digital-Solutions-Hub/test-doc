
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// History           : 09/03/2025, @gisvlasta
//                       Renamed interface from IOwnershipAttributeGroup to IOwnership and added documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <attributeGroup name="OwnershipAttributeGroup">
//   <attribute name="owns" type="boolean" default="false"/>
// </attributeGroup>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  /// <summary>
  /// Encoding a GML property in-line vs by-reference shall not imply anything about
  /// the “ownership” of the contained or referenced GML Object, i.e. the encoding style
  /// shall not imply any “deep-copy” or “deep-delete” semantics.To express ownership over
  /// the contained or referenced GML Object, the <c>gml:OwnershipAttributeGroup</c> attribute group
  /// may be added to object-valued property elements.If the attribute group is not part of the
  /// content model of such a property element, then the value may not be “owned”.
  /// When the value of the owns attribute is <see langword="true"/>, the existence of in-line or
  /// referenced object(s) depends upon the existence of the parent object.
  /// </summary>
  public interface IOwnership {

    /// <summary>
    /// Gets/Sets a <see cref="bool"/> value indicating whether the existence of the contained or referenced
    /// GML object depends on the existence of the parent object.
    /// </summary>
    /// <remarks>
    /// The <c>owns</c> attribute, as defined in the <c>gml:OwnershipAttributeGroup</c>, specifies whether 
    /// the parent object holds ownership over the contained or referenced GML object. 
    /// <list type="bullet">
    /// <item>
    ///   If set to <see langword="true"/>, the life-cycle of the contained or referenced object
    ///   is tied to the parent object, meaning that if the parent object is deleted,
    ///   the owned object(s) should also be deleted.
    /// </item>
    /// <item>
    ///   If set to <see langword="false"/> (default), the contained or referenced object
    ///   exists independently of the parent.
    /// </item>
    /// </list>
    /// This attribute does not imply any specific encoding style (in-line vs. by-reference).
    /// </remarks>
    /// <value>
    /// A <see cref="bool"/> value representing ownership semantics. The default value is <see langword="false"/>.
    /// </value>
    //[XmlAttribute("owns")]
    [DefaultValue(false)]
    //[JsonProperty("owns")]
    public bool Owns {
      get;
      set;
    }

  }

}
