
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 01/02/2023, 20:31, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Gml.Measures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Operations {

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
