
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 19:29, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Units
{

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(ConversionToPreferredUnitType))]
  [XmlInclude(typeof(DerivationUnitTermType))]
  [XmlType("UnitOfMeasureType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("UnitOfMeasureType")]
  public class UnitOfMeasureType : Model
  {

    #region Public Properties

    private string _uom;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("uom")]
    [JsonProperty("uom")]
    public string Uom
    {
      get
      {
        return _uom;
      }
      set
      {
        if (_uom == value)
        {
          return;
        }
        if (_uom == null || _uom.Equals(value) != true)
        {
          _uom = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
