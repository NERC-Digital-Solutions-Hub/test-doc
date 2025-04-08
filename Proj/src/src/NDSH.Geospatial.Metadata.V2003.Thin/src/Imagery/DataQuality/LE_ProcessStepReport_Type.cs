
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/01/2023, 01:54, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
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
  /// Report of what occurred during the process step.
  /// </summary>
  /// <remarks>ShortName: ProcStepRep</remarks>
  [Serializable]
  [XmlType("LE_ProcessStepReport", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("LE_ProcessStepReport", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("LE_ProcessStepReport")]
  public class LE_ProcessStepReport_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_ProcessStepReport_Type"/>
    /// </summary>
    public LE_ProcessStepReport_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _name = default; // new CharacterString_PropertyType();
      _description = default; // new CharacterString_PropertyType();
      _fileType = default; // new CharacterString_PropertyType();

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

    private CharacterString _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString Name {
      get {
        return _name;
      }
      set {
        if (_name == value) {
          return;
        }
        if (_name == null || _name.Equals(value) != true) {
          _name = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 1)]
    [JsonProperty("description", Order = 1)]
    public CharacterString Description {
      get {
        return _description;
      }
      set {
        if (_description == value) {
          return;
        }
        if (_description == null || _description.Equals(value) != true) {
          _description = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _fileType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileType", Order = 2)]
    [JsonProperty("fileType", Order = 2)]
    public CharacterString FileType {
      get {
        return _fileType;
      }
      set {
        if (_fileType == value) {
          return;
        }
        if (_fileType == null || _fileType.Equals(value) != true) {
          _fileType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
