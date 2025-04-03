
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 02:05, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gmi/spatialRepresentationInformation.xsd
// --------------------------------------------------------------------------------
// <!--==XCGE: gml:DirectPosition==-->
// <xs:complexType name="DirectPosition_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gml:pos"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DirectPosition_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("DirectPosition_PropertyType")]
  public class DirectPosition_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DirectPosition_PropertyType"/>.
    /// </summary>
    public DirectPosition_PropertyType() {
      _directposition_PropertyType = default; // new DirectPosition_Type();
    }

    #endregion

    #region Public Properties

    // TODO: DANGER!!! - Make sure that the DirectPositionType is the one that is referenced in the /2005/gmi/spatialRepresentationInformation.xsd
    private DirectPositionType _directposition_PropertyType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DirectPosition", Order = 0)]
    [JsonProperty("DirectPosition", Order = 0)]
    public DirectPositionType DirectPosition {
      get {
        return _directposition_PropertyType;
      }
      set {
        if (_directposition_PropertyType == value) {
          return;
        }
        if (_directposition_PropertyType == null || _directposition_PropertyType.Equals(value) != true) {
          _directposition_PropertyType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
