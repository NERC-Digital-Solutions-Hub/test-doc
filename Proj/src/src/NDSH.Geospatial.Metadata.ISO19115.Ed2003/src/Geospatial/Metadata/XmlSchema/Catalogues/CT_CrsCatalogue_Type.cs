
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 07/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/catalogues.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="CT_CrsCatalogue_Type">
//   <xs:complexContent>
//     <xs:extension base="gmx:s">
//       <xs:sequence>
//         <xs:element name="crs"
//                     type="gmx:CT_CRS_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="coordinateSystem"
//                     type="gmx:CT_CoordinateSystem_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="axis"
//                     type="gmx:CT_CoordinateSystemAxis_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="datum"
//                     type="gmx:CT_Datum_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="ellipsoid"
//                     type="gmx:CT_Ellipsoid_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="primeMeridian"
//                     type="gmx:CT_PrimeMeridian_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="operation"
//                     type="gmx:CT_Operation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="operationMethod"
//                     type="gmx:CT_OperationMethod_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="parameters"
//                     type="gmx:CT_OperationParameters_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="CT_CrsCatalogue" type="gmx:CT_CrsCatalogue_Type" substitutionGroup="gmx:AbstractCT_Catalogue"/>
// <xs:complexType name="CT_CrsCatalogue_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:CT_CrsCatalogue"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues {

  [Serializable]
  //[XmlType("CT_CrsCatalogue", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("CT_CrsCatalogue", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("CT_CrsCatalogue")]
  public class CT_CrsCatalogue_Type : AbstractCT_Catalogue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_CrsCatalogue_Type"/>.
    /// </summary>
    public CT_CrsCatalogue_Type() {
      _crs = default; //  new List<CT_CRS_PropertyType>();
      _coordinateSystem = default; //  new List<CT_CoordinateSystem_PropertyType>();
      _axis = default; //  new List<CT_CoordinateSystemAxis_PropertyType>();
      _datum = default; //  new List<CT_Datum_PropertyType>();
      _ellipsoid = default; //  new List<CT_Ellipsoid_PropertyType>();
      _primeMeridian = default; //  new List<CT_PrimeMeridian_PropertyType>();
      _operation = default; //  new List<CT_Operation_PropertyType>();
      _operationMethod = default; //  new List<CT_OperationMethod_PropertyType>();
      _parameters = default; //  new List<CT_OperationParameters_PropertyType>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<CT_CRS_PropertyType> _crs;

    /// <summary>
    /// Provides the list of CRS described in the CRS catalogue.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("crs", Order = 0)]
    [JsonProperty("crs", Order = 0)]
    public ObservableCollection<CT_CRS_PropertyType> Crs {
      get => _crs;
      set => SetProperty(ref _crs, value);
    }

    private ObservableCollection<CT_CoordinateSystem_PropertyType>? _coordinateSystem;

    /// <summary>
    /// Provides the list of coordinate systems described in the CRS catalogue.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("coordinateSystem", Order = 1)]
    [JsonProperty("coordinateSystem", Order = 1)]
    public ObservableCollection<CT_CoordinateSystem_PropertyType>? CoordinateSystem {
      get => _coordinateSystem;
      set => SetProperty(ref _coordinateSystem, value);
    }

    private ObservableCollection<CT_CoordinateSystemAxis_PropertyType>? _axis;

    /// <summary>
    /// Provides the list of coordinate system axes described in the CRS catalogue.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("axis", Order = 2)]
    [JsonProperty("axis", Order = 2)]
    public ObservableCollection<CT_CoordinateSystemAxis_PropertyType>? Axis {
      get => _axis;
      set => SetProperty(ref _axis, value);
    }

    private List<CT_Datum_PropertyType>? _datum;

    /// <summary>
    /// Provides the list of data described in the CRS catalogue.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("datum", Order = 3)]
    [JsonProperty("datum", Order = 3)]
    public List<CT_Datum_PropertyType>? Datum {
      get => _datum;
      set => SetProperty(ref _datum, value);
    }

    private ObservableCollection<CT_Ellipsoid_PropertyType>? _ellipsoid;

    /// <summary>
    /// Provides the list of ellipsoids described in the CRS catalogue.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("ellipsoid", Order = 4)]
    [JsonProperty("ellipsoid", Order = 4)]
    public ObservableCollection<CT_Ellipsoid_PropertyType>? Ellipsoid {
      get => _ellipsoid;
      set => SetProperty(ref _ellipsoid, value);
    }

    private ObservableCollection<CT_PrimeMeridian_PropertyType>? _primeMeridian;

    /// <summary>
    /// Provides the list of prime meridians described in the CRS catalogue.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("primeMeridian", Order = 5)]
    [JsonProperty("primeMeridian", Order = 5)]
    public ObservableCollection<CT_PrimeMeridian_PropertyType>? PrimeMeridian {
      get => _primeMeridian;
      set => SetProperty(ref _primeMeridian, value);
    }

    private ObservableCollection<CT_Operation_PropertyType>? _operation;

    /// <summary>
    /// Provides the list of operations described in the CRS catalogue.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("operation", Order = 6)]
    [JsonProperty("operation", Order = 6)]
    public ObservableCollection<CT_Operation_PropertyType>? Operation {
      get => _operation;
      set => SetProperty(ref _operation, value);
    }

    private ObservableCollection<CT_OperationMethod_PropertyType>? _operationMethod;

    /// <summary>
    /// Provides the list of operationMethods described in the CRS catalogue.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("operationMethod", Order = 7)]
    [JsonProperty("operationMethod", Order = 7)]
    public ObservableCollection<CT_OperationMethod_PropertyType>? OperationMethod {
      get => _operationMethod;
      set => SetProperty(ref _operationMethod, value);
    }

    private ObservableCollection<CT_OperationParameters_PropertyType>? _parameters;

    /// <summary>
    /// Provides the list of operation parameters described in the CRS catalogue.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("parameters", Order = 8)]
    [JsonProperty("parameters", Order = 8)]
    public ObservableCollection<CT_OperationParameters_PropertyType>? Parameters {
      get => _parameters;
      set => SetProperty(ref _parameters, value);
    }

    #endregion

  }

}
