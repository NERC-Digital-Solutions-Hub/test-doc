
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 20:57, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
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
  [XmlType("MX_SupportFile", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("MX_SupportFile", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  public class MX_SupportFile_Type : AbstractMX_File_Type {
    
    //#region Public Fields

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlNamespaceDeclarations()]
    //public XmlSerializerNamespaces xmlns;

    //#endregion

  }

}
