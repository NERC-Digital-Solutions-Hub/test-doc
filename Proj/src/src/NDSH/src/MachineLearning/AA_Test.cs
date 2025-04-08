
using Microsoft.ML;
using Microsoft.ML.Transforms.Text;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDSH.MachineLearning {

  internal class AA_Test {

    /// <summary>
    /// 
    /// </summary>
    public void DefaultGenerateVE() {

      //// Load your data
      //var mlContext = new MLContext();

      //var data = mlContext.Data.LoadFromTextFile<YourData>(path: "data.csv", hasHeader: true, separatorChar: ',');

      //// Define your text embedding pipeline
      //var pipeline = mlContext.Transforms.Text.NormalizeText("Text")
      //    .Append(mlContext.Transforms.Text.TokenizeIntoWords("Tokens", "Text"))
      //    .Append(mlContext.Transforms.Text.RemoveDefaultStopWords("Tokens"))
      //    .Append(mlContext.Transforms.Text.ApplyWordEmbedding("Embeddings", "Tokens", WordEmbeddingEstimator.PretrainedModelKind.SentimentSpecificWordEmbedding));

      //// Fit your pipeline
      //var model = pipeline.Fit(data);

      //// Generate embeddings for your dataset
      //var transformedData = model.Transform(data);

      //// Save your embeddings
      //mlContext.Data.SaveAsText(transformedData, "embeddings.txt", separatorChar: '\t', headerRow: true);

    }

    public void GenerateVectorEmbeddingsBERT() {
    

    
    }


  }
}

#region BERT Generate Vector Embeddings

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using Microsoft.ML;
//using Microsoft.ML.Transforms.Text;
//using Microsoft.ML.Transforms;

//namespace BERTEmbeddings {
//  class Program {
//    static void Main(string[] args) {
//      // Define paths to the input and output data files
//      string inputDataPath = @"path/to/input/data.tsv";
//      string outputDataPath = @"path/to/output/data.csv";

//      // Load the data from the input file
//      MLContext mlContext = new MLContext();
//      IDataView dataView = mlContext.Data.LoadFromTextFile<InputData>(inputDataPath, separatorChar: '\t', hasHeader: true);

//      // Define the BERT model configuration
//      BertModelConfigurator bertConfigurator = new BertModelConfigurator() {
//        // Specify the path to the pre-trained BERT model
//        ModelPath = @"path/to/pretrained/BERT/model",
//        // Specify the input column name
//        InputColumnName = nameof(InputData.Abstract),
//        // Specify the output column name
//        OutputColumnName = "BERTEmbeddings",
//        // Specify the number of embedding dimensions to output
//        NumOutputColumns = 768,
//        // Specify the maximum length of the input sequence
//        MaxSequenceLength = 128,
//        // Specify the name of the attention mask column
//        AttentionMaskColumnName = "AttentionMask"
//      };

//      // Define the pipeline to generate sentence embeddings using BERT
//      var pipeline = mlContext.Transforms.Text.NormalizeText("Abstract")
//          .Append(mlContext.Transforms.Text.TokenizeIntoWords("Tokens", "Abstract"))
//          .Append(mlContext.Transforms.Conversion.MapValue("AttentionMask", new int[bertConfigurator.MaxSequenceLength]))
//          .Append(mlContext.Transforms.Conversion.MapValue("Label", new float[bertConfigurator.NumOutputColumns]))
//          .Append(bertConfigurator.GetModelPipeline(mlContext))
//          .Append(mlContext.Transforms.Concatenate("Features", "BERTEmbeddings", "AttentionMask"))
//          .Append(mlContext.Transforms.NormalizeMinMax("Features"));

//      // Fit the pipeline to the data
//      IDataView transformedData = pipeline.Fit(dataView).Transform(dataView);

//      // Convert the output to a list of OutputData objects
//      IEnumerable<OutputData> outputData = mlContext.Data.CreateEnumerable<OutputData>(transformedData, reuseRowObject: false);

//      // Write the output data to a CSV file
//      using (StreamWriter writer = new StreamWriter(outputDataPath)) {
//        writer.WriteLine("Abstract,Features");
//        foreach (OutputData output in outputData) {
//          writer.WriteLine($"{output.Abstract},[{string.Join(",", output.Features)}]");
//        }
//      }
//    }
//  }

//  public class InputData {
//    public string Abstract {
//      get; set;
//    }
//  }

//  public class OutputData {
//    public string Abstract {
//      get; set;
//    }
//    public float[] Features {
//      get; set;
//    }
//  }
//}

#endregion

#region BERT Match Sentences

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using Microsoft.ML;
//using Microsoft.ML.Data;

//namespace SentenceMatching {
//  class Program {
//    static void Main(string[] args) {
//      // Define paths to the input and output data files
//      string inputDataPath = @"path/to/input/sentence.txt";
//      string embeddingsDataPath = @"path/to/embeddings/data.csv";

