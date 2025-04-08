
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 20:14, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.DateTime;
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
  /// Time period covered by the content of the dataset.
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(EX_SpatialTemporalExtent_Type))] // TODO: Check this XmlInclude
  [XmlType("EX_TemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("EX_TemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_TemporalExtent")]
  public class EX_TemporalExtent_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_TemporalExtent_Type"/>.
    /// </summary>
    public EX_TemporalExtent_Type() {
      _extent  = default; //  new TM_Primitive_PropertyType();
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

    private TM_Primitive_PropertyType _extent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("extent", Order = 0)]
    [JsonProperty("extent", Order = 0)]
    public TM_Primitive_PropertyType Extent {
      get {
        return _extent;
      }
      set {
        if (_extent == value) {
          return;
        }
        if (_extent == null || _extent.Equals(value) != true) {
          _extent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}