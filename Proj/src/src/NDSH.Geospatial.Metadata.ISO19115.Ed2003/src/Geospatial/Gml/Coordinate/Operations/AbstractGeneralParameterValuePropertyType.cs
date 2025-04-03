
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
// <element name="AbstractGeneralParameterValue" type="gml:AbstractGeneralParameterValueType" abstract="true" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <documentation>gml:AbstractGeneralParameterValue is an abstract parameter value or group of parameter values.
//       This abstract complexType is expected to be extended and restricted for well-known operation methods with many instances,
//       in Application Schemas that define operation-method-specialized element names and contents.
//       Specific parameter value elements are directly contained in concrete subtypes, not in this abstract type.
//       All concrete types derived from this type shall extend this type to include one "...Value" element with an appropriate type,
//       which should be one of the element types allowed in the ParameterValueType.
//       In addition, all derived concrete types shall extend this type to include a "operationParameter" property element that references
//       one element substitutable for the "OperationParameter" object element.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="AbstractGeneralParameterValueType" abstract="true">
//   <sequence/>
// </complexType>
// <complexType name="AbstractGeneralParameterValuePropertyType">
//   <annotation>
//     <documentation>
//       gml:AbstractGeneralParameterValuePropertyType is a property type for inline association roles to a parameter value or group of parameter values,
//       always containing the values.
//     </documentation>
//   </annotation>
//   <sequence>
//     <element ref="gml:AbstractGeneralParameterValue"/>
//   </sequence>
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
  /// gml:AbstractGeneralParameterValuePropertyType is a  property type for inline association roles
  /// to a parameter value or group of parameter values, always containing the values.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralParameterValuePropertyType")]
  public class AbstractGeneralParameterValuePropertyType : ObservableModel {

    #region Private fields
    private AbstractGeneralParameterValueType _abstractGeneralParameterValue;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractGeneralParameterValue", Order = 0)]
    public AbstractGeneralParameterValueType AbstractGeneralParameterValue {
      get {
        return _abstractGeneralParameterValue;
      }
      set {
        if (_abstractGeneralParameterValue == value) {
          return;
        }
        if (_abstractGeneralParameterValue == null || _abstractGeneralParameterValue.Equals(value) != true) {
          _abstractGeneralParameterValue = value;
          OnPropertyChanged("AbstractGeneralParameterValue");
        }
      }
    }

  }

}
