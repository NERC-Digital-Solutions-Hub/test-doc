
#region Header
// Title Name        : MD_DatatypeCodeValue
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The datatype of element or entity.
// Created by        : 19/09/2022, 19:37, @gisvlasta
// Updated by        : 18/12/2022, 03:50, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Extension {

  /// <summary>
  /// The datatype of element or entity.
  /// </summary>
  [Serializable]
  public enum MD_DatatypeCodeValue {

    /// <summary>
    /// Descriptor of a set of objects that share the same attributes,
    /// operations, methods, relationships, and behavior.
    /// </summary>
    [XmlEnum(Name = "class")]
    [EnumMember(Value = "class")]
    Class = 1,

    /// <summary>
    /// Flexible enumeration useful for expressing a long list of values, can be extended.
    /// </summary>
    [XmlEnum(Name = "codelist")]
    [EnumMember(Value = "codelist")]
    Codelist = 2,

    /// <summary>
    /// Data type whose instances form a list of named literal values, not extendable.
    /// </summary>
    [XmlEnum(Name = "enumeration")]
    [EnumMember(Value = "enumeration")]
    Enumeration = 3,

    /// <summary>
    /// Permissible value for a codelist or enumeration.
    /// </summary>
    [XmlEnum(Name = "codelistElement")]
    [EnumMember(Value = "codelistElement")]
    CodelistElement = 4,

    /// <summary>
    /// Class that cannot be directly instantiated.
    /// </summary>
    [XmlEnum(Name = "abstractClass")]
    [EnumMember(Value = "abstractClass")]
    AbstractClass = 5,

    /// <summary>
    /// Class that is composed of classes it is connected to by an aggregate relationship.
    /// </summary>
    [XmlEnum(Name = "aggregateClass")]
    [EnumMember(Value = "aggregateClass")]
    AggregateClass = 6,

    /// <summary>
    /// Subclass that may be substituted for its superclass.
    /// </summary>
    [XmlEnum(Name = "specifiedClass")]
    [EnumMember(Value = "specifiedClass")]
    SpecifiedClass = 7,

    /// <summary>
    /// Class with few or no operations whose primary purpose is to hold the abstract
    /// state of another class for transmittal, storage, encoding or persistent storage.
    /// </summary>
    [XmlEnum(Name = "datatypeClass")]
    [EnumMember(Value = "datatypeClass")]
    DatatypeClass = 8,

    /// <summary>
    /// Named set of operations that characterize the behavior of an element.
    /// </summary>
    [XmlEnum(Name = "interfaceClass")]
    [EnumMember(Value = "interfaceClass")]
    InterfaceClass = 9,

    /// <summary>
    /// Class describing a selection of one of the specified types.
    /// </summary>
    [XmlEnum(Name = "unionClass")]
    [EnumMember(Value = "unionClass")]
    UnionClass = 10,

    /// <summary>
    /// Class whose instances are classes.
    /// </summary>
    [XmlEnum(Name = "metaclass")]
    [EnumMember(Value = "metaclass")]
    Metaclass = 11,

    /// <summary>
    /// Class used for specification of a domain of instances (objects),
    /// together with the operations applicable to the objects.
    /// A type may have attributes and associations.
    /// </summary>
    [XmlEnum(Name = "typeClass")]
    [EnumMember(Value = "typeClass")]
    TypeClass = 12,

    /// <summary>
    /// Free text field.
    /// </summary>
    [XmlEnum(Name = "characterString")]
    [EnumMember(Value = "characterString")]
    CharacterString = 13,

    /// <summary>
    /// Numerical field.
    /// </summary>
    [XmlEnum(Name = "Integer")]
    [EnumMember(Value = "Integer")]
    Integer = 14,

    /// <summary>
    /// Semantic relationship between two classes that involves connections among their instances.
    /// </summary>
    [XmlEnum(Name = "association")]
    [EnumMember(Value = "association")]
    Association = 15,

  }

}
