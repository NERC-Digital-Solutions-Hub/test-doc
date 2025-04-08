
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 06/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
#endregion

#region Constructors - Destructors

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common {

  /// <summary>
  /// Represents an interface for defining a standard value property in geospatial metadata.
  /// This interface ensures that implementing classes provide a structured and serializable
  /// mechanism for handling values in compliance with the ISO 19115 standard.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     The <see cref="Value"/> property is designed to store textual data that represents
  ///     a value associated with a metadata entity.
  ///   </para>
  ///   <para>
  ///     <b>Considerations:</b>
  ///     <list type="bullet">
  ///       <item>
  ///         The <see cref="Value"/> property is a string and may require validation depending on usage.
  ///       </item>
  ///     </list>
  ///   </para>
  /// </remarks>
  public interface IValue {

    /// <summary>
    /// Gets or sets the value associated with a metadata entity.
    /// This property is designed for XML and JSON serialization and represents a
    /// standardized textual representation of geospatial metadata values.
    /// </summary>
    //[XmlText(DataType = "string")]
    //[JsonProperty("Value")]
    public string? Value { // TODO: Check if this should be Value and what JSON serialization should be!!! gcoBase.xsd
      get;
      set;
    }

  }

}
