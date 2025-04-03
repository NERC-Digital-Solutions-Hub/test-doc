
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 01:37, @gisvlasta.
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_AggregateInformation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_AggregateInformation_PropertyType")]
  public class MD_AggregateInformation_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_AggregateInformation_PropertyType"/>.
    /// </summary>
    public MD_AggregateInformation_PropertyType() {
      _md_AggregateInformation  = default; //  new MD_AggregateInformation_Type();
    }

    #endregion

    #region Public Properties

    private MD_AggregateInformation_Type _md_AggregateInformation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_AggregateInformation", Order = 0)]
    [JsonProperty("MD_AggregateInformation", Order = 0)]
    public MD_AggregateInformation_Type MD_AggregateInformation {
      get {
        return _md_AggregateInformation;
      }
      set {
        if (_md_AggregateInformation == value) {
          return;
        }
        if (_md_AggregateInformation == null || _md_AggregateInformation.Equals(value) != true) {
          _md_AggregateInformation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
