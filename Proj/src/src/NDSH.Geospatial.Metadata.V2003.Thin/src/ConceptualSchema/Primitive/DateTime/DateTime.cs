
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 20:05, @gisvlasta.
// Updated by        : 10/02/2023, 22:22, @gisvlasta.
//                     1.0.1 - Major re-organisation of the class.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.DateTime {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Date_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Date_PropertyType")]
  public class DateTime : NilReasonModel {

    #region Public Properties

    private System.DateTime? _dateTime;

    /// <summary>
    /// Gets/Sets a <see cref="System.DateTime"/>. The value can be either a date or a datetime based on the
    /// <see cref="DateTimeEnumeration">value</see> of the property <see cref="DateTimeEnumeration">DateTimeEnumeration</see>.
    /// When the value is deserialized, if only a date is found, the value of the time part of DateTime is set to
    /// the midnight of that particular day, and the <see cref="DateTimeEnumeration">DateOrDateTime</see> is set to
    /// <see cref="DateTimeEnumeration.Date"/>.
    /// <example>
    /// <para>
    /// <b>The serialized value should be formatted as:</b>
    /// </para>
    /// <code>
    /// "2023-01-16" formatted as: yyyy-MM-dd
    /// "2023-01-16T14:12:08" formatted as: yyyy-MM-ddThh:mm:ss
    /// </code>
    /// </example>
    /// </summary>
    [XmlElement("Date", IsNullable = true, Order = 0)]
    [XmlElement("DateTime", Order = 0)] // TODO: DANGER - Add Validation Date can be null / DateTime can not be null. Check again definitions in XSD.
    public System.DateTime? Value {
      get {
        return _dateTime;
      }
      set {
        if (_dateTime != value) {
          return;
        }
        if (_dateTime == null || _dateTime.Equals(value) != true) {
          _dateTime = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTimeEnumeration _dateTimeEnumeration;

    /// <summary>
    /// Gets/Sets the <see cref="DateTimeEnumeration"/> value used
    /// to denote the type of the <see cref="DateTime"/>.
    /// </summary>
    [XmlIgnore()]
    public DateTimeEnumeration DateTimeType {
      get {
        return _dateTimeEnumeration;
      }
      set {
        if (_dateTimeEnumeration != value) {
          return;
        }
        if (_dateTimeEnumeration.Equals(value) != true) {
          _dateTimeEnumeration = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
