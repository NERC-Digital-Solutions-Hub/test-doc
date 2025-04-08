
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 18:55, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_PortSpecification", Namespace = "http://www.isotc211.org/2005/srv")]
  [XmlRoot("SV_PortSpecification", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_PortSpecification")]
  public class SV_PortSpecification_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_PortSpecification_Type"/>.
    /// </summary>
    public SV_PortSpecification_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _binding = default; // new DCPList_PropertyType();
      _address = default; // new URL_PropertyType();
      _theSV_Port = default; // new SV_Port_PropertyType();

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

    private DCPList_PropertyType _binding;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("binding", Order = 0)]
    [JsonProperty("binding", Order = 0)]
    public DCPList_PropertyType Binding {
      get {
        return _binding;
      }
      set {
        if (_binding == value) {
          return;
        }
        if (_binding == null || _binding.Equals(value) != true) {
          _binding = value;
          OnPropertyChanged();
        }
      }
    }

    private URL_PropertyType _address;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("address", Order = 1)]
    [JsonProperty("address", Order = 1)]
    public URL_PropertyType Address {
      get {
        return _address;
      }
      set {
        if (_address == value) {
          return;
        }
        if (_address == null || _address.Equals(value) != true) {
          _address = value;
          OnPropertyChanged();
        }
      }
    }
    
    private SV_Port_PropertyType _theSV_Port;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("theSV_Port", Order = 2)]
    [JsonProperty("theSV_Port", Order = 2)]
    public SV_Port_PropertyType TheSV_Port {
      get {
        return _theSV_Port;
      }
      set {
        if (_theSV_Port == value) {
          return;
        }
        if (_theSV_Port == null || _theSV_Port.Equals(value) != true) {
          _theSV_Port = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
