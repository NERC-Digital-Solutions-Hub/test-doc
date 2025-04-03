
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
// <element name="DynamicFeature" type="gml:DynamicFeatureType" substitutionGroup="gml:AbstractFeature">
//   <annotation>
//     <documentation>
//       States are captured by time-stamped instances of a feature.
//       The content model extends the standard gml:AbstractFeatureType
//       with the gml:dynamicProperties model group.
//       Each time-stamped instance represents a ‘snapshot’ of a feature.
//       The dynamic feature classes will normally be extended to suit
//       particular applications. A dynamic feature bears either a time stamp or a history.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="DynamicFeatureType">
//   <complexContent>
//     <extension base="gml:AbstractFeatureType">
//       <group ref="gml:dynamicProperties"/>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Geospatial.Gml.Temporal;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Feature.Dynamic {

  //[XmlInclude(typeof(DynamicFeatureCollectionType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DynamicFeatureType")]
  public class DynamicFeatureType : AbstractFeatureType {
    #region Private fields
    private TimePrimitivePropertyType _validTime;
    private HistoryPropertyType _history;
    private StringOrRefType _dataSource;
    private ReferenceType _dataSourceReference;
    #endregion

    /// <summary>
    /// DynamicFeatureType class constructor
    /// </summary>
    public DynamicFeatureType() {
      _dataSourceReference = default; // new ReferenceType();
      _dataSource = default; // new StringOrRefType();
      _history = default; // new HistoryPropertyType();
      _validTime = default; // new TimePrimitivePropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("validTime", Order = 0)]
    public TimePrimitivePropertyType ValidTime {
      get {
        return _validTime;
      }
      set {
        if (_validTime == value) {
          return;
        }
        if (_validTime == null || _validTime.Equals(value) != true) {
          _validTime = value;
          OnPropertyChanged("ValidTime");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("history", Order = 1)]
    public HistoryPropertyType History {
      get {
        return _history;
      }
      set {
        if (_history == value) {
          return;
        }
        if (_history == null || _history.Equals(value) != true) {
          _history = value;
          OnPropertyChanged("History");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("dataSource", Order = 2)]
    public StringOrRefType DataSource {
      get {
        return _dataSource;
      }
      set {
        if (_dataSource == value) {
          return;
        }
        if (_dataSource == null || _dataSource.Equals(value) != true) {
          _dataSource = value;
          OnPropertyChanged("DataSource");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("dataSourceReference", Order = 3)]
    public ReferenceType DataSourceReference {
      get {
        return _dataSourceReference;
      }
      set {
        if (_dataSourceReference == value) {
          return;
        }
        if (_dataSourceReference == null || _dataSourceReference.Equals(value) != true) {
          _dataSourceReference = value;
          OnPropertyChanged("DataSourceReference");
        }
      }
    }
  }


}
