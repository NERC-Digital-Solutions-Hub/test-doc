
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
// <complexType name="SurfacePatchArrayPropertyType">
//   <annotation>
//     <documentation>gml:SurfacePatchArrayPropertyType is a container for a sequence of surface patches.</documentation>
//   </annotation>
//   <sequence minOccurs="0" maxOccurs="unbounded">
//     <element ref="gml:AbstractSurfacePatch"/>
//   </sequence>
// </complexType>
// <element name="patches" type="gml:SurfacePatchArrayPropertyType">
//   <annotation>
//     <documentation>
//       The patches property element contains the sequence of surface patches. The order of the elements
//       is significant and shall be preserved when processing the array.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// gml:SurfacePatchArrayPropertyType is a container for a sequence of surface patches.
  /// </summary>
  //[XmlInclude(typeof(TrianglePatchArrayPropertyType))]
  //[XmlInclude(typeof(PolygonPatchArrayPropertyType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SurfacePatchArrayPropertyType")]
  public class SurfacePatchArrayPropertyType : ObservableModel {
    #region Private fields
    private List<AbstractSurfacePatchType> _abstractSurfacePatch;
    #endregion

    /// <summary>
    /// SurfacePatchArrayPropertyType class constructor
    /// </summary>
    public SurfacePatchArrayPropertyType() {
      _abstractSurfacePatch = new List<AbstractSurfacePatchType>();
    }

    [XmlElement("AbstractSurfacePatch", Order = 0)]
    [JsonProperty("AbstractSurfacePatch", Order = 0)]
    public List<AbstractSurfacePatchType> AbstractSurfacePatch {
      get {
        return _abstractSurfacePatch;
      }
      set {
        if (_abstractSurfacePatch == value) {
          return;
        }
        if (_abstractSurfacePatch == null || _abstractSurfacePatch.Equals(value) != true) {
          _abstractSurfacePatch = value;
          OnPropertyChanged("AbstractSurfacePatch");
        }
      }
    }
  }

}
