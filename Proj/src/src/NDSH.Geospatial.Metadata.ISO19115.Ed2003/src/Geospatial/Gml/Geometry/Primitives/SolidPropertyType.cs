
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/geometryPrimitives.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AbstractSolidType">
//   <annotation>
//     <documentation>
//       gml:AbstractSolidType is an abstraction of a solid to support the different levels of complexity.
//       The solid may always be viewed as a geometric primitive, i.e. is contiguous.
//     </documentation>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractGeometricPrimitiveType"/>
//   </complexContent>
// </complexType>
// <element name="AbstractSolid" type="gml:AbstractSolidType" abstract="true" substitutionGroup="gml:AbstractGeometricPrimitive">
//   <annotation>
//     <documentation>The AbstractSolid element is the abstract head of the substitution group for all (continuous) solid elements.</documentation>
//   </annotation>
// </element>
// <complexType name="SolidPropertyType">
//   <annotation>
//     <documentation>
//       A property that has a solid as its value domain may either be an appropriate geometry element
//       encapsulated in an element of this type or an XLink reference to a remote geometry element
//       (where remote includes geometry elements located elsewhere in the same document). Either the
//       reference or the contained element shall be given, but neither both nor none.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractSolid"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="solidProperty" type="gml:SolidPropertyType">
//   <annotation>
//     <documentation>
//       This property element either references a solid via the XLink-attributes or contains the solid element.
//       solidProperty is the predefined property which may be used by GML Application Schemas whenever a GML
//       feature has a property with a value that is substitutable for AbstractSolid.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {


  /// <summary>
  /// A property that has a solid as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SolidPropertyType")]
  public class SolidPropertyType : ObservableModel {
    #region Private fields
    private AbstractSolidType _abstractSolid;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// SolidPropertyType class constructor
    /// </summary>
    public SolidPropertyType() {
      _abstractSolid = default; // new AbstractSolidType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractSolid", Order = 0)]
    public AbstractSolidType AbstractSolid {
      get {
        return _abstractSolid;
      }
      set {
        if (_abstractSolid == value) {
          return;
        }
        if (_abstractSolid == null || _abstractSolid.Equals(value) != true) {
          _abstractSolid = value;
          OnPropertyChanged("AbstractSolid");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged("NilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string RemoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged("RemoteSchema");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("Owns");
        }
      }
    }
  }


}
