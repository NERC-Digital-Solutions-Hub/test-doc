
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
// XSD               : /2005/gml/coverage
// ---------------------------------------------------------------------------------------------------------------------
// <element name="rangeSet" type="gml:RangeSetType">
//   <annotation>
//     <documentation>
//       The gml:rangeSet property element contains the values of the coverage (sometimes called the attribute values).
//       Its content model is given by gml:RangeSetType. This content model supports a structural description
//       of the range. The semantic information describing the range set is embedded using a uniform method,
//       as part of the explicit values, or as a template value accompanying the representation using gml:DataBlock
//       and gml:File. The values from each component (or “band”) in the range may be encoded within a gml:ValueArray
//       element or a concrete member of the gml:AbstractScalarValueList substitution group . Use of these elements
//       satisfies the value-type homogeneity requirement.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="RangeSetType">
//   <choice>
//     <element ref="gml:ValueArray" maxOccurs="unbounded"/>
//     <element ref="gml:AbstractScalarValueList" maxOccurs="unbounded"/>
//     <element ref="gml:DataBlock"/>
//     <element ref="gml:File"/>
//   </choice>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;

using NDSH.Geospatial.Gml.ValueObjects;
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

  [IsoType("RangeSetType", IsoType = IsoTypes.ComplexType)]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("RangeSetType")]
  public class RangeSetType : ObservableModel {

    #region Private fields
    private List<object> _items;
    #endregion

    /// <summary>
    /// RangeSetType class constructor
    /// </summary>
    public RangeSetType() {
      _items = new List<object>();
    }

    [XmlElement("AbstractScalarValueList", typeof(object), Order = 0)]
    [XmlElement("DataBlock", typeof(DataBlockType), Order = 0)]
    [XmlElement("File", typeof(FileType), Order = 0)]
    [XmlElement("ValueArray", typeof(ValueArrayType), Order = 0)]
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

  }

}
