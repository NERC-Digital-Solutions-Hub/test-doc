
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
// <complexType name="TopoComplexMemberType">
//   <sequence minOccurs="0">
//     <element ref="gml:TopoComplex"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// <element name="topoComplexProperty" type="gml:TopoComplexMemberType">
//   <annotation>
//     <documentation>
//       The gml:topoComplexProperty property element encodes the relationship
//       between a GML object and a topological complex.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoComplexMemberType")]
  public class TopoComplexMemberType : ObservableModel {

    #region Private fields
    private TopoComplexType _topoComplex;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TopoComplexMemberType class constructor
    /// </summary>
    public TopoComplexMemberType() {
      _topoComplex = default; // new TopoComplexType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TopoComplex", Order = 0)]
    public TopoComplexType TopoComplex {
      get {
        return _topoComplex;
      }
      set {
        if (_topoComplex == value) {
          return;
        }
        if (_topoComplex == null || _topoComplex.Equals(value) != true) {
          _topoComplex = value;
          OnPropertyChanged("TopoComplex");
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
