
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
// <element name="coverageFunction" type="gml:CoverageFunctionType" substitutionGroup="gml:AbstractObject">
// 	<annotation>
// 		<documentation>
// 		  The gml:coverageFunction property describes the mapping function from the domain to the range of the coverage.
// 		  The value of the CoverageFunction is one of gml:CoverageMappingRule and gml:GridFunction.
// 		  If the gml:coverageFunction property is omitted for a gridded coverage (including rectified gridded coverages)
// 		  the gml:startPoint is assumed to be the value of the gml:low property in the gml:Grid geometry,
// 		  and the gml:sequenceRule is assumed to be linear and the gml:axisOrder property is assumed to be “+1 +2”.
// 		</documentation>
// 	</annotation>
// </element>
// 
// <complexType name="CoverageFunctionType">
// 	<choice>
// 		<element ref="gml:MappingRule"/>
// 		<element ref="gml:CoverageMappingRule"/>
// 		<element ref="gml:GridFunction"/>
// 	</choice>
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

  [IsoType("CoverageFunctionType", IsoType = IsoTypes.ComplexType)]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CoverageFunctionType")]
  public class CoverageFunctionType : ObservableModel {

    #region Private fields
    private object _item;
    #endregion

    [XmlElement("CoverageMappingRule", typeof(MappingRuleType), Order = 0)]
    [XmlElement("GridFunction", typeof(GridFunctionType), Order = 0)]
    [XmlElement("MappingRule", typeof(StringOrRefType), Order = 0)]
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
