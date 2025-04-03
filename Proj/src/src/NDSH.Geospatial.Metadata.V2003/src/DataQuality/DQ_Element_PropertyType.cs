
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 02:03, @gisvlasta.
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_Element_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_Element_PropertyType")]
  public class DQ_Element_PropertyType : ObjectReference_PropertyType {
    
    #region Public Properties
    
    private AbstractDQ_Element_Type _abstractDQ_Element;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractDQ_Element", Order = 0)]
    [JsonProperty("AbstractDQ_Element", Order = 0)]
    public AbstractDQ_Element_Type AbstractDQ_Element {
      get {
        return _abstractDQ_Element;
      }
      set {
        if (_abstractDQ_Element == value) {
          return;
        }
        if (_abstractDQ_Element == null || _abstractDQ_Element.Equals(value) != true) {
          _abstractDQ_Element = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
