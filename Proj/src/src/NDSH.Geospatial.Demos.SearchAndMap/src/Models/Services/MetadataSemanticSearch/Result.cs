
#region Imported Namespaces

//using Esri.ArcGISRuntime.Portal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch {

  /// <summary>
  /// The result returned by the metadata semantic search service.
  /// </summary>
  public sealed class Result {

    /// <summary>
    /// Gets/Sets the list of records returned by the metadata semantic search service.
    /// </summary>
    [JsonProperty("result")]
    public List<Record> Records {
      get; set;
    }

  }

}