//      // Load the pre-computed embeddings from the CSV file
//      List<EmbeddingData> embeddingsData = new List<EmbeddingData>();
//      using (TextFieldParser parser = new TextFieldParser(embeddingsDataPath)) {
//        parser.TextFieldType = FieldType.Delimited;
//        parser.SetDelimiters(",");
//        bool isHeader = true;
//        while (!parser.EndOfData) {
//          string[] fields = parser.ReadFields();
//          if (isHeader) {
//            isHeader = false;
//            continue;
//          }
//          EmbeddingData embedding = new EmbeddingData() {
//            Abstract = fields[0],
//            Features = fields[1].Substring(1, fields[1].Length - 2).Split(',').Select(x => float.Parse(x)).ToArray()
//          };
//          embeddingsData.Add(embedding);
//        }
//      }

//      // Keep the embeddings loaded in memory
//      List<InputData> inputData = embeddingsData.Select(x => new InputData() { Abstract = x.Abstract }).ToList();
//      MLContext mlContext = new MLContext();
//      IDataView dataView = mlContext.Data.LoadFromEnumerable(inputData);
//      var pipeline = mlContext.Transforms.Conversion.MapValue("Features", embeddingsData.Select(x => x.Features).ToArray(), keyColumnName: "Abstract", valueColumnName: "Features");
//      IDataView transformedData = pipeline.Fit(dataView).Transform(dataView);
//      var featuresData = mlContext.Data.CreateEnumerable<FeaturesData>(transformedData, reuseRowObject: false).ToList();
//      Dictionary<string, float[]> featuresMap = featuresData.ToDictionary(x => x.Abstract, x => x.Features);

//      // Load the sentence to match
//      string sentenceToMatch = File.ReadAllText(inputDataPath).Trim();

//      // Generate the embedding for the sentence to match
//      var bertConfigurator = new BertModelConfigurator() {
//        ModelPath = @"path/to/pretrained/BERT/model",
//        InputColumnName = nameof(InputData.Abstract),
//        OutputColumnName = "BERTEmbeddings",
//        NumOutputColumns = 768,
//        MaxSequenceLength = 128,
//        AttentionMaskColumnName = "AttentionMask"
//      };
//      var sentenceData = new List<InputData>() { new InputData() { Abstract = sentenceToMatch } };
//      IDataView sentenceDataView = mlContext.Data.LoadFromEnumerable(sentenceData);
//      var sentencePipeline = mlContext.Transforms.Text.NormalizeText("Abstract")
//          .Append(mlContext.Transforms.Text.TokenizeIntoWords("Tokens", "Abstract"))
//          .Append(mlContext.Transforms.Conversion.MapValue("AttentionMask", new int[bertConfigurator.MaxSequenceLength]))
//          .Append(bertConfigurator.GetModelPipeline(mlContext))
//          .Append(mlContext.Transforms.Concatenate("Features", "BERTEmbeddings", "AttentionMask"));
//      IDataView sentenceTransformedData = sentencePipeline.Fit(sentenceDataView).Transform(sentenceDataView);
//      var sentenceFeaturesData = mlContext.Data.CreateEnumerable<FeaturesData>(sentenceTransformedData, reuseRowObject: false).ToList();
//      float[] sentenceFeatures = sentenceFeaturesData.First().Features;

//      // Calculate the similarity between the new sentence's embedding and the pre-computed embeddings
//      var similarityScores = embeddingsData.Select(x => new
//      {
//        Abstract = x.Abstract,
//        SimilarityScore = CosineSimilarity(sentenceFeatures, featuresMap[x.Abstract])
//      })
//      .OrderByDescending(x => x.SimilarityScore)
//      .Take(n)
//      .ToList();

//      // Print the n best matches
//      Console.WriteLine($"Best {n} matches for \"{sentenceToMatch}\":");
//      foreach (var item in similarityScores) {
//        Console.WriteLine($"{item.Abstract}\t{item.SimilarityScore}");
//      }
//    }

//    private static float CosineSimilarity(float[] vectorA, float[] vectorB) {
//      float dotProduct = vectorA.Zip(vectorB, (a, b) => a * b).Sum();
//      float magnitudeA = (float)Math.Sqrt(vectorA.Select(x => x * x).Sum());
//      float magnitudeB = (float)Math.Sqrt(vectorB.Select(x => x * x).Sum());
//      return dotProduct / (magnitudeA * magnitudeB);
//    }

//    public class InputData {
//      [LoadColumn(0)]
//      public string Abstract {
//        get; set;
//      }
//    }

//    public class EmbeddingData {
//      public string Abstract {
//        get; set;
//      }
//      public float[] Features {
//        get; set;
//      }
//    }

//    public class FeaturesData {
//      public string Abstract {
//        get; set;
//      }
//      public float[] Features {
//        get; set;
//      }
//    }
//  }
//}

#endregion




