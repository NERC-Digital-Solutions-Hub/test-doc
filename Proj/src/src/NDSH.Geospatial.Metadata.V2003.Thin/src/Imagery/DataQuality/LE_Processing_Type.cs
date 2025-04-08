
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/01/2023, 01:46, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem;
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
  /// Description: Comprehensive information about the procedure(s),
  /// process(es) and algorithm(s) applied in the process step.
  /// </summary>
  /// <remarks>ShortName: Procsg</remarks>
  [Serializable]
  [XmlType("LE_Processing", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("LE_Processing", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("LE_Processing")]
  public class LE_Processing_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_Processing_Type"/>
    /// </summary>
    public LE_Processing_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _identifier = default; // new MD_Identifier_PropertyType();
      _softwareReference = default; // new List<CI_Citation_PropertyType>();
      _procedureDescription = default; // new CharacterString_PropertyType();
      _documentation = default; // new List<CI_Citation_PropertyType>();
      _runTimeParameters = default; // new CharacterString_PropertyType();
      _algorithm = default; // new List<LE_Algorithm_PropertyType>();

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

    private MD_Identifier_PropertyType _identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 0)]
    [JsonProperty("identifier", Order = 0)]
    public MD_Identifier_PropertyType Identifier {
      get {
        return _identifier;
      }
      set {
        if (_identifier == value) {
          return;
        }
        if (_identifier == null || _identifier.Equals(value) != true) {
          _identifier = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_Citation_PropertyType> _softwareReference;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("softwareReference", Order = 1)]
    [JsonProperty("softwareReference", Order = 1)]
    public List<CI_Citation_PropertyType> SoftwareReference {
      get {
        return _softwareReference;
      }
      set {
        if (_softwareReference == value) {
          return;
        }
        if (_softwareReference == null || _softwareReference.Equals(value) != true) {
          _softwareReference = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _procedureDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("procedureDescription", Order = 2)]
    [JsonProperty("procedureDescription", Order = 2)]
    public CharacterString ProcedureDescription {
      get {
        return _procedureDescription;
      }
      set {
        if (_procedureDescription == value) {
          return;
        }
        if (_procedureDescription == null || _procedureDescription.Equals(value) != true) {
          _procedureDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_Citation_PropertyType> _documentation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("documentation", Order = 3)]
    [JsonProperty("documentation", Order = 3)]
    public List<CI_Citation_PropertyType> Documentation {
      get {
        return _documentation;
      }
      set {
        if (_documentation == value) {
          return;
        }
        if (_documentation == null || _documentation.Equals(value) != true) {
          _documentation = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _runTimeParameters;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("runTimeParameters", Order = 4)]
    [JsonProperty("runTimeParameters", Order = 4)]
    public CharacterString RunTimeParameters {
      get {
        return _runTimeParameters;
      }
      set {
        if (_runTimeParameters == value) {
          return;
        }
        if (_runTimeParameters == null || _runTimeParameters.Equals(value) != true) {
          _runTimeParameters = value;
          OnPropertyChanged();
        }
      }
    }

    private List<LE_Algorithm_PropertyType> _algorithm;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("algorithm", Order = 5)]
    [JsonProperty("algorithm", Order = 5)]
    public List<LE_Algorithm_PropertyType> Algorithm {
      get {
        return _algorithm;
      }
      set {
        if (_algorithm == value) {
          return;
        }
        if (_algorithm == null || _algorithm.Equals(value) != true) {
          _algorithm = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
