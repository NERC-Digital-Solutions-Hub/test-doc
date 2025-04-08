
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 03:08, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// XSD               : /2005/gml/gmlBase.xsd
// --------------------------------------------------------------------------------
// <attributeGroup name="OwnershipAttributeGroup">
//   <attribute name="owns" type="boolean" default="false"/>
// </attributeGroup>
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Base {

  /// <summary>
  /// Encoding a GML property inline vs. by-reference shall not imply anything about
  /// the “ownership” of the contained or referenced GML Object, i.e.the encoding style
  /// shall not imply any “deep-copy” or “deep-delete” semantics.To express ownership over
  /// the contained or referenced GML Object, the gml:OwnershipAttributeGroup attribute group
  /// may be added to object-valued property elements.If the attribute group is not part of the
  /// content model of such a property element, then the value may not be “owned”.
  /// When the value of the owns attribute is "true", the existence of inline or referenced
  /// object(s) depends upon the existence of the parent object.
  /// </summary>
  public interface IOwnershipAttributeGroup {

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("owns")]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get;
      set;
    }

  }

}
