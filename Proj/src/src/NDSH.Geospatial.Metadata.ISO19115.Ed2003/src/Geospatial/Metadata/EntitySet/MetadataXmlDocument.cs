
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

using System.Xml.Linq;

#endregion

namespace NDSH.Geospatial.Metadata.EntitySet {

  public class MetadataXmlDocument : Metadata {

    // WARNING: Think if this needs to be a string!!!
    private XDocument _xml;

    public XDocument Xml {
      get => _xml;
      set => _ = SetProperty(ref _xml, value);
    }

  }

}
