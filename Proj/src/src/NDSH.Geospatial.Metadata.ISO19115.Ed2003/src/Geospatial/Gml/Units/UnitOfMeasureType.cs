
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/units.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="unitOfMeasure" type="gml:UnitOfMeasureType">
//   <annotation>
//     <documentation>
//       The element gml:unitOfMeasure is a property element to refer to a unit of measure.
//       This is an empty element which carries a reference to a unit of measure definition.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="UnitOfMeasureType">
//   <sequence/>
//   <attribute name="uom" type="gml:UomIdentifier" use="required"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Units {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  //[XmlInclude(typeof(ConversionToPreferredUnitType))]
  //[XmlInclude(typeof(DerivationUnitTermType))]
  //[XmlType("UnitOfMeasureType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("UnitOfMeasureType")]
  public class UnitOfMeasureType : ObservableModel {

    #region Public Properties

    private string _uom;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("uom")]
    [JsonProperty("uom")]
    public string Uom {
      get {
        return _uom;
      }
      set {
        if (_uom == value) {
          return;
        }
        if (_uom == null || _uom.Equals(value) != true) {
          _uom = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
