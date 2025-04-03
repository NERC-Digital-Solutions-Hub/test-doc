
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 00:25, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ApplicationSchema;
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
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Common.Extent {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("EX_ExtentTypeCode", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("EX_ExtentTypeCode", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_ExtentTypeCode")]
  public class EX_ExtentTypeCode : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_ExtentTypeCode"/>.
    /// </summary>
    public EX_ExtentTypeCode() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _value = default;

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

    private EX_ExtentTypeCodeValue _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "value")]
    [JsonProperty("value")]
    [JsonConverter(typeof(StringEnumConverter))]
    public EX_ExtentTypeCodeValue Value {
      get {
        return _value;
      }
      set {
        if ((_value.Equals(value) != true)) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
