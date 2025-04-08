
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

using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.ValueObjects {

  // WARNING: the XSD defines the validation tests that need to run - Check so that these validation tests are implemented.

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ValueArrayType")]
  public class ValueArrayType : CompositeValueType {

    #region Private fields
    private string _codeSpace;
    private string _uom;
    #endregion

    [XmlAttribute(DataType = "anyURI")]
    [JsonProperty("codeSpace")]
    public string CodeSpace {
      get {
        return _codeSpace;
      }
      set {
        if (_codeSpace == value) {
          return;
        }
        if (_codeSpace == null || _codeSpace.Equals(value) != true) {
          _codeSpace = value;
          OnPropertyChanged("CodeSpace");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("uom")]
    public string Uom {
      get {
        return _uom;
      }
      set {
        if (_uom == value) {
          return;
        }
        if (_uom == null || _uom.Equals(value) != true) {
          _uom = value;
          OnPropertyChanged("Uom");
        }
      }
    }

  }

}
