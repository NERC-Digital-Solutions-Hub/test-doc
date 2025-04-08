
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 20:07, @gisvlasta.
// Updated by        : 09/01/2023, 18:23, @gisvlasta. - 1.0.1: Added xmlns field.
//                   : 08/02/2023, 00:50, @gisvlasta. - 1.0.2: Added [XmlInclude]s.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Records;
using NDSH.Geospatial.Metadata.V2003.Imagery.Content;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Content {

  /// <summary>
  /// Information about the domain of the raster cell.
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(MI_ImageDescription_Type))]
  [XmlInclude(typeof(MI_CoverageDescription_Type))]
  [XmlInclude(typeof(MD_ImageDescription_Type))]
  [XmlType("MD_CoverageDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_CoverageDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_CoverageDescription")]
  public class MD_CoverageDescription_Type : AbstractMD_ContentInformation_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_CoverageDescription_Type"/>.
    /// </summary>
    public MD_CoverageDescription_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _attributeDescription  = default; //  new RecordType_PropertyType();
      _contentType  = default; //  new MD_CoverageContentTypeCode_PropertyType();
      _dimension  = default; //  new List<MD_RangeDimension_PropertyType>();
      
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

    private RecordType_PropertyType _attributeDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("attributeDescription", Order = 0)]
    [JsonProperty("attributeDescription", Order = 0)]
    public RecordType_PropertyType AttributeDescription {
      get {
        return _attributeDescription;
      }
      set {
        if (_attributeDescription == value) {
          return;
        }
        if (_attributeDescription == null || _attributeDescription.Equals(value) != true) {
          _attributeDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_CoverageContentTypeCode_PropertyType _contentType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("contentType", Order = 1)]
    [JsonProperty("contentType", Order = 1)]
    public MD_CoverageContentTypeCode_PropertyType ContentType {
      get {
        return _contentType;
      }
      set {
        if (_contentType == value) {
          return;
        }
        if (_contentType == null || _contentType.Equals(value) != true) {
          _contentType = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_RangeDimension_PropertyType> _dimension;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dimension", Order = 2)]
    [JsonProperty("dimension", Order = 2)]
    public List<MD_RangeDimension_PropertyType> Dimension {
      get {
        return _dimension;
      }
      set {
        if (_dimension == value) {
          return;
        }
        if (_dimension == null || _dimension.Equals(value) != true) {
          _dimension = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}