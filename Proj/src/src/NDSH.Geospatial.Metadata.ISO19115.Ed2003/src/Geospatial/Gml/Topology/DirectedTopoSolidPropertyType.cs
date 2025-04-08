
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
// <element name="directedTopoSolid" type="gml:DirectedTopoSolidPropertyType">
//   <annotation>
//     <documentation>
//       The gml:directedSolid property element describes the coBoundary of topology
//       faces and is used in the support of volume features via the gml:TopoVolume
//       expression, see below. The orientation attribute of type gml:SignType expresses
//       the sense in which the included solid appears in the face coboundary.
//       In the context of a gml:TopoVolume the orientation attribute has no meaning.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="DirectedTopoSolidPropertyType">
//   <sequence minOccurs="0">
//     <element ref="gml:TopoSolid"/>
//   </sequence>
//   <attribute name="orientation" type="gml:SignType" default="+"/>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Gml.BasicTypes;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectedTopoSolidPropertyType")]
  public class DirectedTopoSolidPropertyType : ObservableModel {

    #region Private fields
    private TopoSolidType _topoSolid;
    private SignType _orientation;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// DirectedTopoSolidPropertyType class constructor
    /// </summary>
    public DirectedTopoSolidPropertyType() {
      _topoSolid = default; // new TopoSolidType();
      _orientation = SignType.Plus;
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TopoSolid", Order = 0)]
    public TopoSolidType TopoSolid {
      get {
        return _topoSolid;
      }
      set {
        if (_topoSolid == value) {
          return;
        }
        if (_topoSolid == null || _topoSolid.Equals(value) != true) {
          _topoSolid = value;
          OnPropertyChanged("TopoSolid");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(SignType.Plus)]
    [JsonProperty("orientation")]
    public SignType Orientation {
      get {
        return _orientation;
      }
      set {
        if (_orientation.Equals(value) != true) {
          _orientation = value;
          OnPropertyChanged("Orientation");
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
