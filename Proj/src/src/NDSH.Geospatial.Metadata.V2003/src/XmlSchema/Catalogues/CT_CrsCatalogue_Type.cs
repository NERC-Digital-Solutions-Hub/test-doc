
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 18:56, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CT_CrsCatalogue", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("CT_CrsCatalogue", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("CT_CrsCatalogue")]
  public class CT_CrsCatalogue_Type : AbstractCT_Catalogue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_CrsCatalogue_Type"/>.
    /// </summary>
    public CT_CrsCatalogue_Type() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _crs  = default; //  new List<CT_CRS_PropertyType>();
      _coordinateSystem  = default; //  new List<CT_CoordinateSystem_PropertyType>();
      _axis  = default; //  new List<CT_CoordinateSystemAxis_PropertyType>();
      _datum  = default; //  new List<CT_Datum_PropertyType>();
      _ellipsoid  = default; //  new List<CT_Ellipsoid_PropertyType>();
      _primeMeridian  = default; //  new List<CT_PrimeMeridian_PropertyType>();
      _operation  = default; //  new List<CT_Operation_PropertyType>();
      _operationMethod  = default; //  new List<CT_OperationMethod_PropertyType>();
      _parameters  = default; //  new List<CT_OperationParameters_PropertyType>();

    }

    #endregion

    #region Public Fields

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlNamespaceDeclarations()]
    //public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<CT_CRS_PropertyType> _crs;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("crs", Order = 0)]
    [JsonProperty("crs", Order = 0)]
    public List<CT_CRS_PropertyType> Crs {
      get {
        return _crs;
      }
      set {
        if (_crs == value) {
          return;
        }
        if (_crs == null || _crs.Equals(value) != true) {
          _crs = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CT_CoordinateSystem_PropertyType> _coordinateSystem;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("coordinateSystem", Order = 1)]
    [JsonProperty("coordinateSystem", Order = 1)]
    public List<CT_CoordinateSystem_PropertyType> CoordinateSystem {
      get {
        return _coordinateSystem;
      }
      set {
        if (_coordinateSystem == value) {
          return;
        }
        if (_coordinateSystem == null || _coordinateSystem.Equals(value) != true) {
          _coordinateSystem = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CT_CoordinateSystemAxis_PropertyType> _axis;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("axis", Order = 2)]
    [JsonProperty("axis", Order = 2)]
    public List<CT_CoordinateSystemAxis_PropertyType> Axis {
      get {
        return _axis;
      }
      set {
        if (_axis == value) {
          return;
        }
        if (_axis == null || _axis.Equals(value) != true) {
          _axis = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CT_Datum_PropertyType> _datum;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("datum", Order = 3)]
    [JsonProperty("datum", Order = 3)]
    public List<CT_Datum_PropertyType> Datum {
      get {
        return _datum;
      }
      set {
        if (_datum == value) {
          return;
        }
        if (_datum == null || _datum.Equals(value) != true) {
          _datum = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CT_Ellipsoid_PropertyType> _ellipsoid;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ellipsoid", Order = 4)]
    [JsonProperty("ellipsoid", Order = 4)]
    public List<CT_Ellipsoid_PropertyType> Ellipsoid {
      get {
        return _ellipsoid;
      }
      set {
        if (_ellipsoid == value) {
          return;
        }
        if (_ellipsoid == null || _ellipsoid.Equals(value) != true) {
          _ellipsoid = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CT_PrimeMeridian_PropertyType> _primeMeridian;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("primeMeridian", Order = 5)]
    [JsonProperty("primeMeridian", Order = 5)]
    public List<CT_PrimeMeridian_PropertyType> PrimeMeridian {
      get {
        return _primeMeridian;
      }
      set {
        if (_primeMeridian == value) {
          return;
        }
        if (_primeMeridian == null || _primeMeridian.Equals(value) != true) {
          _primeMeridian = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CT_Operation_PropertyType> _operation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("operation", Order = 6)]
    [JsonProperty("operation", Order = 6)]
    public List<CT_Operation_PropertyType> Operation {
      get {
        return _operation;
      }
      set {
        if (_operation == value) {
          return;
        }
        if (_operation == null || _operation.Equals(value) != true) {
          _operation = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CT_OperationMethod_PropertyType> _operationMethod;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("operationMethod", Order = 7)]
    [JsonProperty("operationMethod", Order = 7)]
    public List<CT_OperationMethod_PropertyType> OperationMethod {
      get {
        return _operationMethod;
      }
      set {
        if (_operationMethod == value) {
          return;
        }
        if (_operationMethod == null || _operationMethod.Equals(value) != true) {
          _operationMethod = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CT_OperationParameters_PropertyType> _parameters;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("parameters", Order = 8)]
    [JsonProperty("parameters", Order = 8)]
    public List<CT_OperationParameters_PropertyType> Parameters {
      get {
        return _parameters;
      }
      set {
        if (_parameters == value) {
          return;
        }
        if (_parameters == null || _parameters.Equals(value) != true) {
          _parameters = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
