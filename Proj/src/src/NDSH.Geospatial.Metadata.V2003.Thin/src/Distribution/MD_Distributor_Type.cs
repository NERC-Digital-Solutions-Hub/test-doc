
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 20:33, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
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
  /// Information about the distributor.
  /// </summary>
  [Serializable]
  [XmlType("MD_Distributor", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Distributor", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Distributor")]
  public class MD_Distributor_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Distributor_Type"/>.
    /// </summary>
    public MD_Distributor_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _distributorContact  = default; //  new CI_ResponsibleParty_PropertyType();
      _distributionOrderProcess  = default; //  new List<MD_StandardOrderProcess_PropertyType>();
      _distributorFormat  = default; //  new List<MD_Format_PropertyType>();
      _distributorTransferOptions  = default; //  new List<MD_DigitalTransferOptions_PropertyType>();

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

    private CI_ResponsibleParty_PropertyType _distributorContact;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("distributorContact", Order = 0)]
    [JsonProperty("distributorContact", Order = 0)]
    public CI_ResponsibleParty_PropertyType DistributorContact {
      get {
        return _distributorContact;
      }
      set {
        if (_distributorContact == value) {
          return;
        }
        if (_distributorContact == null || _distributorContact.Equals(value) != true) {
          _distributorContact = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_StandardOrderProcess_PropertyType> _distributionOrderProcess;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("distributionOrderProcess", Order = 1)]
    [JsonProperty("distributionOrderProcess", Order = 1)]
    public List<MD_StandardOrderProcess_PropertyType> DistributionOrderProcess {
      get {
        return _distributionOrderProcess;
      }
      set {
        if (_distributionOrderProcess == value) {
          return;
        }
        if (_distributionOrderProcess == null || _distributionOrderProcess.Equals(value) != true) {
          _distributionOrderProcess = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Format_PropertyType> _distributorFormat;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("distributorFormat", Order = 2)]
    [JsonProperty("distributorFormat", Order = 2)]
    public List<MD_Format_PropertyType> DistributorFormat {
      get {
        return _distributorFormat;
      }
      set {
        if (_distributorFormat == value) {
          return;
        }
        if (_distributorFormat == null || _distributorFormat.Equals(value) != true) {
          _distributorFormat = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_DigitalTransferOptions_PropertyType> _distributorTransferOptions;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("distributorTransferOptions", Order = 3)]
    [JsonProperty("distributorTransferOptions", Order = 3)]
    public List<MD_DigitalTransferOptions_PropertyType> DistributorTransferOptions {
      get {
        return _distributorTransferOptions;
      }
      set {
        if (_distributorTransferOptions == value) {
          return;
        }
        if (_distributorTransferOptions == null || _distributorTransferOptions.Equals(value) != true) {
          _distributorTransferOptions = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}