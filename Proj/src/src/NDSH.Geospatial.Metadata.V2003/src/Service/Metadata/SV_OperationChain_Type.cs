
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 02:08, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Features.Model;
using NDSH.Geospatial.Metadata.V2003.Service.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Service.Metadata {

  /// <summary>
  ///
  /// </summary>
  [Serializable]
  [XmlType("SV_OperationChain", Namespace = "http://www.isotc211.org/2005/srv")]
  [XmlRoot("SV_OperationChain", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_OperationChain")]
  public class SV_OperationChain_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_OperationChain_Type"/>
    /// </summary>
    public SV_OperationChain_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("srv", "http://www.isotc211.org/2005/srv");

      _name = default;
      _description = default;
      _operation = default;

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

    private CharacterString_PropertyType _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString_PropertyType Name {
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

    private List<SV_Operation_PropertyType> _operation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("operation", Order = 2)]
    [JsonProperty("operation", Order = 2)]
    public List<SV_Operation_PropertyType> Operation {
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

    #endregion

  }

}
