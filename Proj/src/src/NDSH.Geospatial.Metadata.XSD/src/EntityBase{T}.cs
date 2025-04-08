
#region Header
// Title Name        : EntityBase<T>
// Member of         : NDSH.Geospatial.Metadata.dll
// Description       : The EntityBase for all the Geographic Metadata types.
// Created by        : 09/09/2022, 20:45, Vasilis Vlastaras.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : 
// License           : 
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using MsgPack.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;

#endregion

namespace NDSH.Geospatial.Metadata {

  /// <summary>
  /// The EntityBase for all the Geographic Metadata types.
  /// </summary>
  public class EntityBase<T> : INotifyPropertyChanged {

    #region Constructors - Destructors

    #endregion

    #region Public Properties

    private static XmlSerializer _xmlSerializer;

    /// <summary>
    /// Gets the <see cref="System.Xml.Serialization.XmlSerializer"/>.
    /// </summary>
    private static XmlSerializer XmlSerializer {
      get {
        if (_xmlSerializer == null) {

          _xmlSerializer = new XmlSerializerFactory().CreateSerializer(typeof(T));

          XmlSerializer.UnknownNode += delegate (object sender, XmlNodeEventArgs e) {
            Debug.WriteLine(
              "[Unknown Node] Ln {0} Col {1} Object: {2} LocalName {3}, NodeName: {4}",
              e.LineNumber,
              e.LinePosition,
              e.ObjectBeingDeserialized.GetType().FullName,
              e.LocalName,
              e.Name
            );
          };

          XmlSerializer.UnknownElement += delegate (object sender, XmlElementEventArgs e) {
            Debug.WriteLine(
              "[Unknown Element  ] Ln {0} Col {1} Object : {2} ExpectedElements {3}, Element : {4}",
              e.LineNumber,
              e.LinePosition,
              e.ObjectBeingDeserialized.GetType().FullName,
              e.ExpectedElements,
              e.Element.InnerXml
            );
          };

          XmlSerializer.UnknownAttribute += delegate (object sender, XmlAttributeEventArgs e) {
            Debug.WriteLine(
              "[Unknown Attribute] Ln {0} Col {1} Object : {2} LocalName {3}, Text : {4}",
              e.LineNumber,
              e.LinePosition,
              e.ObjectBeingDeserialized.GetType().FullName,
              e.ExpectedAttributes,
              e.Attr.Name
            );
          };

        }

        return _xmlSerializer;

      }
    }

    private static JsonSerializer _bsonSerializer;
    
    /// <summary>
    /// Gets the <see cref="JsonSerializer">BSON Serializer</see>.
    /// </summary>
    private static JsonSerializer BsonSerializer {
      get {
        if (_bsonSerializer == null) {
          _bsonSerializer = new JsonSerializer();
        }
        return _bsonSerializer;
      }
    }

    private static MessagePackSerializer _messagePackSerializer;

    /// <summary>
    /// Gets the <see cref="MsgPack.Serialization.MessagePackSerializer"/>.
    /// </summary>
    private static MessagePackSerializer MessagePackSerializer {
      get {
        if ((_messagePackSerializer == null)) {
          _messagePackSerializer = MsgPack.Serialization.MessagePackSerializer.Get<T>(
            new SerializationContext().SerializationMethod = SerializationMethod.Map
          );
        }
        return _messagePackSerializer;
      }
    }

    #endregion

    #region Public Methods

    #region XML Serialization / Deserialization

    /// <summary>
    /// Serializes the <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <returns>A <see cref="string"/> with the serialized object in XML.</returns>
    public virtual string SerializeXml() {

      StreamReader streamReader = null;
      MemoryStream memoryStream = null;

      try {
        memoryStream = new MemoryStream();

        XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();

        xmlWriterSettings.Indent = true;
        xmlWriterSettings.IndentChars = "  ";

        XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);

        XmlSerializer.Serialize(xmlWriter, this);

        memoryStream.Seek(0, SeekOrigin.Begin);
        streamReader = new StreamReader(memoryStream);
        
        return streamReader.ReadToEnd();
      }
      finally {
        if (streamReader != null) {
          streamReader.Dispose();
        }
        if (memoryStream != null) {
          memoryStream.Dispose();
        }
      }
    }

