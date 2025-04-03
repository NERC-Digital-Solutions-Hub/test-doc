
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 20:34, @gisvlasta.
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
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  /// <summary>
  /// 
  /// </summary>
  [Serializable()]
  [XmlType(AnonymousType = false)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_MetaDataAttributeType : GF_AttributeType {

  }

}
