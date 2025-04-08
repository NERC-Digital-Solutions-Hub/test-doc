
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 03:43, @gisvlasta.
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
  [XmlInclude(typeof(ML_ConventionalUnit_Type))]
  [XmlType("ConventionalUnitType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ConventionalUnitType")]
  public class ConventionalUnitType : UnitDefinitionType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ConventionalUnitType"/>.
    /// </summary>
    public ConventionalUnitType() {
      _derivationUnitTerm = default; //  new List<DerivationUnitTermType>();
    }

    #endregion

    #region Public Properties

    private ConversionToPreferredUnitType _conversionToPreferredUnitItem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("conversionToPreferredUnit", typeof(ConversionToPreferredUnitType), Order = 0)]
    [XmlElement("roughConversionToPreferredUnit", typeof(ConversionToPreferredUnitType), Order = 0)]
    [XmlChoiceIdentifier("UnitConversionItemElementName")]
    public ConversionToPreferredUnitType ConversionToPreferredUnitItem {
      get {
        return _conversionToPreferredUnitItem;
      }
      set {
        if (_conversionToPreferredUnitItem == value) {
          return;
        }
        if (_conversionToPreferredUnitItem == null || _conversionToPreferredUnitItem.Equals(value) != true) {
          _conversionToPreferredUnitItem = value;
          OnPropertyChanged();
        }
      }
    }

    private UnitConversion _unitConversionItemElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("UnitConversionItemElementName", Order = 1)]
    [XmlIgnore]
    public UnitConversion UnitConversionItemElementName {
      get {
        return _unitConversionItemElementName;
      }
      set {
        if (_unitConversionItemElementName.Equals(value) != true) {
          _unitConversionItemElementName = value;
          OnPropertyChanged();
        }
      }
    }

    private List<DerivationUnitTermType> _derivationUnitTerm;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("derivationUnitTerm", Order = 2)]
    [JsonProperty("derivationUnitTerm", Order = 2)]
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
