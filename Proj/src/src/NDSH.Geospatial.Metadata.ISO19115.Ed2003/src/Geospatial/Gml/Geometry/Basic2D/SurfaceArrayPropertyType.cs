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
// XSD               : /2005/gml/geometryBasic2d.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="SurfaceArrayPropertyType">
//   <annotation>
//     <documentation>
//       gml:SurfaceArrayPropertyType is a container for an array of surfaces.
//       The elements are always contained in the array property, referencing
//       geometry elements or arrays of geometry elements via XLinks is not supported.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0" maxOccurs="unbounded">
//     <element ref="gml:AbstractSurface"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="surfaceArrayProperty" type="gml:SurfaceArrayPropertyType">
//   <annotation>
//     <documentation>
//       This property element contains a list of surface elements.
//       surfaceArrayProperty is the predefined property which may be used by
//       GML Application Schemas whenever a GML feature has a property with a
//       value that is substitutable for a list of AbstractSurfaces.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion


#region Imported Namespaces

using NDSH.Apps;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Geometry.Basic2D {


  /// <summary>
  /// gml:SurfaceArrayPropertyType is a container for an array of surfaces. The elements are always contained in the array property, referencing geometry elements or arrays of geometry elements via XLinks is not supported.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SurfaceArrayPropertyType")]
  public class SurfaceArrayPropertyType : ObservableModel {

    #region Private fields
    private List<AbstractSurfaceType> _abstractSurface;
    private bool _owns;
    #endregion

    /// <summary>
    /// SurfaceArrayPropertyType class constructor
    /// </summary>
    public SurfaceArrayPropertyType() {
      _abstractSurface = new List<AbstractSurfaceType>();
      _owns = false;
    }

    [XmlElement("AbstractSurface", Order = 0)]
    [JsonProperty("AbstractSurface", Order = 0)]
    public List<AbstractSurfaceType> AbstractSurface {
      get {
        return _abstractSurface;
      }
      set {
        if (_abstractSurface == value) {
          return;
        }
        if (_abstractSurface == null || _abstractSurface.Equals(value) != true) {
          _abstractSurface = value;
          OnPropertyChanged("AbstractSurface");
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
