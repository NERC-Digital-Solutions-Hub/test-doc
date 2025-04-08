
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 23:30, @gisvlasta.
// Updated by        : 09/01/2023, 20:48, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Common.Extent;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ReferenceSystem {

  /// <summary>
  /// Description of the spatial and temporal reference systems used in the dataset.
  /// </summary>
  [Serializable]
  [XmlType("AbstractRS_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("AbstractRS_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractRS_ReferenceSystem")]
  public abstract class AbstractRS_ReferenceSystem_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractRS_ReferenceSystem_Type"/>.
    /// </summary>
    public AbstractRS_ReferenceSystem_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _name  = default; //  new RS_Identifier_PropertyType();
      _domainOfValidity  = default; //  new List<EX_Extent_PropertyType>();

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

    private RS_Identifier_PropertyType _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public RS_Identifier_PropertyType Name {
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

    private List<EX_Extent_PropertyType> _domainOfValidity;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("domainOfValidity", Order = 1)]
    [JsonProperty("domainOfValidity", Order = 1)]
    public List<EX_Extent_PropertyType> DomainOfValidity {
      get {
        return _domainOfValidity;
      }
      set {
        if (_domainOfValidity == value) {
          return;
        }
        if (_domainOfValidity == null || _domainOfValidity.Equals(value) != true) {
          _domainOfValidity = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
