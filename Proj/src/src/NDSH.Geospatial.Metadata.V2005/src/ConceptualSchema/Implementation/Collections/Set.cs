
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

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Collections {
  
  /// <summary>
  /// 
  /// </summary>
  [SerializableAttribute()]
  [DebuggerStepThrough()]
  [XmlTypeAttribute(AnonymousType=false)]
  [XmlRoot(Namespace="", IsNullable=false)]
  public partial class Set<T> : List<T> {

    // TODO: IMPORTANT!!! This class inherits from List<T> - Check out what that means for the project.

    #region Public Properties

    private int sizeField;

    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="size")]
    public int size {
      get {
        return sizeField;
      }
      set {
        sizeField = value;
      }
    }

    #endregion

  }

}
