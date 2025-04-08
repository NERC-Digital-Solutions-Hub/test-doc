
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : data, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/grids.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="GridEnvelopeType">
//   <sequence>
//     <element name="low" type="gml:integerList"/>
//     <element name="high" type="gml:integerList"/>
//   </sequence>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Grids {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GridEnvelopeType")]
  public class GridEnvelopeType : ObservableModel {
    #region Private fields
    private string _low;
    private string _high;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("low", Order = 0)]
    public string Low {
      get {
        return _low;
      }
      set {
        if (_low == value) {
          return;
        }
        if (_low == null || _low.Equals(value) != true) {
          _low = value;
          OnPropertyChanged("Low");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("high", Order = 1)]
    public string High {
      get {
        return _high;
      }
      set {
        if (_high == value) {
          return;
        }
        if (_high == null || _high.Equals(value) != true) {
          _high = value;
          OnPropertyChanged("High");
        }
      }
    }
  }
}
