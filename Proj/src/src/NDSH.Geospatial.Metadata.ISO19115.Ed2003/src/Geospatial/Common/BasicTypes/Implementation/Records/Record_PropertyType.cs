
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 11/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="Record"/>
// <xs:complexType name="Record_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:Record"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Implementation.Records {

  [Serializable]
  [XmlType("Record_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Record_PropertyType")]
  public class Record_PropertyType : ReferenceEntity {
    // WARNING: This was initially removed but had to be added back as there was no _Type equivalent for this class,
    // even though it's PropertyType implements ObjectReference_PropertyType.
    #region Public Properties

    private object _record;

    [XmlElement("Record", Order = 0)]
    [JsonProperty("Record", Order = 0)]
    public object Record {
      get => _record;
      set {
        if (_record == value) {
          return;
        }
        if (_record == null || !_record.Equals(value)) {
          _record = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
