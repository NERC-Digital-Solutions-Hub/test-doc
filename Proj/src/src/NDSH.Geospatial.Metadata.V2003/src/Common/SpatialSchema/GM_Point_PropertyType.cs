
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.Common.SpatialSchema.csproj
// Created           : 24/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
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

namespace NDSH.Geospatial.Metadata.V2003.Common.SpatialSchema {

  /// <summary>
  /// Represents a property type that references a point geometry within a spatial schema.
  /// This class extends <see cref="ObjectReference_PropertyType"/> to support the association of
  /// a point object with its referencing metadata.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     The <see cref="GM_Point_PropertyType"/> class is designed to encapsulate
  ///     a point geometry while maintaining an association with its metadata
  ///     reference and it aligns with the ISO 19107 spatial schema.
  ///   </para>
  ///   <para>
  ///     <b>Key Features:</b>
  ///     <list type="bullet">
  ///       <item>Extends <see cref="ObjectReference_PropertyType"/> to support spatial referencing.</item>
  ///       <item>Encapsulates a GML-compatible <see cref="PointType"/>.</item>
  ///       <item>Ensures compatibility with ISO 19107 and ISO 19115 metadata standards.</item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     <b>Considerations:</b>
  ///     <list type="bullet">
  ///       <item>The <see cref="Point"/> property holds the referenced point geometry object.</item>
  ///       <item>Ensures proper change tracking for data binding scenarios.</item>
  ///     </list>
  ///   </para>
  /// </remarks>
  [Serializable]
  [XmlType("GM_Point_PropertyType", Namespace = "http://www.isotc211.org/2005/gss")]
  [JsonObject("GM_Point_PropertyType")]
  public class GM_Point_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GM_Point_PropertyType"/>.
    /// </summary>
    public GM_Point_PropertyType() {
      _point = default; //  new PointType();
    }

    #endregion

    #region Public Properties

    private PointType _point;

    /// <summary>
    /// Gets or sets the referenced point geometry.
    /// This property stores a point instance that is associated with a metadata reference.
    /// </summary>
    [XmlElement("Point", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("Point", Order = 0)]
    public PointType Point {
      get => _point;
      set {
        if (_point == value) {
          return;
        }
        if (_point == null || !_point.Equals(value)) {
          _point = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
