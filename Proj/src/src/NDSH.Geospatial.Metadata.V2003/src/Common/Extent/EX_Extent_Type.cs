﻿
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

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
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
  /// Information about spatial, vertical, and temporal extent.
  /// </summary>
  [Serializable]
  [XmlType("EX_Extent", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("EX_Extent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_Extent")]
  public class EX_Extent_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_Extent_Type"/>.
    /// </summary>
    public EX_Extent_Type() {
      _description = default; //  new CharacterString_PropertyType();
      _geographicElement = default; //  new List<EX_GeographicExtent_PropertyType>();
      _temporalElement = default; //  new List<EX_TemporalExtent_PropertyType>();
      _verticalElement = default; //  new List<EX_VerticalExtent_PropertyType>();
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

    private CharacterString_PropertyType _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 0)]
    [JsonProperty("description", Order = 0)]
    public CharacterString_PropertyType Description {
      get => _description;
      set {
        if (_description == value) {
          return;
        }
        if (_description == null || !_description.Equals(value)) {
          _description = value;
          OnPropertyChanged();
        }
      }
    }

    private List<EX_GeographicExtent_PropertyType> _geographicElement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("geographicElement", Order = 1)]
    [JsonProperty("geographicElement", Order = 1)]
    public List<EX_GeographicExtent_PropertyType> GeographicElement {
      get => _geographicElement;
      set {
        if (_geographicElement == value) {
          return;
        }
        if (_geographicElement == null || !_geographicElement.Equals(value)) {
          _geographicElement = value;
          OnPropertyChanged();
        }
      }
    }

    private List<EX_TemporalExtent_PropertyType> _temporalElement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("temporalElement", Order = 2)]
    [JsonProperty("temporalElement", Order = 2)]
    public List<EX_TemporalExtent_PropertyType> TemporalElement {
      get => _temporalElement;
      set {
        if (_temporalElement == value) {
          return;
        }
        if (_temporalElement == null || !_temporalElement.Equals(value)) {
          _temporalElement = value;
          OnPropertyChanged();
        }
      }
    }

    private List<EX_VerticalExtent_PropertyType> _verticalElement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("verticalElement", Order = 3)]
    [JsonProperty("verticalElement", Order = 3)]
    public List<EX_VerticalExtent_PropertyType> VerticalElement {
      get => _verticalElement;
      set {
        if (_verticalElement == value) {
          return;
        }
        if (_verticalElement == null || !_verticalElement.Equals(value)) {
          _verticalElement = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
