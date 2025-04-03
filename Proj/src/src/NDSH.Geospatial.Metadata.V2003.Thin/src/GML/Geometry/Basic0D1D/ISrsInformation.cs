
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 31/01/2023, 00:23, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : XML Data Types documentation
//                     https://learn.microsoft.com/en-us/dotnet/standard/data/xml/mapping-xml-data-types-to-clr-types
//                     How to implement NCName:
//                     https://stackoverflow.com/questions/1631396/what-is-an-xsncname-type-and-when-should-it-be-used
// --------------------------------------------------------------------------------
// XSD               : /2005/gml/geometryBasic0d1d.xsd
//                     /2005/gml/basicTypes.xsd
// --------------------------------------------------------------------------------
// <attributeGroup name="SRSInformationGroup">
//   <attribute name="axisLabels" type="gml:NCNameList"/>
//   <attribute name="uomLabels" type="gml:NCNameList"/>
// </attributeGroup>
//
// <simpleType name="NCNameList">
//   <list itemType="NCName"/>
// </simpleType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D {

  /// <summary>
  /// The attributes UomLabels and AxisLabels are optional additional and redundant
  /// information for a CRS to simplify the processing of the coordinate values when
  /// a more complete definition of the CRS is not needed. This information shall be
  /// the same as included in the complete definition of the CRS, referenced by the
  /// srsName attribute. When the srsName attribute is included, either both or neither
  /// of the axisLabels and uomLabels attributes shall be included. When the srsName
  /// attribute is omitted, both of these attributes shall be omitted. The attribute
  /// axisLabels is an ordered list of labels for all the axes of this CRS.
  /// The gml:axisAbbrev value should be used for these axis labels, after spaces and
  /// forbidden characters are removed.When the srsName attribute is included,
  /// this attribute is optional.When the srsName attribute is omitted,
  /// this attribute shall also be omitted. The attribute uomLabels is an ordered list
  /// of unit of measure (uom) labels for all the axes of this CRS.The value of the
  /// string in the gml:catalogSymbol should be used for this uom labels,
  /// after spaces and forbidden characters are removed.
  /// When the axisLabels attribute is included, this attribute shall also be included.
  /// When the axisLabels attribute is omitted, this attribute shall also be omitted.
  /// </summary>
  public interface ISrsInformation {

    #region Public Properties

    /// <summary>
    /// 
    /// </summary>
    //[XmlAttribute("axisLabel")]
    //[JsonProperty("axisLabel")]
    public List<string> AxisLabel {
      get;
      set;
    }

    /// <summary>
    /// 
    /// </summary>
    //[XmlAttribute("uomLabels")]
    //[JsonProperty("uomLabels")]
    public List<string> UomLabels {
      get;
      set;
    }

    #endregion

  }

}
