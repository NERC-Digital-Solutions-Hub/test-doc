
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 31/01/2023, 09:53, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Measures;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Datums
{

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(ML_Ellipsoid_Type))] // GMX
  [Serializable]
  [XmlType("EllipsoidType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EllipsoidType")]
  public class EllipsoidType : IdentifiedObjectType
  {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EllipsoidType"/>.
    /// </summary>
    public EllipsoidType()
    {
      _secondDefiningParameter = new SecondDefiningParameterPropertyType();
      _semiMajorAxis = new MeasureType();
    }

    #endregion

    #region Public Properties

    private MeasureType _semiMajorAxis;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("semiMajorAxis", Order = 0)]
    [JsonProperty("semiMajorAxis", Order = 0)]
    public MeasureType SemiMajorAxis
    {
      get
      {
        return _semiMajorAxis;
      }
      set
      {
        if (_semiMajorAxis == value)
        {
          return;
        }
        if (_semiMajorAxis == null || _semiMajorAxis.Equals(value) != true)
        {
          _semiMajorAxis = value;
          OnPropertyChanged();
        }
      }
    }

    private SecondDefiningParameterPropertyType _secondDefiningParameter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("secondDefiningParameter", Order = 1)]
    [JsonProperty("secondDefiningParameter", Order = 1)]
    public SecondDefiningParameterPropertyType SecondDefiningParameter
    {
      get
      {
        return _secondDefiningParameter;
      }
      set
      {
        if (_secondDefiningParameter == value)
        {
          return;
        }
        if (_secondDefiningParameter == null || _secondDefiningParameter.Equals(value) != true)
        {
          _secondDefiningParameter = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
