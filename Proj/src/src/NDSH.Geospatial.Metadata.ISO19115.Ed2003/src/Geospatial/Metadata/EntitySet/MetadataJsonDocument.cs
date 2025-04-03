
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 18/02/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

#endregion

namespace NDSH.Geospatial.Metadata.EntitySet {

  public class MetadataJsonDocument : Metadata {

    // WARNING: Think if this needs to be a string!!!
    private JsonDocument _json;

    public JsonDocument Json {
      get => _json;
      set => _ = SetProperty(ref _json, value);
    }

  }

}
