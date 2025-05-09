﻿
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 14:15, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
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

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Thin.Properties;
using NDSH.Xml.XLink;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Base {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Association", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("Association")]
  public abstract class Association : Model, IAssociation {

    #region Public Properties

    /// <summary>
    /// Gets the dictionary of all the valid strings used in the <see cref="Actuate"/> property.
    /// </summary>
    // TODO: Find out how to document generic types.
    public static ReadOnlyDictionary<ActuateBehaviour, string> ActuateBehaviours {
      get {
        return IObjectReference.ActuateBehaviours;
      }
    }

    /// <summary>
    /// Gets the dictionary of all the valid strings used in the <see cref="Show"/> property.
    /// </summary>
    // TODO: Find out how to document generic types.
    public static ReadOnlyDictionary<ShowBehaviour, string> ShowBehaviours {
      get {
        return IObjectReference.ShowBehaviours;
      }
    }

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

    #region IAssociation Interface

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("type", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("type")]
    public string Type {
      get {
        return "simple";
      }
    }

    private string _href;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("href", DataType = "anyURI", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("href")]
    public string Href {
      get {
        return _href;
      }
      set {
        if (_href == value) {
          return;
        }
        if (_href == null || _href.Equals(value) != true) {
          _href = value;
          OnPropertyChanged();
        }
      }
    }

    private string _role;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("role", DataType = "anyURI", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("role")]
    public string Role {
      get {
        return _role;
      }
      set {
        if (_role == value) {
          return;
        }
        if (_role == null || _role.Equals(value) != true) {
          _role = value;
          OnPropertyChanged();
        }
      }
    }

    private string _arcRole;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("arcrole", DataType = "anyURI", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("arcrole")]
    public string ArcRole {
      get {
        return _arcRole;
      }
      set {
        if (_arcRole == value) {
          return;
        }
        if (_arcRole == null || _arcRole.Equals(value) != true) {
          _arcRole = value;
          OnPropertyChanged();
        }
      }
    }

    private string _title;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("title", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("title")]
    public string Title {
      get {
        return _title;
      }
      set {
        if (_title == value) {
          return;
        }
        if (_title == null || _title.Equals(value) != true) {
          _title = value;
          OnPropertyChanged();
        }
      }
    }

    private string _show;

    /// <summary>
    ///   <para>
    ///     The Show attribute is used to communicate the desired presentation
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
    /// <exception cref="Exception">
    /// The exception is thrown when the property is attempted to be set to a <see cref="string"/>
    /// value that is not in the list of the accepted values.
    /// </exception>
    [XmlAttribute("show", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("show")]
    public string Show {
      get {
        return _show;
      }
      set {
        if (_show == value) {
          return;
        }
        if (_show == null || _show.Equals(value) != true) {
          if (!IShow.ShowBehaviours.Values.ToList().Contains(value)) {
            throw new Exception(Resources.StringNotMemberOfEnumeration);
          }
          _show = value;
          OnPropertyChanged();
        }
      }
    }

    private string _actuate;

    /// <summary>
    ///   <para>
    ///     The Actuate attribute is used to communicate the desired timing of traversal
    ///     from the starting resource to the ending resource.
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
    /// <exception cref="Exception">
    /// The exception is thrown when the property is attempted to be set to a <see cref="string"/>
    /// value that is not in the list of the accepted values.
    /// </exception>
    [XmlAttribute("actuate", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("actuate")]
    public string Actuate {
      get {
        return _actuate;
      }
      set {
        if (_actuate == value) {
          return;
        }
        if (_actuate == null || _actuate.Equals(value) != true) {
          if (!IActuate.ActuateBehaviours.Values.ToList().Contains(value)) {
            throw new Exception(Resources.StringNotMemberOfEnumeration);
          }
          _actuate = value;
          OnPropertyChanged();
        }
      }
    }

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
    [XmlAttribute("nilReason", DataType = "anyURI", Form = XmlSchemaForm.Qualified)]
    [JsonProperty("nilReason")]
    public string NilReason { // Should the namespace be specified here? gco:nilReason / gml:NilReasonType
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

    private string _remoteSchema;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("remoteSchema", DataType = "anyURI", Form = XmlSchemaForm.Qualified)]
    [XmlIgnore]
    [JsonProperty("remoteSchema")]
    [JsonIgnore]
    [Obsolete] // TODO: This is marked as obsolete because of the 'deprecated' xsd annotation. What should be done with XmlAttribute and JsonProperty ???
    public string RemoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
