
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 04:38, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// --------------------------------------------------------------------------------
// <attribute name="remoteSchema" type="anyURI">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </attribute>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Base {

  /// <summary>
  /// Provides the interface for the remote schema.
  /// </summary>
  /// <remarks>
  /// This is an obsolete interface. (Marked deprecated in gml/gmlBase.xsd)
  /// </remarks>
  [Obsolete()]
  public interface IRemoteSchema { // TODO: What should be done with this [Obsolete] (deprecated) Interface?

    /// <summary>
    /// Gets / Sets the remote schema.
    /// </summary>
    //[XmlAttribute("remoteSchema", DataType = "anyURI", Form = XmlSchemaForm.Qualified)] // TODO: Does it need the [XmlAttribute] ???
    //[XmlIgnore]
    //[JsonProperty("remoteSchema")]
    public string RemoteSchema {
      get;
      set;
    }

  }

}
