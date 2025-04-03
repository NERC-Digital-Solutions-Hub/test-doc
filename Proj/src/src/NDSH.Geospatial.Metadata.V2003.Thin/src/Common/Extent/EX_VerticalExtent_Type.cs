
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 20:25, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent {

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
    public EX_VerticalExtent_Type() {
      _minimumValue  = default; //  new Real_PropertyType();
      _maximumValue  = default; //  new Real_PropertyType();
      _verticalCRS  = default; //  new SC_CRS_PropertyType();
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
      get {
        return _minimumValue;
      }
      set {
        if (_minimumValue == value) {
          return;
        }
        if (_minimumValue == null || _minimumValue.Equals(value) != true) {
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
      get {
        return _maximumValue;
      }
      set {
        if (_maximumValue == value) {
          return;
        }
        if (_maximumValue == null || _maximumValue.Equals(value) != true) {
          _maximumValue = value;
          OnPropertyChanged();
        }
      }
    }

    private SC_CRS_PropertyType _verticalCRS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("verticalCRS", Order = 2)]
    [JsonProperty("verticalCRS", Order = 2)]
    public SC_CRS_PropertyType VerticalCRS {
      get {
        return _verticalCRS;
      }
      set {
        if (_verticalCRS == value) {
          return;
        }
        if (_verticalCRS == null || _verticalCRS.Equals(value) != true) {
          _verticalCRS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}