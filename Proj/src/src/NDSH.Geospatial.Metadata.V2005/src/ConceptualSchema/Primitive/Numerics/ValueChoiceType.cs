
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
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

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Primitive.Numerics {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public enum ValueChoiceType {

    // TODO: Make sure what are the actual enum values (check spec)
    // TODO: Enum values are in PascalCase which is unusual. Make sure this is the case in the corresponding ISO document.

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "Integer")]
    [EnumMember(Value = "Integer")]
    Integer,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "Number")]
    [EnumMember(Value = "Number")]
    Number,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "Real")]
    [EnumMember(Value = "Real")]
    Real,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "Decimal")]
    [EnumMember(Value = "Decimal")]
    Decimal,

  }

  //TODO: ItemChoiceType

  //[Serializable]
  //[XmlType(IncludeInSchema = false)]
  //[XmlRoot("ItemChoiceType")]
  //public enum ItemChoiceType {
  //  Decimal,
  //  Integer,
  //  Number,
  //  Real,
  //}

}
