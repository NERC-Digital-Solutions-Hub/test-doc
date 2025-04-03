
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 20/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// --------------------------------------------------------------------------------
// <xs:complexType name="AbstractObject_Type" abstract="true">
//   <xs:sequence/>
//   <xs:attributeGroup ref="gco:ObjectIdentification"/>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common {

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
  ///       <item>Ensures change notifications through the <see cref="ObservableModel"/> base class.</item>
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
  /// </remarks>
  [Serializable]
  [XmlType("AbstractObject", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("AbstractObject")]
  public abstract class AbstractObject_Type : ObservableModel, IObjectIdentification {

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
      set {
        if (_id == value) {
          return;
        }
        if (_id == null || _id.Equals(value) != true) {
          _id = value;
          OnPropertyChanged();
        }
      }
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
      set {
        if (_uuid == value) {
          return;
        }
        if (_uuid == null || _uuid.Equals(value) != true) {
          _uuid = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
