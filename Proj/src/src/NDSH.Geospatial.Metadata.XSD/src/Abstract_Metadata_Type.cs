
#region Header
// Title Name        : Abstract_Metadata_Type
// Member of         : NDSH.Geospatial.Metadata.dll
// Description       : 
// Created by        : 10/09/2022, 20:35, Vasilis Vlastaras.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : 
// License           : 
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

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

namespace NDSH.Geospatial.Metadata {

  [XmlInclude(typeof(MD_Metadata_Type))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategoryAttribute("code")]
  [XmlTypeAttribute(Namespace = "http://standards.iso.org/iso/19115/-3/mcc/1.0")]
  [XmlRootAttribute("Abstract_Metadata_Type")]
  [JsonObject("Abstract_Metadata_Type")]
  public abstract class Abstract_Metadata_Type : AbstractObject_Type {

  }

}
