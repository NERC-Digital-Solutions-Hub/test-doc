using NDSH.Geospatial.Metadata.EntitySet;
using NDSH.Geospatial.Serializers.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Json.Metadata.EntitySet {

  public class Test : JsonConverter {
    public override bool CanConvert(Type objectType) {
      throw new NotImplementedException();
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
      throw new NotImplementedException();
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
      throw new NotImplementedException();
    }
  }

  /// <summary>
  /// Converts the <see cref="MetadataDocument"/> to JSON.
  /// </summary>
  public sealed class MetadataDocumentJsonConverter : JsonConverter<MetadataDocument> {

    // TODO: Create a wrapper for JsonConverter so that its easier to switch between different implementations in the
    // future. E.g. Newtonsoft.Json.JsonConverter and System.Text.Json.JsonConverter.
    // The class implementing the wrapper should be ignorant of the actual implementation of the JsonConverter.

    /// <inheritdoc />
    public override MetadataDocument? ReadJson(JsonReader reader, Type objectType, MetadataDocument? existingValue, bool hasExistingValue, JsonSerializer serializer) => throw new NotImplementedException();

    /// <inheritdoc />
    public override void WriteJson(JsonWriter writer, MetadataDocument? value, JsonSerializer serializer) {
      if (value == null) {
        writer.WriteNull();
        return;
      }

      writer.WriteStartObject();

      writer.WritePropertyName("schema");
      writer.WriteValue(value.Schema);

      writer.WritePropertyName("uniqueIdentifier");
      writer.WriteValue(value.UniqueIdentifier.ToString());

      writer.WritePropertyName("data");
      XDocument xmlDocument = XDocument.Parse(value.Data);
      string jsonData = XmlToJsonConverter.Convert(xmlDocument);
      JToken token = JToken.Parse(jsonData);
      token.WriteTo(writer);

      writer.WritePropertyName("createDate");
      writer.WriteValue(value.CreateDate.ToString());

      writer.WritePropertyName("updateDate");
      writer.WriteValue(value.UpdateDate.ToString());

      writer.WriteEndObject();
    }

  }
}
