
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
// <complexType name="AbstractFeatureMemberType" abstract="true">
//   <annotation>
//     <documentation>
//       To create a collection of GML features, a property type shall be
//       derived by extension from gml:AbstractFeatureMemberType.
//       By default, this abstract property type does not imply any ownership
//       of the features in the collection. The owns attribute of
//       gml:OwnershipAttributeGroup may be used on a property element
//       instance to assert ownership of a feature in the collection.
//       A collection shall not own a feature already owned by another object.
//     </documentation>
//   </annotation>
//   <sequence/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Apps;
using NDSH.Geospatial.Gml.Feature.Dynamic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Feature {

  /// <summary>
  /// To create a collection of GML features, a property type shall be derived by extension
  /// from gml:AbstractFeatureMemberType. By default, this abstract property type does not imply any ownership of the
  /// features in the collection. The owns attribute of gml:OwnershipAttributeGroup may be used on a property element
  /// instance to assert ownership of a feature in the collection. A collection shall not own a feature
  /// already owned by another object.
  /// </summary>
  //[XmlInclude(typeof(DynamicFeatureMemberType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractFeatureMemberType")]
  public abstract class AbstractFeatureMemberType : ObservableModel {
    #region Private fields
    private bool _owns;
    #endregion

    /// <summary>
    /// AbstractFeatureMemberType class constructor
    /// </summary>
    public AbstractFeatureMemberType() {
      _owns = false;
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
