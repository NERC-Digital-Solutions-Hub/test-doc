
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 01/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/valueObjects.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="ValueArray" type="gml:ValueArrayType" substitutionGroup="gml:CompositeValue">
//   <annotation>
//     <documentation>
//       A Value Array is used for homogeneous arrays of primitive and aggregate values.  
//       The member values may be scalars, composites, arrays or lists.
//       ValueArray has the same content model as CompositeValue,
//       but the member values shall be homogeneous.
//       The element declaration contains a Schematron constraint which expresses this
//       restriction precisely. Since the members are homogeneous,
//       the gml:referenceSystem (uom, codeSpace) may be specified on the gml:ValueArray
//       itself and inherited by all the members if desired.
//     </documentation>
//     <appinfo>
//       <sch:pattern name="Check either codeSpace or uom not both">
//         <sch:rule context="gml:ValueArray">
//           <sch:report test="@codeSpace and @uom">
//             ValueArray may not carry both a reference to a codeSpace and a uom
//           </sch:report>
//         </sch:rule>
//       </sch:pattern>
//       <sch:pattern name="Check components are homogeneous">
//         <sch:rule context="gml:ValueArray">
//           <sch:assert test="
//             count(gml:valueComponent/*) =
//               count(gml:valueComponent/*[name() =
//                 name(../../gml:valueComponent[1]/*[1])])">
//             All components of <sch:name/> shall be of the same type
//           </sch:assert>
//           <sch:assert test="count(gml:valueComponents/*) = count(gml:valueComponents/*[name() = name(../*[1])])">
//             All components of <sch:name/> shall be of the same type
//           </sch:assert>
//         </sch:rule>
//       </sch:pattern>
//     </appinfo>
//   </annotation>
// </element>
// 
// <complexType name="ValueArrayType">
//   <complexContent>
//     <extension base="gml:CompositeValueType">
//       <attributeGroup ref="gml:referenceSystem"/>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="ValueArrayPropertyType">
//   <sequence maxOccurs="unbounded">
//     <group ref="gml:Value"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
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

namespace NDSH.Geospatial.Gml.ValueObjects {

  // WARNING: the XSD defines the validation tests that need to run - Check so that these validation tests are implemented.

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ValueArrayPropertyType")]
  public class ValueArrayPropertyType : ObservableModel {

    #region Private fields
    private List<object> _items;
    private bool _owns;
    #endregion

    /// <summary>
    /// ValueArrayPropertyType class constructor
    /// </summary>
    public ValueArrayPropertyType() {
      _items = new List<object>();
      _owns = false;
    }

    [XmlElement("AbstractGeometry", typeof(AbstractGeometryType), Order = 0)]
    [XmlElement("AbstractTimeObject", typeof(AbstractTimeObjectType), Order = 0)]
    [XmlElement("AbstractValue", typeof(object), Order = 0)]
    [XmlElement("Null", typeof(string), Order = 0)]
    public List<object> Items {
      get {
        return _items;
      }
      set {
        if (_items == value) {
          return;
        }
        if (_items == null || _items.Equals(value) != true) {
          _items = value;
          OnPropertyChanged("Items");
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
