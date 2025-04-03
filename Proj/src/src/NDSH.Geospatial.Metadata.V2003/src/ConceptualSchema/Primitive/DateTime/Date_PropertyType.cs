
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 03/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:simpleType name="Date_Type">
//   <xs:union memberTypes="xs:date xs:gYearMonth xs:gYear"/>
// </xs:simpleType>
// <xs:element name="Date" type="gco:Date_Type" nillable="true"/>
// <xs:complexType name="Date_PropertyType">
//   <xs:choice minOccurs="0">
//     <xs:element ref="gco:Date"/>
//     <xs:element ref="gco:DateTime"/>
//   </xs:choice>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime {

  [Serializable]
  [XmlType("Date_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Date_PropertyType")]
  public class Date_PropertyType : NilReasonModel {

    #region Public Properties

    private object _item;

    /// <summary>
    /// Gets/Sets a date <see cref="string"/> or a <see cref="System.DateTime"/>
    /// based on the <see cref="DateTimeType"/> property.
    /// <example>
    /// <para>
    /// <b>Example:</b>
    /// </para>
    /// <code>
    /// DateOrDateTime = "2022-01-16"; // Add a <see cref="string"/> formatted as: yyyy-MM-dd
    /// DateOrDateTime = new <see cref="System.DateTime"/>(2022, 01, 16, 21, 15, 05); // year, month, day, hour, minute, second
    /// </code>
    /// </example>
    /// </summary>
    [XmlChoiceIdentifier("DateTimeType")]
    [XmlElement("Date", typeof(string), IsNullable = true, Order = 0)]
    [XmlElement("DateTime", typeof(System.DateTime), Order = 0)]
    public object DateOrDateTime {
      get => _item;
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;

          // WARNING: Danger !!! - Perhaps this is not a good idea. When deserializing it may need to have the 'DateTimeType' property set already, otherwise the deserialization will not be correct.
          if (_item.GetType() == typeof(string)) {
            this.DateTimeType = DateTimeEnumeration.Date;
          }
          else if (_item.GetType() == typeof(System.DateTime)) {
            this.DateTimeType = DateTimeEnumeration.DateTime;
          }

          OnPropertyChanged();
        }
      }
    }

    /// <summary>
    /// Gets the <see cref="DateTimeEnumeration"/> value used
    /// to denote the type of the <see cref="DateOrDateTime"/>.
    /// </summary>
    [XmlIgnore()]
    public DateTimeEnumeration DateTimeType {
      get;
      private set;
    }

    #endregion

  }

}
