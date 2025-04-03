
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:34, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.Common.SpatialSchema;
using NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition {

  /// <summary>
  /// Identification of collection coverage.
  /// </summary>
  /// <remarks>ShortName: PlatformPass</remarks>
  [XmlType("MI_PlatformPass", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_PlatformPass", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_PlatformPass")]
  public class MI_PlatformPass_Type : AbstractObject_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_PlatformPass_Type"/>.
    /// </summary>
    public MI_PlatformPass_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _identifier = default; // new MD_Identifier_PropertyType();
      _extent = default; // new GM_Object_PropertyType();
      _relatedEvent = default; // new MI_Event_PropertyType();

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
    
    private MD_Identifier_PropertyType _identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 0)]
    [JsonProperty("identifier", Order = 0)]
    public MD_Identifier_PropertyType Identifier {
      get {
        return _identifier;
      }
      set {
        if (_identifier == value) {
          return;
        }
        if (_identifier == null || _identifier.Equals(value) != true) {
          _identifier = value;
          OnPropertyChanged();
        }
      }
    }

    private GM_Object_PropertyType _extent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("extent", Order = 1)]
    [JsonProperty("extent", Order = 1)]
    public GM_Object_PropertyType Extent {
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

    private List<MI_Event_PropertyType> _relatedEvent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("relatedEvent", Order = 2)]
    [JsonProperty("relatedEvent", Order = 2)]
    public List<MI_Event_PropertyType> RelatedEvent {
      get {
        return _relatedEvent;
      }
      set {
        if (_relatedEvent == value) {
          return;
        }
        if (_relatedEvent == null || _relatedEvent.Equals(value) != true) {
          _relatedEvent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion
  }

}
