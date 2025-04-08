#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 08/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/extendedTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="Anchor_Type">
//   <xs:simpleContent>
//     <xs:extension base="xs:string">
//       <xs:attributeGroup ref="xlink:simpleLink"/>
//     </xs:extension>
//   </xs:simpleContent>
// </xs:complexType>
// <xs:element name="Anchor" type="gmx:Anchor_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="Anchor_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:Anchor"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Hashing;
using NDSH.Resources;
using NDSH.Xml.XLink;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Extended {

  [Serializable]
  //[XmlType("Anchor", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("Anchor", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("Anchor")]
  public class Anchor_Type : CharacterString, ISimpleLink, IComparable<Anchor_Type>, IEquatable<Anchor_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Anchor_Type"/>.
    /// </summary>
    public Anchor_Type() {
      _type = default; // "simple"; // TODO: IMPORTANT !!! - Should Type be always "simple", or something else? The NERC XML documents do not have a type with a value "simple".
    }

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
    public static ReadOnlyDictionary<ActuateBehaviour, string> ActuateBehaviours => IActuate.ActuateBehaviours;

    /// <summary>
    /// Gets the dictionary of all the valid strings used in the <see cref="Show"/> property.
    /// </summary>
    /// <remarks>
    /// Implementations need to provide all the <see cref="string"/> representations
    /// of the <see cref="ShowBehaviour"/> enumeration values.
    /// </remarks>
    // TODO: Find out how to document generic types.
    public static ReadOnlyDictionary<ShowBehaviour, string> ShowBehaviours => IShow.ShowBehaviours;

    #endregion

    #region ISimpleLink

    private string _type;

    //[XmlAttribute("type", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("type")]
    public string Type {
      get => _type;
      set => SetProperty(ref _type, value);
    }

    private string _href;

    //[XmlAttribute("href", DataType = "anyURI", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("href")]
    public string Href {
      get => _href;
      set => SetProperty(ref _href, value);
    }

    private string _role;

    //[XmlAttribute("role", DataType = "anyURI", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("role")]
    public string Role {
      get => _role;
      set => SetProperty(ref _role, value);
    }

    private string _arcrole;

    //[XmlAttribute("arcrole", DataType = "anyURI", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("arcrole")]
    public string ArcRole {
      get => _arcrole;
      set => SetProperty(ref _arcrole, value);
    }

    private string _title;

    //[XmlAttribute("title", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("title")]
    public string Title {
      get => _title;
      set => SetProperty(ref _title, value);
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
    //[XmlAttribute("show", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("show")]
    public string Show {
      get => _show;
      // TODO: SetProperty
      set {
        if (_show == value) {
          return;
        }
        if (_show == null || !_show.Equals(value)) {
          if (_show != null && !IShow.ShowBehaviours.Values.ToList().Contains(value)) {
            throw new Exception(Exceptions.StringNotMemberOfEnumeration); // TODO: Possible Custom Exception???
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
    //[XmlAttribute("actuate", DataType = "actuate", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("actuate")]
    public string Actuate {
      get => _actuate;
      // TODO: SetProperty
      set {
        if (_actuate == value) {
          return;
        }
        if (_actuate == null || !_actuate.Equals(value)) {
          if (_actuate != null && !IActuate.ActuateBehaviours.Values.ToList().Contains(value)) {
            throw new Exception(Exceptions.StringNotMemberOfEnumeration); // TODO: Possible custom exception??
          }
          _actuate = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="Anchor_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="Anchor_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(Anchor_Type? other) {

      int result;

      return
        (other is null) ? 1 :
        (result = base.CompareTo(other)) != 0 ? result :
        (result = Type?.CompareTo(other.Type) ?? 1) != 0 ? result :
        (result = Href?.CompareTo(other.Href) ?? 1) != 0 ? result :
        (result = Role?.CompareTo(other.Role) ?? 1) != 0 ? result :
        (result = ArcRole?.CompareTo(other.ArcRole) ?? 1) != 0 ? result :
        (result = Title?.CompareTo(other.Title) ?? 1) != 0 ? result :
        (result = Show?.CompareTo(other.Show) ?? 1) != 0 ? result :
        (result = Actuate?.CompareTo(other.Actuate) ?? 1) != 0 ? result :
        Value?.CompareTo(other.Value) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="Anchor_Type"/> is equal to the current <see cref="Anchor_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="Anchor_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(Anchor_Type? other) {
      return other != null &&
         base.Equals(other) &&
         Equals(Type, other.Type) &&
         Equals(Href, other.Href) &&
         Equals(Role, other.Role) &&
         Equals(ArcRole, other.ArcRole) &&
         Equals(Title, other.Title) &&
         Equals(Show, other.Show) &&
         Equals(Actuate, other.Actuate) &&
         Equals(Value, other.Value);
    }

    /// <inheritdoc />
    public override bool Equals(CharacterString? other) {
      return Equals(other as Anchor_Type);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="Anchor_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as Anchor_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="Anchor_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(base.GetHashCode());
      hash.Add(Type);
      hash.Add(Href);
      hash.Add(Role);
      hash.Add(ArcRole);
      hash.Add(Title);
      hash.Add(Show);
      hash.Add(Actuate);
      hash.Add(Value);

      return hash.ToHashCode();
    }

    #endregion

  }

}
