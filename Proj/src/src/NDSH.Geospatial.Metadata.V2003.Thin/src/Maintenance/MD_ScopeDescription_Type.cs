
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 16:40, @gisvlasta.
// Updated by        : 09/01/2023, 20:37, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gmd/maintenance.xsd
// --------------------------------------------------------------------------------
// <xs:complexType name="MD_ScopeDescription_Type">
//   <xs:annotation>
//     <xs:documentation>Description of the class of information covered by the information</xs:documentation>
//   </xs:annotation>
//   <xs:choice>
//     <xs:element name="attributes" type="gco:ObjectReference_PropertyType" maxOccurs="unbounded"/>
//     <xs:element name="features" type="gco:ObjectReference_PropertyType" maxOccurs="unbounded"/>
//     <xs:element name="featureInstances" type="gco:ObjectReference_PropertyType" maxOccurs="unbounded"/>
//     <xs:element name="attributeInstances" type="gco:ObjectReference_PropertyType" maxOccurs="unbounded"/>
//     <xs:element name="dataset" type="gco:CharacterString_PropertyType"/>
//     <xs:element name="other" type="gco:CharacterString_PropertyType"/>
//   </xs:choice>
// </xs:complexType>
// <!-- ........................................................................ -->
// <xs:element name="MD_ScopeDescription" type="gmd:MD_ScopeDescription_Type"/>
// <!-- ........................................................................ -->
// <xs:complexType name="MD_ScopeDescription_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_ScopeDescription"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2003.Thin.Common;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Maintenance {

  /*
   * TODO: DANGEROUS - Here things become really strange !!!
   *
	<!-- =========================================================================== -->
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
   * 
   * 
   */


  /// <summary>
  /// Description of the class of information covered by the information.
  /// </summary>
  [Serializable]
  [XmlType("MD_ScopeDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_ScopeDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_ScopeDescription")]
  public class MD_ScopeDescription_Type : Model { // TODO: Make sure what's going on here. It seems that only derives from Model.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ScopeDescription_Type"/>.
    /// </summary>
    public MD_ScopeDescription_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

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

    private object[] _items;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("attributeInstances", typeof(ObjectReference_PropertyType), Order = 0)]
    [XmlElement("attributes", typeof(ObjectReference_PropertyType), Order = 0)]
    [XmlElement("dataset", typeof(CharacterString), Order = 0)]
    [XmlElement("featureInstances", typeof(ObjectReference_PropertyType), Order = 0)]
    [XmlElement("features", typeof(ObjectReference_PropertyType), Order = 0)]
    [XmlElement("other", typeof(CharacterString), Order = 0)]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items { // TODO: this should have been an ObservableCollection ???
      get {
        return _items;
      }
      set {
        if (_items == value) {
          return;
        }
        if (_items == null || _items.Equals(value) != true) {
          _items = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_ScopeDescription_Enum[] _itemsElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ItemsElementName", Order = 1)]
    [XmlIgnore]
    public MD_ScopeDescription_Enum[] ItemsElementName {
      get {
        return _itemsElementName;
      }
      set {
        if (_itemsElementName == value) {
          return;
        }
        if (_itemsElementName == null || _itemsElementName.Equals(value) != true) {
          _itemsElementName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
