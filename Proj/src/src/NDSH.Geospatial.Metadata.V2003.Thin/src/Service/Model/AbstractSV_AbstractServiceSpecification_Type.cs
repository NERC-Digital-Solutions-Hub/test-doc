
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 20:13, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Multiplicities;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(SV_ServiceSpecification_Type))]
  [XmlInclude(typeof(SV_PlatformNeutralServiceSpecification_Type))]
  [XmlInclude(typeof(SV_PlatformSpecificServiceSpecification_Type))]
  [Serializable]
  [XmlType("AbstractSV_AbstractServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv")]
  [XmlRoot("AbstractSV_AbstractServiceSpecification", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("AbstractSV_AbstractServiceSpecification")]
  public abstract class AbstractSV_AbstractServiceSpecification_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractSV_AbstractServiceSpecification_Type"/>
    /// </summary>
    public AbstractSV_AbstractServiceSpecification_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _name = default; // new CharacterString_PropertyType();
      _opModel = default; // new SV_OperationModel_PropertyType();
      _theSV_Interface = default; // new List<SV_Interface_PropertyType>();

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

    private SV_OperationModel_PropertyType _opModel;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("opModel", Order = 1)]
    [JsonProperty("opModel", Order = 1)]
    public SV_OperationModel_PropertyType OpModel {
      get {
        return _opModel;
      }
      set {
        if (_opModel == value) {
          return;
        }
        if (_opModel == null || _opModel.Equals(value) != true) {
          _opModel = value;
          OnPropertyChanged();
        }
      }
    }

    private List<SV_Interface_PropertyType> _theSV_Interface;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("theSV_Interface", Order = 2)]
    [JsonProperty("theSV_Interface", Order = 2)]
    public List<SV_Interface_PropertyType> TheSV_Interface {
      get {
        return _theSV_Interface;
      }
      set {
        if (_theSV_Interface == value) {
          return;
        }
        if (_theSV_Interface == null || _theSV_Interface.Equals(value) != true) {
          _theSV_Interface = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
