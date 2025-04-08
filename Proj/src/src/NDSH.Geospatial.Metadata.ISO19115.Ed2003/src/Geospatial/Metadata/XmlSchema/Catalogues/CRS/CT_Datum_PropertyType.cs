
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
// <xs:complexType name="CT_Datum_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gml:AbstractDatum"/>
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
  //[XmlType("CT_Datum_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_Datum_PropertyType")]
  public class CT_Datum_PropertyType : ReferenceEntity {

    #region Public Properties

    private AbstractDatumType _abstractDatum;

    [XmlElement("AbstractDatum", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractDatum", Order = 0)]
    public AbstractDatumType AbstractDatum {
      get => _abstractDatum;
      set => SetProperty(ref _abstractDatum, value);
    }

    #endregion

  }

}
