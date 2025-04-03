
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 30/01/2023, @gisvlasta
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
// 
// <complexType name="AbstractMemberType" abstract="true">
//   <sequence/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from AbstractMemberType to Member.

  /// <summary>
  /// To create a collection of GML Objects that are not all features, a property type shall
  /// be derived by extension from <see cref="AbstractMemberType"/>. This abstract property type
  /// is intended to be used only in object types where software shall be able to identify that
  /// an instance of such an object type is to be interpreted as a collection of objects.
  /// By default, this abstract property type does not imply any ownership of the objects in the collection.
  /// The <c>owns</c> attribute of <c>gml:OwnershipAttributeGroup</c> may be used on a property element
  /// instance to assert ownership of an object in the collection. A collection shall not own an object
  /// already owned by another object.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AbstractMemberType</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  //[XmlInclude(typeof(DictionaryEntryType))]
  [IsoType("AbstractMemberType", IsAbstract = true, IsoType = IsoTypes.ComplexType)]
  //[XmlType("AbstractMemberType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractMemberType")]
  public abstract class AbstractMemberType : GmlObject, IOwnership {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractMemberType"/>.
    /// </summary>
    public AbstractMemberType() {
      _owns = false;
    }

    #endregion

    #region IOwnership Interface

    private bool _owns = false;

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
      get => _owns;
      set => SetProperty(ref _owns, value);
    }

    #endregion

  }

}
