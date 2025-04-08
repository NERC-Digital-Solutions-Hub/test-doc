
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : dd/01/2023, hh:mm, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.Codelist;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Dictionary {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(CodeListDictionary_Type))]
  [XmlInclude(typeof(ML_CodeListDictionary_Type))]
  [Serializable]
  [XmlType("DictionaryType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DictionaryType")]
  public class DictionaryType : DefinitionType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DictionaryType"/>.
    /// </summary>
    public DictionaryType() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gml", "http://www.opengis.net/gml");

      _items = default; //  new List<object>();

    }

    #endregion

    #region Public Fields

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlNamespaceDeclarations()]
    //public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<object> _items;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dictionaryEntry", typeof(DictionaryEntryType), Order = 0)]
    [XmlElement("indirectEntry", typeof(IndirectEntryType), Order = 0)]
    public List<object> Items {
      get {
        return _items;
      }
      set {
        if (_items == value) {
          return;
        }
        if (_items == null || _items.Equals(value) != true) {
          _items = value;
          OnPropertyChanged();
        }
      }
    }

    private AggregationType _aggregationType;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("aggregationType")]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
