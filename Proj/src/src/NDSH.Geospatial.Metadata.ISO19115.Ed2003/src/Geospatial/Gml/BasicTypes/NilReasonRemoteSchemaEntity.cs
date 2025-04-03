
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 31/12/2022, @gisvlasta
// History           : 16/03/2025, @gisvlasta - Added IsoTypeAttribute, updated code, and documentation.
//                   : 20/03/2025, @gisvlasta - Changed class from abstract to concrete.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
//                     /2005/gco/gcoBase.xsd
//                     /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <simpleType name="NilReasonType">
//  <union memberTypes="gml:NullEnumeration anyURI"/>
// </simpleType>
// 
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
//
// <attribute name="remoteSchema" type="anyURI">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </attribute>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.BasicTypes {

  /// <summary>
  /// The <see cref="NilReasonRemoteSchemaEntity"/> class extends the <see cref="NilReasonEntity"/>
  /// and implements the <see cref="IRemoteSchema"/> interface, providing both a standardized way
  /// to document missing or <see langword="null"/> values and a deprecated reference
  /// to an external schema. This class ensures proper handling of nil reasons based on
  /// the <c>gml:NilReasonType</c> definition while also maintaining compliance with
  /// GML-based schema references.
  /// </summary>
  /// <remarks>
  /// Use this class instead of the <see cref="NilReasonEntity"/> for backwards compatibility
  /// with objects that implement the deprecated <see cref="IRemoteSchema"/> interface.
  /// </remarks>
  // TODO: IMPORTANT - What about [XmlTypeAttribute here???
  [IsoType("NilReasonType", IsoType = IsoTypes.SimpleType)]
  public class NilReasonRemoteSchemaEntity : NilReasonEntity, IRemoteSchema {

    #region IRemoteSchema Interface

    private string? _remoteSchema;

    /// <summary>
    /// Gets/Sets the URI reference to an external remote schema.
    /// This property is deprecated and should be used only for backward compatibility.
    /// </summary>
    /// <remarks>
    /// This is an obsolete property. (Marked deprecated in gml/gmlBase.xsd)
    /// </remarks>
    //[XmlAttribute("remoteSchema", DataType = "anyURI", Form = XmlSchemaForm.Qualified)]
    //[JsonProperty("remoteSchema")]
    // TODO: This is marked as obsolete because of the 'deprecated' xsd annotation. What should be done with XmlAttribute and JsonProperty ???
    [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd")]
    public string? RemoteSchema {
      get => _remoteSchema;
      set => SetProperty(ref _remoteSchema, value);
    }

    #endregion

  }

}
