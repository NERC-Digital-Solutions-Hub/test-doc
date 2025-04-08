
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 31/01/2023, 20:41, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Measures {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DMSAngleType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DMSAngleType")]
  public class DMSAngleType : Model {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DMSAngleType"/>.
    /// </summary>
    public DMSAngleType() {
      _degrees = new DegreesType();
    }

    #endregion

    #region Public Properties

    private DegreesType _degrees;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("degrees", Order = 0)]
    [JsonProperty("degrees", Order = 0)]
    public DegreesType Degrees {
      get {
        return _degrees;
      }
      set {
        if (_degrees == value) {
          return;
        }
        if (_degrees == null || _degrees.Equals(value) != true) {
          _degrees = value;
          OnPropertyChanged();
        }
      }
    }

    private object[] _minutesSecondsValues;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("decimalMinutes", typeof(decimal), Order = 1)]
    [XmlElement("minutes", typeof(string), DataType = "nonNegativeInteger", Order = 1)]
    [XmlElement("seconds", typeof(decimal), Order = 1)]
    [XmlChoiceIdentifier("MinutesSecondsValueTypes")]
    public object[] MinutesSecondsValues {
      get {
        return _minutesSecondsValues;
      }
      set {
        if (_minutesSecondsValues == value) {
          return;
        }
        if (_minutesSecondsValues == null || _minutesSecondsValues.Equals(value) != true) {
          _minutesSecondsValues = value;
          OnPropertyChanged();
        }
      }
    }

    private MinutesSecondsValueType[] _minutesSecondsValueTypes;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MinutesSecondsValueTypes", Order = 2)]
    [XmlIgnore]
    public MinutesSecondsValueType[] MinutesSecondsValueTypes {
      get {
        return _minutesSecondsValueTypes;
      }
      set {
        if (_minutesSecondsValueTypes == value) {
          return;
        }
        if (_minutesSecondsValueTypes == null || _minutesSecondsValueTypes.Equals(value) != true) {
          _minutesSecondsValueTypes = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
