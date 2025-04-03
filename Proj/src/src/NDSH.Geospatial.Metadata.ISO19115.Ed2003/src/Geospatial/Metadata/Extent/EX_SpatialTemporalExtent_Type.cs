
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 22/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/extent.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="EX_SpatialTemporalExtent_Type">
//   <xs:annotation>
//     <xs:documentation>Extent with respect to date and time</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:EX_TemporalExtent_Type">
//       <xs:sequence>
//         <xs:element name="spatialExtent" type="gmd:EX_GeographicExtent_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="EX_SpatialTemporalExtent"
//             type="gmd:EX_SpatialTemporalExtent_Type"
//             substitutionGroup="gmd:EX_TemporalExtent"/>
// <xs:complexType name="EX_SpatialTemporalExtent_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:EX_SpatialTemporalExtent"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Extent {

  /// <summary>
  /// Extent with respect to date and time.
  /// </summary>
  [Serializable]
  //[XmlType("EX_SpatialTemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("EX_SpatialTemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_SpatialTemporalExtent")]
  public class EX_SpatialTemporalExtent_Type : EX_TemporalExtent_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_SpatialTemporalExtent_Type"/>.
    /// </summary>
    public EX_SpatialTemporalExtent_Type() {
      _spatialExtent = default; //  new List<AbstractEX_GeographicExtent_Type>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<AbstractEX_GeographicExtent_Type> _spatialExtent;

    /// <summary>
    /// Spatial extent component of composite spatial and temporal extent.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("spatialExtent", Order = 0)]
    [JsonProperty("spatialExtent", Order = 0)]
    public ObservableCollection<AbstractEX_GeographicExtent_Type> SpatialExtent {
      get => _spatialExtent;
      set => SetProperty(ref _spatialExtent, value);
    }

    #endregion

  }

}
