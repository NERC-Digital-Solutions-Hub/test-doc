
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/citation.xsd
// --------------------------------------------------------------------------------
// <xs:complexType name="CI_Date_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="date" type="gco:Date_PropertyType"/>
//         <xs:element name="dateType" type="gmd:CI_DateTypeCode_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common.Citation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CI_Date", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("CI_Date", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_Date")]
  public class CI_Date_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Date_Type"/>.
    /// </summary>
    public CI_Date_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _date = default; //  new Date_PropertyType();
      _dateType = default; //  new CI_DateTypeCode_PropertyType();

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

    private Date_PropertyType _date;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("date", Order = 0)]
    [JsonProperty("date", Order = 0)]
    public Date_PropertyType Date {
      get => _date;
      set {
        if (_date == value) {
          return;
        }
        if (_date == null || !_date.Equals(value)) {
          _date = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_DateTypeCode_PropertyType _dateType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dateType", Order = 1)]
    [JsonProperty("dateType", Order = 1)]
    public CI_DateTypeCode_PropertyType DateType {
      get => _dateType;
      set {
        if (_dateType == value) {
          return;
        }
        if (_dateType == null || !_dateType.Equals(value)) {
          _dateType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
