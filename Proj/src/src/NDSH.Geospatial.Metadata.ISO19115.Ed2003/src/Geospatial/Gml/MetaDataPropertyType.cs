
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// History           : 09/01/2023, @gisvlasta - Added code in IAssociation interface.
//                   : 15/03/2025, @gisvlasta - Changed 'about' property to nullable string because
//                                               it is an attribute which is not marked as 'use="required"'.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="MetaDataPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractMetaData"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   <attribute name="about" type="anyURI"/>
// </complexType>
// <attributeGroup name="AssociationAttributeGroup">
//   <annotation>
//     <documentation>
//       XLink components are the standard method to support hypertext referencing in XML.
//       An XML Schema attribute group, gml:AssociationAttributeGroup, is provided to support the use of Xlinks
//       as the method for indicating the value of a property by reference in a uniform manner in GML.
//     </documentation>
//   </annotation>
//   <attributeGroup ref="xlink:simpleLink"/>
//   <attribute name="nilReason" type="gml:NilReasonType"/>
//   <attribute ref="gml:remoteSchema"/>
// </attributeGroup>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from MetaDataPropertyType to MetaDataProperty.

  /// <summary>
  /// Represents a metadata property in GML, which allows associating metadata with a GML object.
  /// The metadata can be <b>in-line</b> or a <b>reference</b> to external metadata.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>MetaDataPropertyType</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd")]
  [IsoType("MetaDataPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("MetaDataPropertyType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MetaDataPropertyType")]
  public class MetaDataPropertyType : AssociationEntity {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MetaDataPropertyType"/>.
    /// </summary>
    public MetaDataPropertyType() {
      _abstractMetaData = default;
    }

    #endregion

    #region Public Properties

    private AbstractMetaDataType? _abstractMetaData;

    /// <summary>
    /// Gets/Sets the <b>metadata content</b> associated with the GML object.
    /// </summary>
    /// <remarks>
    /// This property contains an <b>optional metadata object</b> that may describe the associated GML element.
    /// It can be <b>in-line metadata</b> or <b>a reference to external metadata</b>.
    /// </remarks>
    /// <value>
    /// An instance of <see cref="AbstractMetaDataType"/> containing metadata information.
    /// </value>
    //[XmlElement("AbstractMetaData", Order = 0)]
    [JsonProperty("AbstractMetaData", Order = 0)]
    public AbstractMetaDataType? AbstractMetaData {
      get => _abstractMetaData;
      set {
        if (_abstractMetaData == value) {
          return;
        }
        if (_abstractMetaData == null || _abstractMetaData.Equals(value) != true) {
          _abstractMetaData = value;
          OnPropertyChanged();
        }
      }
    }

    private string? _about;

    /// <summary>
    /// Gets/Sets the <b>URI reference</b> for this metadata property.
    /// </summary>
    /// <remarks>
    /// This property provides a <b>unique reference</b> to an external metadata resource.
    /// The value should be a <b>valid URI</b>.
    /// </remarks>
    /// <value>
    /// A <see cref="string"/> representing a <b>URI reference</b>.
    /// </value>
    /// <exception cref="UriFormatException">
    /// Thrown when an invalid URI is assigned to this property.
    /// </exception>
    //[XmlAttribute("about", DataType = "anyURI")]
    [JsonProperty("about")]
    // WARNING: URI validation is needed here.
    public string? About {
      get => _about;
      set {
        if (!Uri.IsWellFormedUriString(value, UriKind.RelativeOrAbsolute)) {
          throw new UriFormatException($"The provided '{nameof(About)}' value is not a valid URI."); // RESOURCE
        }
        SetProperty(ref _about, value);
      }
    }

    #endregion

  }

}
