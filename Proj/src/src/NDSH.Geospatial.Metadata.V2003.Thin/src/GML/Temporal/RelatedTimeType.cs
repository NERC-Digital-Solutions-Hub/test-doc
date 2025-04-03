
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 19:23, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal {

  /// <summary>
  /// RelatedTimeType provides a content model for indicating the relative position of an arbitrary
  /// member of the substitution group whose head is <see cref="AbstractTimePrimitiveType"/>.
  /// It extends the generic gml:TimePrimitivePropertyType with an XML attribute relativePosition,
  /// whose value is selected from the set of 13 temporal relationships identified by Allen (1983).
  /// </summary>
  [Serializable]
  [XmlType("RelatedTimeType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("RelatedTimeType")]
  public class RelatedTimeType : TimePrimitivePropertyType {

    #region Public Properties

    private RelatedTimeTypeRelativePosition _relativePosition;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("relativePosition")]
    [JsonProperty("relativePosition")]
    public RelatedTimeTypeRelativePosition RelativePosition {
      get {
        return _relativePosition;
      }
      set {
        if (_relativePosition.Equals(value) != true) {
          _relativePosition = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
