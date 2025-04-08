
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 31/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
//                     /2005/gco/gcoBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
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
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using NDSH.Xml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common {

  /// <summary>
  /// The <see cref="INilReason"/> interface defines a content model that allows recording
  /// of an explanation for a <see langword="null"/> value or other exception.
  /// </summary>
  public interface INilReason {

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
    ///         The value is a Uniform Resource Identifier <b>(URI)</b>.<br></br>
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
    //[XmlAttribute("nilReason", DataType="anyURI", Form = XmlSchemaForm.Qualified)] // TODO: Check if DataType should be specified here - Check also the corresponding gcoBase.xsd and also an XML example
    //[JsonProperty("nilReason")] // TODO: Should Attributes be attached on the Properties?
    public string NilReason {
      get;
      set;
    }

    /// <summary>
    /// Gets a <see cref="ReadOnlyDictionary{NullEnumeration, String}"/> where each 
    /// <see cref="NullEnumeration"/> key maps to an explanatory string used by the 
    /// <see cref="NilReason"/> property to describe missing or voided metadata values in XML files.
    /// </summary>
    /// <completionlist cref="NullEnumeration"/>
    /// <remarks>
    /// Implementations must provide all the <see cref="string"/> representations
    /// of the <see cref="NullEnumeration"/> enumeration values.
    /// </remarks>
    public static readonly ReadOnlyDictionary<NullEnumeration, string> NilReasons = CreateNilReasonsDictionary();

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
    ) {

      if (nullEnum != NullEnumeration.Other) {
        return nullEnum.GetXmlEnumAttribute();
      }
      else {
        string other = $"{nullEnum.GetXmlEnumAttribute()}:{otherAdditionalReason}";

        Regex regex = new("other:\\w{2,}"); // RESOURCE: Should this be a resource?
        Match match = regex.Match(other);

        if (!match.Success) {
          throw new Exception("The reason string provided is invalid."); // RESOURCE
        }

        return other;
      }

    }

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
    public static string GetNilReason(string uriString) {
      bool isValid = Uri.TryCreate(uriString, UriKind.RelativeOrAbsolute, out _);

      return !isValid ? throw new Exception("Invalid NilReason URI provided.") : uriString; // RESOURCE
    }

    #region Private Procedures

    /// <summary>
    /// Creates a read-only dictionary that maps each <see cref="NullEnumeration"/> value 
    /// to its corresponding XML enum attribute for use in XML serialization and deserialization.
    /// </summary>
    /// <returns>
    /// A <see cref="ReadOnlyDictionary{NullEnumeration, String}"/> whose keys 
    /// are the values of the <see cref="NullEnumeration"/> and whose values 
    /// are the XML enum attributes.
    /// </returns>
    private static ReadOnlyDictionary<NullEnumeration, string> CreateNilReasonsDictionary() {
      return new ReadOnlyDictionary<NullEnumeration, string>(new Dictionary<NullEnumeration, string>(6) {
        { NullEnumeration.Inapplicable, NullEnumeration.Inapplicable.GetXmlEnumAttribute() },
        { NullEnumeration.Missing, NullEnumeration.Missing.GetXmlEnumAttribute() },
        { NullEnumeration.Template, NullEnumeration.Template.GetXmlEnumAttribute() },
        { NullEnumeration.Unknown, NullEnumeration.Unknown.GetXmlEnumAttribute() },
        { NullEnumeration.Withheld, NullEnumeration.Withheld.GetXmlEnumAttribute() },
        { NullEnumeration.Other, NullEnumeration.Other.GetXmlEnumAttribute() }
      });
    }

    #endregion

  }

}
