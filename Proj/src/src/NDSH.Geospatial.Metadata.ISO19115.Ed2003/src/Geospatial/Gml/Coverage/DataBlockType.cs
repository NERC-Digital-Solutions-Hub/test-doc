
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
// <element name="DataBlock" type="gml:DataBlockType" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <documentation>
//       gml:DataBlock describes the Range as a block of text encoded values similar
//       to a Common Separated Value (CSV) representation.
//       The range set parameterization is described by the property gml:rangeParameters.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="DataBlockType">
//   <sequence>
//     <element ref="gml:rangeParameters"/>
//     <choice>
//       <element ref="gml:tupleList"/>
//       <element ref="gml:doubleOrNilReasonTupleList"/>
//     </choice>
//   </sequence>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;

using NDSH.Geospatial.Gml.BasicTypes;
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

  [IsoType("DataBlockType", IsoType = IsoTypes.ComplexType)]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DataBlockType")]
  public class DataBlockType : ObservableModel {

    #region Private fields
    private RangeParametersType _rangeParameters;
    private object _item;
    #endregion

    /// <summary>
    /// DataBlockType class constructor
    /// </summary>
    public DataBlockType() {
      _rangeParameters = new RangeParametersType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("rangeParameters", Order = 0)]
    public RangeParametersType RangeParameters {
      get {
        return _rangeParameters;
      }
      set {
        if (_rangeParameters == value) {
          return;
        }
        if (_rangeParameters == null || _rangeParameters.Equals(value) != true) {
          _rangeParameters = value;
          OnPropertyChanged("RangeParameters");
        }
      }
    }

    [XmlElement("doubleOrNilReasonTupleList", typeof(string), Order = 1)]
    [XmlElement("tupleList", typeof(CoordinatesType), Order = 1)]
    public object Item {
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

  }

}
