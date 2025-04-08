
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 20:25, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CT_Datum_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_Datum_PropertyType")]
  public class CT_Datum_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractDatumType _abstractDatum;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractDatum", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractDatum", Order = 0)]
    public AbstractDatumType AbstractDatum {
      get {
        return _abstractDatum;
      }
      set {
        if (_abstractDatum == value) {
          return;
        }
        if (_abstractDatum == null || _abstractDatum.Equals(value) != true) {
          _abstractDatum = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
