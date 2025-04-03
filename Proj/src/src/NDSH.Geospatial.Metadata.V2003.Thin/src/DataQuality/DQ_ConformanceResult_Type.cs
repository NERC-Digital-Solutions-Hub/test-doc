
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 03:07, @gisvlasta.
// Updated by        : 09/01/2023, 18:41, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Truth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality {

  // TODO: Check the Summary of this type.

  /// <summary>
  /// quantitative_result from Quality Procedures -  - renamed to remove implied use limitiation.
  /// </summary>
  [Serializable]
  [XmlType("DQ_ConformanceResult", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("DQ_ConformanceResult", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("DQ_ConformanceResult")]
  public class DQ_ConformanceResult_Type : AbstractDQ_Result_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_ConformanceResult_Type"/>.
    /// </summary>
    public DQ_ConformanceResult_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _specification  = default; //  new CI_Citation_PropertyType();
      _explanation  = default; //  new CharacterString_PropertyType();
      _pass  = default; //  new Boolean_PropertyType();
      
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

    private CI_Citation_PropertyType _specification;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("specification", Order = 0)]
    [JsonProperty("specification", Order = 0)]
    public CI_Citation_PropertyType Specification {
      get {
        return _specification;
      }
      set {
        if (_specification == value) {
          return;
        }
        if (_specification == null || _specification.Equals(value) != true) {
          _specification = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _explanation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("explanation", Order = 1)]
    [JsonProperty("explanation", Order = 1)]
    public CharacterString Explanation {
      get {
        return _explanation;
      }
      set {
        if (_explanation == value) {
          return;
        }
        if (_explanation == null || _explanation.Equals(value) != true) {
          _explanation = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean_PropertyType _pass;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("pass", Order = 2)]
    [JsonProperty("pass", Order = 2)]
    public Boolean_PropertyType Pass {
      get {
        return _pass;
      }
      set {
        if (_pass == value) {
          return;
        }
        if (_pass == null || _pass.Equals(value) != true) {
          _pass = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}