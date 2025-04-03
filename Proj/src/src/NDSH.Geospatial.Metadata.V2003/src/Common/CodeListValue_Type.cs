
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// --------------------------------------------------------------------------------
// <xs:complexType name="CodeListValue_Type">
//   <xs:simpleContent>
//     <xs:extension base="xs:string">
//       <xs:attribute name="codeList" type="xs:anyURI" use="required"/>
//       <xs:attribute name="codeListValue" type="xs:anyURI" use="required"/>
//       <xs:attribute name="codeSpace" type="xs:anyURI"/>
//     </xs:extension>
//   </xs:simpleContent>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common {

  /// <summary>
  /// Represents a specific value within a registered code list, ensuring standardized
  /// categorization and reference. This class implements multiple metadata interfaces
  /// to provide comprehensive code list support as per the ISO 19115 metadata standard.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     The <see cref="CodeListValue_Type"/> class allows referencing an external code list value,
  ///     supporting interoperability across metadata systems. It provides attributes to store the
  ///     code list URI, the selected value within the list, and an optional code space.
  ///   </para>
  ///   <para>
  ///     <b>Considerations:</b>
  ///     <list type="bullet">
  ///       <item>
  ///         The <see cref="CodeList"/> and <see cref="CodeListValue"/> properties are required attributes.
  ///       </item>
  ///       <item>
  ///         The <see cref="CodeSpace"/> property is optional but recommended for unambiguous referencing.
  ///       </item>
  ///     </list>
  ///   </para>
  /// </remarks>
  [Serializable]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("CodeListValue_Type")]
  public class CodeListValue_Type : ObservableModel, ICodeList, ICodeListValue, ICodeSpace, IValue {

    #region ICodeList Interface

    private string _codeList;

    /// <summary>
    /// Gets/Sets the URI reference to the external code list.
    /// This property is required and ensures compliance with the metadata schema.
    /// </summary>
    [XmlAttribute(AttributeName = "codeList", DataType = "anyURI")]
    [JsonProperty("codeList")]
    [Required()] // TODO: Check out the RequiredAttribute and its arguments.
    public string CodeList {
      get => _codeList;
      set {
        if (_codeList == value) {
          return;
        }
        if (_codeList == null || _codeList.Equals(value) != true) {
          _codeList = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region ICodeListValue Interface

    private string _codeListValue;

    /// <summary>
    /// Gets or sets the URI reference to a specific value in the external code list.
    /// This property is required and must be a valid URI.
    /// </summary>
    [XmlAttribute(AttributeName = "codeListValue", DataType = "anyURI")]
    [JsonProperty("codeListValue")]
    [Required()] // TODO: Check out the RequiredAttribute and its arguments.
    public string CodeListValue {
      get => _codeListValue;
      set {
        if (_codeListValue == value) {
          return;
        }
        if (_codeListValue == null || _codeListValue.Equals(value) != true) {
          _codeListValue = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region ICodeSpace Interface

    private string _codeSpace;

    /// <summary>
    /// Gets or sets the URI reference for the code space, defining the authority for the code list.
    /// This property is optional but recommended for metadata traceability.
    /// </summary>
    [XmlAttribute(AttributeName = "codeSpace", DataType = "anyURI")]
    [JsonProperty("codeSpace")]
    //[Required()] // TODO: Check out the RequiredAttribute and its arguments.
    public string? CodeSpace {
      get => _codeSpace;
      set {
        if (_codeSpace == value) {
          return;
        }
        if (_codeSpace == null || _codeSpace.Equals(value) != true) {
          _codeSpace = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region IValue Interface

    private string _value;

    /// <summary>
    /// Gets or sets the actual value associated with the metadata entity.
    /// This property supports XML text serialization.
    /// </summary>
    [XmlText(DataType = "string")]
    [JsonProperty("Value")]
    public string? Value { // TODO: Check if this should be Value and what JSON serialization should be!!! gcoBase.xsd
      get => _value;
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || _value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
