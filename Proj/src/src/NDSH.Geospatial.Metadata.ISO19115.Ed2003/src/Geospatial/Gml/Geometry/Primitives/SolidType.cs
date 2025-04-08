
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
// <complexType name="SolidType">
//   <complexContent>
//     <extension base="gml:AbstractSolidType">
//       <sequence>
//         <element name="exterior" type="gml:ShellPropertyType" minOccurs="0"/>
//         <element name="interior" type="gml:ShellPropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="Solid" type="gml:SolidType" substitutionGroup="gml:AbstractSolid">
//   <annotation>
//     <documentation>
//       A solid is the basis for 3-dimensional geometry. The extent of a solid is defined
//       by the boundary surfaces as specified in ISO 19107:2003, 6.3.18. exterior specifies
//       the outer boundary, interior the inner boundary of the solid.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SolidType")]
  public class SolidType : AbstractSolidType {
    #region Private fields
    private ShellPropertyType _exterior;
    private List<ShellPropertyType> _interior;
    #endregion

    /// <summary>
    /// SolidType class constructor
    /// </summary>
    public SolidType() {
      _interior = new List<ShellPropertyType>();
      _exterior = new ShellPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("exterior", Order = 0)]
    public ShellPropertyType Exterior {
      get {
        return _exterior;
      }
      set {
        if (_exterior == value) {
          return;
        }
        if (_exterior == null || _exterior.Equals(value) != true) {
          _exterior = value;
          OnPropertyChanged("Exterior");
        }
      }
    }

    [XmlElement("interior", Order = 1)]
    [JsonProperty("interior", Order = 1)]
    public List<ShellPropertyType> Interior {
      get {
        return _interior;
      }
      set {
        if (_interior == value) {
          return;
        }
        if (_interior == null || _interior.Equals(value) != true) {
          _interior = value;
          OnPropertyChanged("Interior");
        }
      }
    }
  }

}
