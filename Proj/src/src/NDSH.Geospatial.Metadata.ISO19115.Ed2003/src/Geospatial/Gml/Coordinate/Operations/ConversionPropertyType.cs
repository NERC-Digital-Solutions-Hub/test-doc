
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
// XSD               : /2005/gml/coordinateOperations.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="Conversion" type="gml:ConversionType" substitutionGroup="gml:AbstractGeneralConversion">
//   <annotation>
//     <documentation>
//       gml:Conversion is a concrete operation on coordinates that does not include any change of Datum.
//       The best-known example of a coordinate conversion is a map projection. The parameters describing
//       coordinate conversions are defined rather than empirically derived. Note that some conversions have no parameters.
//       This concrete complex type can be used without using a GML Application Schema that defines
//       operation-method-specialized element names and contents, especially for methods with only one Conversion instance.
//       The usesValue property elements are an unordered list of composition associations to the
//       set of parameter values used by this conversion operation.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="ConversionType">
//   <complexContent>
//     <extension base="gml:AbstractGeneralConversionType">
//       <sequence>
//         <element ref="gml:method"/>
//         <element ref="gml:parameterValue" minOccurs="0" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="ConversionPropertyType">
//   <annotation>
//     <documentation>
//       gml:ConversionPropertyType is a property type for association roles to a concrete general-purpose conversion,
//       either referencing or containing the definition of that conversion.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:Conversion"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Operations {

  /// <summary>
  /// gml:ConversionPropertyType is a property type for association roles to a concrete general-purpose conversion, either referencing or containing the definition of that conversion.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ConversionPropertyType")]
  public class ConversionPropertyType : ObservableModel {

    #region Private fields
    private ConversionType _conversion;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// ConversionPropertyType class constructor
    /// </summary>
    public ConversionPropertyType() {
      _conversion = default; // new ConversionType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("Conversion", Order = 0)]
    public ConversionType Conversion {
      get {
        return _conversion;
      }
      set {
        if (_conversion == value) {
          return;
        }
        if (_conversion == null || _conversion.Equals(value) != true) {
          _conversion = value;
          OnPropertyChanged("Conversion");
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

  }

}
