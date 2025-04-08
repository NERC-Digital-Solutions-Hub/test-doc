
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
// <element name="DynamicFeatureCollection" type="gml:DynamicFeatureCollectionType" substitutionGroup="gml:DynamicFeature">
//   <annotation>
//     <documentation>
//       A gml:DynamicFeatureCollection is a feature collection that has a gml:validTime property
//       (i.e. is a snapshot of the feature collection) or which has a gml:history property that contains
//       one or more gml:AbstractTimeSlices each of which contain values of the time varying properties of
//       the feature collection.  Note that the gml:DynamicFeatureCollection may be one of the following:
//       1.  A feature collection which consists of static feature members (members do not change in time)
//           but which has properties of the collection object as a whole that do change in time .  
//       2.  A feature collection which consists of dynamic feature members (the members are gml:DynamicFeatures)
//           but which also has properties of the collection as a whole that vary in time.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="DynamicFeatureCollectionType">
//   <complexContent>
//     <extension base="gml:DynamicFeatureType">
//       <sequence>
//         <element ref="gml:dynamicMembers"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Feature.Dynamic {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DynamicFeatureCollectionType")]
  public class DynamicFeatureCollectionType : DynamicFeatureType {
    #region Private fields
    private DynamicFeatureMemberType _dynamicMembers;
    #endregion

    /// <summary>
    /// DynamicFeatureCollectionType class constructor
    /// </summary>
    public DynamicFeatureCollectionType() {
      _dynamicMembers = default; // new DynamicFeatureMemberType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("dynamicMembers", Order = 0)]
    public DynamicFeatureMemberType DynamicMembers {
      get {
        return _dynamicMembers;
      }
      set {
        if (_dynamicMembers == value) {
          return;
        }
        if (_dynamicMembers == null || _dynamicMembers.Equals(value) != true) {
          _dynamicMembers = value;
          OnPropertyChanged("DynamicMembers");
        }
      }
    }
  }

}
