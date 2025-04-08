
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 14:29, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.V2003.Thin.GML.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Operations
{

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(ML_ConcatenatedOperation_Type))] // GMX
  [XmlInclude(typeof(ML_Conversion_Type))] // GMX
  [XmlInclude(typeof(ML_PassThroughOperation_Type))] // GMX
  [XmlInclude(typeof(ML_Transformation_Type))] // GMX
  [XmlInclude(typeof(OperationAlt_Type))] // GMX
  [XmlInclude(typeof(PassThroughOperationType))]
  [XmlInclude(typeof(ConcatenatedOperationType))]
  [XmlInclude(typeof(AbstractGeneralTransformationType))]
  [XmlInclude(typeof(TransformationType))]
  [XmlInclude(typeof(AbstractGeneralConversionType))]
  [XmlInclude(typeof(ConversionType))]
  [Serializable]
  [XmlType("AbstractCoordinateOperationType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractCoordinateOperationType")]
  public abstract class AbstractCoordinateOperationType : IdentifiedObjectType
  {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractCoordinateOperationType"/>.
    /// </summary>
    public AbstractCoordinateOperationType()
    {
      _domainOfValidity = default; //  new domainOfValidity();
      _scope = default; //  new List<string>();
      _coordinateOperationAccuracy = default; //  new List<coordinateOperationAccuracy>();
      _sourceCRS = default; //  new CRSPropertyType();
      _targetCRS = default; //  new CRSPropertyType();
    }

    #endregion

    #region Private fields

    private DomainOfValidity _domainOfValidity;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("domainOfValidity", Order = 0)]
    [JsonProperty("domainOfValidity", Order = 0)]
    public DomainOfValidity DomainOfValidity
    {
      get
      {
        return _domainOfValidity;
      }
      set
      {
        if (_domainOfValidity == value)
        {
          return;
        }
        if (_domainOfValidity == null || _domainOfValidity.Equals(value) != true)
        {
          _domainOfValidity = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _scope;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("scope", Order = 1)]
    [JsonProperty("scope", Order = 1)]
    public List<string> Scope
    {
      get
      {
        return _scope;
      }
      set
      {
        if (_scope == value)
        {
          return;
        }
        if (_scope == null || _scope.Equals(value) != true)
        {
          _scope = value;
          OnPropertyChanged();
        }
      }
    }

    private string _operationVersion;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("operationVersion", Order = 2)]
    [JsonProperty("operationVersion", Order = 2)]
    public string OperationVersion
    {
      get
      {
        return _operationVersion;
      }
      set
      {
        if (_operationVersion == value)
        {
          return;
        }
        if (_operationVersion == null || _operationVersion.Equals(value) != true)
        {
          _operationVersion = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CoordinateOperationAccuracy> _coordinateOperationAccuracy;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("coordinateOperationAccuracy", Order = 3)]
    [JsonProperty("coordinateOperationAccuracy", Order = 3)]
    public List<CoordinateOperationAccuracy> CoordinateOperationAccuracy
    {
      get
      {
        return _coordinateOperationAccuracy;
      }
      set
      {
        if (_coordinateOperationAccuracy == value)
        {
          return;
        }
        if (_coordinateOperationAccuracy == null || _coordinateOperationAccuracy.Equals(value) != true)
        {
          _coordinateOperationAccuracy = value;
          OnPropertyChanged();
        }
      }
    }

    private CRSPropertyType _sourceCRS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sourceCRS", Order = 4)]
    [JsonProperty("sourceCRS", Order = 4)]
    public CRSPropertyType SourceCRS
    {
      get
      {
        return _sourceCRS;
      }
      set
      {
        if (_sourceCRS == value)
        {
          return;
        }
        if (_sourceCRS == null || _sourceCRS.Equals(value) != true)
        {
          _sourceCRS = value;
          OnPropertyChanged();
        }
      }
    }

    private CRSPropertyType _targetCRS;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("targetCRS", Order = 5)]
    [JsonProperty("targetCRS", Order = 5)]
    public CRSPropertyType TargetCRS
    {
      get
      {
        return _targetCRS;
      }
      set
      {
        if (_targetCRS == value)
        {
          return;
        }
        if (_targetCRS == null || _targetCRS.Equals(value) != true)
        {
          _targetCRS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
