
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 01/02/2023, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateOperations.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="ParameterValue" type="gml:ParameterValueType" substitutionGroup="gml:AbstractGeneralParameterValue">
//   <annotation>
//     <documentation>
//       gml:ParameterValue is a parameter value, an ordered sequence of values, or a reference to a file of parameter values.
//       This concrete complex type may be used for operation methods without using an Application Schema
//       that defines operation-method-specialized element names and contents, especially for methods with only one instance.
//       This complex type may be used, extended, or restricted for well-known operation methods,
//       especially for methods with many instances.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="ParameterValueType">
//   <complexContent>
//     <extension base="gml:AbstractGeneralParameterValueType">
//       <sequence>
//         <choice>
//           <element ref="gml:value"/>
//           <element ref="gml:dmsAngleValue"/>
//           <element ref="gml:stringValue"/>
//           <element ref="gml:integerValue"/>
//           <element ref="gml:booleanValue"/>
//           <element ref="gml:valueList"/>
//           <element ref="gml:integerValueList"/>
//           <element ref="gml:valueFile"/>
//         </choice>
//         <element ref="gml:operationParameter"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Measures;
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
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ParameterValueType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ParameterValueType")]
  public class ParameterValueType : AbstractGeneralParameterValueType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ParameterValueType"/>.
    /// </summary>
    public ParameterValueType() {
      _operationParameter = new OperationParameterPropertyType();
    }

    #endregion

    #region Public Properties

    private object _item;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("booleanValue", typeof(bool), Order = 0)]
    [XmlElement("dmsAngleValue", typeof(DMSAngleType), Order = 0)]
    [XmlElement("integerValue", typeof(string), DataType = "positiveInteger", Order = 0)]
    [XmlElement("integerValueList", typeof(string), DataType = "integer", Order = 0)]
    [XmlElement("stringValue", typeof(string), Order = 0)]
    [XmlElement("value", typeof(MeasureType), Order = 0)]
    [XmlElement("valueFile", typeof(string), DataType = "anyURI", Order = 0)]
    [XmlElement("valueList", typeof(MeasureListType), Order = 0)]
    [XmlChoiceIdentifier("ItemElementName")]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged();
        }
      }
    }

    private ParameterType _itemElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ItemElementName", Order = 1)]
    [XmlIgnore]
    public ParameterType ItemElementName {
      get {
        return _itemElementName;
      }
      set {
        if (_itemElementName.Equals(value) != true) {
          _itemElementName = value;
          OnPropertyChanged();
        }
      }
    }

    private OperationParameterPropertyType _operationParameter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("operationParameter", Order = 2)]
    [JsonProperty("operationParameter", Order = 2)]
    public OperationParameterPropertyType OperationParameter {
      get {
        return _operationParameter;
      }
      set {
        if (_operationParameter == value) {
          return;
        }
        if (_operationParameter == null || _operationParameter.Equals(value) != true) {
          _operationParameter = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
