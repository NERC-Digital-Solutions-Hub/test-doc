
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 08/01/2023, 03:22, @gisvlasta.
// Updated by        : 12/01/2023, 20:15, @gisvlasta.
//                     13/01/2023, 15:05, @gisvlasta.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gmx/extendedTypes.xsd
// --------------------------------------------------------------------------------
// <xs:complexType name="Anchor_Type">
//   <xs:simpleContent>
//     <xs:extension base="xs:string">
//       <xs:attributeGroup ref="xlink:simpleLink"/>
//     </xs:extension>
//   </xs:simpleContent>
// </xs:complexType>
// <xs:element name="Anchor" type="gmx:Anchor_Type" substitutionGroup="gco:CharacterString"/>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Resources;
using NDSH.Xml.XLink;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Extended {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Anchor", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("Anchor", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("Anchor")]
  public class Anchor_Type : ObservableModel, ISimpleLink, IValue {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Anchor_Type"/>.
    /// </summary>
    public Anchor_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx"); // TODO: DANGER !!! - Make sure that qualifed anchors are needed here.

      _type = default; // "simple"; // TODO: IMPORTANT !!! - Should Type be always "simple", or something else? The NERC XML documents do not have a type with a value "simple".

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets the dictionary of all the valid strings used in the <see cref="Actuate"/> property.
    /// </summary>
    /// <remarks>
    /// Implementations need to provide all the <see cref="string"/> representations
    /// of the <see cref="ActuateBehaviour"/> enumeration values.
    /// </remarks>
    // TODO: Find out how to document generic types.
    public static ReadOnlyDictionary<ActuateBehaviour, string> ActuateBehaviours {
      get {
        return IObjectReference.ActuateBehaviours;
      }
    }

    /// <summary>
    /// Gets the dictionary of all the valid strings used in the <see cref="Show"/> property.
    /// </summary>
    /// <remarks>
    /// Implementations need to provide all the <see cref="string"/> representations
    /// of the <see cref="ShowBehaviour"/> enumeration values.
    /// </remarks>
    // TODO: Find out how to document generic types.
    public static ReadOnlyDictionary<ShowBehaviour, string> ShowBehaviours {
      get {
        return IObjectReference.ShowBehaviours;
      }
    }

    #endregion

    #region ISimpleLink

    private string _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("type", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("type")]
    public string Type {
      get {
        return _type;
      }
      set {
        if (_type == value) {
          return;
        }
        if (_type == null || _type.Equals(value) != true) {
          _type = value;
          OnPropertyChanged();
        }
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

    private string _arcrole;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("arcrole", DataType = "anyURI", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("arcrole")]
    public string ArcRole {
      get {
        return _arcrole;
      }
      set {
        if (_arcrole == value) {
          return;
        }
        if (_arcrole == null || _arcrole.Equals(value) != true) {
          _arcrole = value;
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
            throw new Exception(Exceptions.StringNotMemberOfEnumeration); // TODO: Possible Custom Exception??? No
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
    [XmlAttribute("actuate", DataType = "actuate", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
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
            throw new Exception(Exceptions.StringNotMemberOfEnumeration); // TODO: Possible custom exception??
          }
          _actuate = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region IValue Interface

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText(DataType = "string")]
    [JsonProperty("Value")]
    public string Value {
      get {
        return _value;
      }
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || _value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
