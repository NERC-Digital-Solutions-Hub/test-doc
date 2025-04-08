
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 27/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gsr/spatialReferencing.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="SC_CRS_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gml:AbstractCRS"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ReferenceSystem {

  /// <summary>
  /// Defines a property type for association roles to a CRS abstract coordinate reference system,
  /// either referencing or containing the definition of that CRS.
  /// </summary>
  [Serializable]
  [XmlType("SC_CRS_PropertyType", Namespace = "http://www.isotc211.org/2005/gsr")]
  [JsonObject("SC_CRS_PropertyType")]
  public class SC_CRS_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractCRSType _abstractCRS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractCRS", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractCRS", Order = 0)]
    public AbstractCRSType AbstractCRS {
      get {
        return _abstractCRS;
      }
      set {
        if (_abstractCRS == value) {
          return;
        }
        if (_abstractCRS == null || !_abstractCRS.Equals(value)) {
          _abstractCRS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
