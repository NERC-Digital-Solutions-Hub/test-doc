
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 19:10, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent {

  /// <summary>
  /// Geographic area of the entire dataset referenced to WGS 84.
  /// </summary>
  [Serializable]
  [XmlType("EX_GeographicBoundingBox", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("EX_GeographicBoundingBox", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_GeographicBoundingBox")]
  public class EX_GeographicBoundingBox_Type : AbstractEX_GeographicExtent_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_GeographicBoundingBox_Type"/>.
    /// </summary>
    public EX_GeographicBoundingBox_Type() {
      _westBoundLongitude  = default; //  new Decimal_PropertyType();
      _eastBoundLongitude  = default; //  new Decimal_PropertyType();
      _southBoundLatitude  = default; //  new Decimal_PropertyType();
      _northBoundLatitude  = default; //  new Decimal_PropertyType();
    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Private fields

    private Decimal_PropertyType _westBoundLongitude;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("westBoundLongitude", Order = 0)]
    [JsonProperty("westBoundLongitude", Order = 0)]
    public Decimal_PropertyType westBoundLongitude {
      get {
        return _westBoundLongitude;
      }
      set {
        if (_westBoundLongitude == value) {
          return;
        }
        if (_westBoundLongitude == null || _westBoundLongitude.Equals(value) != true) {
          _westBoundLongitude = value;
          OnPropertyChanged();
        }
      }
    }

    private Decimal_PropertyType _eastBoundLongitude;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("eastBoundLongitude", Order = 1)]
    [JsonProperty("eastBoundLongitude", Order = 1)]
    public Decimal_PropertyType eastBoundLongitude {
      get {
        return _eastBoundLongitude;
      }
      set {
        if (_eastBoundLongitude == value) {
          return;
        }
        if (_eastBoundLongitude == null || _eastBoundLongitude.Equals(value) != true) {
          _eastBoundLongitude = value;
          OnPropertyChanged();
        }
      }
    }

    private Decimal_PropertyType _southBoundLatitude;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("southBoundLatitude", Order = 2)]
    [JsonProperty("southBoundLatitude", Order = 2)]
    public Decimal_PropertyType southBoundLatitude {
      get {
        return _southBoundLatitude;
      }
      set {
        if (_southBoundLatitude == value) {
          return;
        }
        if (_southBoundLatitude == null || _southBoundLatitude.Equals(value) != true) {
          _southBoundLatitude = value;
          OnPropertyChanged();
        }
      }
    }

    private Decimal_PropertyType _northBoundLatitude;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("northBoundLatitude", Order = 3)]
    [JsonProperty("northBoundLatitude", Order = 3)]
    public Decimal_PropertyType northBoundLatitude {
      get {
        return _northBoundLatitude;
      }
      set {
        if (_northBoundLatitude == value) {
          return;
        }
        if (_northBoundLatitude == null || _northBoundLatitude.Equals(value) != true) {
          _northBoundLatitude = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}