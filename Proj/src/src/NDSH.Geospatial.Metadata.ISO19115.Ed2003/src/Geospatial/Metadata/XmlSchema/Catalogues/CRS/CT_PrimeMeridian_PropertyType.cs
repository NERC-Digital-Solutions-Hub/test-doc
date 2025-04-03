
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
// <xs:complexType name="CT_PrimeMeridian_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gml:PrimeMeridian"/>
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
  //[XmlType("CT_PrimeMeridian_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_PrimeMeridian_PropertyType")]
  public class CT_PrimeMeridian_PropertyType : ReferenceEntity {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_PrimeMeridian_PropertyType"/>.
    /// </summary>
    public CT_PrimeMeridian_PropertyType() {
      _primeMeridian = default; //  new PrimeMeridianType();
    }

    #endregion

    #region Public Properties

    private PrimeMeridianType _primeMeridian;

    //[XmlElement("PrimeMeridian", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("PrimeMeridian", Order = 0)]
    public PrimeMeridianType PrimeMeridian {
      get => _primeMeridian;
      set => SetProperty(ref _primeMeridian, value);
    }

    #endregion

  }

}
