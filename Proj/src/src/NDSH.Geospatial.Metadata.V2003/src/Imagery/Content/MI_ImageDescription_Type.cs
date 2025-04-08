
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 11:40, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime;
using NDSH.Geospatial.Metadata.V2003.Content;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_ImageDescription", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_ImageDescription", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_ImageDescription")]
  public class MI_ImageDescription_Type : MD_ImageDescription_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_ImageDescription_Type"/>
    /// </summary>
    public MI_ImageDescription_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _rangeElementDescription = default; // new List<MI_RangeElementDescription_PropertyType>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public new XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<MI_RangeElementDescription_PropertyType> _rangeElementDescription;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("rangeElementDescription", Order = 0)]
    [JsonProperty("rangeElementDescription", Order = 0)]
    public List<MI_RangeElementDescription_PropertyType> RangeElementDescription {
      get {
        return _rangeElementDescription;
      }
      set {
        if (_rangeElementDescription == value) {
          return;
        }
        if (_rangeElementDescription == null || _rangeElementDescription.Equals(value) != true) {
          _rangeElementDescription = value;
          OnPropertyChanged();
        }
      }
    }


    #endregion

  }

}
