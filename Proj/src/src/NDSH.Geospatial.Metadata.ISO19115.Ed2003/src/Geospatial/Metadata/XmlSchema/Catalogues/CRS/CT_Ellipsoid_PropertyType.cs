
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
// <xs:complexType name="CT_Ellipsoid_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gml:Ellipsoid"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Coordinate.Datums;
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
  //[XmlType("CT_Ellipsoid_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_Ellipsoid_PropertyType")]
  public class CT_Ellipsoid_PropertyType : ReferenceEntity {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_Ellipsoid_PropertyType"/>.
    /// </summary>
    public CT_Ellipsoid_PropertyType() {
      _ellipsoid = default; //  new EllipsoidType();
    }

    #endregion

    #region Public Properties

    private EllipsoidType _ellipsoid;

    //[XmlElement("Ellipsoid", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("Ellipsoid", Order = 0)]
    public EllipsoidType Ellipsoid {
      get => _ellipsoid;
      set => SetProperty(ref _ellipsoid, value);
    }

    #endregion

  }

}
