
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 20:12, @gisvlasta.
// Updated by        : 09/01/2023, 19:10, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Distribution {

  /// <summary>
  /// Information about the distributor of and options for obtaining the dataset
  /// </summary>
  [Serializable]
  [XmlType("MD_Distribution", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Distribution", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Distribution")]
  public class MD_Distribution_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Distribution_Type"/>.
    /// </summary>
    public MD_Distribution_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _distributionFormat  = default; //  new List<MD_Format_PropertyType>();
      _distributor  = default; //  new List<MD_Distributor_PropertyType>();
      _transferOptions  = default; //  new List<MD_DigitalTransferOptions_PropertyType>();

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

    private List<MD_Format_PropertyType> _distributionFormat;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("distributionFormat", Order = 0)]
    [JsonProperty("distributionFormat", Order = 0)]
    public List<MD_Format_PropertyType> DistributionFormat {
      get {
        return _distributionFormat;
      }
      set {
        if (_distributionFormat == value) {
          return;
        }
        if (_distributionFormat == null || _distributionFormat.Equals(value) != true) {
          _distributionFormat = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Distributor_PropertyType> _distributor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("distributor", Order = 1)]
    [JsonProperty("distributor", Order = 1)]
    public List<MD_Distributor_PropertyType> Distributor {
      get {
        return _distributor;
      }
      set {
        if (_distributor == value) {
          return;
        }
        if (_distributor == null || _distributor.Equals(value) != true) {
          _distributor = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_DigitalTransferOptions_PropertyType> _transferOptions;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("transferOptions", Order = 2)]
    [JsonProperty("transferOptions", Order = 2)]
    public List<MD_DigitalTransferOptions_PropertyType> TransferOptions {
      get {
        return _transferOptions;
      }
      set {
        if (_transferOptions == value) {
          return;
        }
        if (_transferOptions == null || _transferOptions.Equals(value) != true) {
          _transferOptions = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}