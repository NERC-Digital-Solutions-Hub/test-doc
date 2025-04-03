
#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Serializers {

  /// <summary>
  /// 
  /// </summary>
  public sealed class JsonSerializer {

    /// <summary>
    /// Serializes the specified <see cref="object"/> into a JSON <see cref="string"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to serialize.</param>
    /// <param name="indent">Indicates whether the JSON will be indented or not.</param>
    /// <remarks><paramref name="indent"/> default value is <code>true</code>.</remarks>
    /// <returns>A JSON formatted <see cref="string"/> with the serialized object.</returns>
    public string SerializeJson(object obj, bool indent = true) {
      JsonSerializerSettings settings = new JsonSerializerSettings {
        Formatting = Newtonsoft.Json.Formatting.Indented
      };
      return JsonConvert.SerializeObject(obj, settings);
    }

    ///// <summary>
    ///// Serializes the <see cref="EntityBase{T}"/> object into a JSON file.
    ///// </summary>
    ///// <param name="fileName">The full path and name of the output JSON file.</param>
    //public virtual void SaveToJsonFile(string fileName) {

    //  StreamWriter streamWriter = null;

    //  try {
    //    string dataString = SerializeJson();

    //    FileInfo outputFile = new FileInfo(fileName);

    //    streamWriter = outputFile.CreateText();
    //    streamWriter.WriteLine(dataString);
    //    streamWriter.Close();
    //  }
    //  finally {
    //    if (streamWriter != null) {
    //      streamWriter.Dispose();
    //    }
    //  }

    //}

    ///// <summary>
    ///// Deserializes a JSON <see cref="string"/> into an <see cref="EntityBase{T}"/> object.
    ///// </summary>
    ///// <param name="input">The JSON <see cref="string"/>to deserialize.</param>
    ///// <param name="obj">Outputs the <see cref="EntityBase{T}"/> object.</param>
    ///// <param name="exception">
    ///// Outputs the <see cref="Exception"/> in case the deserialization fails.
    ///// </param>
    ///// <returns>
    ///// A <see cref="Boolean"/> value indicating whether the deserialization succeeded or not.
    ///// </returns>
    //public static bool DeserializeJson(string input, out T obj, out Exception exception) {

    //  exception = null;
    //  obj = default;

    //  try {
    //    obj = DeserializeJson(input);
    //    return true;
    //  }
    //  catch (Exception ex) {
    //    exception = ex;
    //    return false;
    //  }

    //}

    ///// <summary>
    ///// Deserializes the JSON <see cref="string"/> into an <see cref="EntityBase{T}"/> object.
    ///// </summary>
    ///// <param name="input">The JSON <see cref="string"/> to deserialize.</param>
    ///// <param name="obj">Outputs the <see cref="EntityBase{T}"/> object.</param>
    ///// <returns>
    ///// A <see cref="Boolean"/> value indicating whether the deserialization succeeded or not.
    ///// </returns>
    //public static bool DeserializeJson(string input, out T obj) {
    //  return DeserializeJson(input, out obj, out _);
    //}

    ///// <summary>
    ///// Deserializes the JSON <see cref="string"/> into an <see cref="EntityBase{T}"/> object.
    ///// </summary>
    ///// <param name="input">The JSON <see cref="string"/> to deserialize.</param>
    ///// <returns>
    ///// An instance of the deserialized <see cref="EntityBase{T}"/> object.
    ///// </returns>
    //public static T DeserializeJson(string input) {
    //  JsonSerializerSettings settings = new JsonSerializerSettings {
    //    Formatting = Newtonsoft.Json.Formatting.Indented
    //  };

    //  return JsonConvert.DeserializeObject<T>(input, settings);
    //}

    ///// <summary>
    ///// Deserializes a JSON file into an <see cref="EntityBase{T}"/> object.
    ///// </summary>
    ///// <param name="fileName">The full path and name of the JSON file to deserialize.</param>
    ///// <returns>
    ///// An instance of the deserialized <see cref="EntityBase{T}"/> object.
    ///// </returns>
    //public static T LoadFromJsonFile(string fileName) {

    //  FileStream file = null;
    //  StreamReader sr = null;

    //  try {
    //    file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
    //    sr = new StreamReader(file);

    //    string dataString = sr.ReadToEnd();
    //    sr.Close();
    //    file.Close();

    //    return DeserializeJson(dataString);
    //  }
    //  finally {
    //    if (file != null) {
    //      file.Dispose();
    //    }
    //    if (sr != null) {
    //      sr.Dispose();
    //    }
    //  }

    //}

  }

}
