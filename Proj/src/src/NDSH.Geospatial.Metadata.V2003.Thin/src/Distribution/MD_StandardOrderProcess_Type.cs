
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 20:59, @gisvlasta.
// Updated by        : 09/01/2023, 19:09, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.DateTime;
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
  /// Common ways in which the dataset may be obtained or received, and related instructions and fee information.
  /// </summary>
  [Serializable]
  [XmlType("MD_StandardOrderProcess", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_StandardOrderProcess", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_StandardOrderProcess")]
  public class MD_StandardOrderProcess_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_StandardOrderProcess_Type"/>.
    /// </summary>
    public MD_StandardOrderProcess_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _fees  = default; //  new CharacterString_PropertyType();
      _plannedAvailableDateTime  = default; //  new DateTime_PropertyType();
      _orderingInstructions  = default; //  new CharacterString_PropertyType();
      _turnaround  = default; //  new CharacterString_PropertyType();

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

    private CharacterString _fees;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fees", Order = 0)]
    [JsonProperty("fees", Order = 0)]
    public CharacterString Fees {
      get {
        return _fees;
      }
      set {
        if (_fees == value) {
          return;
        }
        if (_fees == null || _fees.Equals(value) != true) {
          _fees = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTime_PropertyType _plannedAvailableDateTime;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("plannedAvailableDateTime", Order = 1)]
    [JsonProperty("plannedAvailableDateTime", Order = 1)]
    public DateTime_PropertyType PlannedAvailableDateTime {
      get {
        return _plannedAvailableDateTime;
      }
      set {
        if (_plannedAvailableDateTime == value) {
          return;
        }
        if (_plannedAvailableDateTime == null || _plannedAvailableDateTime.Equals(value) != true) {
          _plannedAvailableDateTime = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _orderingInstructions;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("orderingInstructions", Order = 2)]
    [JsonProperty("orderingInstructions", Order = 2)]
    public CharacterString OrderingInstructions {
      get {
        return _orderingInstructions;
      }
      set {
        if (_orderingInstructions == value) {
          return;
        }
        if (_orderingInstructions == null || _orderingInstructions.Equals(value) != true) {
          _orderingInstructions = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _turnaround;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("turnaround", Order = 3)]
    [JsonProperty("turnaround", Order = 3)]
    public CharacterString Turnaround {
      get {
        return _turnaround;
      }
      set {
        if (_turnaround == value) {
          return;
        }
        if (_turnaround == null || _turnaround.Equals(value) != true) {
          _turnaround = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}