
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 17:58, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Records;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.DateTime;
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Content {

  /// <summary>
  /// Description of specific range elements.
  /// </summary>
  /// <remarks>ShortName: RgEltDesc</remarks>
  [Serializable]
  [XmlType("MI_RangeElementDescription", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_RangeElementDescription", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_RangeElementDescription")]
  public class MI_RangeElementDescription_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_RangeElementDescription_Type"/>
    /// </summary>
    public MI_RangeElementDescription_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _name = default; // new CharacterString_PropertyType();
      _definition = default; // new CharacterString_PropertyType();
      _rangeElement = default; // new List<Record_PropertyType>();

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
    
    private CharacterString _definition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("definition", Order = 1)]
    [JsonProperty("definition", Order = 1)]
    public CharacterString Definition {
      get {
        return _definition;
      }
      set {
        if (_definition == value) {
          return;
        }
        if (_definition == null || _definition.Equals(value) != true) {
          _definition = value;
          OnPropertyChanged();
        }
      }
    }

    private List<Record_PropertyType> _rangeElement;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("rangeElement", Order = 2)]
    [JsonProperty("rangeElement", Order = 2)]
    public List<Record_PropertyType> RangeElement {
      get {
        return _rangeElement;
      }
      set {
        if (_rangeElement == value) {
          return;
        }
        if (_rangeElement == null || _rangeElement.Equals(value) != true) {
          _rangeElement = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
