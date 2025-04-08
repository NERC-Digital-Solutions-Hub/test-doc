
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
using NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common.Extent {

  /// <summary>
  /// Vertical domain of dataset.
  /// </summary>
  [Serializable]
  [XmlType("EX_VerticalExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("EX_VerticalExtent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_VerticalExtent")]
  public class EX_VerticalExtent_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_VerticalExtent_Type"/>.
    /// </summary>
    // WARNING: What is the required modifier?
    public EX_VerticalExtent_Type() {
      _minimumValue = default; //  new Real_PropertyType();
      _maximumValue = default; //  new Real_PropertyType();
      _verticalCRS = default; //  new SC_CRS_PropertyType();
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

    private Real_PropertyType _minimumValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("minimumValue", Order = 0)]
    [JsonProperty("minimumValue", Order = 0)]
    public Real_PropertyType MinimumValue {
      get => _minimumValue;
      set {
        if (_minimumValue == value) {
          return;
        }
        if (_minimumValue == null || !_minimumValue.Equals(value)) {
          _minimumValue = value;
          OnPropertyChanged();
        }
      }
    }

    private Real_PropertyType _maximumValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("maximumValue", Order = 1)]
    [JsonProperty("maximumValue", Order = 1)]
    public Real_PropertyType MaximumValue {
      get => _maximumValue;
      set {
        if (_maximumValue == value) {
          return;
        }
        if (_maximumValue == null || !_maximumValue.Equals(value)) {
          _maximumValue = value;
          OnPropertyChanged();
        }
      }
    }

    private CRSPropertyType _verticalCRS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("verticalCRS", Order = 2)]
    [JsonProperty("verticalCRS", Order = 2)]
    public CRSPropertyType VerticalCRS {
      get => _verticalCRS;
      set {
        if (_verticalCRS == value) {
          return;
        }
        if (_verticalCRS == null || !_verticalCRS.Equals(value)) {
          _verticalCRS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
