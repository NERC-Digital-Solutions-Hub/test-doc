
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Feature {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false)]
  [JsonObject("MultiplicityRange")]
  public class MultiplicityRange : EntityBase<MultiplicityRange> {

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private int _lower;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "lower")]
    [RequiredAttribute()]
    [JsonProperty("lower", Order = 0)]
    public int Lower {
      get {
        return _lower;
      }
      set {
        if (_lower.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "Lower";
          Validator.ValidateProperty(value, validatorPropContext);
          _lower = value;
          OnPropertyChanged();
        }
      }
    }

    private int _upper;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "upper")]
    [RequiredAttribute()]
    [JsonProperty("upper", Order = 1)]
    public int Upper {
      get {
        return _upper;
      }
      set {
        if (_upper.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "Upper";
          Validator.ValidateProperty(value, validatorPropContext);
          _upper = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
