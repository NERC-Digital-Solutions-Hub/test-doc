
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 04:26, @gisvlasta.
// Updated by        : 09/01/2023, 20:56, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Numerics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_GeometricObjects", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_GeometricObjects", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_GeometricObjects")]
  public class MD_GeometricObjects_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_GeometricObjects_Type"/>.
    /// </summary>
    public MD_GeometricObjects_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _geometricObjectType  = default; //  new MD_GeometricObjectTypeCode_PropertyType();
      _geometricObjectCount  = default; //  new Integer_PropertyType();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private MD_GeometricObjectTypeCode_PropertyType _geometricObjectType;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("geometricObjectType", Order = 0)]
    [JsonProperty("geometricObjectType", Order = 0)]
    public MD_GeometricObjectTypeCode_PropertyType GeometricObjectType {
      get {
        return _geometricObjectType;
      }
      set {
        if (_geometricObjectType == value) {
          return;
        }
        if (_geometricObjectType == null || _geometricObjectType.Equals(value) != true) {
          _geometricObjectType = value;
          OnPropertyChanged();
        }
      }
    }

    private Integer_PropertyType _geometricObjectCount;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("geometricObjectCount", Order = 1)]
    [JsonProperty("geometricObjectCount", Order = 1)]
    public Integer_PropertyType GeometricObjectCount {
      get {
        return _geometricObjectCount;
      }
      set {
        if (_geometricObjectCount == value) {
          return;
        }
        if (_geometricObjectCount == null || _geometricObjectCount.Equals(value) != true) {
          _geometricObjectCount = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
