
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 15:28, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.DataQuality;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality {

  /// <summary>
  /// Degree of adherence of a dataset to a specific set of user requirements.
  /// </summary>
  /// <remarks>ShortName: Usability</remarks>
  [Serializable]
  [XmlType("QE_Usability", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("QE_Usability", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("QE_Usability")]
  public class QE_Usability_Type : AbstractDQ_Element_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="QE_Usability_Type"/>
    /// </summary>
    public QE_Usability_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

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
