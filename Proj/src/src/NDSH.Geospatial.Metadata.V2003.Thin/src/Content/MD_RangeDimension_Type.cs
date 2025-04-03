
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 20:48, @gisvlasta.
// Updated by        : 09/01/2023, 18:22, @gisvlasta. - 1.0.1: Added xmlns field.
//                   : 08/02/2023, 00:39, @gisvlasta. - 1.0.2: Added [XmlInclude]s.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Names;
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
using NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Content;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Content {

  /// <summary>
  /// Set of adjacent wavelengths in the electro-magnetic spectrum with a common characteristic, such as the visible band.
  /// </summary>
  [XmlInclude(typeof(MI_Band_Type))]
  [XmlInclude(typeof(MD_Band_Type))]
  [Serializable]
  [XmlType("MD_RangeDimension", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_RangeDimension", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_RangeDimension")]
  public class MD_RangeDimension_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_RangeDimension_Type"/>.
    /// </summary>
    public MD_RangeDimension_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _sequenceIdentifier  = default; //  new MemberName_PropertyType();
      _descriptor  = default; //  new CharacterString_PropertyType();
      
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

    private MemberName_PropertyType _sequenceIdentifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sequenceIdentifier", Order = 0)]
    [JsonProperty("sequenceIdentifier", Order = 0)]
    public MemberName_PropertyType sequenceIdentifier {
      get {
        return _sequenceIdentifier;
      }
      set {
        if (_sequenceIdentifier == value) {
          return;
        }
        if (_sequenceIdentifier == null || _sequenceIdentifier.Equals(value) != true) {
          _sequenceIdentifier = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _descriptor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("descriptor", Order = 1)]
    [JsonProperty("descriptor", Order = 1)]
    public CharacterString descriptor {
      get {
        return _descriptor;
      }
      set {
        if (_descriptor == value) {
          return;
        }
        if (_descriptor == null || _descriptor.Equals(value) != true) {
          _descriptor = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}