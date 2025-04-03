
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
//                     /2005/gco/gcoBase.xsd
//                     /2005/gml/gmlBase.xsd
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
//
// <attribute name="remoteSchema" type="anyURI">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </attribute>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Base {

  /// <summary>
  /// The NilReasonRemoteSchemaModel class extends the <see cref="NilReasonModel"/>
  /// and implements the IRemoteSchema interface, providing both a standardized way
  /// to document missing or <see langword="null"/> values and a deprecated reference
  /// to an external schema. This class ensures proper handling of nil reasons based on
  /// the <c>gml:NilReasonType</c> definition while also maintaining compliance with
  /// GML-based schema references.
  /// </summary>
  [Serializable]
  // TODO: IMPORTANT - What about [XmlTypeAttribute here???
  public abstract class NilReasonRemoteSchemaModel : NilReasonModel, IRemoteSchema {

    #region IRemoteSchema Interface

    private string? _remoteSchema;

    /// <summary>
    /// Gets/Sets the URI reference to an external remote schema.
    /// This property is deprecated and should be used only for backward compatibility.
    /// </summary>
    //[XmlAttribute("remoteSchema", DataType = "anyURI", Form = XmlSchemaForm.Qualified)]
    //[JsonProperty("remoteSchema")]
    // TODO: This is marked as obsolete because of the 'deprecated' xsd annotation. What should be done with XmlAttribute and JsonProperty ???
    [Obsolete("This method is deprecated according to the GML schema.")]
    public string? RemoteSchema {
      get => _remoteSchema;
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || !_remoteSchema.Equals(value)) {
          _remoteSchema = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
