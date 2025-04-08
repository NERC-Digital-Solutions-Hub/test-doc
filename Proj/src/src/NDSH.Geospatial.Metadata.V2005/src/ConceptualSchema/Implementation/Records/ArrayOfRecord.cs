
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

using NDSH.Geospatial.Metadata.V2005;
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

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Records {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = true)]
  [JsonObject("ArrayOfRecord")]
  public class ArrayOfRecord : Model {

    #region Cosntructors - Destructors

    /// <summary>
    /// Initialzies the <see cref="ArrayOfRecord"/>.
    /// </summary>
    public ArrayOfRecord() {
      _record = new List<Record>();
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

    private List<Record> _record;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Record", IsNullable = true, Order = 0)]
    [JsonProperty(Order = 0)]
    public List<Record> Record {
      get {
        return _record;
      }
      set {
        if (_record == value) {
          return;
        }
        if (_record == null || _record.Equals(value) != true) {
          _record = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
