
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
// <element name="AbstractTimeSlice" type="gml:AbstractTimeSliceType" abstract="true" substitutionGroup="gml:AbstractGML">
//   <annotation>
//     <documentation>
//       To describe an event — an action that occurs at an instant or over an
//       interval of time — GML provides the gml:AbtractTimeSlice element.
//       A timeslice encapsulates the time-varying properties of a dynamic
//       feature -- it shall be extended to represent a time stamped projection of
//       a specific feature. The gml:dataSource property describes how the temporal data was acquired.
//       A gml:AbstractTimeSlice instance is a GML object that encapsulates updates of the dynamic—or
//       volatile—properties that reflect some change event; it thus includes only those feature properties
//       that have actually changed due to some process.
//       gml:AbstractTimeSlice basically provides a facility for attribute-level time stamping,
//       in contrast to the object-level time stamping of dynamic feature instances. 
//       The time slice can thus be viewed as event or process-oriented, whereas a snapshot is more
//       state or structure-oriented. A timeslice has richer causality, whereas a snapshot merely
//       portrays the status of the whole. 
//     </documentation>
//   </annotation>
// </element>
// <complexType name="AbstractTimeSliceType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractGMLType">
//       <sequence>
//         <element ref="gml:validTime"/>
//         <element ref="gml:dataSource" minOccurs="0"/>
//       </sequence>
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

  //[XmlInclude(typeof(MovingObjectStatusType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimeSliceType")]
  public abstract class AbstractTimeSliceType : AbstractGMLType {
    #region Private fields
    private TimePrimitivePropertyType _validTime;
    private StringOrRefType _dataSource;
    #endregion

    /// <summary>
    /// AbstractTimeSliceType class constructor
    /// </summary>
    public AbstractTimeSliceType() {
      _dataSource = default; // new StringOrRefType();
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
    [JsonProperty("dataSource", Order = 1)]
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
  }
}
