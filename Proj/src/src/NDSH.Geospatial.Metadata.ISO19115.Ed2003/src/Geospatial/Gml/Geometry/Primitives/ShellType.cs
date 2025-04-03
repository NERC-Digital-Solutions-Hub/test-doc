
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
// <complexType name="ShellType">
//   <sequence>
//     <element ref="gml:surfaceMember" maxOccurs="unbounded"/>
//   </sequence>
//   <attributeGroup ref="gml:AggregationAttributeGroup"/>
// </complexType>
// <element name="Shell" type="gml:ShellType" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <documentation>
//       A shell is used to represent a single connected component of a solid boundary as specified in ISO 19107:2003, 6.3.8.
//       Every gml:surfaceMember references or contains one surface, i.e. any element which is substitutable
//       for gml:AbstractSurface. In the context of a shell, the surfaces describe the boundary of the solid. 
//       If provided, the aggregationType attribute shall have the value “set”.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="ShellPropertyType">
//   <annotation>
//     <documentation>
//       A property with the content model of gml:ShellPropertyType
//       encapsulates a shell to represent a component of a solid boundary.</documentation>
//   </annotation>
//   <sequence>
//     <element ref="gml:Shell"/>
//   </sequence>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using NDSH.Geospatial.Gml.Geometry.Basic2D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ShellType")]
  public class ShellType : ObservableModel {
    #region Private fields
    private List<SurfacePropertyType> _surfaceMember;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// ShellType class constructor
    /// </summary>
    public ShellType() {
      _surfaceMember = new List<SurfacePropertyType>();
    }

    [XmlElement("surfaceMember", Order = 0)]
    [JsonProperty("surfaceMember", Order = 0)]
    public List<SurfacePropertyType> SurfaceMember {
      get {
        return _surfaceMember;
      }
      set {
        if (_surfaceMember == value) {
          return;
        }
        if (_surfaceMember == null || _surfaceMember.Equals(value) != true) {
          _surfaceMember = value;
          OnPropertyChanged("SurfaceMember");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("AggregationType");
        }
      }
    }
  }

}
