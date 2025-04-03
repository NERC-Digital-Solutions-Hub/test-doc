
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
// XSD               : 
// ---------------------------------------------------------------------------------------------------------------------
// <element name="GridFunction" type="gml:GridFunctionType" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <documentation>
//       gml:GridFunction provides an explicit mapping rule for grid geometries, i.e. the domain shall be a
//       geometry of type grid. It describes the mapping of grid posts (discrete point grid coverage) or
//       grid cells (discrete surface coverage) to the values in the range set.
//       The gml:startPoint is the index position of a point in the grid that is mapped to the first point
//       in the range set (this is also the index position of the first grid post).
//       If the gml:startPoint property is omitted the gml:startPoint is assumed to be equal to the value of
//       gml:low in the gml:Grid geometry. Subsequent points in the mapping are determined by
//       the value of the gml:sequenceRule.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="GridFunctionType">
//   <sequence>
//     <element name="sequenceRule" type="gml:SequenceRuleType" minOccurs="0"/>
//     <element name="startPoint" type="gml:integerList" minOccurs="0"/>
//   </sequence>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;

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

  [IsoType("GridFunctionType", IsoType = IsoTypes.ComplexType)]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GridFunctionType")]
  public class GridFunctionType : ObservableModel {

    #region Private fields
    private SequenceRuleType _sequenceRule;
    private string _startPoint;
    #endregion

    /// <summary>
    /// GridFunctionType class constructor
    /// </summary>
    public GridFunctionType() {
      _sequenceRule = new SequenceRuleType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("sequenceRule", Order = 0)]
    public SequenceRuleType SequenceRule {
      get {
        return _sequenceRule;
      }
      set {
        if (_sequenceRule == value) {
          return;
        }
        if (_sequenceRule == null || _sequenceRule.Equals(value) != true) {
          _sequenceRule = value;
          OnPropertyChanged("SequenceRule");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("startPoint", Order = 1)]
    public string StartPoint {
      get {
        return _startPoint;
      }
      set {
        if (_startPoint == value) {
          return;
        }
        if (_startPoint == null || _startPoint.Equals(value) != true) {
          _startPoint = value;
          OnPropertyChanged("StartPoint");
        }
      }
    }

  }

}
