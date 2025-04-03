
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="CoordinatesType">
//   <annotation>
//     <documentation>
//       This type is deprecated for tuples with ordinate values that are numbers.
//       CoordinatesType is a text string, intended to be used to record an array of tuples or coordinates. 
//       While it is not possible to enforce the internal structure of the string through schema validation,
//       some optional attributes have been provided in previous versions of GML to support a description of
//       the internal structure. These attributes are deprecated. The attributes were intended to be used as follows:
//       Decimal symbol - used for a decimal point (default=”.” a stop or period)
//       cs      symbol - used to separate components within a tuple or coordinate string (default=”,” a comma)
//       ts      symbol - used to separate tuples or coordinate strings (default=” “ a space)
//       Since it is based on the XML Schema string type, CoordinatesType may be used in the construction
//       of tables of tuples or arrays of tuples, including ones that contain mixed text and numeric values.
//     </documentation>
//   </annotation>
//   <simpleContent>
//     <extension base="string">
//       <attribute name="decimal" type="string" default="."/>
//       <attribute name="cs" type="string" default=","/>
//       <attribute name="ts" type="string" default="&#x20;"/>
//     </extension>
//   </simpleContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Geospatial.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.BasicTypes {

  /// <summary>
  /// The <see cref="CoordinatesType"/> is deprecated for tuples with ordinate values that are numbers.
  /// The <see cref="CoordinatesType"/> is a text string, intended to be used to record an array of tuples or
  /// coordinates. While it is not possible to enforce the internal structure of the string through schema validation,
  /// some optional attributes have been provided in previous versions of GML to support a description of the
  /// internal structure. These attributes are deprecated. The attributes were intended to be used as follows:
  /// <list type="bullet">
  ///   <item>
  ///     <term><b>Decimal symbol</b></term>
  ///     <description>Used for a decimal point (default="." a stop or period).</description>
  ///   </item>
  ///   <item>
  ///     <term><b>cs symbol</b></term>
  ///     <description>
  ///       Used to separate components within a tuple or coordinate string (default="," a comma).
  ///     </description>
  ///   </item>
  ///   <item>
  ///     <term><b>ts symbol</b></term>
  ///     <description>
  ///       Used to separate tuples or coordinate strings (default=" " a space).
  ///     </description>
  ///   </item>
  ///   Since it is based on the XML Schema <see cref="string"/> type, <see cref="CoordinatesType"/>
  ///   may be used in the construction of tables of tuples or arrays of tuples,
  ///   including ones that contain mixed text and numeric values.
  /// </list>
  /// </summary>
  [IsoType("CoordinatesType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("CoordinatesType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CoordinatesType")]
  public class CoordinatesType : ObservableDbEntity, IValue<string> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CoordinatesType"/>.
    /// </summary>
    public CoordinatesType() {
      _decimal = ".";
      _cs = ",";
      _ts = " ";
      _value = string.Empty;
    }

    #endregion

    #region Public Properties

    private string _decimal;

    /// <summary>
    /// Gets/Sets the decimal symbol.
    /// </summary>
    //[XmlAttribute("decimal")]
    [DefaultValue(".")]
    [JsonProperty("decimal")]
    public string Decimal {
      get => _decimal;
      set => SetProperty(ref _decimal, value);
    }

    private string _cs;

    /// <summary>
    /// Gets/Sets the <b><c>cs</c></b> symbol.
    /// </summary>
    //[XmlAttribute("cs")]
    [DefaultValue(",")]
    [JsonProperty("cs")]
    public string CS {
      get => _cs;
      set => SetProperty(ref _cs, value);
    }

    private string _ts;

    /// <summary>
    /// Gets/Sets tje <b><c>ts</c></b> symbol.
    /// </summary>
    //[XmlAttribute("ts")]
    [DefaultValue(" ")]
    [JsonProperty("ts")]
    public string TS {
      get => _ts;
      set => SetProperty(ref _ts, value);
    }

    #endregion

    #region IValue<string> Interface

    private string _value;

    /// <summary>
    /// Gets/Sets the value of <see cref="CoordinatesType"/>.
    /// </summary>
    //[XmlText]
    [JsonProperty("Value")]
    public string Value {
      get => _value;
      set => SetProperty(ref _value, value);
    }

    #endregion

  }

}
