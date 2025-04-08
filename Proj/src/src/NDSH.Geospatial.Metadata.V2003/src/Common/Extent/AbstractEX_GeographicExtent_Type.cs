
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

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Truth;
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
  /// Geographic area of the dataset.
  /// </summary>
  //[XmlInclude(typeof(EX_GeographicDescription_Type))]
  //[XmlInclude(typeof(EX_GeographicBoundingBox_Type))]
  //[XmlInclude(typeof(EX_BoundingPolygon_Type))]
  [Serializable]
  [XmlType("AbstractEX_GeographicExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("AbstractEX_GeographicExtent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractEX_GeographicExtent")]
  public abstract class AbstractEX_GeographicExtent_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractEX_GeographicExtent_Type"/>.
    /// </summary>
    public AbstractEX_GeographicExtent_Type() {
      _extentTypeCode = default; //  new Boolean_PropertyType();
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

    private Boolean_PropertyType _extentTypeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("extentTypeCode", Order = 0)]
    [JsonProperty("extentTypeCode", Order = 0)]
    public Boolean_PropertyType ExtentTypeCode {
      get => _extentTypeCode;
      set {
        if (_extentTypeCode == value) {
          return;
        }
        if (_extentTypeCode == null || !_extentTypeCode.Equals(value)) {
          _extentTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
