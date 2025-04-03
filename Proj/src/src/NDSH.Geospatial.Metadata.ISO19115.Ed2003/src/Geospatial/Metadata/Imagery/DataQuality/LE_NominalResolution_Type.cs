
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
// <xs:element name="LE_NominalResolution" type="gmi:LE_NominalResolution_Type"/>
// <xs:complexType name="LE_NominalResolution_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:LE_NominalResolution" minOccurs="0"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Derived.UnitsOfMeasure;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Imagery.DataQuality {

  /// <summary>
  /// Distance between adjacent pixels.
  /// </summary>
  /// <remarks>ShortName: nomRes</remarks>
  [Serializable]
  [XmlType("LE_NominalResolution", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("LE_NominalResolution", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("LE_NominalResolution")]
  public class LE_NominalResolution_Type : MetadataObject {

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
    /// Distance between consistent parts of (centre, left side, right side) adjacent pixels in the scan plane.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    [XmlElement("scanningResolution")]
    [JsonProperty("scanningResolution")]
    public Distance_PropertyType ScanningResolution {
      get {
        return _scanningResolution;
      }
      set => SetProperty(ref _scanningResolution, value);
    }

    private Distance_PropertyType _groundResolution;

    /// <summary>
    /// Distance between consistent parts of (centre, left side, right side) adjacent pixels in the object space.
    /// </summary>
    [XmlElement("groundResolution")]
    [JsonProperty("groundResolution")]
    public Distance_PropertyType GroundResolution {
      get {
        return _groundResolution;
      }
      set => SetProperty(ref _groundResolution, value);
    }

    #endregion

  }

}
