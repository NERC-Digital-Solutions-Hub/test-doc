
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Feature {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false)]
  [JsonObject("Multiplicity")]
  public class Multiplicity : EntityBase<Multiplicity> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Multiplicity"/>.
    /// </summary>
    public Multiplicity() {
      _range = new MultiplicityRange();
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

    private MultiplicityRange _range;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "range")]
    [JsonProperty("range", Order = 0)]
    public MultiplicityRange Range {
      get {
        return _range;
      }
      set {
        if (_range == value) {
          return;
        }
        if (_range == null || _range.Equals(value) != true) {
          _range = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
