
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
// XSD               : /2005/gml/coverage.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="domainSet" type="gml:DomainSetType">
//   <annotation>
//     <documentation>
//       The gml:domainSet property element describes the spatio-temporal region of interest,
//       within which the coverage is defined. Its content model is given by gml:DomainSetType.
//       The value of the domain is thus a choice between a gml:AbstractGeometry and a gml:AbstractTimeObject.
//       In the instance these abstract elements will normally be substituted by a geometry complex or temporal complex,
//       to represent spatial coverages and time-series, respectively.
//       The presence of the gml:AssociationAttributeGroup means that domainSet follows the usual GML property model
//       and may use the xlink:href attribute to point to the domain, as an alternative to describing the domain inline.
//       Ownership semantics may be provided using the gml:OwnershipAttributeGroup.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="DomainSetType">
//   <sequence minOccurs="0">
//     <choice>
//       <element ref="gml:AbstractGeometry"/>
//       <element ref="gml:AbstractTimeObject"/>
//     </choice>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Gml.Temporal;
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

namespace NDSH.Geospatial.Gml.Coverage {

  #region XmlIncludes
  //[XmlInclude(typeof(RectifiedGridDomainType))]
  //[XmlInclude(typeof(GridDomainType))]
  //[XmlInclude(typeof(MultiSolidDomainType))]
  //[XmlInclude(typeof(MultiSurfaceDomainType))]
  //[XmlInclude(typeof(MultiCurveDomainType))]
  //[XmlInclude(typeof(MultiPointDomainType))]
  #endregion

  [IsoType("DomainSetType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DomainSetType")]
  public class DomainSetType : ObservableModel {

    #region Private fields
    private AbstractGMLType _item;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// DomainSetType class constructor
    /// </summary>
    public DomainSetType() {
      _owns = false;
    }

    [XmlElement("AbstractGeometry", typeof(AbstractGeometryType), Order = 0)]
    [XmlElement("AbstractTimeObject", typeof(AbstractTimeObjectType), Order = 0)]
    public AbstractGMLType Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
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