    /// <summary>
    /// Serializes the <see cref="EntityBase{T}"/> object into an XML file.
    /// </summary>
    /// <param name="fileName">The full path and filename of the outupt XML file.</param>
    /// <param name="exception">Outputs the <see cref="Exception"/> in case the serialization fails.</param>
    /// <returns>
    /// A <see cref="Boolean"/> value indicating whether the serialization process succeded or not.
    /// </returns>
    public virtual bool SaveToXmlFile(string fileName, out Exception exception) {

      exception = null;

      try {
        SaveToXmlFile(fileName);
        return true;
      }
      catch (Exception e) {
        exception = e;
        return false;
      }

    }

    /// <summary>
    /// Serializes the <see cref="EntityBase{T}"/> object into an XML file.
    /// </summary>
    /// <param name="fileName">The full path and name of the outupt XML file.</param>
    public virtual void SaveToXmlFile(string fileName) {

      StreamWriter streamWriter = null;

      try {
        string dataString = SerializeXml();

        FileInfo outputFile = new FileInfo(fileName);

        streamWriter = outputFile.CreateText();
        streamWriter.WriteLine(dataString);
        streamWriter.Close();
      }
      finally {
        if ((streamWriter != null)) {
          streamWriter.Dispose();
        }
      }

    }

    /// <summary>
    /// Deserializes an XML <see cref="string"/> into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="input">The XML <see cref="string"/> to deserialize.</param>
    /// <param name="obj">The output <see cref="EntityBase{T}"/> object.</param>
    /// <param name="exception">Outputs the <see cref="Exception"/> in case the deserialization fails.</param>
    /// <returns>
    /// A <see cref="Boolean"/> value indicating whether the deserialization process succeded or not.
    /// </returns>
    public static bool DeserializeXml(string input, out T obj, out Exception exception) {

      exception = null;
      obj = default;

      try {
        obj = DeserializeXml(input);
        return true;
      }
      catch (Exception ex) {
        exception = ex;
        return false;
      }

    }

    /// <summary>
    /// Deserializes an XML <see cref="string"/> into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="input">The XML <see cref="string"/> to deserialize.</param>
    /// <param name="obj">The output <see cref="EntityBase{T}"/> object.</param>
    /// <returns>
    /// A <see cref="Boolean"/> value indicating whether the deserialization process succeded.
    /// </returns>
    public static bool DeserializeXml(string input, out T obj) {
      return DeserializeXml(input, out obj, out _);
    }

    /// <summary>
    /// Deserializes an XML <see cref="string"/> into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="input">The XML <see cref="string"/> to deserialize.</param>
    /// <returns>
    /// An instance of the deserialized <see cref="EntityBase{T}"/> object.
    /// </returns>
    public static T DeserializeXml(string input) {

      StringReader stringReader = null;

      try {
        stringReader = new StringReader(input);

        return (T)XmlSerializer.Deserialize(XmlReader.Create(stringReader));
      }
      finally {
        if (stringReader != null) {
          stringReader.Dispose();
        }
      }

    }

    /// <summary>
    /// Deserializes a <see cref="Stream"/> into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="stream">The <see cref="Stream"/> to deserialize.</param>
    /// <returns>
    /// An instance of the deserialized <see cref="EntityBase{T}"/> object.
    /// </returns>
    public static T DeserializeXml(Stream stream) {
      return (T)XmlSerializer.Deserialize(stream);
    }

    /// <summary>
    /// Deserializes an XML file into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="fileName">The XML file to deserialize.</param>
    /// <param name="obj">Outputs the deserialized <see cref="EntityBase{T}"/> object.</param>
    /// <param name="exception">Outputs the <see cref="Exception"/> in case the deserialization fails.</param>
    /// <returns>
    /// A <see cref="Boolean"/> value indicating whether the serialization process succeded or not.
    /// </returns>
    public static bool LoadFromXmlFile(string fileName, out T obj, out Exception exception) {

      exception = null;
      obj = default;

      try {
        obj = LoadFromXmlFile(fileName);
        return true;
      }
      catch (Exception ex) {
        exception = ex;
        return false;
      }

    }

    /// <summary>
    /// Deserializes an XML file into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="fileName">The XML file to deserialize.</param>
    /// <param name="obj">Outputs the deserialized <see cref="EntityBase{T}"/> object.</param>
    /// <returns>
    /// A <see cref="Boolean"/> value indicating whether the serialization process succeded or not.
    /// </returns>
    public static bool LoadFromXmlFile(string fileName, out T obj) {
      return LoadFromXmlFile(fileName, out obj, out _);
    }

