
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Constraint;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Names;
using NDSH.Utilities.App.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

#endregion

namespace NDSH.Utilities.App {

  /// <summary>
  /// 
  /// </summary>
  public static class XsdToCode {

    #region Public Methods

    /// <summary>
    /// 
    /// </summary>
    /// <param name="xsdPath"></param>
    /// <param name="xsdResourceName"></param>
    /// <param name="richTextBox"></param>
    public static XmlSchema? GetXmlSchema(string xsdPath, string xsdResourceName, RichTextBox richTextBox) {

      richTextBox.Text = "";

      Stream stream = GetEmbeddedResourceStream(xsdPath, xsdResourceName);

      if (stream == null) {
        return null;
      }

      StreamReader streamReader = new StreamReader(stream);
      richTextBox.Text = streamReader.ReadToEnd();
      stream.Position = 0;
      
      return XmlSchema.Read(stream, null);
      
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="xmlSchema"></param>
    /// <param name="classTypeVariables"></param>
    /// <returns></returns>
    public static string GenerateTypesCode(XmlSchema? xmlSchema, ClassTypeVariables classTypeVariables) {

      Logger logger = new Logger();

      XmlQualifiedName abstractObjectTypeQN = new XmlQualifiedName("AbstractObject_Type", "http://www.isotc211.org/2005/gco");

      if (xmlSchema == null) {
        logger.Log("NullSchema", "The Schema was not created successfully.");
        return logger.Dump();
      }

      XmlSchemaObjectCollection items = xmlSchema.Items;

      if (xmlSchema.Items == null) {
        logger.Log("NoSchemaContents", "No contents found in schema.");
        return logger.Dump();
      }

      StringBuilder sb = new StringBuilder();

      foreach (var item in items) {
        if (item.GetType() == typeof(XmlSchemaComplexType)) {
          sb.AppendLine(ProcessComplexType((XmlSchemaComplexType)item, logger, abstractObjectTypeQN, classTypeVariables));
        }
        else if (item.GetType() == typeof(XmlSchemaElement)) {
          //ProcessElementType((XmlSchemaElement)item, logger);
        }
        sb.AppendLine();
        sb.AppendLine();
        sb.AppendLine("================================================================================");
        sb.AppendLine();
        sb.AppendLine();
      }

      return sb.ToString();
    
    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <param name="resourceName"></param>
    /// <returns></returns>
    private static Stream GetEmbeddedResourceStream(string path, string resourceName) {

      Assembly? assembly = Assembly.GetAssembly(typeof(NDSH.Geospatial.Metadata.V2003.Tests.Content.Content));

      return assembly?.GetManifestResourceStream(string.Format($"{path}.{resourceName}", path, resourceName));

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="complexType"></param>
    /// <param name="logger"></param>
    /// <param name="abstractObjectTypeQN"></param>
    /// <param name="classTypeVariables"></param>
    /// <returns></returns>
    private static string ProcessComplexType(XmlSchemaComplexType complexType, Logger logger, XmlQualifiedName abstractObjectTypeQN, ClassTypeVariables classTypeVariables) {

      string result = default;

      if (complexType == null) {
        logger.Log(DateTime.Now.Ticks.ToString(), "Complex Type is null.");
        return result;
      }

      if (complexType.Name == null) {
        logger.Log(DateTime.Now.Ticks.ToString(), "Complex Type Name is null.");
        return result;
      }

      if (complexType.Name.EndsWith("_Type")) {
        result = ProcessType(complexType, logger, abstractObjectTypeQN, classTypeVariables);
      }
      else if (complexType.Name.EndsWith("_PropertyType")) {
        result = ProcessPropertyType(complexType, logger, abstractObjectTypeQN, classTypeVariables);
      }
      
      return result;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="complexType"></param>
    /// <param name="logger"></param>
    /// <param name="abstractObjectTypeQN"></param>
    /// <param name="classTypeVariables"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    private static string? ProcessType(XmlSchemaComplexType complexType, Logger logger, XmlQualifiedName abstractObjectTypeQN, ClassTypeVariables classTypeVariables) {

      string result = default;
      List<string> properties = default;

      string classCode = Resources.ClassTemplateType;

      string element = complexType.Name.Replace("_Type", "");

      if (complexType.ContentModel == null) {
        logger.Log(Logger.CreateKey(complexType.Name, complexType.LinePosition), "Complex Type ContentModel is null.");
        return result;
      }

      if (complexType.ContentModel.Content == null) {
        logger.Log(Logger.CreateKey(complexType.Name, complexType.ContentModel.LinePosition), "Complex Type ContentModel.Content is null.");
        return result;
      }

      // Make sure that the Type has a content extension.
      if (complexType.ContentModel.Content.GetType() != typeof(XmlSchemaComplexContentExtension)) {
        logger.Log(Logger.CreateKey(complexType.ContentModel.Content.GetType().Name, complexType.ContentModel.Content.LineNumber), "Complex Type ContentModel.Content does not have a content extension.");
        return result;
      }

      XmlSchemaComplexContentExtension complexContentExtension = (XmlSchemaComplexContentExtension)complexType.ContentModel.Content;

      // Make sure that the Type inherits from AbstractObject_Type.
      if (complexContentExtension.BaseTypeName != abstractObjectTypeQN) {
        logger.Log(Logger.CreateKey(DateTime.Now.Ticks.ToString(), complexContentExtension.LineNumber), "Complex Type ContentModel.Content extension base type is not AbstractObject_Type.");
        return result;
      }

      if (complexContentExtension.Particle == null) {
        logger.Log(Logger.CreateKey(DateTime.Now.Ticks.ToString(), complexContentExtension.LineNumber), "Complex Type ContentModel.Content extension in null.");
        return result;
      }

      if (complexContentExtension.Particle.GetType() != typeof(XmlSchemaSequence)) {
        logger.Log(Logger.CreateKey(DateTime.Now.Ticks.ToString(), complexContentExtension.Particle.LineNumber), "Complex Type ContentModel.Content extension does not have a sequence.");
        return result;
      }

      XmlSchemaSequence sequence = (XmlSchemaSequence)complexContentExtension.Particle;

      if (sequence.Items == null) {
        logger.Log(Logger.CreateKey(DateTime.Now.Ticks.ToString(), sequence.LineNumber), "Complex Type ContentModel.Content extension sequence is null.");
        return result;
      }

      if (sequence.Items.Count <= 0) {
        logger.Log(Logger.CreateKey(DateTime.Now.Ticks.ToString(), sequence.LineNumber), "Complex Type ContentModel.Content extension sequence has no items.");
        return result;
      }

      // Create the Properties of the class.

      properties = new List<string>(sequence.Items.Count);

      int order = 0;

      // Loop through the sequence items.
      foreach (var seqItem in sequence.Items) {
        if (seqItem == null) {
          logger.Log(Logger.CreateKey(DateTime.Now.Ticks.ToString(), sequence.LineNumber), "Complex Type ContentModel.Content extension sequence item is null.");
        }
        else {
          if (seqItem.GetType() != typeof(XmlSchemaElement)) {
            logger.Log(Logger.CreateKey(DateTime.Now.Ticks.ToString(), seqItem.LineNumber), "Complex Type ContentModel.Content extension sequence item is not an element.");
          }

          XmlSchemaElement xsdElement = (XmlSchemaElement)seqItem;

          if (xsdElement == null) {
            logger.Log(Logger.CreateKey(DateTime.Now.Ticks.ToString(), seqItem.LineNumber), "Complex Type ContentModel.Content extension sequence element is null.");
          }
          else {

            string propertyCode;

            // Check if the property is a List.
            if (xsdElement.MaxOccursString == "unbounded") {
              propertyCode = Resources.PropertyListTemplate;
            }
            else {
              propertyCode = Resources.PropertyObjectTemplate;
            }

            string propertyVariable = "";
            string propertyName = "";

            if (xsdElement.Name == null) {
              logger.Log(Logger.CreateKey(DateTime.Now.Ticks.ToString(), xsdElement.LineNumber), "Complex Type ContentModel.Content extension sequence element name is null.");
            }
            else {
              propertyVariable = xsdElement.Name;
              propertyName = propertyVariable[0].ToString().ToUpperInvariant() + propertyVariable.Substring(1);
            }

            string type = default;

            if (xsdElement.SchemaTypeName == null) {
              logger.Log(Logger.CreateKey(DateTime.Now.Ticks.ToString(), xsdElement.LineNumber), "Complex Type ContentModel.Content extension sequence element SchemaTypeName is null.");
            }
            else {
              if (xsdElement.SchemaTypeName.Name == null) {
                logger.Log(Logger.CreateKey(DateTime.Now.Ticks.ToString(), xsdElement.LineNumber), "Complex Type ContentModel.Content extension sequence element SchemaTypeName.Name is null.");
              }
              else {
                type = xsdElement.SchemaTypeName.Name;
              }
            }
            
            // Create the property code and add it to the code list.
            propertyCode = propertyCode.Replace("@@Element@@", propertyVariable)
                                       .Replace("@@Property@@", propertyName)
                                       .Replace("@@Type@@", type)
                                       .Replace("@@Order@@", order.ToString());

            properties.Add(propertyCode);

            // Advance the property order by one.
            order++;

          }

        }

      }

      // Create a StringBuilder to output all properties code in to a string.

      StringBuilder sb = new StringBuilder();

      for (int i = 0; i < properties.Count; i++) {
        sb.Append(properties[i]);
        sb.AppendLine("");
        sb.AppendLine("    ");
        sb.Append("    ");
      }

      // Create the class code.
      classCode = classCode.Replace("@@dd@@", DateTime.Now.Day.ToString().PadLeft(2, '0'))
                           .Replace("@@hh@@", DateTime.Now.Hour.ToString().PadLeft(2, '0'))
                           .Replace("@@mm@@", DateTime.Now.Minute.ToString().PadLeft(2, '0'))
                           .Replace("@@Coder@@", classTypeVariables.Coder)
                           .Replace("@@Namespace@@", classTypeVariables.Namespace)
                           .Replace("@@Element@@", element)
                           .Replace("@@XmlNamespace@@", classTypeVariables.XmlNamespace)
                           .Replace("@@Prefix@@", classTypeVariables.XmlNamespacePrefix)
                           .Replace("@@PropertiesList@@", sb.ToString());

      result = classCode;

      return result;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="complexType"></param>
    /// <param name="logger"></param>
    /// <param name="abstractObjectTypeQN"></param>
    /// <param name="classTypeVariables"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    private static string? ProcessPropertyType(XmlSchemaComplexType complexType, Logger logger, XmlQualifiedName abstractObjectTypeQN, ClassTypeVariables classTypeVariables) {
      return String.Empty;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <exception cref="NotImplementedException"></exception>
    private static void ProcessElementType(XmlSchemaElement item) {
      throw new NotImplementedException();
    }

    #endregion

    /// <summary>
    /// 
    /// </summary>
    private class Logger {

      #region Member Variables

      private readonly Dictionary<string, string> _logRecords;

      #endregion

      #region Constructors - Destructors

      /// <summary>
      /// 
      /// </summary>
      public Logger() {
        _logRecords = new Dictionary<string, string>();
      }

      #endregion

      #region Public Methods

      /// <summary>
      /// 
      /// </summary>
      /// <param name="s"></param>
      /// <param name="lineNumber"></param>
      public static string CreateKey(string s, int lineNumber) {
        return string.Format("{0}/linenumber:{1}", s, lineNumber);
      }

      /// <summary>
      /// 
      /// </summary>
      public void Clear() {
        _logRecords.Clear();
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="key"></param>
      /// <param name="message"></param>
      public void Log(string key, string message) {
        _logRecords.Add(key, message);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      public string Dump() {

        StringBuilder sb = new StringBuilder();

        foreach (string key in _logRecords.Keys) {
          sb.AppendLine(string.Format("{0}: {1}", key, _logRecords[key]));
        }

        return sb.ToString();

      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="key"></param>
      /// <returns></returns>
      public string Dump(string key) {
        return _logRecords.Keys.Contains(key) == true ? string.Format("{0}: {1}", key, _logRecords[key]) : string.Format("key: message empty");
      }

      #endregion

    }

    /// <summary>
    /// 
    /// </summary>
    public class ClassTypeVariables {

      public string Coder;

      public string Namespace;

      public string XmlNamespace;

      public string XmlNamespacePrefix;
    
    }

  }

}
