
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 16:56, @gisvlasta.
// Updated by        : 09/01/2023, 18:51, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2003.Thin.Common;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.Lineage {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LI_Lineage", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("LI_Lineage", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("LI_Lineage")]
  public class LI_Lineage_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LI_Lineage_Type"/>.
    /// </summary>
    public LI_Lineage_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _statement  = default; //  new CharacterString_PropertyType();
      _processStep  = default; //  new List<LI_ProcessStep_PropertyType>();
      _source  = default; //  new List<LI_Source_PropertyType>();

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

    private CharacterString _statement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("statement", Order = 0)]
    [JsonProperty("statement", Order = 0)]
    public CharacterString Statement {
      get {
        return _statement;
      }
      set {
        if (_statement == value) {
          return;
        }
        if (_statement == null || _statement.Equals(value) != true) {
          _statement = value;
          OnPropertyChanged();
        }
      }
    }

    private List<LI_ProcessStep_PropertyType> _processStep;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("processStep", Order = 1)]
    [JsonProperty("processStep", Order = 1)]
    public List<LI_ProcessStep_PropertyType> ProcessStep {
      get {
        return _processStep;
      }
      set {
        if (_processStep == value) {
          return;
        }
        if (_processStep == null || _processStep.Equals(value) != true) {
          _processStep = value;
          OnPropertyChanged();
        }
      }
    }

    private List<LI_Source_PropertyType> _source;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("source", Order = 2)]
    [JsonProperty("source", Order = 2)]
    public List<LI_Source_PropertyType> Source {
      get {
        return _source;
      }
      set {
        if (_source == value) {
          return;
        }
        if (_source == null || _source.Equals(value) != true) {
          _source = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}