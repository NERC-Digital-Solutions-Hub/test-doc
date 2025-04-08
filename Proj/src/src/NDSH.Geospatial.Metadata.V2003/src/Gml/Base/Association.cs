
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 30/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// --------------------------------------------------------------------------------
// <attributeGroup name="AssociationAttributeGroup">
//   <attributeGroup ref="xlink:simpleLink"/>
//   <attribute name="nilReason" type="gml:NilReasonType"/>
//   <attribute ref="gml:remoteSchema"/>
// </attributeGroup>
// <attribute name="remoteSchema" type="anyURI">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </attribute>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using NDSH.Resources;
using NDSH.Xml.XLink;
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Base {

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
  ///     By abstracting these attributes into a single class, <see cref="Association"/> enables a
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
  [Serializable]
  [XmlType("Association", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("Association")]
  public abstract class Association : ObservableModel, IAssociation {

    #region Public Properties

    /// <summary>
    /// Gets the <see cref="ReadOnlyDictionary{ActuateBehaviour, String}"/> of valid values
    /// used for the <b>Actuate attribute</b> (<see cref="Actuate"/> property),
    /// which determines how a link is triggered.
    /// </summary>
    public static ReadOnlyDictionary<ActuateBehaviour, string> ActuateBehaviours => IObjectReference.ActuateBehaviours;

    /// <summary>
    /// Gets the <see cref="ReadOnlyDictionary{ShowBehaviour, String}"/> of valid values
    /// used for the <b>Show attribute</b> (<see cref="Show"/> property),
    /// which determines how a linked resource should be displayed.
    /// </summary>
    public static ReadOnlyDictionary<ShowBehaviour, string> ShowBehaviours => IObjectReference.ShowBehaviours;

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

    #region IAssociation Interface

    /// <summary>
    /// Gets/Sets the type of the reference, which is always <c>&quot;simple&quot;</c>.
    /// </summary>
    [XmlAttribute(
      "type", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink"
    )]
    [JsonProperty("type")]
    public string Type => "simple"; // RESOURCE

    private string _href; // WARNING: What about the null situation?

    /// <summary>
    /// Gets/Sets a reference to a remote resource via a URI.
    /// </summary>
    [XmlAttribute(
      "href", DataType = "anyURI", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink"
    )]
    [JsonProperty("href")]
    public string Href {
      get => _href;
      set {
        if (_href == value) {
          return;
        }
        if (_href == null || !_href.Equals(value)) {
          _href = value;
          OnPropertyChanged();
        }
      }
    }

    private string _role; // WARNING: What about the null situation?

    /// <summary>
    /// Gets/Sets the role of the link, specifying its function within an association.
    /// </summary>
    [XmlAttribute(
      "role", DataType = "anyURI", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink"
    )]
    [JsonProperty("role")]
    public string Role {
      get => _role;
      set {
        if (_role == value) {
          return;
        }
        if (_role == null || !_role.Equals(value)) {
          _role = value;
          OnPropertyChanged();
        }
      }
    }

    private string _arcRole; // WARNING: What about the null situation?

    /// <summary>
    /// Gets/Sets a more detailed function of the link,
    /// similar to the value of <see cref="Role"/> but more specialized.
    /// </summary>
    [XmlAttribute(
      "arcrole", DataType = "anyURI", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink"
    )]
    [JsonProperty("arcrole")]
    public string ArcRole {
      get => _arcRole;
      set {
        if (_arcRole == value) {
          return;
        }
        if (_arcRole == null || !_arcRole.Equals(value)) {
          _arcRole = value;
          OnPropertyChanged();
        }
      }
    }

    private string _title; // WARNING: What about the null situation?

    /// <summary>
    /// Gets/Sets the descriptive title of the linked resource.
    /// </summary>
    [XmlAttribute(
      "title", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink"
    )]
    [JsonProperty("title")]
    public string Title {
      get => _title;
      set {
        if (_title == value) {
          return;
        }
        if (_title == null || !_title.Equals(value)) {
          _title = value;
          OnPropertyChanged();
        }
      }
    }

    private string _show; // WARNING: What about the null situation?

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
    [XmlAttribute("show", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("show")]
    public string Show {
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

    private string _actuate; // WARNING: What about the null situation?

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
    [XmlAttribute(
      "actuate", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink"
    )]
    [JsonProperty("actuate")]
    public string Actuate {
      get => _actuate;
      set {
        if (_actuate == value) {
          return;
        }
        if (_actuate == null || !_actuate.Equals(value)) {
          if (!IActuate.ActuateBehaviours.Values.ToList().Contains(value)) {
            throw new ArgumentOutOfRangeException(nameof(value), value, Exceptions.StringNotMemberOfEnumeration);
          }
          _actuate = value;
          OnPropertyChanged();
        }
      }
    }

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

    private string? _remoteSchema;

    /// <summary>
    /// Gets/Sets a reference to an external remote schema.
    /// </summary>
    /// <remarks>
    /// This is an obsolete property. (Marked deprecated in gml/gmlBase.xsd)
    /// </remarks>
    [Obsolete("RemoteSchema is marked as deprecated in gml/gmlBase.xsd")]
    [XmlAttribute("remoteSchema", DataType = "anyURI", Form = XmlSchemaForm.Qualified)]
    [XmlIgnore]
    [JsonProperty("remoteSchema")]
    [JsonIgnore]
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
