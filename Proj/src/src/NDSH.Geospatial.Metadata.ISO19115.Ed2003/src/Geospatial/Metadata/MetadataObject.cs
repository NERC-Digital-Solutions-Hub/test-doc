
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 20/12/2022, @gisvlasta
// History           : 21/03/2025, @gisvlasta - Renamed to 'MetadataObject' and added the property 'PropertyMetadata'
//                      which stores property level metadata for all concrete classes inheriting from MetadatObject.
//                      The PropertyMetadata either stores a NilreasonEntity which provides the reason why the expected
//                      value of a property is null, or a ReferencedObject which provides a way to create references.
//                   : 27/03/2025, @gisvlasta - Implemented the ITypeReferenced interface.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="AbstractObject_Type" abstract="true">
//   <xs:sequence/>
//   <xs:attributeGroup ref="gco:ObjectIdentification"/>
// </xs:complexType>
// <xs:element name="AbstractObject" type="gco:AbstractObject_Type" abstract="true"/>
// <xs:attributeGroup name="ObjectIdentification">
//   <xs:attribute name="id" type="xs:ID"/>
//   <xs:attribute name="uuid" type="xs:string"/>
// </xs:attributeGroup>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Geospatial.Gml.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata {

  /// <summary>
  /// The AbstractObject_Type class serves as an abstract base type for geospatial metadata objects
  /// in compliance with the ISO 19115 standard. It implements the <see cref="IObjectIdentification"/>
  /// interface, which provides unique identification attributes such as id and uuid.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     <b>Usage:</b>
  ///     <list type="bullet">
  ///       <item>Used as a base class for other metadata objects that require identification attributes.</item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     <b>Key Features:</b>
  ///     <list type="bullet">
  ///       <item>Ensures change notifications through the <see cref="ObservableDbEntity"/> base class.</item>
  ///       <item>
  ///         The class cannot be instantiated directly but provides a foundation for other metadata objects.
  ///       </item>
  ///       <item>
  ///         Global Unique Identifiers:
  ///         The id and uuid properties ensure each object instance can be uniquely referenced.
  ///       </item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     <b>Considerations:</b>
  ///     <list type="bullet">
  ///       <item>The id attribute follows XML ID constraints and must be unique within a document.</item>
  ///       <item>
  ///         The uuid should be a globally unique identifier and is represented as a <see cref="string"/>.
  ///       </item>
  ///       <item>As an abstract type, this class must be subclassed before use.</item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     Maps to: <c>AbstractObject_Type</c> ( /2005/gco/gcoBase.xsd )
  ///   </para>
  /// </remarks>
  [IsoType("AbstractObject_Type", IsAbstract = true, IsoType = IsoTypes.ComplexType)]
  //[XmlType("AbstractObject", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("AbstractObject")]
  public abstract class MetadataObject : ObservableDbEntity, IObjectIdentification, ITypeReferenced {

    #region IObjectIdentification Interface

    private string? _id;

    /// <summary>
    /// Gets/Sets the unique identifier for the object.
    /// This attribute's type is defined in the schema as <c>ID</c> and must be unique within an XML document.
    /// </summary>
    [XmlAttribute("id", DataType = "ID")]
    [JsonProperty("id")]
    public string? Id {
      get => _id;
      set => SetProperty(ref _id, value);
    }

    private string? _uuid;

    /// <summary>
    /// Gets/Sets the universally unique identifier (UUID) for the object.
    /// This ensures the object can be referenced uniquely across different datasets.
    /// </summary>
    [XmlAttribute("uuid", DataType = "string")]
    [JsonProperty("uuid")]
    public string? Uuid {
      get => _uuid;
      set => SetProperty(ref _uuid, value);
    }

    #endregion

    #region ITypeReferenced Interface

    private TypeReferenceMetadata? _typeReferenceMetadata;

    // WARNING: Make sure that all objects inheriting from MetadataObject expect either a NilReasonEntity or a ReferenceEntity. We may have to restrict further for certain concrete classes.

    /// <summary>
    /// Gets/Sets the <see cref="Metadata.TypeReferenceMetadata">union reference</see>.
    /// </summary>
    /// <remarks>
    /// This is either a <see cref="ReferenceEntity"/> or a <see cref="NilReasonEntity"/>.
    /// </remarks>
    public TypeReferenceMetadata? TypeReferenceMetadata {
      get => _typeReferenceMetadata;
      set => SetProperty(ref _typeReferenceMetadata, value);
    }

    #endregion

  }

}
