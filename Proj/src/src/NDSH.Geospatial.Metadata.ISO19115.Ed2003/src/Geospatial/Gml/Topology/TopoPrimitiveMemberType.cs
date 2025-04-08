
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
// <element name="topoPrimitiveMember" type="gml:TopoPrimitiveMemberType">
//   <annotation>
//     <documentation>
//       The gml:topoPrimitiveMember property element encodes for the relationship
//       between a topology complex and a single topology primitive.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TopoPrimitiveMemberType">
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractTopoPrimitive"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
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
  [JsonObject("TopoPrimitiveMemberType")]
  public class TopoPrimitiveMemberType : ObservableModel {

    #region Private fields
    private AbstractTopoPrimitiveType _abstractTopoPrimitive;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// TopoPrimitiveMemberType class constructor
    /// </summary>
    public TopoPrimitiveMemberType() {
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractTopoPrimitive", Order = 0)]
    public AbstractTopoPrimitiveType AbstractTopoPrimitive {
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
