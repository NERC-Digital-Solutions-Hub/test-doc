
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 19:32, @gisvlasta.
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
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Units {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DerivationUnitTermType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DerivationUnitTermType")]
  public class DerivationUnitTermType : UnitOfMeasureType {

    #region Public Properties

    private string _exponent;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("exponent", DataType = "integer")]
    [JsonProperty("exponent")]
    public string Exponent {
      get {
        return _exponent;
      }
      set {
        if (_exponent == value) {
          return;
        }
        if (_exponent == null || _exponent.Equals(value) != true) {
          _exponent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
