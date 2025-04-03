
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
// <element name="AbstractGeneralConversion" type="gml:AbstractGeneralConversionType" abstract="true" substitutionGroup="gml:AbstractOperation">
//   <annotation>
//     <documentation>
//       gm:AbstractGeneralConversion is an abstract operation on coordinates that does not include any change of datum.
//       The best-known example of a coordinate conversion is a map projection.
//       The parameters describing coordinate conversions are defined rather than empirically derived.
//       Note that some conversions have no parameters. The operationVersion, sourceCRS, and targetCRS elements are omitted in a coordinate conversion.
//       This abstract complex type is expected to be extended for well-known operation methods with many Conversion instances,
//       in GML Application Schemas that define operation-method-specialized element names and contents. 
//       This conversion uses an operation method, usually with associated parameter values.
//       However, operation methods and parameter values are directly associated with concrete subtypes, not with this abstract type.
//       All concrete types derived from this type shall extend this type to include a "usesMethod" element that references the "OperationMethod" element.
//       Similarly, all concrete types derived from this type shall extend this type to include zero or more elements each named "uses...Value" that
//       each use the type of an element substitutable for the "AbstractGeneralParameterValue" element.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="AbstractGeneralConversionType" abstract="true">
//   <complexContent>
//     <restriction base="gml:AbstractCoordinateOperationType">
//       <sequence>
//         <element ref="gml:metaDataProperty" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:description" minOccurs="0"/>
//         <element ref="gml:descriptionReference" minOccurs="0"/>
//         <element ref="gml:identifier"/>
//         <element ref="gml:name" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:remarks" minOccurs="0"/>
//         <element ref="gml:domainOfValidity" minOccurs="0"/>
//         <element ref="gml:scope" maxOccurs="unbounded"/>
//         <element ref="gml:coordinateOperationAccuracy" minOccurs="0" maxOccurs="unbounded"/>
//       </sequence>
//       <attribute ref="gml:id" use="required"/>
//     </restriction>
//   </complexContent>
// </complexType>
// <complexType name="GeneralConversionPropertyType">
//   <annotation>
//     <documentation>
//       gml:GeneralConversionPropertyType is a property type for association roles to a general conversion,
//       either referencing or containing the definition of that conversion.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractGeneralConversion"/>
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
  /// gml:GeneralConversionPropertyType is a property type for association roles to a general conversion,
  /// either referencing or containing the definition of that conversion.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeneralConversionPropertyType")]
  public class GeneralConversionPropertyType : ObservableModel {

    #region Private fields
    private AbstractGeneralConversionType _abstractGeneralConversion;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractGeneralConversion", Order = 0)]
    public AbstractGeneralConversionType AbstractGeneralConversion {
      get {
        return _abstractGeneralConversion;
      }
      set {
        if (_abstractGeneralConversion == value) {
          return;
        }
        if (_abstractGeneralConversion == null || _abstractGeneralConversion.Equals(value) != true) {
          _abstractGeneralConversion = value;
          OnPropertyChanged("AbstractGeneralConversion");
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
