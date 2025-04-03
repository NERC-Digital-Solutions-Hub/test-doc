
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 20:07, @gisvlasta.
// Updated by        : 09/01/2023, 19:13, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Numerics;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Distribution {

  /// <summary>
  /// Technical means and media by which a dataset is obtained from the distributor.
  /// </summary>
  [Serializable]
  [XmlType("MD_DigitalTransferOptions", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_DigitalTransferOptions", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_DigitalTransferOptions")]
  public class MD_DigitalTransferOptions_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_DigitalTransferOptions_Type"/>.
    /// </summary>
    public MD_DigitalTransferOptions_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _unitsOfDistribution  = default; //  new CharacterString_PropertyType();
      _transferSize  = default; //  new Real_PropertyType();
      _onLine  = default; //  new List<CI_OnlineResource_PropertyType>();
      _offLine  = default; //  new MD_Medium_PropertyType();

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

    private CharacterString _unitsOfDistribution;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("unitsOfDistribution", Order = 0)]
    [JsonProperty("unitsOfDistribution", Order = 0)]
    public CharacterString UnitsOfDistribution {
      get {
        return _unitsOfDistribution;
      }
      set {
        if (_unitsOfDistribution == value) {
          return;
        }
        if (_unitsOfDistribution == null || _unitsOfDistribution.Equals(value) != true) {
          _unitsOfDistribution = value;
          OnPropertyChanged();
        }
      }
    }

    private Real_PropertyType _transferSize;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("transferSize", Order = 1)]
    [JsonProperty("transferSize", Order = 1)]
    public Real_PropertyType TransferSize {
      get {
        return _transferSize;
      }
      set {
        if (_transferSize == value) {
          return;
        }
        if (_transferSize == null || _transferSize.Equals(value) != true) {
          _transferSize = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_OnlineResource_PropertyType> _onLine;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("onLine", Order = 2)]
    [JsonProperty("onLine", Order = 2)]
    public List<CI_OnlineResource_PropertyType> OnLine {
      get {
        return _onLine;
      }
      set {
        if (_onLine == value) {
          return;
        }
        if (_onLine == null || _onLine.Equals(value) != true) {
          _onLine = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_Medium_PropertyType _offLine;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("offLine", Order = 3)]
    [JsonProperty("offLine", Order = 3)]
    public MD_Medium_PropertyType OffLine {
      get {
        return _offLine;
      }
      set {
        if (_offLine == value) {
          return;
        }
        if (_offLine == null || _offLine.Equals(value) != true) {
          _offLine = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}