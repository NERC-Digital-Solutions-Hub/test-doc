#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/geometryAggregates.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="EnvelopeType">
//   <choice>
//     <sequence>
//       <element name="lowerCorner" type="gml:DirectPositionType"/>
//       <element name="upperCorner" type="gml:DirectPositionType"/>
//     </sequence>
//     <element ref="gml:pos" minOccurs="2" maxOccurs="2">
//       <annotation>
//         <appinfo>deprecated</appinfo>
//       </annotation>
//     </element>
//     <element ref="gml:coordinates"/>
//   </choice>
//   <attributeGroup ref="gml:SRSReferenceGroup"/>
// </complexType>
// <element name="Envelope" type="gml:EnvelopeType" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <documentation>
//       Envelope defines an extent using a pair of positions defining opposite corners in arbitrary dimensions. 
//       The first direct position is the "lower corner" (a coordinate position consisting of all the minimal ordinates for each dimension for
//       all points within the envelope), the second one the "upper corner" (a coordinate position consisting of all the maximal ordinates for
//       each dimension for all points within the envelope).
//       The use of the properties “coordinates” and “pos” has been deprecated. The explicitly named properties “lowerCorner” and “upperCorner”
//       shall be used instead.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Feature;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Geometry.Basic0D1D {

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(EnvelopeWithTimePeriodType))]
  [Serializable]
  //[XmlType("EnvelopeType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EnvelopeType")]
  public class EnvelopeType : ObservableModel {

    #region Public Properties

    private object[] _coordinatesOrPositionItems;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("coordinates", typeof(CoordinatesType), Order = 0)]
    [XmlElement("lowerCorner", typeof(DirectPositionType), Order = 0)]
    [XmlElement("pos", typeof(DirectPositionType), Order = 0)]
    [XmlElement("upperCorner", typeof(DirectPositionType), Order = 0)]
    [XmlChoiceIdentifier("CoordinatesOrPositionItemsElementName")]
    public object[] CoordinatesOrPositionItems {
      get {
        return _coordinatesOrPositionItems;
      }
      set {
        if (_coordinatesOrPositionItems == value) {
          return;
        }
        if (_coordinatesOrPositionItems == null || _coordinatesOrPositionItems.Equals(value) != true) {
          _coordinatesOrPositionItems = value;
          OnPropertyChanged();
        }
      }
    }

    private CoordinatesOrPositionEnumeration[] _coordinatesOrPositionItemsElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CoordinatesOrPositionItemsElementName", Order = 1)]
    [XmlIgnore]
    public CoordinatesOrPositionEnumeration[] CoordinatesOrPositionItemsElementName {
      get {
        return _coordinatesOrPositionItemsElementName;
      }
      set {
        if (_coordinatesOrPositionItemsElementName == value) {
          return;
        }
        if (_coordinatesOrPositionItemsElementName == null || _coordinatesOrPositionItemsElementName.Equals(value) != true) {
          _coordinatesOrPositionItemsElementName = value;
          OnPropertyChanged();
        }
      }
    }

    private string _srsName;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("srsName", DataType = "anyURI")]
    [JsonProperty("srsName")]
    public string SrsName {
      get {
        return _srsName;
      }
      set {
        if (_srsName == value) {
          return;
        }
        if (_srsName == null || _srsName.Equals(value) != true) {
          _srsName = value;
          OnPropertyChanged();
        }
      }
    }

    private string _srsDimension;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("srsDimension", DataType = "positiveInteger")]
    [JsonProperty("srsDimension")]
    public string SrsDimension {
      get {
        return _srsDimension;
      }
      set {
        if (_srsDimension == value) {
          return;
        }
        if (_srsDimension == null || _srsDimension.Equals(value) != true) {
          _srsDimension = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
