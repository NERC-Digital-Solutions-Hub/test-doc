
#region Imported Namespaces

using NDSH.Geospatial.Metadata.Serializers;
using NDSH.Geospatial.Metadata.V2003;
using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.DateTime;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.EntitySet;
using NDSH.Geospatial.Metadata.V2003.GML.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Identification;
using NDSH.Geospatial.Metadata.V2003.Localisation;
using NDSH.Geospatial.Metadata.V2003.Maintenance;
using NDSH.Geospatial.Metadata.V2003.Tests.Content;
using NDSH.Geospatial.Metadata.V2003.XLinks;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Extended;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Primitive.Numerics;
using NDSH.Geospatial.Metadata.V2005.EntitySet;
using NDSH.Geospatial.Metadata.V2005.Tests.Content;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Utilities.App {

  /// <summary>
  /// 
  /// </summary>
  public static class V2003 {

    #region Member Variables

    private static Dictionary<string, Delegate> _metadataCreationDictionary;

    private delegate MD_Metadata_Type CreateMetadataTypeDelegate();
    
    #endregion

    /// <summary>
    /// Initializes <see cref="V2003"/>.
    /// </summary>
    static V2003() {

      _metadataCreationDictionary = new Dictionary<string, Delegate>();
      _metadataCreationDictionary.Add("gmd_metadata_01.xml", new CreateMetadataTypeDelegate(CreateMetadata01Type));
      _metadataCreationDictionary.Add("gmd_metadata_02.xml", new CreateMetadataTypeDelegate(CreateMetadata02Type));
      _metadataCreationDictionary.Add("gmd_metadata_03.xml", new CreateMetadataTypeDelegate(CreateMetadata03Type));
      _metadataCreationDictionary.Add("nerc00001.xml", new CreateMetadataTypeDelegate(CreateMetadataNerc00001));
      _metadataCreationDictionary.Add("nerc00101.xml", new CreateMetadataTypeDelegate(CreateMetadataNerc00101));
      _metadataCreationDictionary.Add("nerc00201.xml", new CreateMetadataTypeDelegate(CreateMetadataNerc00201));
      _metadataCreationDictionary.Add("nerc00301.xml", new CreateMetadataTypeDelegate(CreateMetadataNerc00301));
      _metadataCreationDictionary.Add("nerc00401.xml", new CreateMetadataTypeDelegate(CreateMetadataNerc00401));
      _metadataCreationDictionary.Add("nerc00501.xml", new CreateMetadataTypeDelegate(CreateMetadataNerc00501));
      _metadataCreationDictionary.Add("nerc00601.xml", new CreateMetadataTypeDelegate(CreateMetadataNerc00601));
      _metadataCreationDictionary.Add("nerc00701.xml", new CreateMetadataTypeDelegate(CreateMetadataNerc00701));
      _metadataCreationDictionary.Add("nerc00801.xml", new CreateMetadataTypeDelegate(CreateMetadataNerc00801));
      _metadataCreationDictionary.Add("nerc00901.xml", new CreateMetadataTypeDelegate(CreateMetadataNerc00901));
      _metadataCreationDictionary.Add("nerc01001.xml", new CreateMetadataTypeDelegate(CreateMetadataNerc01001));

    }



    #region Public Methods

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeCharacterStringPropertyType(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

      bool indent = indentCheckBox.Checked;
      bool useEntity = useEntityCheckBox.Checked;

      if (indent) {
        if (useEntity) {
          inputTextBox.Text = CitationInformationResources.CharacterString_Entity;
        }
        else {
          inputTextBox.Text = CitationInformationResources.CharacterString;
        }
      }
      else {
        if (useEntity) {
          inputTextBox.Text = CitationInformationResources.CharacterString_Entity_Compact;
        }
        else {
          inputTextBox.Text = CitationInformationResources.CharacterString_Compact;
        }
      }

      CharacterString_PropertyType cs = V2003.CreateCharacterStringPropertyType();

      //if (useEntity) {
      //  Entity entity = V2005.CreateEntity();
      //  entity.Item = cs;

      //  SerializeObjectToXml(outputTextBox, entity, indent, indentChars);
      //}
      //else {
      //  SerializeObjectToXml(outputTextBox, cs, indent, indentChars);
      //}
      SerializeObjectToXml(outputTextBox, cs, indent, indentChars);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeAddressPropertyType(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

      bool indent = indentCheckBox.Checked;
      bool useEntity = useEntityCheckBox.Checked;

      if (indent) {
        if (useEntity) {
          inputTextBox.Text = CitationInformationResources.CI_Address_Type_Entity;
        }
        else {
          inputTextBox.Text = CitationInformationResources.CI_Address_Type;
        }
      }
      else {
        if (useEntity) {
          inputTextBox.Text = CitationInformationResources.CI_Address_Type_Entity_Compact;
        }
        else {
          inputTextBox.Text = CitationInformationResources.CI_Address_Type_Compact;
        }
      }

      CI_Address_PropertyType address = V2003.CreateAddressPropertyType();

      //if (useEntity) {
      //  Entity entity = V2005.CreateEntity();
      //  entity.Item = address;

      //  SerializeObjectToXml(outputTextBox, entity, indent, indentChars);
      //}
      //else {
      //  SerializeObjectToXml(outputTextBox, address, indent, indentChars);
      //}
      SerializeObjectToXml(outputTextBox, address, indent, indentChars);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeAddressType(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

      bool indent = indentCheckBox.Checked;
      bool useEntity = useEntityCheckBox.Checked;

      if (indent) {
        if (useEntity) {
          inputTextBox.Text = CitationInformationResources.CI_Address_Type_Entity;
        }
        else {
          inputTextBox.Text = CitationInformationResources.CI_Address_Type;
        }
      }
      else {
        if (useEntity) {
          inputTextBox.Text = CitationInformationResources.CI_Address_Type_Entity_Compact;
        }
        else {
          inputTextBox.Text = CitationInformationResources.CI_Address_Type_Compact;
        }
      }

      CI_Address_Type address = V2003.CreateAddressType();

      //if (useEntity) {
      //  Entity entity = V2005.CreateEntity();
      //  entity.Item = address;

      //  SerializeObjectToXml(outputTextBox, entity, indent, indentChars);
      //}
      //else {
      //  SerializeObjectToXml(outputTextBox, address, indent, indentChars);
      //}
      SerializeObjectToXml(outputTextBox, address, indent, indentChars);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeCitationPropertyType(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

      bool indent = indentCheckBox.Checked;
      bool useEntity = useEntityCheckBox.Checked;

      //if (indent) {
      //  if (useEntity) {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type_Entity;
      //  }
      //  else {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type;
      //  }
      //}
      //else {
      //  if (useEntity) {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type_Entity_Compact;
      //  }
      //  else {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type_Compact;
      //  }
      //}

      inputTextBox.Text = CitationInformationResources.CI_Citation_Type;

      CI_Citation_PropertyType citation = V2003.CreateCitationPropertyType();

      //if (useEntity) {
      //  Entity entity = V2005.CreateEntity();
      //  entity.Item = citation;

      //  SerializeObjectToXml(outputTextBox, entity, indent, indentChars);
      //}
      //else {
      //  SerializeObjectToXml(outputTextBox, citation, indent, indentChars);
      //}
      SerializeObjectToXml(outputTextBox, citation, indent, indentChars);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeCitationType(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

      bool indent = indentCheckBox.Checked;
      bool useEntity = useEntityCheckBox.Checked;

      //if (indent) {
      //  if (useEntity) {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type_Entity;
      //  }
      //  else {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type;
      //  }
      //}
      //else {
      //  if (useEntity) {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type_Entity_Compact;
      //  }
      //  else {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type_Compact;
      //  }
      //}

      inputTextBox.Text = CitationInformationResources.CI_Citation_Type;

      CI_Citation_Type citation = V2003.CreateCitationType();

      //if (useEntity) {
      //  Entity entity = V2005.CreateEntity();
      //  entity.Item = citation;

      //  SerializeObjectToXml(outputTextBox, entity, indent, indentChars);
      //}
      //else {
      //  SerializeObjectToXml(outputTextBox, citation, indent, indentChars);
      //}
      SerializeObjectToXml(outputTextBox, citation, indent, indentChars);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeTelephonePropertyType(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

      bool indent = indentCheckBox.Checked;
      bool useEntity = useEntityCheckBox.Checked;

      //if (indent) {
      //  if (useEntity) {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type_Entity;
      //  }
      //  else {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type;
      //  }
      //}
      //else {
      //  if (useEntity) {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type_Entity_Compact;
      //  }
      //  else {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type_Compact;
      //  }
      //}

      inputTextBox.Text = CitationInformationResources.CI_Telephone_Type;

      CI_Telephone_PropertyType telephone = V2003.CreateTelephonePropertyType();

      //if (useEntity) {
      //  Entity entity = V2005.CreateEntity();
      //  entity.Item = telephone;

      //  SerializeObjectToXml(outputTextBox, entity, indent, indentChars);
      //}
      //else {
      //  SerializeObjectToXml(outputTextBox, telephone, indent, indentChars);
      //}
      SerializeObjectToXml(outputTextBox, telephone, indent, indentChars);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeTelephoneType(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

      bool indent = indentCheckBox.Checked;
      bool useEntity = useEntityCheckBox.Checked;

      //if (indent) {
      //  if (useEntity) {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type_Entity;
      //  }
      //  else {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type;
      //  }
      //}
      //else {
      //  if (useEntity) {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type_Entity_Compact;
      //  }
      //  else {
      //    this.SerializationInputTextBox.Text = CitationInformationResources.CI_Address_Type_Compact;
      //  }
      //}

      inputTextBox.Text = CitationInformationResources.CI_Telephone_Type;

      CI_Telephone_Type telephone = V2003.CreateTelephoneType();

      //if (useEntity) {
      //  Entity entity = V2005.CreateEntity();
      //  entity.Item = telephone;

      //  SerializeObjectToXml(outputTextBox, entity, indent, indentChars);
      //}
      //else {
      //  SerializeObjectToXml(outputTextBox, telephone, indent, indentChars);
      //}
      SerializeObjectToXml(outputTextBox, telephone, indent, indentChars);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeMetadata01PropertyType(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

      bool indent = indentCheckBox.Checked;
      bool useEntity = useEntityCheckBox.Checked;

      inputTextBox.Text = MetadataInformationResources.Test01;

      MD_Metadata_PropertyType metadata = V2003.CreateMetadata01PropertyType();

      SerializeObjectToXml(outputTextBox, metadata, indent, indentChars);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="resource"></param>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeMetadataType(string resource, RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

      bool indent = indentCheckBox.Checked;
      bool useEntity = useEntityCheckBox.Checked;

      //inputTextBox.Text = MetadataInformationResources.Test01;
      inputTextBox.Text = V2003.GetEmbeddedResourceString(resource);

      // Use the dictionary delegate to initiate the metadata creation procedure.
      MD_Metadata_Type metadata = ((CreateMetadataTypeDelegate)_metadataCreationDictionary[resource])();

      SerializeObjectToXml(outputTextBox, metadata, indent, indentChars);

      //JsonSerializer jsonSerializer = new JsonSerializer();
      //outputTextBox.Text = jsonSerializer.SerializeJson(metadata, true);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="propertyGrid"></param>
    /// <param name="xmlDocument"></param>
    public static void DeserializeMetadataType(RichTextBox inputTextBox, PropertyGrid propertyGrid, string xmlDocument) {

      inputTextBox.Text = V2003.GetEmbeddedResourceString(xmlDocument);

      DeserializeXmlToObject(propertyGrid, inputTextBox.Text);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeCT_ColdelistCatalogue(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

      bool indent = indentCheckBox.Checked;
      bool useEntity = useEntityCheckBox.Checked;

      inputTextBox.Text = CatalogueResources.ML_gmxCodelists;

      CT_CodelistCatalogue_Type codelistCatalogue = V2003.CreateML_GmxCodelistCatalogueType();

      SerializeObjectToXml(outputTextBox, codelistCatalogue, indent, indentChars);

    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// 
    /// </summary>
    /// <param name="resourceName"></param>
    /// <returns></returns>
    private static string? GetEmbeddedResourceString(string resourceName) {

      string metadataXml = null;

      Assembly? assembly = Assembly.GetAssembly(typeof(NDSH.Geospatial.Metadata.V2003.Tests.Content.Content));

      Stream stream = assembly?.GetManifestResourceStream(string.Format("NDSH.Geospatial.Metadata.V2003.Tests.Content.NERC.{0}", resourceName));
      if (stream != null) {
        StreamReader streamReader = new StreamReader(stream);
        metadataXml = streamReader.ReadToEnd();
        streamReader.Close();
      }

      return metadataXml;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="outputTextBox"></param>
    /// <param name="obj"></param>
    /// <param name="indent"></param>
    /// <param name="indentChars"></param>
    private static void SerializeObjectToXml(RichTextBox outputTextBox, object obj, bool indent = true, string indentChars = "  ") {

      //Entity entity = new Entity();
      //entity.Item = obj;

      //this.SerializationOutputTextBox.Text =
      //  XElement.Parse(SerializeXml(entity))
      //          .Elements()
      //          .First()
      //          .ToString(SaveOptions.DisableFormatting);

      //this.SerializationOutputTextBox.Text =
      //  XElement.Parse(SerializeXml(entity))
      //          .Elements()
      //          .First()
      //          .ToString(SaveOptions.None);

      outputTextBox.Text = SerializeXml(obj, indent, indentChars);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="outputPropertyGrid"></param>
    /// <param name="xml"></param>
    private static void DeserializeXmlToObject(PropertyGrid outputPropertyGrid, string xml) {
      outputPropertyGrid.SelectedObject = DeserializeXml(xml);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="indent"></param>
    /// <param name="indentChars"></param>
    /// <returns></returns>
    private static string SerializeXml(object obj, bool indent = true, string indentChars = "  ") {

      Debug.WriteLine("Debug: SerializeXml");

      StreamReader streamReader = null;
      MemoryStream memoryStream = null;

      try {

        // -------- Stream --------

        //memorystream = new memorystream();

        //geonetworkgmd2005serializer xmlserializer = new geonetworkgmd2005serializer(obj.gettype());
        //xmlserializer.serialize(memorystream, obj);

        //memorystream.seek(0, seekorigin.begin);
        //streamreader = new streamreader(memorystream);

        //return streamreader.readtoend();

        //xmlserializer.serialize();

        // -------- TextWriter --------

        //string filename = @"C:\NDSH\Documents\zz\test.xml";

        //FileStream fs = new FileStream(filename, FileMode.Create);
        //TextWriter textWriter = new StreamWriter(fs, new UTF8Encoding());

        //GeoNetworkGmd2005Serializer xmlSerializer = new GeoNetworkGmd2005Serializer(obj.GetType());
        ////XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
        //xmlSerializer.Serialize(textWriter, obj);

        //textWriter.Close();

        //return null;

        // -------- XmlWriter --------

        //memoryStream = new MemoryStream();

        //XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();

        //xmlWriterSettings.Indent = indent;
        //xmlWriterSettings.IndentChars = indentChars;

        //XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);

        //GeoNetworkGmd2005Serializer xmlSerializer = new GeoNetworkGmd2005Serializer(obj.GetType());
        ////XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
        //xmlSerializer.Serialize(xmlWriter, obj);

        //memoryStream.Seek(0, SeekOrigin.Begin);
        //streamReader = new StreamReader(memoryStream);

        //return streamReader.ReadToEnd();

        // -------- Stream, XmlSerializerNamespaces --------

        //memoryStream = new MemoryStream();

        //XmlSerializerNamespaces? xmlSerializerNamespaces = new XmlSerializerNamespaces();
        //xmlSerializerNamespaces.Add("gma", "http://www.isotc211.org/2005/gma");
        //xmlSerializerNamespaces.Add("gmb", "http://www.isotc211.org/2005/gmb");

        //GeoNetworkGmd2005Serializer xmlSerializer = new GeoNetworkGmd2005Serializer(obj.GetType());
        //xmlSerializer.Serialize(memoryStream, obj, xmlSerializerNamespaces);

        //memoryStream.Seek(0, SeekOrigin.Begin);
        //streamReader = new StreamReader(memoryStream);

        //return streamReader.ReadToEnd();

        // -------- TextWriter, XmlSerializerNamespaces --------

        //string filename = @"C:\NDSH\Documents\zz\test2.xml";

        //FileStream fs = new FileStream(filename, FileMode.Create);
        //TextWriter textWriter = new StreamWriter(fs, new UTF8Encoding());

        //XmlSerializerNamespaces? xmlSerializerNamespaces = new XmlSerializerNamespaces();
        //xmlSerializerNamespaces.Add("gma", "http://www.isotc211.org/2005/gma");
        //xmlSerializerNamespaces.Add("gmb", "http://www.isotc211.org/2005/gmb");

        //GeoNetworkGmd2005Serializer xmlSerializer = new GeoNetworkGmd2005Serializer(obj.GetType());
        ////XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
        //xmlSerializer.Serialize(textWriter, obj, xmlSerializerNamespaces);

        //textWriter.Close();

        //return null;

        // -------- XmlWriter, XmlSerializerNamespaces --------

        memoryStream = new MemoryStream();

        XmlSerializerNamespaces? xmlSerializerNamespaces = new XmlSerializerNamespaces();
        //xmlSerializerNamespaces.Add("gma", "http://www.isotc211.org/2005/gma");
        //xmlSerializerNamespaces.Add("geonet", "http://www.fao.org/geonetwork");

        XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();

        xmlWriterSettings.Indent = indent;
        xmlWriterSettings.IndentChars = indentChars;

        XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);

        //GeoNetworkGmd2005Serializer xmlSerializer = new GeoNetworkGmd2005Serializer(obj.GetType());
        XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
        xmlSerializer.Serialize(xmlWriter, obj, xmlSerializerNamespaces);

        memoryStream.Seek(0, SeekOrigin.Begin);
        streamReader = new StreamReader(memoryStream);

        return streamReader.ReadToEnd();

      }
      catch (Exception ex) {
        throw ex;
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
    /// 
    /// </summary>
    /// <param name="xml"></param>
    /// <returns></returns>
    private static object DeserializeXml(string xml) {

      Debug.WriteLine("Debug: DeserializeXml");

      StreamWriter streamWriter = null;
      MemoryStream memoryStream = null;

      try {

        // -------- XmlReader, XmlSerializerNamespaces --------

        memoryStream = new MemoryStream();
        streamWriter = new StreamWriter(memoryStream);

        streamWriter.Write(xml);
        streamWriter.Flush();
        
        memoryStream.Position = 0;

        XmlSerializerNamespaces? xmlSerializerNamespaces = new XmlSerializerNamespaces();
        //xmlSerializerNamespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        
        XmlReaderSettings xmlReaderSettings = new System.Xml.XmlReaderSettings();
        //xmlReaderSettings.DtdProcessing = DtdProcessing.Parse;
        //sxmlReaderSettings.Schemas.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        
        //XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();

        //XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
        XmlReader xmlReader = XmlReader.Create(memoryStream, xmlReaderSettings);
        
        //GeoNetworkGmd2005Serializer xmlSerializer = new GeoNetworkGmd2005Serializer(obj.GetType());
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(MD_Metadata_Type));
        object? obj = xmlSerializer.Deserialize(xmlReader);
        
        return obj;

      }
      finally {

        if (streamWriter != null) {
          streamWriter.Dispose();
        }
        if (memoryStream != null) {
          memoryStream.Dispose();
        }

      }

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static CharacterString_PropertyType CreateCharacterStringPropertyType() {

      CharacterString_PropertyType cspt = new CharacterString_PropertyType();
      cspt.CharacterString = "This is a character string";

      return cspt;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static CI_Address_PropertyType CreateAddressPropertyType() {

      //CI_Address address = new CI_Address() {
      //  Id = "id-1",
      //  Uuid = "uuid-1",
      //  DeliveryPoint = new List<string>(1),
      //  City = "NOTTINGHAM",
      //  AdministrativeArea = "NOTTINGHAMSHIRE",
      //  PostalCode = "NG12 5GG",
      //  Country = "United Kingdom",
      //  ElectronicMailAddress = new List<string>(1)
      //};
      //address.DeliveryPoint.Add("Environmental Science Centre, Keyworth");
      //address.ElectronicMailAddress.Add("enquiries@bgs.ac.uk");

      //return address;

      return null;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static CI_Address_Type CreateAddressType() {

      //CI_Address address = new CI_Address() {
      //  Id = "id-1",
      //  Uuid = "uuid-1",
      //  DeliveryPoint = new List<string>(1),
      //  City = "NOTTINGHAM",
      //  AdministrativeArea = "NOTTINGHAMSHIRE",
      //  PostalCode = "NG12 5GG",
      //  Country = "United Kingdom",
      //  ElectronicMailAddress = new List<string>(1)
      //};
      //address.DeliveryPoint.Add("Environmental Science Centre, Keyworth");
      //address.ElectronicMailAddress.Add("enquiries@bgs.ac.uk");

      //return address;

      return null;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static CI_Citation_PropertyType CreateCitationPropertyType() {

      //CI_Citation citation = new CI_Citation() {
      //  Title = "Geological Indicators of Flooding Great Britain",
      //  Date = new List<CI_Date>() {
      //    new CI_Date() {
      //      Date = "2006",
      //      DateType = new CI_DateTypeCode() {
      //        Value = CI_DateTypeCodeValue.Creation
      //      }
      //    }
      //  },
      //  Identifier = new List<Parent_MD_Identifier>() {
      //    new Parent_MD_Identifier() {
      //      Item = new MD_Identifier() {
      //        Code = "http://data.bgs.ac.uk/id/dataHolding/13603094"
      //      }
      //    }
      //  }
      //};

      //return citation;

      return null;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static CI_Citation_Type CreateCitationType() {

      //CI_Citation citation = new CI_Citation() {
      //  Title = "Geological Indicators of Flooding Great Britain",
      //  Date = new List<CI_Date>() {
      //    new CI_Date() {
      //      Date = "2006",
      //      DateType = new CI_DateTypeCode() {
      //        Value = CI_DateTypeCodeValue.Creation
      //      }
      //    }
      //  },
      //  Identifier = new List<Parent_MD_Identifier>() {
      //    new Parent_MD_Identifier() {
      //      Item = new MD_Identifier() {
      //        Code = "http://data.bgs.ac.uk/id/dataHolding/13603094"
      //      }
      //    }
      //  }
      //};

      //return citation;

      return null;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static CI_Telephone_PropertyType CreateTelephonePropertyType() {

      //CI_Telephone telephone = new() {
      //  Id = "id-1",
      //  Uuid = "uuid-1",
      //  Facsimile = new List<string>(),
      //  Voice = new List<string>()
      //};
      //telephone.Facsimile.Add("0115 936 3276");
      //telephone.Voice.Add("0115 936 3143");

      //return telephone;

      return null;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static CI_Telephone_Type CreateTelephoneType() {

      //CI_Telephone telephone = new() {
      //  Id = "id-1",
      //  Uuid = "uuid-1",
      //  Facsimile = new List<string>(),
      //  Voice = new List<string>()
      //};
      //telephone.Facsimile.Add("0115 936 3276");
      //telephone.Voice.Add("0115 936 3143");

      //return telephone;

      return null;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static MD_Metadata_PropertyType CreateMetadata01PropertyType() {

      //MD_Metadata metadata = new MD_Metadata {
      //  FileIdentifier = "9df8df52-d644-37a8-e044-0003ba9b0d98",
      //  Contact = new List<CI_ResponsibleParty> {
      //    new CI_ResponsibleParty() {
      //      OrganisationName = "British Geologiical Survey",
      //      ContactInfo = new CI_Contact {
      //        Phone = new CI_Telephone {
      //          Voice = new List<string> { "+44 115 936 3100" }
      //        },
      //        Address = new CI_Address {
      //          DeliveryPoint = new List<string> { "Environmental Science Centre, Keyworth" },
      //          City = "NOTTINGHAM",
      //          AdministrativeArea = "NOTTINGHAMSHIRE",
      //          PostalCode = "NG12 5GG",
      //          Country = "United Kingdom",
      //          ElectronicMailAddress=new List<string>{ "enquiries@bgs.ac.uk" }
      //        }
      //      },
      //      Role = new CI_RoleCode {
      //        Value = CI_RoleCodeValue.PointOfContact
      //      }
      //    }
      //  },

      //DateStamp = new DateTime(2022, 7, 5),
      //MetadataStandardName = "UK GEMINI", // xmltype: Anchor
      //MetadataStandardVersion = "2.3",
      //DatasetURI = "http://data.bgs.ac.uk/id/dataHolding/13603094",
      //DistributionInfo = new MD_Distribution {
      //  DistributionFormat = new List<MD_Format> {
      //    new MD_Format {
      //      Name = "GIS Files(shp and tab)",
      //      Version = "inapplicable",
      //    },
      //    new MD_Format {
      //      Name = "Hardcopy - Printed Map",
      //      Version = "inapplicable",
      //    },
      //  },

      //  Distributor = new List<MD_Distributor> {
      //    new MD_Distributor {
      //      DistributorContact = new CI_ResponsibleParty {
      //       IndividualName = "Enquiries",
      //       OrganisationName = "British Geological Survey",
      //       ContactInfo = new CI_Contact {
      //         Phone = new CI_Telephone {
      //           Voice = new List<string> { "0115 936 3143" },
      //           Facsimile = new List<string> { "0115 936 3276" },
      //         },
      //         Address = new CI_Address {
      //           DeliveryPoint = new List<string> {
      //             "Environmental Science Centre, Nicker Hill, Keyworth"
      //           },
      //           City = "NOTTINGHAM",
      //           AdministrativeArea = "NOTTINGHAMSHIRE",
      //           PostalCode = "NG12 5GG",
      //           Country = "United Kingdom",
      //           ElectronicMailAddress =  new List<string>{ "enquiries@bgs.ac.uk" },
      //         }
      //       },
      //       Role = new CI_RoleCode{Value= CI_RoleCodeValue.Distributor }
      //     },
      //      DistributorTransferOptions = new List<MD_DigitalTransferOptions> {
      //       new MD_DigitalTransferOptions {
      //       OnLine = new List<CI_OnlineResource> {
      //         new CI_OnlineResource{
      //           Linkage =   "http://ogc.bgs.ac.uk/dppp/wmc/gif.xml", // xmltype: URL
      //           Protocol= "http",
      //           Name = "Web map context for GIF",
      //           Description = "Web map context for GIF",
      //           Function = new CI_OnLineFunctionCode{ Value = CI_OnLineFunctionCodeValue.Download }
      //           }
      //       }
      //     },
      //       new MD_DigitalTransferOptions {
      //         OnLine = new List<CI_OnlineResource> {
      //           new CI_OnlineResource {
      //             Linkage = "http://ogc.bgs.ac.uk/dppp/kml/gif.kml", // xmltype: URL
      //             Protocol = "http",
      //             Name = "KML resource for GIF",
      //             Description = "KML resource for GIF",
      //             Function = new CI_OnLineFunctionCode {
      //               Value = CI_OnLineFunctionCodeValue.Download
      //             }


      //           }
      //         }
      //       },
      //       new MD_DigitalTransferOptions {
      //         OnLine = new List<CI_OnlineResource> {
      //           new CI_OnlineResource {
      //             Linkage = "http://www.bgs.ac.uk/products/hydrogeology/indicatorsOfFlooding.html",
      //             Description = "Geological Indicators of Flooding Homepage.",
      //             Function = new CI_OnLineFunctionCode {
      //               Value= CI_OnLineFunctionCodeValue.Information
      //             }
      //           }
      //         }
      //       }

      //     },
      //    }
      //  }
      //},

      //};

      //return metadata;

      return null;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the gmd_metadata_01.xml resource file.
    /// </summary>
    /// <remarks>
    /// Uses resource: NDSH.Geospatial.Metadata.V2003\tests.content\NERC\gmd_metadata_01.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadata01Type() {

      MD_Metadata_Type metadata = new MD_Metadata_Type {
        FileIdentifier = "9df8df52-d644-37a8-e044-0003ba9b0d98",
        //FileIdentifier = new CharacterString_PropertyType() {
        //  CharacterString = "9df8df52-d644-37a8-e044-0003ba9b0d98"
        //},
        //Language = new CharacterString_PropertyType() {
        //  CharacterString = "English"
        //},
        Language = new LanguageCode_PropertyType() {
          LanguageCode = new CodeListValue_Type() {
            CodeList = "http://standards.iso.org/ittf/PubliclyAvailableStandards/ISO_19139_Schemas/resources/codelist/ML_gmxCodelists.xml#LanguageCode",
            CodeListValue = "eng",
            Value = "English"
          }
        },
        //CharacterSet = new MD_CharacterSetCode_PropertyType() {
        //  MD_CharacterSetCode = new CodeListValue_Type() {
        //    CodeList = "https://schemas.isotc211.org/schemas/19139/resources/codelist/gmxCodelists.xml#MD_CharacterSetCode",
        //    CodeListValue = "utf8",
        //    Value = "utf8"
        //  }
        //},
        //ParentIdentifier = new CharacterString_PropertyType() {
        //  CharacterString = "test"
        //},
        //HierarchyLevel = new List<MD_ScopeCode_PropertyType>() {
        //  {
        //    new MD_ScopeCode_PropertyType() {
        //      MD_ScopeCode = new CodeListValue_Type() {
        //        CodeList = "https://schemas.isotc211.org/schemas/19139/resources/codelist/gmxCodelists.xml#MD_ScopeCode",
        //        CodeListValue = "dataset",
        //        Value = "dataset"
        //      }
        //    }
        //  }
        //},
        //Contact = new List<CI_ResponsibleParty_PropertyType>() {
        //  {
        //    new CI_ResponsibleParty_PropertyType() {
        //      NilReason = "test"
        //    }
        //  }
        //},
        //Contact = new List<CI_ResponsibleParty_PropertyType>() {
        //  {
        //    new CI_ResponsibleParty_PropertyType() {
        //      CI_ResponsibleParty = new CI_ResponsibleParty_Type() {

        //      }
        //    }
        //  }
        //},
        //Contact = new List<CI_ResponsibleParty_PropertyType>() {
        //  {
        //    new CI_ResponsibleParty_PropertyType() {
        //      CI_ResponsibleParty = new CI_ResponsibleParty_Type() {
        //        OrganisationName = new CharacterString_PropertyType() {
        //          CharacterString = "British Geological Survey"
        //        },
        //        //ContactInfo = new CI_Contact_PropertyType() {
        //        //  UuidRef = "lala0000",
        //        //  Actuate = IActuate.ActuateBehaviours[ActuateBehaviour.None],
        //        //  Show = ObjectReference_PropertyType.ShowBehaviours[ShowBehaviour.Embed],
        //        //  NilReason = INilReason.GetNilReason(NilReasonEnumeration.Missing),
        //        //  NilReason = INilReason.GetNilReason(NilReasonEnumeration.Other, "Who knows what is the reason"),
        //        //  NilReason = INilReason.GetNilReason("http://www.koula.com/1/2/used-already-nilreason/"
        //        //},
        //        ContactInfo = new CI_Contact_PropertyType() {
        //          CI_Contact = new CI_Contact_Type() {
        //            Phone = new CI_Telephone_PropertyType() {
        //              CI_Telephone = new CI_Telephone_Type() {
        //                Voice = new List<CharacterString_PropertyType>() {
        //                  { new CharacterString_PropertyType() { CharacterString = "+44 115 936 3100" } }
        //                }
        //              }
        //            },
        //            Address = new CI_Address_PropertyType() {
        //              CI_Address = new CI_Address_Type() {
        //                DeliveryPoint = new List<CharacterString_PropertyType>() {
        //                  { new CharacterString_PropertyType() { CharacterString = "Environmental Science Centre, Keyworth" } }
        //                },
        //                City = new CharacterString_PropertyType() { CharacterString = "NOTTINGHAM" },
        //                AdministrativeArea = new CharacterString_PropertyType() { CharacterString = "NOTTINGHAMSHIRE" },
        //                PostalCode = new CharacterString_PropertyType() { CharacterString = "NG12 5GG" },
        //                Country = new CharacterString_PropertyType() { CharacterString = "Environmental Science Centre, Keyworth" },
        //                ElectronicMailAddress = new List<CharacterString_PropertyType>() {
        //                  { new CharacterString_PropertyType() { CharacterString = "enquiries@bgs.ac.uk" } }
        //                }
        //              }
        //            }
        //          }
        //        }
        //      }
        //    }
        //  }
        //},
        //DateStamp = new Date_PropertyType() {
        //  //Item = new System.DateTime(2022, 7, 5, 14, 28, 0).Date
        //  DateOrDateTime = "2022-07-05"
        //  //DateOrDateTime = new System.DateTime(2022, 01, 16, 21, 24, 28)
        //},
        //MetadataStandardName = new 




        //DateStamp = new DateTime(2022, 7, 5),
        //MetadataStandardName = "UK GEMINI", // xmltype: Anchor
        //MetadataStandardVersion = "2.3",
        //DatasetURI = "http://data.bgs.ac.uk/id/dataHolding/13603094",
        //DistributionInfo = new MD_Distribution {
        //  DistributionFormat = new List<MD_Format> {
        //    new MD_Format {
        //      Name = "GIS Files(shp and tab)",
        //      Version = "inapplicable",
        //    },
        //    new MD_Format {
        //      Name = "Hardcopy - Printed Map",
        //      Version = "inapplicable",
        //    },
        //  },

        //  Distributor = new List<MD_Distributor> {
        //    new MD_Distributor {
        //      DistributorContact = new CI_ResponsibleParty {
        //       IndividualName = "Enquiries",
        //       OrganisationName = "British Geological Survey",
        //       ContactInfo = new CI_Contact {
        //         Phone = new CI_Telephone {
        //           Voice = new List<string> { "0115 936 3143" },
        //           Facsimile = new List<string> { "0115 936 3276" },
        //         },
        //         Address = new CI_Address {
        //           DeliveryPoint = new List<string> {
        //             "Environmental Science Centre, Nicker Hill, Keyworth"
        //           },
        //           City = "NOTTINGHAM",
        //           AdministrativeArea = "NOTTINGHAMSHIRE",
        //           PostalCode = "NG12 5GG",
        //           Country = "United Kingdom",
        //           ElectronicMailAddress =  new List<string>{ "enquiries@bgs.ac.uk" },
        //         }
        //       },
        //       Role = new CI_RoleCode{Value= CI_RoleCodeValue.Distributor }
        //     },
        //      DistributorTransferOptions = new List<MD_DigitalTransferOptions> {
        //       new MD_DigitalTransferOptions {
        //       OnLine = new List<CI_OnlineResource> {
        //         new CI_OnlineResource{
        //           Linkage =   "http://ogc.bgs.ac.uk/dppp/wmc/gif.xml", // xmltype: URL
        //           Protocol= "http",
        //           Name = "Web map context for GIF",
        //           Description = "Web map context for GIF",
        //           Function = new CI_OnLineFunctionCode{ Value = CI_OnLineFunctionCodeValue.Download }
        //           }
        //       }
        //     },
        //       new MD_DigitalTransferOptions {
        //         OnLine = new List<CI_OnlineResource> {
        //           new CI_OnlineResource {
        //             Linkage = "http://ogc.bgs.ac.uk/dppp/kml/gif.kml", // xmltype: URL
        //             Protocol = "http",
        //             Name = "KML resource for GIF",
        //             Description = "KML resource for GIF",
        //             Function = new CI_OnLineFunctionCode {
        //               Value = CI_OnLineFunctionCodeValue.Download
        //             }


        //           }
        //         }
        //       },
        //       new MD_DigitalTransferOptions {
        //         OnLine = new List<CI_OnlineResource> {
        //           new CI_OnlineResource {
        //             Linkage = "http://www.bgs.ac.uk/products/hydrogeology/indicatorsOfFlooding.html",
        //             Description = "Geological Indicators of Flooding Homepage.",
        //             Function = new CI_OnLineFunctionCode {
        //               Value= CI_OnLineFunctionCodeValue.Information
        //             }
        //           }
        //         }
        //       }

        //     },
        //    }
        //  }
        //},

      };

      return metadata;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the gmd_metadata_02.xml resource file.
    /// </summary>
    /// <remarks>
    /// .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\gmd_metadata_02.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadata02Type() {

      MD_Metadata_Type metadata = new MD_Metadata_Type();
      //metadata.FileIdentifier = new CharacterString_PropertyType {
      //  CharacterString = "de61cf3bd77c4246b2d1bdd769a788c7"
      //};

      //metadata.Language = new LanguageCode_PropertyType() {
      //  LanguageCode = new CodeListValue_Type() {
      //    CodeList = "http://www.loc.gov/standards/iso639-2/php/code_list.php",
      //    CodeListValue = "eng",
      //    Value = "English"
      //  }
      //};

      //metadata.CharacterSet = new MD_CharacterSetCode_PropertyType() {
      //  MD_CharacterSetCode = new CodeListValue_Type() {
      //    CodeList = "http://standards.iso.org/ittf/PubliclyAvailableStandards/ISO_19139_Schemas/resources/codelist/gmxCodelists.xml#MD_CharacterSetCode",
      //    CodeListValue = "utf8",
      //    Value = "8-bit variable size UCS Transfer Format, based on ISO/IEC 10646"
      //  }
      //};

      //metadata.ParentIdentifier = new CharacterString_PropertyType {
      //  CharacterString = "d8e627be22c940e0b299bfcaaca1dd24"
      //};
      
      //metadata.HierarchyLevelName = new List<CharacterString_PropertyType>() {
      //  new CharacterString_PropertyType() {
      //    NilReason = NilReasonEnumeration.Inapplicable.ToString(),
      //  }
      //};

      ////metadata.HierarchyLevel = new MD_ScopeCode_PropertyType {
      ////  MD_ScopeCode mdScopeCode = new CodeListValue_Type() {
      ////    CodeList = "https://schemas.isotc211.org/schemas/19139/resources/codelist/gmxCodelists.xml#MD_ScopeCode",
      ////    CodeListValue = "dataset",
      ////    Value = "dataset"
      ////  }
      ////};

      //metadata.Contact = new List<CI_ResponsibleParty_PropertyType> {
      //  new CI_ResponsibleParty_PropertyType() {
      //    CI_ResponsibleParty = new CI_ResponsibleParty_Type() {
      //      OrganisationName = new CharacterString_PropertyType() {
      //        CharacterString = "Centre for Environmental Data Analysis (CEDA)"
      //      },
      //      ContactInfo = new CI_Contact_PropertyType() {
      //        CI_Contact= new CI_Contact_Type() {
      //          Phone = new CI_Telephone_PropertyType() {
      //            CI_Telephone = new CI_Telephone_Type() {
      //              Voice = new List<CharacterString_PropertyType>{
      //                new CharacterString_PropertyType() {
      //                  CharacterString = "01235446432"
      //                }
      //              }
      //            }
      //          },
      //          Address= new CI_Address_PropertyType() {
      //            CI_Address = new CI_Address_Type() {
      //              DeliveryPoint = new List<CharacterString_PropertyType> {
      //                new CharacterString_PropertyType() { CharacterString = "Rutherford Appleton Laboratory" },
      //                new CharacterString_PropertyType() { CharacterString = "Harwell" },
      //              },
      //              City = new CharacterString_PropertyType() { CharacterString = "Oxon" },
      //              PostalCode = new CharacterString_PropertyType() { CharacterString = "OX11 0QX" },
      //              Country= new CharacterString_PropertyType() { CharacterString = "United Kingdom" },
      //              ElectronicMailAddress= new List<CharacterString_PropertyType> {
      //                new CharacterString_PropertyType() { CharacterString = "support@ceda.ac.uk" },
      //              },
      //            }
      //          }
      //        }
      //      },
      //      Role = new CI_RoleCode_PropertyType() {
      //        CI_RoleCode = new CodeListValue_Type() {
      //          CodeList = "http://standards.iso.org/ittf/PubliclyAvailableStandards/ISO_19139_Schemas/resources/codelist/gmxCodelists.xml#CI_RoleCode",
      //          CodeListValue = "pointOfContact",
      //          Value = "pointOfContact"
      //        }
      //      },

      //    }
      //  }
      //};
      
      // TODO: Did not Finish. Please continue the metadata creation of gmd_metadata_02.xml.
      return metadata;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the gmd_metadata_03.xml resource file.
    /// </summary>
    /// <remarks>
    /// // .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\gmd_metadata_03.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadata03Type() {
      
      var metadata = new MD_Metadata_Type();

      //metadata.FileIdentifier = new CharacterString_PropertyType() { 
      //  CharacterString = "9df8df52-d644-37a8-e044-0003ba9b0d98" 
      //};
      //metadata.Contact = new List<CI_ResponsibleParty_PropertyType>() {
      //  new CI_ResponsibleParty_PropertyType {
      //    CI_ResponsibleParty = new CI_ResponsibleParty_Type() {
      //      OrganisationName = new CharacterString_PropertyType() {
      //        CharacterString = "British Geological Survey"
      //      },
      //      ContactInfo = new CI_Contact_PropertyType() {
      //        CI_Contact = new CI_Contact_Type() {
      //          Phone = new CI_Telephone_PropertyType() {
      //            CI_Telephone = new CI_Telephone_Type() {
      //              Voice = new List<CharacterString_PropertyType>{
      //                new CharacterString_PropertyType() {
      //                  CharacterString = "+44 115 936 3100"
      //                }
      //              }
      //            }
      //          },
      //          Address = new CI_Address_PropertyType() {
      //            CI_Address= new CI_Address_Type() {
      //              DeliveryPoint = new List<CharacterString_PropertyType>() {
      //                new CharacterString_PropertyType() {
      //                  CharacterString = "Environmental Science Centre, Keyworth"
      //                },
      //              },
      //              City = new CharacterString_PropertyType() {
      //                  CharacterString = "NOTTINGHAM"
      //                },
      //              AdministrativeArea= new CharacterString_PropertyType() {
      //                CharacterString = "NOTTINGHAMSHIRE"
      //              },
      //              PostalCode = new CharacterString_PropertyType() {
      //                CharacterString = "NG12 5GG"

      //              },
      //              Country = new CharacterString_PropertyType() {
      //                CharacterString = "United Kingdom"
      //              },
      //              ElectronicMailAddress = new List<CharacterString_PropertyType>{new CharacterString_PropertyType() {CharacterString = "enquiries@bgs.ac.uk"}},



      //            }
      //          }

      //        },
      //      },
      //      Role = new CI_RoleCode_PropertyType() {
      //        CI_RoleCode= new CodeListValue_Type() {
      //          CodeList = "https://schemas.isotc211.org/schemas/19139/resources/codelist/gmxCodelists.xml#CI_RoleCode",
      //          CodeListValue = "pointOfContact",
      //          Value = "pointOfContact"
      //      }
      //      }
      //    }
      //  },

      //};

      // TODO: Did not Finish. Please continue the metadata creation of gmd_metadata_03.xml.

      return metadata;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the gmd_metadata_03.xml resource file.
    /// </summary>
    /// <remarks>
    /// // .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\gmd_metadata_03.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadataNerc00001() {
      // .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\nerc00001.xml
      return null;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the nerc00101.xml resource file.
    /// </summary>
    /// <remarks>
    /// // .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\nerc00101.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadataNerc00101() {
      
      return null;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the nerc00201.xml resource file.
    /// </summary>
    /// <remarks>
    /// .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\nerc00201.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadataNerc00201() {
      
      return null;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the nerc00301.xml resource file.
    /// </summary>
    /// <remarks>
    /// .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\nerc00301.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadataNerc00301() {
      
      return null;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the nerc00401.xml resource file.
    /// </summary>
    /// <remarks>
    /// .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\nerc00401.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadataNerc00401() {
      
      return null;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the nerc00501.xml resource file.
    /// </summary>
    /// <remarks>
    /// .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\nerc00501.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadataNerc00501() {
      
      return null;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the nerc00601.xml resource file.
    /// </summary>
    /// <remarks>
    /// .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\nerc00601.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadataNerc00601() {
      
      return null;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the nerc00701.xml resource file.
    /// </summary>
    /// <remarks>
    /// .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\nerc00701.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadataNerc00701() {
      
      return null;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the nerc00801.xml resource file.
    /// </summary>
    /// <remarks>
    /// .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\nerc00801.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadataNerc00801() {
      
      return null;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the nerc00901.xml resource file.
    /// </summary>
    /// <remarks>
    /// .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\nerc00901.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadataNerc00901() {
      
      return null;

    }

    /// <summary>
    /// Serializes a <see cref="MD_Metadata_Type"/> based on the nerc001001.xml resource file.
    /// </summary>
    /// <remarks>
    /// .\nerc-digital-solutions-hub\Hub\DotNet\Proj\src\NDSH.Geospatial.Metadata.V2003\tests.content\NERC\nerc001001.xml
    /// </remarks>
    /// <returns>A <see cref="MD_Metadata_Type"/>.</returns>
    private static MD_Metadata_Type CreateMetadataNerc01001() {
      
      return null;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static CT_CodelistCatalogue_Type CreateML_GmxCodelistCatalogueType() {

      CT_CodelistCatalogue_Type codelistCatalogue = new CT_CodelistCatalogue_Type() {
        Name = new CharacterString_PropertyType() {
          CharacterString = "ML_gmxCodelists"
        },

      };

      return codelistCatalogue;

    }

    #endregion

  }

}
