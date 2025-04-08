
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
// <complexType name="GridLimitsType">
//   <sequence>
//     <element name="GridEnvelope" type="gml:GridEnvelopeType"/>
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
  [JsonObject("GridLimitsType")]
  public class GridLimitsType : ObservableModel {
    #region Private fields
    private GridEnvelopeType _gridEnvelope;
    #endregion

    /// <summary>
    /// GridLimitsType class constructor
    /// </summary>
    public GridLimitsType() {
      _gridEnvelope = new GridEnvelopeType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("GridEnvelope", Order = 0)]
    public GridEnvelopeType GridEnvelope {
      get {
        return _gridEnvelope;
      }
      set {
        if (_gridEnvelope == value) {
          return;
        }
        if (_gridEnvelope == null || _gridEnvelope.Equals(value) != true) {
          _gridEnvelope = value;
          OnPropertyChanged("GridEnvelope");
        }
      }
    }
  }
}
