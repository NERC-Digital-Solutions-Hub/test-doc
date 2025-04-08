
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gts/temporalObjects.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="TM_PeriodDuration" type="xs:duration"/>
// <xs:complexType name="TM_PeriodDuration_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gts:TM_PeriodDuration"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;

using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime {

  [Serializable]
  [XmlType("TM_PeriodDuration_PropertyType", Namespace = "http://www.isotc211.org/2005/gts")]
  [JsonObject("TM_PeriodDuration_PropertyType")]
  public class TM_PeriodDuration_PropertyType : ObservableDbEntity {

    #region Public Properties

    private string _tm_PeriodDuration;

    [XmlElement("TM_PeriodDuration", DataType = "duration", Order = 0)]
    [JsonProperty("TM_PeriodDuration", Order = 0)]
    public string TM_PeriodDuration {
      get => _tm_PeriodDuration;
      set {
        if (_tm_PeriodDuration == value) {
          return;
        }
        if (_tm_PeriodDuration == null || !_tm_PeriodDuration.Equals(value)) {
          _tm_PeriodDuration = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
