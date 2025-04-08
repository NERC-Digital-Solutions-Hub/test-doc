
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/012023, 02:57, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.UnitsOfMeasure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
  [XmlInclude(typeof(ML_DerivedUnit_Type))]
  [XmlType("DerivedUnitType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DerivedUnitType")]
  public class DerivedUnitType : UnitDefinitionType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DerivedUnitType"/>.
    /// </summary>
    public DerivedUnitType() {
      _derivationUnitTerm = default; //  new List<DerivationUnitTermType>();
    }

    #endregion

    #region Public Properties

    private List<DerivationUnitTermType> _derivationUnitTerm;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("derivationUnitTerm", Order = 0)]
    [JsonProperty("derivationUnitTerm", Order = 0)]
    public List<DerivationUnitTermType> DerivationUnitTerm {
      get {
        return _derivationUnitTerm;
      }
      set {
        if (_derivationUnitTerm == value) {
          return;
        }
        if (_derivationUnitTerm == null || _derivationUnitTerm.Equals(value) != true) {
          _derivationUnitTerm = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
