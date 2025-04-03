
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/01/2023, @gisvlasta
// History           : 15/03/2025, @gisvlasta - Added non nullable CodeSpace property, added URI validation,
//                                               added IsoTypeAttribute, documentation, and header.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="CodeWithAuthorityType">
//   <annotation>
//     <documentation>
//       gml:CodeWithAuthorityType requires that the codeSpace attribute is provided in an instance.
//     </documentation>
//   </annotation>
//   <simpleContent>
//     <restriction base="gml:CodeType">
//       <attribute name="codeSpace" type="anyURI" use="required"/>
//     </restriction>
//   </simpleContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.BasicTypes {

  // WARNING: Rename from CodeWithAuthorityType to CodeWithAuthority.

  /// <summary>
  /// The <see cref="CodeWithAuthorityType"/> is a generalized type to be used for a term, keyword or name.
  /// It adds a XML attribute codeSpace to a term, where the value of the codeSpace
  /// attribute (if present) shall indicate a dictionary, thesaurus, classification scheme,
  /// authority, or pattern for the term.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     The <see cref="CodeWithAuthorityType"/> requires that the <see cref="CodeSpace">CodeSpace</see> property
  ///     (<c>codeSpace</c> attribute) is provided in an instance.
  ///   </para>
  ///   <para>Maps to: <c>CodeType</c> ( /2005/gml/gmlBase.xsd )</para>
  /// </remarks>
  [IsoType("CodeWithAuthorityType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("CodeWithAuthorityType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CodeWithAuthorityType")]
  public class CodeWithAuthorityType : CodeType {

    #region Public Properties

    private string _codeSpace = string.Empty;

    /// <summary>
    /// Gets/Sets the URI reference to the code space authority.
    /// This property is required and must be a valid URI,
    /// ensuring compliance with metadata schema definitions.
    /// </summary>
    //[XmlAttribute(AttributeName = "codeSpace", DataType = "anyURI")]
    // WARNING: This property performs the validation in the setter; however, it may need to use a validation library. (Attribute or Fluent based)
    // WARNING: What if this is a UriReference type?
    [JsonProperty("codeSpace")]
    public new string CodeSpace {
      get => _codeSpace;
      set {
        if (!Uri.IsWellFormedUriString(value, UriKind.RelativeOrAbsolute)) {
          throw new UriFormatException($"The provided '{nameof(CodeSpace)}' value is not a valid URI."); // RESOURCE
        }
        SetProperty(ref _codeSpace, value);
      }
    }

    #endregion

  }

}
