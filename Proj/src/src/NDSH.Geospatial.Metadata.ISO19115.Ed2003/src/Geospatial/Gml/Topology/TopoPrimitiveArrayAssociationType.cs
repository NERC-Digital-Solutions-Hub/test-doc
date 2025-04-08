
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
// XSD               : /2005/gml/topology.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="topoPrimitiveMembers" type="gml:TopoPrimitiveArrayAssociationType">
//   <annotation>
//     <documentation>
//       The gml:topoPrimitiveMembers property element encodes the relationship between
//       a topology complex and an arbitrary number of topology primitives.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TopoPrimitiveArrayAssociationType">
//   <sequence minOccurs="0" maxOccurs="unbounded">
//     <element ref="gml:AbstractTopoPrimitive"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoPrimitiveArrayAssociationType")]
  public class TopoPrimitiveArrayAssociationType : ObservableModel {

    #region Private fields
    private List<AbstractTopoPrimitiveType> _abstractTopoPrimitive;
    private bool _owns;
    #endregion

    /// <summary>
    /// TopoPrimitiveArrayAssociationType class constructor
    /// </summary>
    public TopoPrimitiveArrayAssociationType() {
      _abstractTopoPrimitive = new List<AbstractTopoPrimitiveType>();
      _owns = false;
    }

    [XmlElement("AbstractTopoPrimitive", Order = 0)]
    [JsonProperty("AbstractTopoPrimitive", Order = 0)]
    public List<AbstractTopoPrimitiveType> AbstractTopoPrimitive {
      get {
        return _abstractTopoPrimitive;
      }
      set {
        if (_abstractTopoPrimitive == value) {
          return;
        }
        if (_abstractTopoPrimitive == null || _abstractTopoPrimitive.Equals(value) != true) {
          _abstractTopoPrimitive = value;
          OnPropertyChanged("AbstractTopoPrimitive");
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
