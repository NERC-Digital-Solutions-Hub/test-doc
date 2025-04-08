
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
// XSD               : /2005/gml/basicTypes.xsd
//                     /2005/gco/gcoBase.xsd
// --------------------------------------------------------------------------------
// <simpleType name="NilReasonType">
//  <union memberTypes="gml:NullEnumeration anyURI"/>
// </simpleType>
// <simpleType name="NullEnumeration">
//   <union>
//     <simpleType>
//       <restriction base="string">
//         <enumeration value="inapplicable"/>
//         <enumeration value="missing"/>
//         <enumeration value="template"/>
//         <enumeration value="unknown"/>
//         <enumeration value="withheld"/>
//       </restriction>
//     </simpleType>
//     <simpleType>
//       <restriction base="string">
//       <pattern value="other:\w{2,}"/>
//       </restriction>
//     </simpleType>
//   </union>
// </simpleType>
//
// <xs:attribute name="nilReason" type="gml:NilReasonType"/>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common {

  /// <summary>
  /// Represents a standardized way to document the reason for a missing or null value in geospatial metadata.
  /// It is based on the <c>gml:NilReasonType</c> definition in the GML schema and supports enumerated reasons
  /// <see cref="NullEnumeration"/> as well as custom user-defined explanations.
  /// The class ensures that nil reasons are properly structured, validated,
  /// and serialized for interoperability with XML and JSON-based metadata systems.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     <b>Usage:</b>
  ///     <list type="bullet">
  ///       <item>Used in geospatial metadata to indicate why a value is missing or inapplicable.</item>
  ///       <item>
  ///         Supports both predefined enumeration values (NullEnumeration)
  ///         and free-text reasons prefixed with "other:".
  ///       </item>
  ///       <item>Can reference an external explanation using a URI.</item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     <b>Key Features:</b>
  ///     <list type="bullet">
  ///       <item>
  ///         Implements the <see cref="INilReason"/> interface to standardize the handling of missing values.
  ///       </item>
  ///       <item>Ensures valid nil reasons using predefined values or structured custom reasons.</item>
  ///       <item>Provides static helper methods to retrieve correctly formatted nil reason values.</item>
  ///     </list>
  ///   </para>
  /// </remarks>
  [Serializable]
  //[XmlType("CodeList_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot???
  //[JsonObject("CodeList_PropertyType")] // TODO: DANGER!!! - Why is this CodeList_PropertyType ???
  public abstract class NilReasonModel : ObservableModel, INilReason {

    #region Public Properties

    /// <summary>
    /// Gets a <see cref="ReadOnlyDictionary{NullEnumeration, String}"/> where each 
    /// <see cref="NullEnumeration"/> key maps to an explanatory string used by the 
    /// <see cref="NilReason"/> property to describe missing or voided metadata values in XML files.
    /// </summary>
    public static ReadOnlyDictionary<NullEnumeration, string> NilReasons => INilReason.NilReasons;

    #endregion

    #region Public Methods

    /// <summary>
    ///   <para>
    ///     Generates a NilReason <see cref="string"/> based on a predefined enumeration value.
    ///     The method can be used to set the <see cref="string"/> value of the <see cref="NilReason"/> property.
    ///   </para>
    ///   <para>
    ///     The procedure makes sure that rules for setting the <see cref="string"/>
    ///     are observed and should be preferably used rather than setting the
    ///     <see cref="string"/> value using the property's setter. The reason for having a
    ///     public setter in the <see cref="NilReason"/> property is to allow for XML deserialization.
    ///   </para>
    ///   <para>
    ///     <b>Example:</b>
    ///     <example>
    ///       <code>
    ///         NilReason = INilReason.GetNilReason(NullEnumeration.Missing);
    ///         NilReason = INilReason.GetNilReason(NullEnumeration.Other, "Example reason given here");
    ///       </code>
    ///     </example>
    ///   </para>
    /// </summary>
    /// <param name="nullEnum">The <see cref="NullEnumeration"/> value.</param>
    /// <param name="otherAdditionalReason">
    /// Allows a <see cref="string"/> value providing a brief reason to be appended after the
    /// <see cref="NullEnumeration.Other"/>. The argument's value will be used only if
    /// the enumerated value provided is <see cref="NullEnumeration"/>; in all other cases
    /// the argument's value will be omitted.
    /// </param>
    /// <returns>A properly formatted <see cref="string"/> with the NilReason.</returns>
    public static string GetNilReason(
      NullEnumeration nullEnum, string otherAdditionalReason = "Reason not in list" // RESOURCE
    ) => INilReason.GetNilReason(nullEnum, otherAdditionalReason);

    /// <summary>
    ///   <para>
    ///     Generates a NilReason <see cref="string"/> based on a URI reference.
    ///     The method can be used to set the <see cref="string"/> value of the <see cref="NilReason"/> property.
    ///   </para>
    ///   <para>
    ///     <b>Example:</b>
    ///     <example>
    ///       <code>
    ///         NilReason = INilReason.GetNilReason("http://www.example.com/a-detailed-explanation-for-nilreason/";
    ///       </code>
    ///     </example>
    ///   </para>
    /// </summary>
    /// <param name="uriString">
    /// The <see cref="string"/> holding a <c>URI</c> describing in detail the reason for a
    /// <see langword="null"/> / <see cref="void"/> or exception.
    /// </param>
    /// <remarks>
    /// The URI method enables a specific or more complete explanation for the absence
    /// of a value to be provided elsewhere and indicated by-reference in an instance document.
    /// </remarks>
    /// <returns>A <see cref="string"/> with the Nil Reason.</returns>
    public static string GetNilReason(string uriString) => INilReason.GetNilReason(uriString);

    #endregion

    #region INilReason Interface

    // This implementation uses the string representation of NullEnumeration.Unknown as the default Nil Reason value.
    private string _nilReason = GetNilReason(NullEnumeration.Unknown);

    /// <summary>
    ///   <para>
    ///     Gets/Sets an explanation for why a value is missing.
    ///   </para>
    ///   <para>
    ///     The NilReason is a <see cref="string"/> value of one of the following three options:
    ///   </para>
    ///   <para>
    ///     <list type="number">
    ///       <item>
    ///         The value is a low case <see cref="string"/> representation of one of the
    ///         values of the <see cref="NullEnumeration"/>,
    ///         except the value <see cref="NullEnumeration.Other"/>
    ///       </item>
    ///       <item>
    ///         The value is a combination of the low case <see cref="string"/> representation of the
    ///         value <see cref="NullEnumeration.Other"/> followed by <b>:</b>
    ///         and then by a string providing a brief explanation,
    ///         where text is a string of two or more characters with no included spaces.
    ///         <br></br>
    ///         <b>Example:</b>
    ///         <example>
    ///         other:brief explanation goes here
    ///         </example>
    ///         <br></br>
    ///         The entire <see cref="string"/> must be valid against the following regular expression:
    ///         <br></br>
    ///         <c>other:\w{2,}</c>
    ///       </item>
    ///       <item>
    ///         The value is a Uniform Resource Identifier <c>(URI)</c>.<br></br>
    ///         A particular community may choose to assign more detailed semantics to the
    ///         standard values provided by the <see cref="NullEnumeration"/>.
    ///         Alternatively, the URI method enables a specific or more complete explanation
    ///         for the absence of a value to be provided elsewhere and indicated by-reference
    ///         in an instance document.
    ///       </item>
    ///     </list>
    ///   </para>
    ///   <para>
    ///     <b>Example:</b>
    ///     <example>
    ///       <code>
    ///         NilReason = INilReason.GetNilReason(NullEnumeration.Missing);
    ///         NilReason = INilReason.GetNilReason(NullEnumeration.Other, "Example reason give here");
    ///         NilReason = INilReason.GetNilReason("http://www.example.com/a-detailed-explanation-for-nilreason/";
    ///       </code>
    ///     </example>
    ///   </para>
    /// </summary>
    /// <completionlist cref="NullEnumeration"/>
    /// <remarks>
    /// The <b>default</b> <see cref="NilReason"/> value is: <c>&quot;unknown&quot;</c>,
    /// the XML enum value of the <see cref="NullEnumeration.Unknown"/>.
    /// </remarks>
    [XmlAttribute("nilReason", DataType = "anyURI", Form = XmlSchemaForm.Qualified)] // TODO: Check if DataType should be specified here - Check also the corresponding gcoBase.xsd and also an XML example
    [JsonProperty("nilReason")]
    public string NilReason { // Should the namespace be specified here? gco:nilReason / gml:NilReasonType
      get => _nilReason;
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || !_nilReason.Equals(value)) {
          _nilReason = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
