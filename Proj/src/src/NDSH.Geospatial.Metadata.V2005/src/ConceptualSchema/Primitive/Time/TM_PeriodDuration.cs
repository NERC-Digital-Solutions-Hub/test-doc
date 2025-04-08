
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

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Primitive.Time {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false)]
  [JsonObject("TM_PeriodDuration")]
  public class TM_PeriodDuration : Model {

    #region Public Fields
    
    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private DateTime _from;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "from")]
    [RequiredAttribute()]
    [JsonProperty("from", Order = 0)]
    public DateTime From {
      get {
        return _from;
      }
      set {
        if (_from.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "From";
          Validator.ValidateProperty(value, validatorPropContext);
          _from = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTime _to;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "to")]
    [RequiredAttribute()]
    [JsonProperty("to", Order = 1)]
    public DateTime To {
      get {
        return _to;
      }
      set {
        if (_to.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "To";
          Validator.ValidateProperty(value, validatorPropContext);
          _to = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
