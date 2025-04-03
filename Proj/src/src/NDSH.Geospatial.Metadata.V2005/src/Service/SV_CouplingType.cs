
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 03:31, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Service {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("SV_CouplingType", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [XmlType("SV_CouplingType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_CouplingType")]
  public class SV_CouplingType : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_CouplingType"/>.
    /// </summary>
    public SV_CouplingType() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _value = default; // TODO: Is this correct?

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private SV_CouplingTypeValue _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "value")]
    [JsonProperty("value")]
    [JsonConverter(typeof(StringEnumConverter))]
    public SV_CouplingTypeValue Value {
      get {
        return _value;
      }
      set {
        if (_value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    // TODO: MISSING id and uuid properties (Check Schema)???

    #endregion

  }

}
