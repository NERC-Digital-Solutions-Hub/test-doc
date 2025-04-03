
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 19:02, @gisvlasta.
// Updated by        : 02/01/2023, 19:01, @gisvlasta. - Renamed to NilModel.
//                     13/01/2023, 20:58, @gisvlasta. - Renamed to NilReasonModel.
//                     16/01/2023, 15:23, @gisvlasta. - Added static methods.
// Version           : 1.0.3
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
//                     /2005/gco/gcoBase.xsd
// --------------------------------------------------------------------------------
// <simpleType name="NilReasonType">
//  <union memberTypes="gml:NilReasonEnumeration anyURI"/>
// </simpleType>
// <simpleType name="NilReasonEnumeration">
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

using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CodeList_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot???
  [JsonObject("CodeList_PropertyType")] // TODO: DANGER!!! - Why is this CodeList_PropertyType ???
  public abstract class NilReasonModel : Model, INilReason {

    #region Public Properties

    /// <summary>
    /// Gets the dictionary of all the valid strings used in the <see cref="NilReason"/> property.
    /// </summary>
    // TODO: Find out how to document generic types.
    public static ReadOnlyDictionary<NilReasonEnumeration, string> NilReasons {
      get {
        return INilReason.NilReasons;
      }
    }

    #endregion

    #region Public Methods

    /// <summary>
    ///   <para>
    ///     Sets the <see cref="string"/> value of the <see cref="NilReason"/> property.
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
    ///         NilReason = INilReason.GetNilReason(NilReasonEnumeration.Missing);
    ///         NilReason = INilReason.GetNilReason(NilReasonEnumeration.Other, "Example reason given here");
    ///       </code>
    ///     </example>
    ///   </para>
    /// </summary>
    /// <param name="nilReasonEnum">The <see cref="NilReasonEnumeration"/> value.</param>
    /// <param name="otherAdditionalReason">
    /// Allows a string value providing a brief reason to be appended after the
    /// <see cref="NilReasonEnumeration.Other"/>. The argument's value will be used only if
    /// the enumerated value provided is <see cref="NilReasonEnumeration"/>; in all other cases
    /// the argument's value will be ommited.
    /// </param>
    /// <returns>A <see cref="string"/> with the Nil Reason.</returns>
    public static string GetNilReason(NilReasonEnumeration nilReasonEnum, string otherAdditionalReason = "Reason not in list") {
      return INilReason.GetNilReason(nilReasonEnum, otherAdditionalReason);
    }

    /// <summary>
    /// <para>
    /// Sets the <see cref="string"/> value of the <see cref="NilReason"/> property.
    /// </para>
    /// <para>
    ///   <b>Example:</b>
    ///   <example>
    ///     <code>
    ///       NilReason = INilReason.GetNilReason("http://www.example.com/a-detailed-explanation-for-nilreason/";
    ///     </code>
    ///   </example>
    /// </para>
    /// </summary>
    /// <param name="uriString">
    /// The string holding a URI describing in detail the reason for a null / void or exception.
    /// </param>
    /// <returns>A <see cref="string"/> with the Nil Reason.</returns>
    public static string GetNilReason(string uriString) {
      return INilReason.GetNilReason(uriString);
    }

    #endregion

    #region INilReason Interface

    private string _nilReason;

    /// <summary>
    /// <para>
    /// The NilReason is a <see cref="string"/> value of one of the following three options:
    /// </para>
    /// <para>
    ///   <list type="number">
    ///     <item>
    ///       The value is a low case <see cref="string"/> representation of one of the
    ///       values of the <see cref="NilReasonEnumeration"/>,
    ///       except the value <see cref="NilReasonEnumeration.Other"/>
    ///     </item>
    ///     <item>
    ///       The value is a combination of the low case <see cref="string"/> representation of the
    ///       value <see cref="NilReasonEnumeration.Other"/> followed by <b>:</b>
    ///       and then by a string providing a brief explanation,
    ///       where text is a string of two or more characters with no included spaces.
    ///       <br></br>
    ///       <b>Example:</b>
    ///       <example>
    ///       other:brief explanation goes here
    ///       </example>
    ///       <br></br>
    ///       The entire <see cref="string"/> must be valid against the following regular expression:
    ///       <br></br>
    ///       <c>other:\w{2,}</c>
    ///     </item>
    ///     <item>
    ///       The value is a Uniform Resource Identifier <b>(URI)</b>.<br></br>
    ///       A particular community may choose to assign more detailed semantics to the
    ///       standard values provided by the <see cref="NilReasonEnumeration"/>.
    ///       Alternatively, the URI method enables a specific or more complete explanation
    ///       for the absence of a value to be provided elsewhere and indicated by-reference
    ///       in an instance document.
    ///     </item>
    ///   </list>
    /// </para>
    /// <para>
    /// <b>Example:</b>
    /// <example>
    /// <code>
    /// NilReason = INilReason.GetNilReason(NilReasonEnumeration.Missing);
    /// NilReason = INilReason.GetNilReason(NilReasonEnumeration.Other, "Example reason give here");
    /// NilReason = INilReason.GetNilReason("http://www.example.com/a-detailed-explanation-for-nilreason/";
    /// </code>
    /// </example>
    /// </para>
    /// </summary>
    [XmlAttribute("nilReason", DataType = "anyURI", Form = XmlSchemaForm.Qualified)] // TODO: Check if DataType should be specified here - Check also the corresponding gcoBase.xsd and also an XML example
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
