
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/01/2023, 01:57, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.DataQuality {

  /// <summary>
  /// Details of the methodology by which geographic information was derived from the instrument readings.
  /// </summary>
  /// <remarks>
  /// <para>FGDC: Algorithm_Information</para>
  /// <para>ShortName: Algorithm</para>
  /// </remarks>
  [Serializable]
  [XmlType("LE_Algorithm", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("LE_Algorithm", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("LE_Algorithm")]
  public class LE_Algorithm_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_Algorithm_Type"/>
    /// </summary>
    public LE_Algorithm_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _citation = default; // new CI_Citation_PropertyType();
      _description = default; // new CharacterString_PropertyType();

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

    private CI_Citation_PropertyType _citation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("citation", Order = 0)]
    [JsonProperty("citation", Order = 0)]
    public CI_Citation_PropertyType Citation {
      get {
        return _citation;
      }
      set {
        if (_citation == value) {
          return;
        }
        if (_citation == null || _citation.Equals(value) != true) {
          _citation = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 1)]
    [JsonProperty("description", Order = 1)]
    public CharacterString_PropertyType Description {
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

    #endregion

  }

}
