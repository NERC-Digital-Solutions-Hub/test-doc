
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
// XSD               : /2005/gml/geometryPrimitives.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="SolidArrayPropertyType">
//   <annotation>
//     <documentation>
//       gml:SolidArrayPropertyType is a container for an array of solids.
//       The elements are always contained in the array property, referencing geometry
//       elements or arrays of geometry elements is not supported.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0" maxOccurs="unbounded">
//     <element ref="gml:AbstractSolid"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="solidArrayProperty" type="gml:SolidArrayPropertyType">
//   <annotation>
//     <documentation>
//       This property element contains a list of solid elements.
//       solidArrayProperty is the predefined property which may be used by
//       GML Application Schemas whenever a GML feature has a property with a
//       value that is substitutable for a list of AbstractSolid.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {


  /// <summary>
  /// gml:SolidArrayPropertyType is a container for an array of solids. The elements are always contained in the array property, referencing geometry elements or arrays of geometry elements is not supported.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SolidArrayPropertyType")]
  public class SolidArrayPropertyType : ObservableModel {
    #region Private fields
    private List<AbstractSolidType> _abstractSolid;
    private bool _owns;
    #endregion

    /// <summary>
    /// SolidArrayPropertyType class constructor
    /// </summary>
    public SolidArrayPropertyType() {
      _abstractSolid = new List<AbstractSolidType>();
      _owns = false;
    }

    [XmlElement("AbstractSolid", Order = 0)]
    [JsonProperty("AbstractSolid", Order = 0)]
    public List<AbstractSolidType> AbstractSolid {
      get {
        return _abstractSolid;
      }
      set {
        if (_abstractSolid == value) {
          return;
        }
        if (_abstractSolid == null || _abstractSolid.Equals(value) != true) {
          _abstractSolid = value;
          OnPropertyChanged("AbstractSolid");
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
