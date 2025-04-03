
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
// XSD               : /2005/gml/feature.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="FeatureArrayPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence minOccurs="0" maxOccurs="unbounded">
//     <element ref="gml:AbstractFeature"/>
//   </sequence>
// </complexType>
// <element name="featureMembers" type="gml:FeatureArrayPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Feature {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("FeatureArrayPropertyType")]
  public class FeatureArrayPropertyType : ObservableModel {
    #region Private fields
    private List<AbstractFeatureType> _abstractFeature;
    #endregion

    /// <summary>
    /// FeatureArrayPropertyType class constructor
    /// </summary>
    public FeatureArrayPropertyType() {
      _abstractFeature = new List<AbstractFeatureType>();
    }

    [XmlElement("AbstractFeature", Order = 0)]
    [JsonProperty("AbstractFeature", Order = 0)]
    public List<AbstractFeatureType> AbstractFeature {
      get {
        return _abstractFeature;
      }
      set {
        if (_abstractFeature == value) {
          return;
        }
        if (_abstractFeature == null || _abstractFeature.Equals(value) != true) {
          _abstractFeature = value;
          OnPropertyChanged("AbstractFeature");
        }
      }
    }
  }
}
