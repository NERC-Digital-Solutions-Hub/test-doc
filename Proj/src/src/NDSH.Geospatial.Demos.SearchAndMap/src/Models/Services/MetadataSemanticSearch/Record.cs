
#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch {

  /// <summary>
  /// The record returned by the metadata semantic search service.
  /// </summary>
  public sealed class Record {

    /// <summary>
    /// Gets/Sets the metadata record identifier.
    /// </summary>
    [JsonProperty("identifier")]
    public string Identifier {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the metadata record id.
    /// </summary>
    [JsonProperty("recordId")]
    public int Id {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the metadata record title.
    /// </summary>
    [JsonProperty("title")]
    public string Title {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the metadata record title vector embedding.
    /// </summary>
    [JsonProperty("title_emb")]
    public List<double> TitleVectorEmbedding {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the metadata record abstract.
    /// </summary>
    [JsonProperty("abstract")]
    public string Abstract {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the metadata record abstract vector embedding.
    /// </summary>
    [JsonProperty("abstract_emb")]
    public List<double> AbstractVectorEmbedding {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the similarity score of the metadata record when its
    /// title or abstract is compared with the provide query question.
    /// </summary>
    [JsonProperty("scores")]
    public double Score {
      get; set;
    }

  }

}
