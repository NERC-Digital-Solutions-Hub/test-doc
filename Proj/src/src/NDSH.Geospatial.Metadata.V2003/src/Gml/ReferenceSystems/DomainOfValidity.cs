
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 31/01/2023, 15:19, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common.Extent;
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems {

  /// <summary>
  /// The DomainOfValidity implements an association role to an
  /// <see cref="EX_Extent_Type"/> object as encoded in ISO/TS 19139,
  /// either referencing or containing the definition of that extent.
  /// </summary>
  [Serializable]
  [XmlType("DomainOfValidity", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DomainOfValidity")]
  public class DomainOfValidity : Association {

    #region Constructors - Destructors

    /// <summary> 
    /// Initializes the <see cref="DomainOfValidity"/>.
    /// </summary>
    public DomainOfValidity() {
      _eX_Extent = new EX_Extent_Type();
    }

    #endregion

    #region Public Properties

    private EX_Extent_Type _eX_Extent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("EX_Extent", Namespace = "http://www.isotc211.org/2005/gmd", Order = 0)]
    [JsonProperty("EX_Extent", Order = 0)]
    public EX_Extent_Type EX_Extent {
      get {
        return _eX_Extent;
      }
      set {
        if (_eX_Extent == value) {
          return;
        }
        if (_eX_Extent == null || !_eX_Extent.Equals(value)) {
          _eX_Extent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
