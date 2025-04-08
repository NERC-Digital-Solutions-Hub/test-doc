
#region Imported Namespaces

using NDSH.Geospatial.Metadata.Serializers;
using NDSH.Geospatial.Metadata.V2005;
using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2005.EntitySet;
using NDSH.Geospatial.Metadata.V2005.ReferenceSystem;
using NDSH.Geospatial.Metadata.V2005.Tests.Content;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Net;

#endregion

namespace NDSH.Utilities.App {

  /// <summary>
  /// 
  /// </summary>
  public static class V2005 {

    #region Public Methods

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeEntity(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, string indentChars = "  ") {
      if (indentCheckBox.Checked) {
        inputTextBox.Text = CitationInformationResources.Entity;
      }
      else {
        inputTextBox.Text = CitationInformationResources.Entity_Compact;
      }

      V2005.SerializeObjectToXml(outputTextBox, V2005.CreateEntity(), indentCheckBox.Checked, indentChars);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeCharacterString(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

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

      CharacterString cs = V2005.CreateCharacterString();

      if (useEntity) {
        Entity entity = V2005.CreateEntity();
        entity.Item = cs;

        SerializeObjectToXml(outputTextBox, entity, indent, indentChars);
      }
      else {
        SerializeObjectToXml(outputTextBox, cs, indent, indentChars);
      }

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeAddress(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

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

      CI_Address address = V2005.CreateAddress();

      if (useEntity) {
        Entity entity = V2005.CreateEntity();
        entity.Item = address;

        SerializeObjectToXml(outputTextBox, entity, indent, indentChars);
      }
      else {
        SerializeObjectToXml(outputTextBox, address, indent, indentChars);
      }

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeCitation(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

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

      CI_Citation citation = V2005.CreateCitation();

      if (useEntity) {
        Entity entity = V2005.CreateEntity();
        entity.Item = citation;

        SerializeObjectToXml(outputTextBox, entity, indent, indentChars);
      }
      else {
        SerializeObjectToXml(outputTextBox, citation, indent, indentChars);
      }

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeTelephone(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

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

      CI_Telephone telephone = V2005.CreateTelephone();

      if (useEntity) {
        Entity entity = V2005.CreateEntity();
        entity.Item = telephone;

        SerializeObjectToXml(outputTextBox, entity, indent, indentChars);
      }
      else {
        SerializeObjectToXml(outputTextBox, telephone, indent, indentChars);
      }

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputTextBox"></param>
    /// <param name="outputTextBox"></param>
    /// <param name="indentCheckBox"></param>
    /// <param name="useEntityCheckBox"></param>
    /// <param name="indentChars"></param>
    public static void SerializeMetadata(RichTextBox inputTextBox, RichTextBox outputTextBox, CheckBox indentCheckBox, CheckBox useEntityCheckBox, string indentChars = "  ") {

      bool indent = indentCheckBox.Checked;
      bool useEntity = useEntityCheckBox.Checked;

      inputTextBox.Text = MetadataInformationResources.Test01;

      MD_Metadata metadata = V2005.CreateMetadata01();

      SerializeObjectToXml(outputTextBox, metadata, indent, indentChars);

    }

    #endregion

    #region Private Procedures

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

        GeoNetworkGmd2005Serializer xmlSerializer = new GeoNetworkGmd2005Serializer(obj.GetType());
        //XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
        xmlSerializer.Serialize(xmlWriter, obj, xmlSerializerNamespaces);

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
    /// 
    /// </summary>
    /// <returns></returns>
    private static Entity CreateEntity() {
      return new Entity();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static CharacterString CreateCharacterString() {

      CharacterString cs = new();
      cs.Value = "This is a character string";

      return cs;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static CI_Address CreateAddress() {

      CI_Address address = new CI_Address() {
        Id = "id-1",
        Uuid = "uuid-1",
        DeliveryPoint = new List<string>(1),
        City = "NOTTINGHAM",
        AdministrativeArea = "NOTTINGHAMSHIRE",
        PostalCode = "NG12 5GG",
        Country = "United Kingdom",
        ElectronicMailAddress = new List<string>(1)
      };
      address.DeliveryPoint.Add("Environmental Science Centre, Keyworth");
      address.ElectronicMailAddress.Add("enquiries@bgs.ac.uk");

      return address;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static CI_Citation CreateCitation() {

      CI_Citation citation = new CI_Citation() {
        Title = "Geological Indicators of Flooding Great Britain",
        Date = new List<CI_Date>() {
          new CI_Date() {
            Date = "2006",
            DateType = new CI_DateTypeCode() {
              Value = CI_DateTypeCodeValue.Creation
            }
          }
        },
        Identifier = new List<Parent_MD_Identifier>() {
          new Parent_MD_Identifier() {
            Item = new MD_Identifier() {
              Code = "http://data.bgs.ac.uk/id/dataHolding/13603094"
            }
          }
        }
      };

      return citation;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static CI_Telephone CreateTelephone() {

      CI_Telephone telephone = new() {
        Id = "id-1",
        Uuid = "uuid-1",
        Facsimile = new List<string>(),
        Voice = new List<string>()
      };
      telephone.Facsimile.Add("0115 936 3276");
      telephone.Voice.Add("0115 936 3143");

      return telephone;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static MD_Metadata CreateMetadata01() {

      MD_Metadata metadata = new MD_Metadata {
        FileIdentifier = "9df8df52-d644-37a8-e044-0003ba9b0d98",
        //Contact = new List<CI_ResponsibleParty> {
        //  new CI_ResponsibleParty() {
        //    OrganisationName = "British Geologiical Survey",
        //    ContactInfo = new CI_Contact {
        //      Phone = new CI_Telephone {
        //        Voice = new List<string> { "+44 115 936 3100" }
        //      },
        //      Address = new CI_Address {
        //        DeliveryPoint = new List<string> { "Environmental Science Centre, Keyworth" },
        //        City = "NOTTINGHAM",
        //        AdministrativeArea = "NOTTINGHAMSHIRE",
        //        PostalCode = "NG12 5GG",
        //        Country = "United Kingdom",
        //        ElectronicMailAddress=new List<string>{ "enquiries@bgs.ac.uk" }
        //      }
        //    },
        //    Role = new CI_RoleCode {
        //      Value = CI_RoleCodeValue.PointOfContact
        //    }
        //  }
        //},

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

    #endregion

  }

}
