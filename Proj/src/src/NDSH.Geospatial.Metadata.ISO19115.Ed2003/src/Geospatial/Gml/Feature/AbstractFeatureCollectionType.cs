
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
// <complexType name="AbstractFeatureCollectionType" abstract="true">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractFeatureType">
//       <sequence>
//         <element ref="gml:featureMember" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:featureMembers" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="AbstractFeatureCollection" type="gml:AbstractFeatureCollectionType" abstract="true" substitutionGroup="gml:AbstractFeature">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Feature {

  //[XmlInclude(typeof(FeatureCollectionType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractFeatureCollectionType")]
  public abstract class AbstractFeatureCollectionType : AbstractFeatureType {
    #region Private fields
    private List<FeaturePropertyType> _featureMember;
    private FeatureArrayPropertyType _featureMembers;
    #endregion

    /// <summary>
    /// AbstractFeatureCollectionType class constructor
    /// </summary>
    public AbstractFeatureCollectionType() {
      _featureMembers = new FeatureArrayPropertyType();
      _featureMember = new List<FeaturePropertyType>();
    }

    [XmlElement("featureMember", Order = 0)]
    [JsonProperty("featureMember", Order = 0)]
    public List<FeaturePropertyType> FeatureMember {
      get {
        return _featureMember;
      }
      set {
        if (_featureMember == value) {
          return;
        }
        if (_featureMember == null || _featureMember.Equals(value) != true) {
          _featureMember = value;
          OnPropertyChanged("FeatureMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("featureMembers", Order = 1)]
    public FeatureArrayPropertyType FeatureMembers {
      get {
        return _featureMembers;
      }
      set {
        if (_featureMembers == value) {
          return;
        }
        if (_featureMembers == null || _featureMembers.Equals(value) != true) {
          _featureMembers = value;
          OnPropertyChanged("FeatureMembers");
        }
      }
    }
  }
}
