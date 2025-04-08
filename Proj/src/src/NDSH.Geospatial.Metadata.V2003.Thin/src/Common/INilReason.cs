
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 31/12/2022, 03:45, @gisvlasta.
// Updated by        : 12/01/2023, 17:49, @gisvlasta.
//                     13/01/2023, 03:48, @gisvlasta.
// Version           : 1.0.2
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

using NDSH.Geospatial.Metadata.V2003.Thin;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;
using NDSH.Xml.XLink;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common {

  /// <summary>
  /// The INilReason interface defines a content model that allows recording
  /// of an explanation for a <c>Null</c> value or other exception.
  /// </summary>
  public interface INilReason {

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
    //[XmlAttribute("nilReason", DataType="anyURI", Form = XmlSchemaForm.Qualified)] // TODO: Check if DataType should be specified here - Check also the corresponding gcoBase.xsd and also an XML example
    //[JsonProperty("nilReason")] // TODO: Should Attributes be attached on the Properties?
    public string NilReason {
      get;
      set;
    }

    /// <summary>
    /// Gets the dictionary of all the valid strings used in the <see cref="NilReason"/> property.
    /// </summary>
    /// <remarks>
    /// Implementations need to provide all the <see cref="string"/> representations
    /// of the <see cref="NilReasonEnumeration"/> enumeration values.
    /// </remarks>
    public static ReadOnlyDictionary<NilReasonEnumeration, string> NilReasons = CreateNilReasonsDictionary();

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

      if (nilReasonEnum != NilReasonEnumeration.Other) {
        return nilReasonEnum.GetXmlEnumName();
      }
      else {
        string other = String.Format("{0}:{1}", nilReasonEnum.GetXmlEnumName(), otherAdditionalReason);

        Regex regex = new Regex("other:\\w{2,}");
        Match match = regex.Match(other);

        if (!match.Success) {
          throw new Exception("The reason string provided is invalid.");
        }

        return other;
      }

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

      bool isValid = Uri.TryCreate(uriString, UriKind.RelativeOrAbsolute, out Uri uri);

      if (!isValid) {
        throw new Exception("Invalid NilReason URI provided.");
      }

      return uriString;

    }

    #region Private Procedures

    /// <summary>
    /// Creates the read only dictionary of valid NilReason strings.
    /// </summary>
    /// <returns>
    /// 
    /// </returns>
    // TODO: Find out how to document generic types.
    private static ReadOnlyDictionary<NilReasonEnumeration, string> CreateNilReasonsDictionary() {

      return new ReadOnlyDictionary<NilReasonEnumeration, string>(new Dictionary<NilReasonEnumeration, string>(6) {
        { NilReasonEnumeration.Inapplicable, NilReasonEnumeration.Inapplicable.GetXmlEnumName() },
        { NilReasonEnumeration.Missing, NilReasonEnumeration.Missing.GetXmlEnumName() },
        { NilReasonEnumeration.Template, NilReasonEnumeration.Template.GetXmlEnumName() },
        { NilReasonEnumeration.Unknown, NilReasonEnumeration.Unknown.GetXmlEnumName() },
        { NilReasonEnumeration.Withheld, NilReasonEnumeration.Withheld.GetXmlEnumName() },
        { NilReasonEnumeration.Other, NilReasonEnumeration.Other.GetXmlEnumName() }
      });

    }

    #endregion

  }

}
