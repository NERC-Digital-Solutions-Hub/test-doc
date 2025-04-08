
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 04/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/crsItem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="CT_CoordinateSystemAxis_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gml:CoordinateSystemAxis"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Coordinate.Systems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS {

  // WARNING: REFACTOR - This is a property type wrapping a GML type.

  [Serializable]
  //[XmlType("CT_CoordinateSystemAxis_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_CoordinateSystemAxis_PropertyType")]
  public class CT_CoordinateSystemAxis_PropertyType : ReferenceEntity {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_CoordinateSystemAxis_PropertyType"/>.
    /// </summary>
    public CT_CoordinateSystemAxis_PropertyType() {
      _coordinateSystemAxis = default; //  new CoordinateSystemAxisType();
    }

    #endregion

    #region Public Properties

    private CoordinateSystemAxisType _coordinateSystemAxis;

    //[XmlElement("CoordinateSystemAxis", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("CoordinateSystemAxis", Order = 0)]
    public CoordinateSystemAxisType CoordinateSystemAxis {
      get => _coordinateSystemAxis;
      set => SetProperty(ref _coordinateSystemAxis, value);
    }

    #endregion

  }

}
