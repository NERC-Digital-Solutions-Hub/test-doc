
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 18:40, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005;
using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

// TODO: IMPORTANT Missing Properties !!! - The MD_ScopeDescription misses 4 important properties.

/*
 * The following is the official documentation of MD_ScopeDescription_Type in maintenance.xsd
 * 
 
	<xs:complexType name="MD_ScopeDescription_Type">
		<xs:annotation>
			<xs:documentation>Description of the class of information covered by the information</xs:documentation>
		</xs:annotation>
		<xs:choice>
			<xs:element name="attributes" type="gco:ObjectReference_PropertyType" maxOccurs="unbounded"/>
			<xs:element name="features" type="gco:ObjectReference_PropertyType" maxOccurs="unbounded"/>
			<xs:element name="featureInstances" type="gco:ObjectReference_PropertyType" maxOccurs="unbounded"/>
			<xs:element name="attributeInstances" type="gco:ObjectReference_PropertyType" maxOccurs="unbounded"/>
			<xs:element name="dataset" type="gco:CharacterString_PropertyType"/>
			<xs:element name="other" type="gco:CharacterString_PropertyType"/>
		</xs:choice>
	</xs:complexType>
	<!-- ........................................................................ -->
	<xs:element name="MD_ScopeDescription" type="gmd:MD_ScopeDescription_Type"/>
	<!-- ........................................................................ -->
	<xs:complexType name="MD_ScopeDescription_PropertyType">
		<xs:sequence minOccurs="0">
			<xs:element ref="gmd:MD_ScopeDescription"/>
		</xs:sequence>
		<xs:attribute ref="gco:nilReason"/>
	</xs:complexType>

*/

/*
 * The following is the definition used in MetadataSchema.xsd for the generation of the code. It seems that is missing 4 properties defined as sets.
 * 

  <xs:complexType name="MD_ScopeDescription">
    <xs:sequence>
      <xs:element minOccurs="0" maxOccurs="1" name="id" type="xs:string" />
      <xs:element minOccurs="0" maxOccurs="1" name="uuid" type="xs:string" />
      <xs:element minOccurs="0" maxOccurs="1" name="dataset" type="xs:string" />
      <xs:element minOccurs="0" maxOccurs="1" name="other" type="xs:string" />
    </xs:sequence>
  </xs:complexType>

*/

namespace NDSH.Geospatial.Metadata.V2005.Maintenance {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_ScopeDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_ScopeDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ScopeDescription")]
  public class MD_ScopeDescription : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ScopeDescription"/>.
    /// </summary>
    public MD_ScopeDescription() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _dataset = default;
      _other = default;

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    // TODO: MISSING PROPERTIES HERE !!! also when properties will be added , their ORDER should be updated.

    private string _dataset;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "dataset")]
    [JsonProperty("dataset", Order = 0)]
    public string Dataset {
      get {
        return _dataset;
      }
      set {
        if (_dataset == value) {
          return;
        }
        if (_dataset == null || _dataset.Equals(value) != true) {
          _dataset = value;
          OnPropertyChanged();
        }
      }
    }

    private string _other;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "other")]
    [JsonProperty("other", Order = 1)]
    public string Other {
      get {
        return _other;
      }
      set {
        if (_other == value) {
          return;
        }
        if (_other == null || _other.Equals(value) != true) {
          _other = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
    [XmlIgnore()]
    [JsonProperty("id")]
    public string Id {
      get {
        return _id;
      }
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

    private string _uuid;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "uuid")]
    [XmlIgnore()]
    [JsonProperty("uuid")]
    public string Uuid {
      get {
        return _uuid;
      }
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