    /// <summary>
    /// Deserializes an XML file into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="fileName">The full path and name of the XML file to deserialize.</param>
    /// <returns>
    /// An instance of the deserialized <see cref="EntityBase{T}"/> object.
    /// </returns>
    public static T LoadFromXmlFile(string fileName) {

      FileStream file = null;
      StreamReader streamReader = null;

      try {
        file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        
        streamReader = new StreamReader(file);
        string dataString = streamReader.ReadToEnd();
        streamReader.Close();
        
        file.Close();

        return DeserializeXml(dataString);
      }
      finally {
        if (file != null) {
          file.Dispose();
        }
        if (streamReader != null) {
          streamReader.Dispose();
        }
      }

    }

    #endregion XML Serialization / Deserialization

    #region BSON Serialization / Deserialization

    /// <summary>
    /// Serializes the <see cref="EntityBase{T}"/> object into a Base64 encoded BSON <see cref="string"/>.
    /// </summary>
    /// <returns>
    /// A <see cref="string"/> containing the serialized BSON in Base64.
    /// </returns>
    public virtual string SerializeBson() {

      MemoryStream memoryStream = null;

      try {
        memoryStream = new MemoryStream();

        BsonDataWriter bsonDataWriter = new BsonDataWriter(memoryStream);
        BsonSerializer.Serialize(bsonDataWriter, this);

        return Convert.ToBase64String(memoryStream.ToArray());
      }
      finally {
        if (memoryStream != null) {
          memoryStream.Dispose();
        }
      }

    }

    /// <summary>
    /// Serializes the <see cref="EntityBase{T}"/> object into a Base64 encoded BSON file.
    /// </summary>
    /// <param name="fileName">The full path and name of the output Base64 encoded BSON file.</param>
    public virtual void SaveToBsonFile(string fileName) {

      StreamWriter streamWriter = null;

      try {
        string dataString = SerializeBson();

        FileInfo outputFile = new FileInfo(fileName);

        streamWriter = outputFile.CreateText();
        streamWriter.WriteLine(dataString);
        streamWriter.Close();
      }
      finally {
        if (streamWriter != null) {
          streamWriter.Dispose();
        }
      }

    }

    /// <summary>
    /// Deserializes a Base64 <see cref="string"/> of a BSON into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="input">
    /// The Base64 <see cref="string"/> encoded BSON to deserialize.
    /// </param>
    /// <param name="obj">Outputs the <see cref="EntityBase{T}"/> object.</param>
    /// <param name="exception">
    /// Outputs the <see cref="Exception"/> in case the deserialization fails.
    /// </param>
    /// <returns>
    /// A <see cref="Boolean"/> value indicating whether the deserialization succeeded or not.
    /// </returns>
    public static bool DeserializeBson(string input, out T obj, out Exception exception) {

      exception = null;
      obj = default;

      try {
        obj = DeserializeBson(input);
        return true;
      }
      catch (Exception ex) {
        exception = ex;
        return false;
      }

    }

    /// <summary>
    /// Deserializes a Base64 <see cref="string"/> of a BSON into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="input">
    /// The Base64 <see cref="string"/> encoded BSON to deserialize.
    /// </param>
    /// <param name="obj">Outputs the <see cref="EntityBase{T}"/> object.</param>
    /// <returns>
    /// A <see cref="Boolean"/> value indicating whether the deserialization succeeded or not.
    /// </returns>
    public static bool DeserializeBson(string input, out T obj) {
      return DeserializeBson(input, out obj, out _);
    }

    /// <summary>
    /// Deserializes a Base64 <see cref="string"/> encoded BSON into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="input">
    /// The Base64 <see cref="string"/> encoded BSON to deserialize.
    /// </param>
    /// <returns>
    /// An instance of the deserialized <see cref="EntityBase{T}"/> object.
    /// </returns>
    public static T DeserializeBson(string input) {

      MemoryStream memoryStream = null;

      try {
        byte[] data;
        
        data = Convert.FromBase64String(input);
        memoryStream = new MemoryStream(data);

        BsonDataReader bsonDataReader = new BsonDataReader(memoryStream);

        return BsonSerializer.Deserialize<T>(bsonDataReader);
      }
      finally {
        if (memoryStream != null) {
          memoryStream.Dispose();
        }
      }

    }

