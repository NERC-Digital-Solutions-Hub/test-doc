
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
  /// Represents a property type that references a geometric object within a spatial schema.
  /// This class extends <see cref="ObjectReference_PropertyType"/> to support the association of
  /// a geometry object with its referencing metadata.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     The <see cref="GM_Object_PropertyType"/> class is designed to encapsulate
  ///     a geometric object while maintaining an association with its metadata
  ///     reference and it aligns with the ISO 19107 spatial schema.
  ///   </para>
  ///   <para>
  ///     <b>Key Features:</b>
  ///     <list type="bullet">
  ///       <item>Extends <see cref="ObjectReference_PropertyType"/> to support spatial referencing.</item>
  ///       <item>Encapsulates a GML-compatible <see cref="AbstractGeometryType"/>.</item>
  ///       <item>Ensures compatibility with ISO 19107 and ISO 19115 metadata standards.</item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     <b>Considerations:</b>
  ///     <list type="bullet">
  ///       <item>The <see cref="AbstractGeometry"/> property holds the referenced geometry object.</item>
  ///       <item>Ensures proper change tracking for data binding scenarios.</item>
  ///     </list>
  ///   </para>
  /// </remarks>
  [Serializable]
  [XmlType("GM_Object_PropertyType", Namespace = "http://www.isotc211.org/2005/gss")]
  [JsonObject("GM_Object_PropertyType")]
  public class GM_Object_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractGeometryType _abstractGeometry;

    /// <summary>
    /// Gets or sets the referenced geometric object.
    /// This property stores a geometry instance that is associated with a metadata reference.
    /// </summary>
    [XmlElement("AbstractGeometry", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractGeometry", Order = 0)]
    public AbstractGeometryType AbstractGeometry {
      get => _abstractGeometry;
      set {
        if (_abstractGeometry == value) {
          return;
        }
        if (_abstractGeometry == null || !_abstractGeometry.Equals(value)) {
          _abstractGeometry = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
