
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 16:38, @gisvlasta.
// Updated by        : 10/01/2023, 01:37, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Dictionary;
using Newtonsoft.Json;
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

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.Codelist {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(ML_CodeDefinition_Type))]
  [Serializable]
  [XmlType("CodeDefinition", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("CodeDefinition", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("CodeDefinition")]
  public class CodeDefinition_Type : DefinitionType {

    #region Constructors - Destructors

    /// <summary>
    /// 
    /// </summary>
    public CodeDefinition_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public new XmlSerializerNamespaces xmlns;

    #endregion

  }

}
