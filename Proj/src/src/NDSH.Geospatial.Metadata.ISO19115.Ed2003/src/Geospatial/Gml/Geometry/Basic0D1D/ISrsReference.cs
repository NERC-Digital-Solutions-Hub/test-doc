
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 30/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : XML Data Types documentation
//                     https://learn.microsoft.com/en-us/dotnet/standard/data/xml/mapping-xml-data-types-to-clr-types
//                     How to implement NCName:
//                     https://stackoverflow.com/questions/1631396/what-is-an-xsncname-type-and-when-should-it-be-used
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/geometryBasic0d1d.xsd
//                     /2005/gml/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <attributeGroup name="SRSReferenceGroup">
//   <attribute name="srsName" type="anyURI"/>
//   <attribute name="srsDimension" type="positiveInteger"/>
//   <attributeGroup ref="gml:SRSInformationGroup"/>
// </attributeGroup>
//
// <attributeGroup name="SRSInformationGroup">
//   <attribute name="axisLabels" type="gml:NCNameList"/>
//   <attribute name="uomLabels" type="gml:NCNameList"/>
// </attributeGroup>
//
// <simpleType name="NCNameList">
//   <list itemType="NCName"/>
// </simpleType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Geometry.Basic0D1D {

  // WARNING: REVISIT

  /// <summary>
  /// The attribute group SRSReferenceGroup is an optional reference to the CRS used
  /// by this geometry, with optional additional information to simplify the processing
  /// of the coordinates when a more complete definition of the CRS is not needed.
  /// In general the attribute srsName points to a CRS instance of
  /// gml:AbstractCoordinateReferenceSystem.For well-known references it is not required
  /// that the CRS description exists at the location the URI points to.
  /// If no srsName attribute is given, the CRS shall be specified as part of the larger
  /// context this geometry element is part of.
  /// </summary>
  //TODO: Improve documentation
  public interface ISrsReference : ISrsInformation {

    #region Public Properties

    //[XmlAttribute("srsName", DataType = "anyURI")]
    //[JsonProperty("srsName")]
    public string SrsName {
      get;
      set;
    }

    //[XmlAttribute("srsDimension", DataType = "positiveInteger")]
    //[JsonProperty("srsDimension")]
    public string SrsDimension {
      get;
      set;
    }

    #endregion

  }

}