    /// <summary>
    /// Deserializes a Base64 encoded BSON file into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="fileName">The full path and name of the Base64 encoded BSON file to deserialize.</param>
    /// <returns>
    /// An instance of the deserialized <see cref="EntityBase{T}"/> object.
    /// </returns>
    public static T LoadFromBsonFile(string fileName) {

      FileStream file = null;
      StreamReader sr = null;

      try {
        file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new StreamReader(file);

        string dataString = sr.ReadToEnd();
        sr.Close();
        file.Close();

        return DeserializeBson(dataString);
      }
      finally {
        if (file != null) {
          file.Dispose();
        }
        if (sr != null) {
          sr.Dispose();
        }
      }

    }

    #endregion BSON Serialization / Deserialization

    #region JSON Serialization / Deserialization

    /// <summary>
    /// Serializes the <see cref="EntityBase{T}"/> object into a JSON <see cref="string"/>.
    /// </summary>
    public virtual string SerializeJson() {
      JsonSerializerSettings settings = new JsonSerializerSettings {
        Formatting = Newtonsoft.Json.Formatting.Indented
      };

      return JsonConvert.SerializeObject(this, settings);
    }

    /// <summary>
    /// Serializes the <see cref="EntityBase{T}"/> object into a JSON file.
    /// </summary>
    /// <param name="fileName">The full path and name of the output JSON file.</param>
    public virtual void SaveToJsonFile(string fileName) {

      StreamWriter streamWriter = null;

      try {
        string dataString = SerializeJson();

        FileInfo outputFile = new FileInfo(fileName);

        streamWriter = outputFile.CreateText();
        streamWriter.WriteLine(dataString);
        streamWriter.Close();
      }
      finally {
        if (streamWriter != null) {
          streamWriter.Dispose();
        }
      }

    }

    /// <summary>
    /// Deserializes a JSON <see cref="string"/> into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="input">The JSON <see cref="string"/>to deserialize.</param>
    /// <param name="obj">Outputs the <see cref="EntityBase{T}"/> object.</param>
    /// <param name="exception">
    /// Outputs the <see cref="Exception"/> in case the deserialization fails.
    /// </param>
    /// <returns>
    /// A <see cref="Boolean"/> value indicating whether the deserialization succeeded or not.
    /// </returns>
    public static bool DeserializeJson(string input, out T obj, out Exception exception) {

      exception = null;
      obj = default;

      try {
        obj = DeserializeJson(input);
        return true;
      }
      catch (Exception ex) {
        exception = ex;
        return false;
      }

    }

    /// <summary>
    /// Deserializes the JSON <see cref="string"/> into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="input">The JSON <see cref="string"/> to deserialize.</param>
    /// <param name="obj">Outputs the <see cref="EntityBase{T}"/> object.</param>
    /// <returns>
    /// A <see cref="Boolean"/> value indicating whether the deserialization succeeded or not.
    /// </returns>
    public static bool DeserializeJson(string input, out T obj) {
      return DeserializeJson(input, out obj, out _);
    }

    /// <summary>
    /// Deserializes the JSON <see cref="string"/> into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="input">The JSON <see cref="string"/> to deserialize.</param>
    /// <returns>
    /// An instance of the deserialized <see cref="EntityBase{T}"/> object.
    /// </returns>
    public static T DeserializeJson(string input) {
      JsonSerializerSettings settings = new JsonSerializerSettings {
        Formatting = Newtonsoft.Json.Formatting.Indented
      };

      return JsonConvert.DeserializeObject<T>(input, settings);
    }

    /// <summary>
    /// Deserializes a JSON file into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="fileName">The full path and name of the JSON file to deserialize.</param>
    /// <returns>
    /// An instance of the deserialized <see cref="EntityBase{T}"/> object.
    /// </returns>
    public static T LoadFromJsonFile(string fileName) {

      FileStream file = null;
      StreamReader sr = null;

      try {
        file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new StreamReader(file);

        string dataString = sr.ReadToEnd();
        sr.Close();
        file.Close();

        return DeserializeJson(dataString);
      }
      finally {
        if (file != null) {
          file.Dispose();
        }
        if (sr != null) {
          sr.Dispose();
        }
      }

    }

