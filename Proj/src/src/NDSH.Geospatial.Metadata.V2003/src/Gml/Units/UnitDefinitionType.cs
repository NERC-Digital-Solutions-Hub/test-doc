
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 02:20, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Gml.Dictionary;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
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
  [XmlInclude(typeof(ConventionalUnitType))]
  [XmlInclude(typeof(ML_ConventionalUnit_Type))]
  [XmlInclude(typeof(DerivedUnitType))]
  [XmlInclude(typeof(ML_DerivedUnit_Type))]
  [XmlInclude(typeof(BaseUnitType))]
  [XmlInclude(typeof(ML_BaseUnit_Type))]
  [XmlInclude(typeof(UomAlternativeExpression_Type))]
  [XmlInclude(typeof(ML_UnitDefinition_Type))]
  [XmlType("UnitDefinitionType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("UnitDefinitionType")]
  public class UnitDefinitionType : DefinitionType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UnitDefinitionType"/>.
    /// </summary>
    public UnitDefinitionType() {
      _quantityType = default; //  new StringOrRefType();
      _quantityTypeReference = default; //  new ReferenceType();
      _catalogSymbol = default; //  new CodeType();
    }

    #endregion

    #region Public Properties

    private StringOrRefType _quantityType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("quantityType", Order = 0)]
    [JsonProperty("quantityType", Order = 0)]
    public StringOrRefType QuantityType {
      get {
        return _quantityType;
      }
      set {
        if (_quantityType == value) {
          return;
        }
        if (_quantityType == null || _quantityType.Equals(value) != true) {
          _quantityType = value;
          OnPropertyChanged();
        }
      }
    }

    private ReferenceType _quantityTypeReference;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("quantityTypeReference", Order = 1)]
    [JsonProperty("quantityTypeReference", Order = 1)]
    public ReferenceType QuantityTypeReference {
      get {
        return _quantityTypeReference;
      }
      set {
        if (_quantityTypeReference == value) {
          return;
        }
        if (_quantityTypeReference == null || _quantityTypeReference.Equals(value) != true) {
          _quantityTypeReference = value;
          OnPropertyChanged();
        }
      }
    }

    private CodeType _catalogSymbol;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("catalogSymbol", Order = 2)]
    [JsonProperty("catalogSymbol", Order = 2)]
    public CodeType CatalogSymbol {
      get {
        return _catalogSymbol;
      }
      set {
        if (_catalogSymbol == value) {
          return;
        }
        if (_catalogSymbol == null || _catalogSymbol.Equals(value) != true) {
          _catalogSymbol = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
