
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 15:32, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gmi/dataQualityInformation.xsd
// --------------------------------------------------------------------------------
// <xs:complexType name="LE_NominalResolution_Type">
//   <xs:annotation>
//     <xs:documentation>Description: Distance between adjacent pixels - shortName: nomRes</xs:documentation>
//   </xs:annotation>
//   <xs:choice>
//     <xs:element name="scanningResolution" type="gco:Distance_PropertyType"/>
//     <xs:element name="groundResolution" type="gco:Distance_PropertyType"/>
//   </xs:choice>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Derived.UnitsOfMeasure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality {

  /// <summary>
  /// Distance between adjacent pixels.
  /// </summary>
  /// <remarks>ShortName: nomRes</remarks>
  [Serializable]
  [XmlType("LE_NominalResolution", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("LE_NominalResolution", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("LE_NominalResolution")]
  public class LE_NominalResolution_Type : AbstractObject_Type {

    // TODO: DANGER!!! - This class is complete nonsense.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_NominalResolution_Type"/>
    /// </summary>
    public LE_NominalResolution_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _scanningResolution = default; // new Distance_PropertyType();
      _groundResolution = default; // new Distance_PropertyType();
      
    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    //TODO: DANGER!!! - The two properties (ScanningResolution, GroundResolution) are marked with a <xs:choice in C:\NDSH\GitHub\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata\src\Schemas\ISO\2005\gmi\dataQualityInformation.xsd(210):<xs:choice> - What do we do with this situation???


    private Distance_PropertyType _scanningResolution;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("scanningResolution")]
    [JsonProperty("scanningResolution")]
    public Distance_PropertyType ScanningResolution {
      get {
        return _scanningResolution;
      }
      set {
        if (_scanningResolution == value) {
          return;
        }
        if (_scanningResolution == null || _scanningResolution.Equals(value) != true) {
          _scanningResolution = value;
          OnPropertyChanged();
        }
      }
    }

    private Distance_PropertyType _groundResolution;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("groundResolution")]
    [JsonProperty("groundResolution")]
    public Distance_PropertyType GroundResolution {
      get {
        return _groundResolution;
      }
      set {
        if (_groundResolution == value) {
          return;
        }
        if (_groundResolution == null || _groundResolution.Equals(value) != true) {
          _groundResolution = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
