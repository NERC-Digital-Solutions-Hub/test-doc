
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:44, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Numerics;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_GCPCollection", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_GCPCollection", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_GCPCollection")]
  public class MI_GCPCollection_Type : AbstractMI_GeolocationInformation_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_GCPCollection_Type"/>
    /// </summary>
    public MI_GCPCollection_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _collectionIdentification = default; // new Integer_PropertyType();
      _collectionName = default; // new CharacterString_PropertyType();
      _coordinateReferenceSystem = default; // new MD_ReferenceSystem_PropertyType();
      _gcp = default; // new List<MI_GCP_PropertyType>();

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

    private Integer_PropertyType _collectionIdentification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("collectionIdentification", Order = 0)]
    [JsonProperty("collectionIdentification", Order = 0)]
    public Integer_PropertyType CollectionIdentification {
      get {
        return _collectionIdentification;
      }
      set {
        if (_collectionIdentification == value) {
          return;
        }
        if (_collectionIdentification == null || _collectionIdentification.Equals(value) != true) {
          _collectionIdentification = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _collectionName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("collectionName", Order = 1)]
    [JsonProperty("collectionName", Order = 1)]
    public CharacterString CollectionName {
      get {
        return _collectionName;
      }
      set {
        if (_collectionName == value) {
          return;
        }
        if (_collectionName == null || _collectionName.Equals(value) != true) {
          _collectionName = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_ReferenceSystem_PropertyType _coordinateReferenceSystem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("coordinateReferenceSystem", Order = 2)]
    [JsonProperty("coordinateReferenceSystem", Order = 2)]
    public MD_ReferenceSystem_PropertyType CoordinateReferenceSystem {
      get {
        return _coordinateReferenceSystem;
      }
      set {
        if (_coordinateReferenceSystem == value) {
          return;
        }
        if (_coordinateReferenceSystem == null || _coordinateReferenceSystem.Equals(value) != true) {
          _coordinateReferenceSystem = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MI_GCP_PropertyType> _gcp;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("gcp", Order = 3)]
    [JsonProperty("gcp", Order = 3)]
    public List<MI_GCP_PropertyType> Gcp {
      get {
        return _gcp;
      }
      set {
        if (_gcp == value) {
          return;
        }
        if (_gcp == null || _gcp.Equals(value) != true) {
          _gcp = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
