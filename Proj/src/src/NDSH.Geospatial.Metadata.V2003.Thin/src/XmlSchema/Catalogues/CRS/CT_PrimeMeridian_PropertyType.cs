
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 20:10, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Datums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS
{

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CT_PrimeMeridian_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_PrimeMeridian_PropertyType")]
  public class CT_PrimeMeridian_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_PrimeMeridian_PropertyType"/>.
    /// </summary>
    public CT_PrimeMeridian_PropertyType() {
      _primeMeridian  = default; //  new PrimeMeridianType();
    }

    #endregion

    #region Public Properties

    private PrimeMeridianType _primeMeridian;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PrimeMeridian", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("PrimeMeridian", Order = 0)]
    public PrimeMeridianType PrimeMeridian {
      get {
        return _primeMeridian;
      }
      set {
        if (_primeMeridian == value) {
          return;
        }
        if (_primeMeridian == null || _primeMeridian.Equals(value) != true) {
          _primeMeridian = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
