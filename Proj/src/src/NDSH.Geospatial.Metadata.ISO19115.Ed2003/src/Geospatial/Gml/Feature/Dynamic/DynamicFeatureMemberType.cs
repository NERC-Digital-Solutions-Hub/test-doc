
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
// <element name="dynamicMembers" type="gml:DynamicFeatureMemberType"/>
// <complexType name="DynamicFeatureMemberType">
//   <complexContent>
//     <extension base="gml:AbstractFeatureMemberType">
//       <sequence>
//         <element ref="gml:DynamicFeature" minOccurs="0" maxOccurs="unbounded"/>
//       </sequence>
//       <attributeGroup ref="gml:AssociationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Geospatial.Gml.Feature;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Feature.Dynamic {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DynamicFeatureMemberType")]
  public class DynamicFeatureMemberType : AbstractFeatureMemberType {
    #region Private fields
    private List<DynamicFeatureType> _dynamicFeature;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// DynamicFeatureMemberType class constructor
    /// </summary>
    public DynamicFeatureMemberType() {
      _dynamicFeature = default; // new List<DynamicFeatureType>();
    }

    [XmlElement("DynamicFeature", Order = 0)]
    [JsonProperty("DynamicFeature", Order = 0)]
    public List<DynamicFeatureType> DynamicFeature {
      get {
        return _dynamicFeature;
      }
      set {
        if (_dynamicFeature == value) {
          return;
        }
        if (_dynamicFeature == null || _dynamicFeature.Equals(value) != true) {
          _dynamicFeature = value;
          OnPropertyChanged("DynamicFeature");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged("NilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string RemoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged("RemoteSchema");
        }
      }
    }
  }
}
