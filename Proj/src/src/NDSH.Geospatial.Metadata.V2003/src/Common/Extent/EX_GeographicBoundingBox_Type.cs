
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 22/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Numerics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common.Extent {

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
      _westBoundLongitude = default; //  new Decimal_PropertyType();
      _eastBoundLongitude = default; //  new Decimal_PropertyType();
      _southBoundLatitude = default; //  new Decimal_PropertyType();
      _northBoundLatitude = default; //  new Decimal_PropertyType();
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
    public Decimal_PropertyType WestBoundLongitude {
      get => _westBoundLongitude;
      set {
        if (_westBoundLongitude == value) {
          return;
        }
        if (_westBoundLongitude == null || !_westBoundLongitude.Equals(value)) {
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
    public Decimal_PropertyType EastBoundLongitude {
      get => _eastBoundLongitude;
      set {
        if (_eastBoundLongitude == value) {
          return;
        }
        if (_eastBoundLongitude == null || !_eastBoundLongitude.Equals(value)) {
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
    public Decimal_PropertyType SouthBoundLatitude {
      get => _southBoundLatitude;
      set {
        if (_southBoundLatitude == value) {
          return;
        }
        if (_southBoundLatitude == null || !_southBoundLatitude.Equals(value)) {
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
    public Decimal_PropertyType NorthBoundLatitude {
      get => _northBoundLatitude;
      set {
        if (_northBoundLatitude == value) {
          return;
        }
        if (_northBoundLatitude == null || !_northBoundLatitude.Equals(value)) {
          _northBoundLatitude = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