    #endregion JSON Serialization / Deserialization

    #region MessagePack Serialization / Deserialization

    /// <summary>
    /// Serializes the <see cref="EntityBase{T}"/> object into a MessagePack byte stream.
    /// </summary>
    /// <returns>
    /// A MessagePack <see cref="Byte"/> array.
    /// </returns>
    public virtual byte[] SerializeMsgPack() {

      MemoryStream byteStream = null;
      
      try {
        byteStream = new MemoryStream();
        MessagePackSerializer.Pack(byteStream, this);

        return byteStream.ToArray();
      }
      finally {
        if (byteStream != null) {
          byteStream.Dispose();
        }
      }

    }

    /// <summary>
    /// Serializes the <see cref="EntityBase{T}"/> object into a MessagePack file.
    /// </summary>
    /// <param name="fileName">The full path and name of the output MessagePack file.</param>
    public virtual void SaveToFileMsgPack(string fileName) {

      FileStream fileStream = null;

      try {
        byte[] msgPackBytes = SerializeMsgPack();

        fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        fileStream.Write(msgPackBytes, 0, msgPackBytes.Length);
        fileStream.Close();
      }
      finally {
        if (fileStream != null) {
          fileStream.Dispose();
        }
      }

    }

    /// <summary>
    /// Deserializes a MessagePack <see cref="Byte"/> array into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="input">The <see cref="Byte"/> array to deserialize.</param>
    /// <param name="obj">Outputs the <see cref="EntityBase{T}"/> object.</param>
    /// <param name="exception">
    /// Outputs the <see cref="Exception"/> in case the deserialization fails.
    /// </param>
    /// <returns>
    /// A <see cref="Boolean"/> value indicating whether the deserialization succeded or not.
    /// </returns>
    public static bool DeserializeMsgPack(byte[] input, out T obj, out Exception exception) {

      exception = null;
      obj = default;

      try {
        obj = DeserializeMsgPack(input);
        return true;
      }
      catch (Exception ex) {
        exception = ex;
        return false;
      }

    }

    /// <summary>
    /// Deserializes the MessagePack <see cref="Byte"/> array into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="input">The MessagePack <see cref="Byte"/> array to deserialzie.</param>
    /// <param name="obj">Outputs the <see cref="EntityBase{T}"/> object.</param>
    /// <returns>
    /// A <see cref="Boolean"/> value indicating whether the deserialization succeeded or not.
    /// </returns>
    public static bool DeserializeMsgPack(byte[] input, out T obj) {
      return DeserializeMsgPack(input, out obj, out _);
    }

    /// <summary>
    /// Deserializes the MessagePack <see cref="Byte"/> array into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="input">The MessagePack <see cref="Byte"/> array to deserialzie.</param>
    /// <returns>
    /// An instance of the deserialized <see cref="EntityBase{T}"/> object.
    /// </returns>
    public static T DeserializeMsgPack(byte[] input) {

      MemoryStream byteStream = null;

      try {
        byteStream = new MemoryStream(input);
        return (T)MessagePackSerializer.Unpack(byteStream);
      }
      finally {
        if ((byteStream != null)) {
          byteStream.Dispose();
        }
      }

    }

    /// <summary>
    /// Deserializes a MessagePack file into an <see cref="EntityBase{T}"/> object.
    /// </summary>
    /// <param name="fileName">The full path and name of the MessagePack file to deserialize.</param>
    /// <returns>
    /// An instance of the deserialized <see cref="EntityBase{T}"/> object.
    /// </returns>
    public static T LoadFromFileMsgPack(string fileName) {

      FileStream file = null;

      try {
        file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        byte[] buffer = new byte[file.Length];
        file.Read(buffer, 0, ((int)(file.Length)));

        return DeserializeMsgPack(buffer);
      }
      finally {
        if (file != null) {
          file.Dispose();
        }
      }

    }

    #endregion MessagePack Serialization / Deserialization

    #endregion

    #region Events

    public event PropertyChangedEventHandler PropertyChanged;

    public virtual void OnPropertyChanged(string propertyName) {
      PropertyChangedEventHandler handler = PropertyChanged;
      if ((handler != null)) {
        handler(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    #endregion

  }

}
