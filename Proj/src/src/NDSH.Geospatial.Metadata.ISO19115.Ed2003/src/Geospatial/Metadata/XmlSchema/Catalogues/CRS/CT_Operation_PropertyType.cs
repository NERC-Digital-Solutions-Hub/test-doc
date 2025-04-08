
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
// XSD:              : /2005/gmx/crsItem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="CT_Operation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gml:AbstractCoordinateOperation"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Coordinate.Operations;
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
  //[XmlType("CT_Operation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_Operation_PropertyType")]
  public class CT_Operation_PropertyType : ReferenceEntity {

    #region Public Properties

    private AbstractCoordinateOperationType _abstractCoordinateOperation;

    //[XmlElement("AbstractCoordinateOperation", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractCoordinateOperation", Order = 0)]
    public AbstractCoordinateOperationType AbstractCoordinateOperation {
      get => _abstractCoordinateOperation;
      set => SetProperty(ref _abstractCoordinateOperation, value);
    }

    #endregion

  }

}
