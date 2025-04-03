
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 02/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="DateTime" type="xs:dateTime"/>
// <xs:complexType name="DateTime_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:DateTime"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime {

  [Serializable]
  [XmlType("DateTime_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("DateTime_PropertyType")]
  public class DateTime_PropertyType : NilReasonModel {

    #region Public Properties

    private System.DateTime _dateTime;

    [XmlElement("DateTime", Order = 0)]
    [JsonProperty("DateTime", Order = 0)]
    public System.DateTime DateTime {
      get => _dateTime;
      set {
        if (!_dateTime.Equals(value)) { // TODO: Can this be null?
          _dateTime = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
