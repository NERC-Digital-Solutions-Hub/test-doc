
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 30/01/2023, @gisvlasta
// History           : 07/03/2025, @gisvlasta
//                       Updated property nullability, setters, and removed the use of IObjectReference
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/xlink/xlinks.xsd
//                     /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <attribute name="href" type="anyURI"/>
// <attribute name="role" type="anyURI"/>
// <attribute name="arcrole" type="anyURI"/>
// <attribute name="title" type="string"/>
// <attribute name="show">
//   <simpleType>
//     <restriction base="string">
//       <enumeration value="new"/>
//       <enumeration value="replace"/>
//       <enumeration value="embed"/>
//       <enumeration value="other"/>
//       <enumeration value="none"/>
//     </restriction>
//   </simpleType>
// </attribute>
// <attribute name="actuate">
//   <simpleType>
//     <restriction base="string">
//       <enumeration value="onLoad"/>
//       <enumeration value="onRequest"/>
//       <enumeration value="other"/>
//       <enumeration value="none"/>
//     </restriction>
//   </simpleType>
// </attribute>
// <attributeGroup name="simpleLink">
//   <attribute name="type" type="string" fixed="simple" form="qualified"/>
//   <attribute ref="xlink:href" use="optional"/>
//   <attribute ref="xlink:role" use="optional"/>
//   <attribute ref="xlink:arcrole" use="optional"/>
//   <attribute ref="xlink:title" use="optional"/>
//   <attribute ref="xlink:show" use="optional"/>
//   <attribute ref="xlink:actuate" use="optional"/>
// </attributeGroup>
// 
// [
//   XmlAttribute(AttributeName = "type",
//   DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")
// ]
// 
// <attribute name="remoteSchema" type="anyURI">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </attribute>
// 
// <attributeGroup name="AssociationAttributeGroup">
//   <annotation>
//     <documentation>
//       XLink components are the standard method to support hypertext referencing in XML.
//       An XML Schema attribute group, gml:AssociationAttributeGroup, is provided to support the use of
//       Xlinks as the method for indicating the value of a property by reference in a uniform manner in GML.
//     </documentation>
//   </annotation>
//   <attributeGroup ref="xlink:simpleLink"/>
//   <attribute name="nilReason" type="gml:NilReasonType"/>
//   <attribute ref="gml:remoteSchema"/>
// </attributeGroup>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Resources;
using NDSH.Xml.XLink;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  /// <summary>
  /// Represents a generalized association in GML, providing an XLink-based mechanism for referencing
  /// external or internal resources within geospatial metadata. This abstract class implements the
  /// GML <c>AssociationAttributeGroup</c> pattern from <c>gmlBase.xsd</c>, enabling a standard approach
  /// for linking GML objects and facilitating interoperability with ISO 19115:2003 metadata structures.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     In practice, GML uses “association” elements or properties to capture relationships between
  ///     metadata objects or geospatial features—often expressed through the <c>xlink</c> attributes
  ///     (<c>href</c>, <c>role</c>, <c>arcrole</c>, <c>title</c>, <c>show</c>, and <c>actuate</c>).
  ///     By abstracting these attributes into a single class, <see cref="AssociationEntity"/> enables a
  ///     consistent mechanism for referencing remote or local resources.
  ///   </para>
  ///   <para>
  ///     The class also supports a <c>nilReason</c> attribute (based on GML’s <c>NilReasonType</c>) to
  ///     indicate missing or inapplicable data, reflecting the requirements of ISO 19115:2003 for
  ///     managing incomplete or unknown metadata values. Additionally, a <c>remoteSchema</c> attribute
  ///     is provided to reference an external schema, though it is marked as deprecated in GML.
  ///   </para>
  ///   <para>
  ///     In ISO 19115 applications, leveraging this association pattern can help decompose or link
  ///     metadata elements effectively, fostering modular metadata design and allowing distributed
  ///     systems to reference shared resources rather than duplicating content.
  ///   </para>
  /// </remarks>
  [IsoType("AssociationAttributeGroup", IsoType = IsoTypes.AttributeGroup)]
  //[XmlType("Association", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("Association")]
  public class AssociationEntity : ObservableDbEntity, IAssociation {

    #region Public Properties

    /// <summary>
    /// Gets the <see cref="ReadOnlyDictionary{ActuateBehaviour, String}"/> of valid values
    /// used for the <b>Actuate attribute</b> (<see cref="Actuate"/> property),
    /// which determines how a link is triggered.
    /// </summary>
    public static ReadOnlyDictionary<ActuateBehaviour, string> ActuateBehaviours => IActuate.ActuateBehaviours;

    /// <summary>
    /// Gets the <see cref="ReadOnlyDictionary{ShowBehaviour, String}"/> of valid values
    /// used for the <b>Show attribute</b> (<see cref="Show"/> property),
    /// which determines how a linked resource should be displayed.
    /// </summary>
    public static ReadOnlyDictionary<ShowBehaviour, string> ShowBehaviours => IShow.ShowBehaviours;

    /// <summary>
    /// Gets a <see cref="ReadOnlyDictionary{NillReasonEnumeration, String}"/> where each 
    /// <see cref="NilReasonEnumeration"/> key maps to an explanatory string used by the 
    /// <see cref="NilReason"/> property to describe missing or voided metadata values in XML files.
    /// </summary>
    public static ReadOnlyDictionary<NilReasonEnumeration, string> NilReasons => INilReason.NilReasons;

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
    ///         NilReason = INilReason.GetNilReason(NilReasonEnumeration.Missing);
    ///         NilReason = INilReason.GetNilReason(NilReasonEnumeration.Other, "Example reason given here");
    ///       </code>
    ///     </example>
    ///   </para>
    /// </summary>
    /// <param name="nilReasonEnum">The <see cref="NilReasonEnumeration"/> value.</param>
    /// <param name="otherAdditionalReason">
    /// Allows a <see cref="string"/> value providing a brief reason to be appended after the
    /// <see cref="NilReasonEnumeration.Other"/>. The argument's value will be used only if
    /// the enumerated value provided is <see cref="NilReasonEnumeration"/>; in all other cases
    /// the argument's value will be omitted.
    /// </param>
    /// <returns>A properly formatted <see cref="string"/> with the NilReason.</returns>
    public static string GetNilReason(
      NilReasonEnumeration nilReasonEnum, string otherAdditionalReason = "Reason not in list" // RESOURCE
    ) => INilReason.GetNilReason(nilReasonEnum, otherAdditionalReason);

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

    #region IAssociation Interface

    /// <summary>
    /// Gets/Sets the type of the reference, which is always <c>&quot;simple&quot;</c>.
    /// </summary>
    //[XmlAttribute(
    //  "type", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink"
    //)]
    [JsonProperty("type")]
    public string Type => "simple"; // RESOURCE

    private string? _href;

    /// <summary>
    /// Gets/Sets a reference to a remote resource via a URI.
    /// </summary>
    //[XmlAttribute(
    //  "href", DataType = "anyURI", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink"
    //)]
    [JsonProperty("href")]
    public string? Href {
      get => _href;
      set => SetProperty(ref _href, value);
    }

    private string? _role;

    /// <summary>
    /// Gets/Sets the role of the link, specifying its function within an association.
    /// </summary>
    //[XmlAttribute(
    //  "role", DataType = "anyURI", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink"
    //)]
    [JsonProperty("role")]
    public string? Role {
      get => _role;
      set => SetProperty(ref _role, value);
    }

    private string? _arcRole;

    /// <summary>
    /// Gets/Sets a more detailed function of the link,
    /// similar to the value of <see cref="Role"/> but more specialized.
    /// </summary>
    //[XmlAttribute(
    //  "arcrole", DataType = "anyURI", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink"
    //)]
    [JsonProperty("arcrole")]
    public string? ArcRole {
      get => _arcRole;
      set => SetProperty(ref _arcRole, value);
    }

    private string? _title;

    /// <summary>
    /// Gets/Sets the descriptive title of the linked resource.
    /// </summary>
    //[XmlAttribute(
    //  "title", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink"
    //)]
    [JsonProperty("title")]
    public string? Title {
      get => _title;
      set => SetProperty(ref _title, value);
    }

    private string? _show;

    /// <summary>
    ///   <para>
    ///     Gets/Sets the Show attribute which is used to communicate the desired presentation
    ///     of the ending resource on traversal from the starting resource.
    ///   </para>
    ///   <para>
    ///     Use the <see cref="ShowBehaviours"/> static property to access all valid string values
    ///     used in the <see cref="Show"/> property.
    ///     Select a valid value using as a key an <see cref="ShowBehaviour"/> enumerated value.
    ///   </para>
    ///   <para>
    ///   <b>Example:</b>
    ///   <example>
    ///     <code>
    ///       <see cref="Show"/> = <see cref="ShowBehaviours"/>[<see cref="ShowBehaviour.None"/>]
    ///     </code>
    ///   </example>
    ///   </para>
    /// </summary>
    /// <completionlist cref="ShowBehaviour"/>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The exception is thrown when the property is attempted to be set to a <see cref="string"/>
    /// value that is not in the list of the accepted values.
    /// </exception>
    //[XmlAttribute(
    //  "show", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink"
    //)]
    [JsonProperty("show")]
    public string? Show {
      get => _show;
      set {
        if (_show == value) {
          return;
        }
        if (_show == null || !_show.Equals(value)) {
          if (!IShow.ShowBehaviours.Values.Contains(value)) {
            throw new ArgumentOutOfRangeException(nameof(value), value, Exceptions.StringNotMemberOfEnumeration);
          }
          _show = value;
          OnPropertyChanged();
        }
      }
    }

    private string? _actuate;

    /// <summary>
    ///   <para>
    ///     Gets/Sets the Actuate attribute which is used to communicate the desired timing
    ///     of traversal from the starting resource to the ending resource.
    ///   </para>
    ///   <para>
    ///     Use the <see cref="ActuateBehaviours"/> static property to access all valid string values
    ///     used in the <see cref="Actuate"/> property.
    ///     Select a valid value using as a key an <see cref="ActuateBehaviour"/> enumerated value.
    ///   </para>
    ///   <para>
    ///   <b>Example:</b>
    ///   <example>
    ///     <code>
    ///       <see cref="Actuate"/> = <see cref="ActuateBehaviours"/>[<see cref="ActuateBehaviour.None"/>]
    ///     </code>
    ///   </example>
    ///   </para>
    /// </summary>
    /// <completionlist cref="ActuateBehaviour"/>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The exception is thrown when the property is attempted to be set to a <see cref="string"/>
    /// value that is not in the list of the accepted values.
    /// </exception>
    //[XmlAttribute(
    //  "actuate", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink"
    //)]
    [JsonProperty("actuate")]
    public string? Actuate {
      get => _actuate;
      set {
        if (_actuate == value) {
          return;
        }
        if (_actuate == null || !_actuate.Equals(value)) {
          if (!IActuate.ActuateBehaviours.Values.Contains(value)) {
            throw new ArgumentOutOfRangeException(nameof(value), value, Exceptions.StringNotMemberOfEnumeration);
          }
          _actuate = value;
          OnPropertyChanged();
        }
      }
    }

    private string? _nilReason;

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
    ///         values of the <see cref="NilReasonEnumeration"/>,
    ///         except the value <see cref="NilReasonEnumeration.Other"/>
    ///       </item>
    ///       <item>
    ///         The value is a combination of the low case <see cref="string"/> representation of the
    ///         value <see cref="NilReasonEnumeration.Other"/> followed by <b>"<c>:</c>"</b>
    ///         and then by a string providing a brief explanation,
    ///         where text is a string of two or more characters with no included spaces.
    ///         <br></br>
    ///         <b>Example:</b><br></br>
    ///         <example>
    ///         <b><c>other:brief explanation goes here</c></b>
    ///         </example>
    ///         <br></br>
    ///         The entire <see cref="string"/> must be valid against the following regular expression:
    ///         <br></br>
    ///         <b><c>other:\w{2,}</c></b>
    ///       </item>
    ///       <item>
    ///         The value is a Uniform Resource Identifier <b>(URI)</b>.
    ///         A particular community may choose to assign more detailed semantics to the
    ///         standard values provided by the <see cref="NilReasonEnumeration"/>.
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
    ///         NilReason = INilReason.GetNilReason(NilReasonEnumeration.Missing);
    ///         NilReason = INilReason.GetNilReason(NilReasonEnumeration.Other, "Example reason give here");
    ///         NilReason = INilReason.GetNilReason("http://www.example.com/a-detailed-explanation-for-nilreason/";
    ///       </code>
    ///     </example>
    ///   </para>
    /// </summary>
    /// <completionlist cref="NilReasonEnumeration"/>
    /// <remarks>
    /// The <b>default</b> <see cref="NilReason"/> value is: <c>&quot;unknown&quot;</c>,
    /// the XML enum value of the <see cref="NilReasonEnumeration.Unknown"/>.
    /// </remarks>
    //[XmlAttribute("nilReason", DataType = "anyURI", Form = XmlSchemaForm.Qualified)] // TODO: Check if DataType should be specified here - Check also the corresponding gcoBase.xsd and also an XML example
    [JsonProperty("nilReason")]
    public string? NilReason { // Should the namespace be specified here? gco:nilReason / gml:NilReasonType
      get => _nilReason;
      set => SetProperty(ref _nilReason, value);
    }

    private string? _remoteSchema;

    /// <summary>
    /// Gets/Sets a reference to an external remote schema.
    /// </summary>
    /// <remarks>
    /// This is an obsolete property. (Marked deprecated in gml/gmlBase.xsd)
    /// </remarks>
    [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd")]
    //[XmlAttribute("remoteSchema", DataType = "anyURI", Form = XmlSchemaForm.Qualified)]
    //[XmlIgnore]
    [JsonProperty("remoteSchema")]
    [JsonIgnore]
    public string? RemoteSchema {
      get => _remoteSchema;
      set => SetProperty(ref _remoteSchema, value);
    }

    #endregion

  }

}
