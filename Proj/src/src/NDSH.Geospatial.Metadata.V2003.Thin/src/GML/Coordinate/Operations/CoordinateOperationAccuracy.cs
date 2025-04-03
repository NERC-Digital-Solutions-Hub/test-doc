
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 14:31, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateOperations.xsd
// --------------------------------------------------------------------------------
// <element name="coordinateOperationAccuracy">
//   <complexType>
//     <sequence minOccurs="0">
//       <element ref="gmd:AbstractDQ_PositionalAccuracy"/>
//     </sequence>
//     <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   </complexType>
// </element>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.PositionalAccuracy;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Operations
{

  /// <summary>
  /// CoordinateOperationAccuracy is an association role to a DQ_PositionalAccuracy object as encoded
  /// in ISO/TS 19139, either referencing or containing the definition of that positional accuracy.
  /// That object contains an estimate of the impact of this coordinate operation on point accuracy.
  /// That is, it gives position error estimates for the target coordinates of this coordinate operation,
  /// assuming no errors in the source coordinates.
  /// </summary>
  [Serializable]
  [XmlType("coordinateOperationAccuracy", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("coordinateOperationAccuracy")]
  public class CoordinateOperationAccuracy : Association
  {

    #region Public Properties

    private AbstractDQ_PositionalAccuracy_Type _abstractDQ_PositionalAccuracy;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractDQ_PositionalAccuracy", Namespace = "http://www.isotc211.org/2005/gmd", Order = 0)]
    [JsonProperty("AbstractDQ_PositionalAccuracy", Order = 0)]
    public AbstractDQ_PositionalAccuracy_Type AbstractDQ_PositionalAccuracy
    {
      get
      {
        return _abstractDQ_PositionalAccuracy;
      }
      set
      {
        if (_abstractDQ_PositionalAccuracy == value)
        {
          return;
        }
        if (_abstractDQ_PositionalAccuracy == null || _abstractDQ_PositionalAccuracy.Equals(value) != true)
        {
          _abstractDQ_PositionalAccuracy = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
