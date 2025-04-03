
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
// XSD               : /2005/gml/dynamicFeature.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="history" type="gml:HistoryPropertyType">
//   <annotation>
//     <documentation>
//       A generic sequence of events constitute a gml:history of an object.
//       The gml:history element contains a set of elements in the substitution
//       group headed by the abstract element gml:AbstractTimeSlice, representing
//       the time-varying properties of interest. The history property of a dynamic
//       feature associates a feature instance with a sequence of time slices
//       (i.e. change events) that encapsulate the evolution of the feature.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="HistoryPropertyType">
//   <sequence>
//     <element ref="gml:AbstractTimeSlice" maxOccurs="unbounded"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="track" type="gml:HistoryPropertyType" substitutionGroup="gml:history">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Feature.Dynamic {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("HistoryPropertyType")]
  public class HistoryPropertyType : ObservableModel {
    #region Private fields
    private List<AbstractTimeSliceType> _abstractTimeSlice;
    private bool _owns;
    #endregion

    /// <summary>
    /// HistoryPropertyType class constructor
    /// </summary>
    public HistoryPropertyType() {
      _abstractTimeSlice = default; // new List<AbstractTimeSliceType>();
      _owns = default; // false;
    }

    [XmlElement("AbstractTimeSlice", Order = 0)]
    [JsonProperty("AbstractTimeSlice", Order = 0)]
    public List<AbstractTimeSliceType> AbstractTimeSlice {
      get {
        return _abstractTimeSlice;
      }
      set {
        if (_abstractTimeSlice == value) {
          return;
        }
        if (_abstractTimeSlice == null || _abstractTimeSlice.Equals(value) != true) {
          _abstractTimeSlice = value;
          OnPropertyChanged("AbstractTimeSlice");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("Owns");
        }
      }
    }
  }
}
