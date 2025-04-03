
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 16:16, @gisvlasta.
// Updated by        : 10/01/2023, 00:53, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MX_File_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("MX_File_PropertyType")]
  public class MX_File_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MX_File_PropertyType"/>.
    /// </summary>
    public MX_File_PropertyType() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

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

    private AbstractMX_File_Type _abstractMX_File;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractMX_File", Order = 0)]
    [JsonProperty("AbstractMX_File", Order = 0)]
    public AbstractMX_File_Type AbstractMX_File {
      get {
        return _abstractMX_File;
      }
      set {
        if (_abstractMX_File == value) {
          return;
        }
        if (_abstractMX_File == null || _abstractMX_File.Equals(value) != true) {
          _abstractMX_File = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
