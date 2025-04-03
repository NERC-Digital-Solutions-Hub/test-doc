
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 04:27, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Names;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_Interface", Namespace = "http://www.isotc211.org/2005/srv")]
  [XmlRoot("SV_Interface", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_Interface")]
  public class SV_Interface_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Interface_Type"/>.
    /// </summary>
    public SV_Interface_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _typeName = default; // new TypeName_PropertyType();
      _operation = default; // new SV_Operation_PropertyType();
      _theSV_PortSpecification = default; // new SV_PortSpecification_PropertyType();

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

    private TypeName_PropertyType _typeName;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("typeName", Order = 0)]
    [JsonProperty("typeName", Order = 0)]
    public TypeName_PropertyType TypeName {
      get {
        return _typeName;
      }
      set {
        if (_typeName == value) {
          return;
        }
        if (_typeName == null || _typeName.Equals(value) != true) {
          _typeName = value;
          OnPropertyChanged();
        }
      }
    }

    private SV_Operation_PropertyType _operation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("operation", Order = 1)]
    [JsonProperty("operation", Order = 1)]
    public SV_Operation_PropertyType Operation {
      get {
        return _operation;
      }
      set {
        if (_operation == value) {
          return;
        }
        if (_operation == null || _operation.Equals(value) != true) {
          _operation = value;
          OnPropertyChanged();
        }
      }
    }

    private SV_PortSpecification_PropertyType _theSV_PortSpecification; //  " minOccurs="0"/>

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("theSV_PortSpecification", Order = 2)]
    [JsonProperty("theSV_PortSpecification", Order = 2)]
    public SV_PortSpecification_PropertyType TheSV_PortSpecification {
      get {
        return _theSV_PortSpecification;
      }
      set {
        if (_theSV_PortSpecification == value) {
          return;
        }
        if (_theSV_PortSpecification == null || _theSV_PortSpecification.Equals(value) != true) {
          _theSV_PortSpecification = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
