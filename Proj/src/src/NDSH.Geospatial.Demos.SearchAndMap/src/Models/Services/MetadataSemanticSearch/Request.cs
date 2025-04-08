
#region Imported Namespaces

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Demos.SearchAndMap.Models.Services.MetadataSemanticSearch {

  /// <summary>
  /// The request that is submitted to the metadata semantic search service.
  /// </summary>
  public sealed class Request : Model {

    ////var query = "find me datasets showing precipitation in the uk for the last 20 years";
    //var query = "landslides";
    ////var queryCol = "abstract";
    //var queryCol = "title";
    //var topK = 20;
    ////var showColumns = new List<string> { "identifier", "title", "abstract", "abstract_emb", "scores" };
    //var showColumns = new List<string> { "identifier", "recordId", "title", "scores" };

    #region Public Properties

    private string _query;

    /// <summary>
    /// Gets/Sets the query that is submitted to the metadata semantic search service.
    /// </summary>
    public string Query {
      get {
        return _query;
      }
      set {
        if (_query != value) {
          _query = value;
          OnPropertyChanged();
        }
      }
    }

    private string _queryField;

    /// <summary>
    /// Gets/Sets the field used to perform the similarity search.
    /// </summary>
    public string QueryField {
      get {
        return _queryField;
      }
      set {
        if (_queryField != value) {
          _queryField = value;
          OnPropertyChanged();
        }
      }
    }

    private int _topNumberOfRecords;

    /// <summary>
    /// Gets/Sets the number of records with the top most similar results returned by the metadata semantic search service.
    /// </summary>
    public int TopNumberOfRecords {
      get {
        return _topNumberOfRecords;
      }
      set {
        if (_topNumberOfRecords != value) {
          _topNumberOfRecords = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _returnedFields;

    /// <summary>
    /// Gets/Sets the result's fields returned by the metadata semantic search service.
    /// </summary>
    public List<string> ReturnedFields {
      get {
        return _returnedFields;
      }
      set {
        if (_returnedFields != value) {
          _returnedFields = value;
          OnPropertyChanged();
        }
      }
    }

    private bool _isUsed;

    /// <summary>
    /// Gets/Sets whether the request is used by the metadata semantic search service.
    /// </summary>
    public bool IsUsed {
      get {
        return _isUsed;
      }
      set {
        if (_isUsed != value) {
          _isUsed = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Converts the <see cref="Request"/> to a dictionary of keys and values used to
    /// encode the request to be submitted to the metadata semantic search service.
    /// </summary>
    /// <returns>
    /// A <see cref="Dictionary{TKey, TValue}"/> where TKey is <see cref="string"/>
    /// and TValue is <see cref="object"/>
    /// </returns>
    public Dictionary<string, object> ToDictionary() {

      return new Dictionary<string, object> {
        { "query", Query },
        { "query_col", QueryField },
        { "topk", TopNumberOfRecords },
        { "show_columns", ReturnedFields }
      };

    }

    #endregion

  }

}
