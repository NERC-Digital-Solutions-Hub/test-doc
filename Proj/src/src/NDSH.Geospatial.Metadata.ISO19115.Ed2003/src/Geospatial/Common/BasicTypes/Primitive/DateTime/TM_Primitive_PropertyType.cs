
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gts/temporalObjects.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="TM_Primitive_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gml:AbstractTimePrimitive"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Temporal;
using NDSH.Geospatial.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime {

  [Serializable]
  [XmlType("TM_Primitive_PropertyType", Namespace = "http://www.isotc211.org/2005/gts")]
  [JsonObject("TM_Primitive_PropertyType")]
  public class TM_Primitive_PropertyType : ReferenceEntity {

    #region Public Properties

    private AbstractTimePrimitiveType _abstractTimePrimitive;

    [XmlElement("AbstractTimePrimitive", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractTimePrimitive", Order = 0)]
    public AbstractTimePrimitiveType AbstractTimePrimitive {
      get => _abstractTimePrimitive;
      set {
        if (_abstractTimePrimitive == value) {
          return;
        }
        if (_abstractTimePrimitive == null || !_abstractTimePrimitive.Equals(value)) {
          _abstractTimePrimitive = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
