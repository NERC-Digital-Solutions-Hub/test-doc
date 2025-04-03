
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

using NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Operations {

  //[XmlInclude(typeof(ML_Conversion_Type))] // GMX
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ConversionType")]
  public class ConversionType : AbstractGeneralConversionType {

    #region Private fields
    private OperationMethodPropertyType _method;
    private List<AbstractGeneralParameterValuePropertyType> _parameterValue;
    #endregion

    /// <summary>
    /// ConversionType class constructor
    /// </summary>
    public ConversionType() {
      _parameterValue = default; //  new List<AbstractGeneralParameterValuePropertyType>();
      _method = default; //  new OperationMethodPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("method", Order = 0)]
    public OperationMethodPropertyType Method {
      get {
        return _method;
      }
      set {
        if (_method == value) {
          return;
        }
        if (_method == null || _method.Equals(value) != true) {
          _method = value;
          OnPropertyChanged("Method");
        }
      }
    }

    [XmlElement("parameterValue", Order = 1)]
    [JsonProperty("parameterValue", Order = 1)]
    public List<AbstractGeneralParameterValuePropertyType> ParameterValue {
      get {
        return _parameterValue;
      }
      set {
        if (_parameterValue == value) {
          return;
        }
        if (_parameterValue == null || _parameterValue.Equals(value) != true) {
          _parameterValue = value;
          OnPropertyChanged("ParameterValue");
        }
      }
    }

  }

}
