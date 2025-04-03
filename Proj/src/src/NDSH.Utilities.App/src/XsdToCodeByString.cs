
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Names;
using NDSH.Utilities.App.Properties;
using Serilog;
using Serilog.Core;

namespace NDSH.Utilities.App {

  /// <summary>
  /// 
  /// </summary>
  public class XsdToCodeByString {

    /// <summary>
    /// 
    /// </summary>
    public List<XSDClass> XsdClasses {
      get; set;
    } = new();

    /// <summary>
    /// 
    /// </summary>
    public string XsdString {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string XsdFilePath {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Author { get; set; } = "";
    

    private Logger _logger = null;
    
    /// <summary>
    /// 
    /// </summary>
    public string LogFilePath {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public string AbstractObject_Type_FP {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public static string ReadFileToString(string filePath) {
      return File.ReadAllText(filePath);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="xsdResourceFile"></param>
    /// <returns></returns>
    public static string? GetEmbeddedXsdFileResourceString(string xsdResourceFile) {

      string xsd = null;

      Assembly? assembly = Assembly.GetAssembly(typeof(NDSH.Geospatial.Metadata.V2003.Tests.Content.Content));

      Stream stream = assembly?.GetManifestResourceStream(string.Format("NDSH.Geospatial.Metadata.V19136.Tests.Content.Schemas.{0}", xsdResourceFile));
      if (stream != null) {
        StreamReader streamReader = new StreamReader(stream);
        xsd = streamReader.ReadToEnd();
        streamReader.Close();
      }

      return xsd;

    }

    /// <summary>
    /// 
    /// </summary>
    public XsdToCodeByString(string logFilePath = "") {
      if (logFilePath.Length > 0) {
        _logger = new LoggerConfiguration()
                  .MinimumLevel.Debug()
                  .WriteTo.Console()
                  .WriteTo.File(logFilePath)
                  .CreateLogger();
      }
      else {
        _logger = new LoggerConfiguration()
                  .MinimumLevel.Debug()
                  .WriteTo.Console()
                  .CreateLogger();

      }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="attrToken"></param>
    /// <param name="xsdString"></param>
    /// <param name="startIdx"></param>
    /// <param name="endIdx"></param>
    /// <returns></returns>
    private string getAttritube(string attrToken, string xsdString, int startIdx = 0, int endIdx = -1) {
      if (endIdx < 0) {
        endIdx = xsdString.Length - 1;
      }


      int i = startIdx;
      string attr = "";
      attrToken += '=';
      attrToken += '"';
      while (i + attrToken.Length < endIdx + 1) {
        string checkWord = xsdString.Substring(i, attrToken.Length);
        if (checkWord == attrToken) {
          i += attrToken.Length;
          Debug.Assert(xsdString[i - 1] == '"');
          while (i < xsdString.Length) {
            char c = xsdString[i];
            if (c == '"')
              break;
            attr += c;
            i++;
          }
          return attr;
        }
        i++ ;
      }
      return "";
    }
    
    /// <summary>
    /// returns begin tag of <paramref name="tagName"/>
    /// </summary>
    /// <param name="tagName"></param>
    /// <returns></returns>
    public string BeginTag(string tagName) {
      Debug.Assert(!string.IsNullOrEmpty(tagName));
      return $"<xs:{tagName}";
    }

    /// <summary>
    /// return end tag of <paramref name="tagName"/>
    /// </summary>
    /// <param name="tagName"></param>
    /// <returns></returns>
    public string EndTag(string tagName) {
      Debug.Assert(!string.IsNullOrEmpty(tagName));
      if (tagName == "element")
        return "/>";
      return $"</xs:{tagName}>";
    }

    /// <summary>
    /// returns the <paramref name="tag"/> index from <paramref name="startIdx"/>, returns -1 if not found
    /// </summary>
    /// <param name="tag"></param>
    /// <param name="xsdString"></param>
    /// <param name="startIdx"></param>
    /// <param name="endIdx"></param>
    /// <param name="lastIdx"></param>
    /// <returns></returns>
    public int FindTagIdx(string tag, string xsdString, int startIdx = 0, int endIdx = -1, bool lastIdx = false) {
      if (endIdx >= xsdString.Length)
        throw new IndexOutOfRangeException("endIdx out of range.");
      
      if (tag == null) {
        throw new ArgumentNullException("tag is null");
      }

      if ( string.IsNullOrEmpty(tag) 
        && !(tag.StartsWith("<xs:") || tag.EndsWith('>'))) {
        throw new ArgumentException($"[{tag}] is not a tag.");
      }
      
      if (xsdString == "") {
        return -1;
      }
      
      if (endIdx < 0) {
        endIdx = xsdString.Length - 1;
      }
      
      if (endIdx < startIdx) {
        return -1;
      }
      
      int idx = xsdString.IndexOf(tag, startIdx, endIdx - startIdx + 1);

      if (lastIdx == true)
        return idx + tag.Length - 1;
      //_logger.Information("find {tag} at index {idx}", tag, idx);
      return idx;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="tagName"></param>
    /// <param name="attrName"></param>
    /// <param name="xsdString"></param>
    /// <param name="startIdx"></param>
    /// <param name="endIdx"></param>
    /// <returns></returns>
    public string GetTagAttribute(string tagName, string attrName, string xsdString, int startIdx = 0, int endIdx = -1) {

      // Get a attribute value in a tag, return empty string if anything wrong.
      int i = FindTagIdx(tag: BeginTag(tagName), xsdString: xsdString, startIdx: startIdx, endIdx:endIdx);
      if (i < 0) {
        Console.WriteLine($"BeginTag: [{BeginTag(tagName)}] not found.");
        return "";
      }

      i += BeginTag(tagName).Length;
      int e = FindTagIdx(tag: EndTag(tagName), xsdString: xsdString, startIdx: i, endIdx:endIdx);

      if (e < 0) {
        Console.WriteLine($"EndTag: [{EndTag(tagName)}] not found.");
        return "";
      }
      
      string attr = getAttritube(attrToken: attrName, xsdString: xsdString, startIdx: i, endIdx: e); // ok
      return attr;
    }
    
    /// <summary>
    /// extract value between tag
    /// </summary>
    /// <param name="tagName"></param>
    /// <param name="xsdString"></param>
    /// <param name="startIdx"></param>
    /// <param name="endIdx"></param>
    /// <returns></returns>
    public string GetTagValue(string tagName, string xsdString, int startIdx = 0, int endIdx = -1) {
      if (EndTag(tagName) == "/>") {
        return "";
      }

      // Get the string between BeginTag and EndTag
      int i = FindTagIdx(tag: BeginTag(tagName), xsdString: xsdString, startIdx: startIdx, endIdx: endIdx);
      if (i < 0) {
        Console.WriteLine($"BeginTag: [{BeginTag(tagName)}] not found.");
        return "";
      }

      int e = FindTagIdx(tag: EndTag(tagName), xsdString: xsdString, startIdx: i, endIdx: endIdx);
      if (e < 0) {
        Console.WriteLine($"EndTag: [{EndTag(tagName)}] not found.");
        return "";
      }

      i = xsdString.IndexOf(value: '>',startIndex:i, count: e - i) + 1;
      string value = xsdString.Substring(i, e - i);
      return value;
    }

    /// <summary>
    /// Parse the <paramref name="xsdString"/> from <paramref name="startIdx"/> into <see cref="XSDClass"/>, add the object to  <see cref="XsdToCodeByString.XsdClasses"/> List
    /// note that it assumes there is no nested complexType, which is a very strong assumption.
    /// if <paramref name="recursive"/> is <code>true</code>, it parses all <complexType> object in the <paramref name="xsdString"/>
    /// </summary>
    /// <param name="xsdString"></param>
    /// <param name="startIdx"></param>
    /// <param name="recursive"></param>
    public void ParseXsdString(string xsdString = "", int startIdx = 0, bool recursive = false) {

      XSDClass XsdClass = new();
      int i = 0;
      int e = 0;

      // get <complexType>
      {
        i = FindTagIdx(tag: BeginTag("complexType"), xsdString: xsdString, startIdx: startIdx);
        if (i < 0)
          return;
        e = FindTagIdx(tag: EndTag("complexType"), xsdString: xsdString, startIdx: i); // We assume there is no nested complexType
        string name = GetTagAttribute(tagName: "complexType", attrName: "name", xsdString: xsdString, startIdx: i);
        Debug.Assert(name != "", $"attribute [name] not found");
        XsdClass.Name = name;
        i++;
      }

      // check if xsdString is a TypeWrapper or CodeListWrapper
      {
        bool FoundAttributeTag = FindTagIdx(tag: BeginTag("attribute"), xsdString: xsdString, startIdx: i, endIdx: e) > 0;
        bool FoundAttributeGroupTag = FindTagIdx(tag: BeginTag("attributeGroup"), xsdString: xsdString, startIdx: i, endIdx: e) > 0;
        if (FoundAttributeTag && !FoundAttributeGroupTag)
          XsdClass.IsCodeListWrapper = true;
        if (FoundAttributeTag && FoundAttributeGroupTag)
          XsdClass.IsTypeWrapper = true;
      }

      // get all <documentation> value
      {
        string summary = "";
        int prev_i = i;
        while (true) {
          i = FindTagIdx(tag: BeginTag("documentation"), xsdString: xsdString, startIdx: i, endIdx: e);
          if (i < 0) {
            i = prev_i;
            break;
          }

          string docString = GetTagValue(tagName: "documentation", xsdString: xsdString, startIdx: i, endIdx: e);

          if (summary.Length > 0) {
            summary += docString;
          }
          else {
            summary = docString;
          }
          prev_i = i;
          i++;
        }
        XsdClass.Summary = summary;

      }

      //try get <extension> base value, make sure only one extension tag
      {


        int extBeginIdx = FindTagIdx(tag: BeginTag("extension"), xsdString: xsdString, startIdx: i, endIdx: e);
        if (extBeginIdx > 0) {
          string ext = GetTagAttribute(tagName: "extension", attrName: "base", xsdString: xsdString, startIdx: extBeginIdx, endIdx: e);
          XsdClass.Extension = ext;
          i = extBeginIdx + 1;
          Debug.Assert(FindTagIdx(tag: BeginTag("extension"), xsdString: xsdString, startIdx: i, endIdx: e) < 0, "More than 1 <extension>");
        }

      }

      //try get <sequence>
      {

        int seqBeginIdx = FindTagIdx(tag: BeginTag("sequence"), xsdString: xsdString, startIdx: i, endIdx: e);
        if (seqBeginIdx > 0) {
          i = seqBeginIdx + 1;
          XsdClass.InOrder = true;
        }

      }

      // get all <element>
      {

        int prev_i = i;
        while (true) {

          i = FindTagIdx(tag: BeginTag("element"), xsdString: xsdString,
            startIdx: i, endIdx: e);

          if (i < 0) {
            i = prev_i;
            break;
          }
          string eName = GetTagAttribute(
            tagName: "element", attrName: "name", xsdString: xsdString,
            startIdx: i, endIdx: e);

          string eType = GetTagAttribute(
            tagName: "element", attrName: "type", xsdString: xsdString,
            startIdx: i, endIdx: e);

          string eMinOccurs = GetTagAttribute(
            tagName: "element", attrName: "minOccurs", xsdString: xsdString,
            startIdx: i, endIdx: e);

          string eMaxOccurs = GetTagAttribute(
            tagName: "element", attrName: "maxOccurs", xsdString: xsdString,
            startIdx: i, endIdx: e);

          string eRef = GetTagAttribute(
            tagName: "element", attrName: "ref", xsdString: xsdString,
          startIdx: i, endIdx: e);


          XSDClassElement el = new () {
            Name = eName,
            Type = eType,
            MaxOccurs = eMaxOccurs,
            MinOccurs = eMinOccurs,
            Ref = eRef
          };

          XsdClass.Elements.Add(el);
          prev_i = i;
          i++;
        }

      }

      XsdClasses.Add(XsdClass);
      if (recursive) {
        ParseXsdString(xsdString: xsdString, startIdx: e, recursive: true);
      }
      return;
    }

    /// <summary>
    /// stupid logging function.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="logFilePath"></param>
    public void WriteLog(string s, string logFilePath = null) {
      if (logFilePath == null) {
        logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "ChrisXsdToCode.log");
      }
      File.AppendAllText(logFilePath, s);
    }

    /// <summary>
    /// Add XmlInclude Attribute to AbstractObject_Type.cs if <paramref name="xsdClass"/> <see cref="XSDClass.Inheritance"/> is "AbstractObject_Type"
    /// Otherwise Log the <paramref name="xsdClass"/> <see cref="XSDClass.Name"/> for the record.
    /// </summary>
    /// <param name="xsdClass"></param>
    /// <param name="dstClass"></param>
    public void AddXmlIncludeAttribute(XSDClass xsdClass, string @namespace = "", bool writeToFile=false) {

      if (string.IsNullOrEmpty(xsdClass.Inheritance)) {
        return;
      }

      string codeStr = ReadFileToString(this.AbstractObject_Type_FP);
      string lineToInsert = $@"// [XMLInclude(typeof({xsdClass.Name}))]";
      
      if (codeStr.IndexOf(lineToInsert) > 0) {
        // already has the XmlIncludes attribute in AbstractObject_Type_FP
        return;
      }

      string newCode = "";
      List<string> codeLines = codeStr.Split("\n").ToList();
      
      for (int i = 0; i < codeLines.Count; i++) {
        string line = codeLines[i];
        int idx = line.IndexOf("// [XmlInclude(");
        if (idx > 0) {
          newCode += lineToInsert + '\n';
          break;
        }
        newCode += line + '\n';
      }
      
      if (writeToFile) {
        _logger.Information("Add {lineToInsert} to {AbstractObject_Type_fp}", lineToInsert, Path.GetFileName(this.AbstractObject_Type_FP));
        File.WriteAllText(this.AbstractObject_Type_FP, newCode);
      }
      
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="destinationDir"></param>
    /// <param name="xsdClass"></param>
    /// <param name="xmlNamespace"></param>
    /// <param name="namespace"></param>
    /// <param name="addXmlInclude"></param>
    public void ToCsFile(
      string destinationDir, 
      XSDClass xsdClass,
      string xmlPrefix = "", 
      string xmlNamespace = "gmi", 
      string @namespace = "NDSH.Geospatial.Metadata.V19136", 
      string author = "XsdToCodeByString",
      bool addXmlInclude = false) {
      DirectoryInfo d = Directory.CreateDirectory(destinationDir);
      
      string filename = xsdClass.Name + ".cs";
      string fp = Path.Combine(destinationDir, filename);
      
      string codeStr = xsdClass.ToCode(
        xmlPrefix: xmlPrefix,
        xmlNamespace: xmlNamespace,
        @namespace: @namespace,
        author: author);
      
      File.WriteAllText(path: fp, contents: codeStr);

      if (!xsdClass.IsTypeWrapper && !xsdClass.IsCodeListWrapper) {
        if (xsdClass.Inheritance != "AbstractObject_Type") {
          _logger.Error("{fp} inherit from [{Inheritance}] not AbstractObject_Type", fp, xsdClass.Inheritance);
        }
        else {
          AddXmlIncludeAttribute(
            xsdClass: xsdClass,
            @namespace: @namespace,
            writeToFile: addXmlInclude);
        }
      }

      return;  
    }

    /// <summary>
    /// Iterate throught <see cref="XsdClasses"/> and write each to *.cs under the given directory.
    /// </summary>
    /// <param name="destinationDir">The destination directory.</param>
    /// <param name="xmlNamespace">The xml namespace.</param>
    /// <param name="namespace">The namespace.</param>
    /// <param name="addXmlInclude">Indicates whether to add an <see cref="XmlIncludeAttribute"/> attribute or not.</param>
    public void ToCsFiles(string destinationDir, string xmlPrefix, string xmlNamespace, string @namespace, string author, bool addXmlInclude = false) {
      
      foreach (var xsdClass in XsdClasses) {
        ToCsFile(
          destinationDir: destinationDir, 
          xsdClass: xsdClass, 
          xmlPrefix: xmlPrefix,
          xmlNamespace: xmlNamespace, 
          @namespace: @namespace, 
          author: author,
          addXmlInclude: addXmlInclude);
      }
    }

    

    /// <summary>
    /// 
    /// </summary>
    public class XSDClassElement {

      /// <summary>
      /// 
      /// </summary>
      public string Name {
        get; set;
      } = "";

      /// <summary>
      /// 
      /// </summary>
      public string Type {
        get; set;
      } = "";

      /// <summary>
      /// 
      /// </summary>
      public string MinOccurs {
        get; set;
      } = "";

      /// <summary>
      /// 
      /// </summary>
      public string MaxOccurs {
        get; set;
      } = "";

      /// <summary>
      /// 
      /// </summary>
      public string Ref {
        get; set;
      } = "";

      /// <summary>
      /// 
      /// </summary>
      public bool IsList => MaxOccurs != "";

      /// <summary>
      /// 
      /// </summary>
      public bool IsNullable => MinOccurs == "0";
      
      /// <summary>
      /// 
      /// </summary>
      public string PropertyType {
        get {
          Debug.Assert(Type.IndexOf(':') > 0);
          string propTypeName = Type.Split(':')[1];
          if (IsList) {
            return $"List<{propTypeName}>";
          }
          return propTypeName;
        }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="order"></param>
      /// <returns></returns>
      public string ToProperty(int order = -1) {
        string orderString = order >= 0 ? $", Order = {order}" : "";
        string propName = char.ToUpper(Name[0]) + Name.Substring(1);
        string propString = "";
        string propTypeName = Type.Split(':')[1];
        if (IsList) {
          propString = Resources.PropertyListTemplate
            .Replace("@@Type@@", propTypeName)
            .Replace("@@Element@@", Name)
            .Replace("@@Property@@", propName)
            .Replace(", Order = @@Order@@", orderString) + "\r\n\r\n    ";
        }
        else {
          propString = Resources.PropertyObjectTemplate
            .Replace("@@Type@@", propTypeName)
            .Replace("@@Element@@", Name)
            .Replace("@@Property@@", propName)
            .Replace(", Order = @@Order@@", orderString) + "\r\n\r\n    ";
        }
        return propString;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public class XSDClass {
      public List<XSDClassElement> Elements {
        get; set;
      } = new List<XSDClassElement>();
      public string Name {
        get; set;
      } = "";
      public string Summary {
        get; set;
      } = "";
      public bool InOrder {
        get; set;
      } = false;

      public string Extension {
        get; set;
      } = "";
      public bool IsCodeListWrapper = false;
      public bool IsTypeWrapper = false;

      public string Inheritance {
        get {
          string[] s = Extension.Split(':');
          Debug.Assert(s.Length > 0);
          return s.Length > 1 ? s[1] : s[0];
        }

      }
      public string InheritanceToCode() {
        if (Extension == "")
          return "";
        return $": {Inheritance}";
      }

      

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      public string ElementsToPropertiesCode() {
        string propertiesString = "";
        for (int i = 0; i < Elements.Count; i++) {
          XSDClassElement e = Elements[i];

          if (InOrder) {
            propertiesString += e.ToProperty(order: i);
          }
          else {
            propertiesString += e.ToProperty(order: -1);
          }
        }
        return propertiesString;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="xmlNamespace"></param>
      /// <param name="namespace"></param>
      /// <returns></returns>
      public string TypeWrapperToCode(string xmlPrefix = "", string xmlNamespace = "gmi", string @namespace = "NDSH.Geospatial.Metadata.V19136", string author="XsdToCodeByString") {
        Debug.Assert(IsTypeWrapper);
        string[] _name = Name.Split("_");
        Debug.Assert(_name.Length == 3, $"{Name} is not a wrapper name. WrapperName Example: MI_Requirement_PropertyType");
        
        string elementName = Name.Replace("_PropertyType", "");
        string elementVariableName = _name[0].ToLower() + '_' + _name[1];
        string date = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        string creationString = $"{date}, {author}";
        
        string typeWrapperString = Resources.ClassTemplatePropertyType1
          .Replace("@@dd@@/01/2023, @@hh@@:@@mm@@, @@Coder@@.", creationString)
          .Replace("NDSH.Geospatial.Metadata.V19136.Imagery.@@Namespace@@", @namespace)
          .Replace("@@XmlNamespace@@", xmlNamespace)
          .Replace("@@Element@@", elementName)
          .Replace("@@ElementVariable@@", elementVariableName);
        
        return typeWrapperString;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="xmlNamespace"></param>
      /// <param name="namespace"></param>
      /// <returns></returns>
      public string CodeListWrapperToCode(string xmlPrefix = "", string xmlNamespace = "gmi", string @namespace = "NDSH.Geospatial.Metadata.V19136", string author = "XsdToCodeByString") {
        Debug.Assert(IsCodeListWrapper);
        string[] _name = Name.Split("_");
        Debug.Assert(_name.Length == 3, $"{Name} is not a wrapper name. WrapperName Example: MI_Requirement_PropertyType");
        
        string elementVariableName = _name[0].ToLower() + '_' + _name[1];
        string elementName = Name.Replace("_PropertyType", "");
        string date = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        string creationString = $"{date}, {author}";
        
        string codeListWrapperString = Resources.ClassTemplatePropertyType2
          .Replace("@@dd@@/01/2023, @@hh@@:@@mm@@, @@Coder@@.", creationString)
          .Replace("NDSH.Geospatial.Metadata.V19136.Imagery.@@Namespace@@", @namespace)
          .Replace("@@XmlNamespace@@", xmlNamespace)
          .Replace("@@Element@@", elementName)
          .Replace("@@ElementVariable@@", elementVariableName);
        
        return codeListWrapperString;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="xmlNamespace"></param>
      /// <param name="namespace"></param>
      /// <returns></returns>
      public string ClassToCode(string xmlPrefix = "", string xmlNamespace = "gmi", string @namespace = "NDSH.Geospatial.Metadata.V19136", string author = "XsdToCodeByString") {        
        
        string date = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        string creationString = $"{date}, {author}";
        string propertiesListString = "";
        string privateVarListString = "";


        for (int i = 0; i < Elements.Count; i++) {
          var e = Elements[i];
          if (InOrder) {
            propertiesListString += e.ToProperty(order: i) + '\n';
            
            if (privateVarListString.Length > 0) {
              privateVarListString += "      ";
            }
            privateVarListString += $"_{e.Name} = default; // new {e.PropertyType}();\n";
          }
          else {
            propertiesListString += e.ToProperty(order: -1) + '\n';
            
            if (privateVarListString.Length > 0) {
              privateVarListString += "      ";
            }
            privateVarListString += $"_{e.Name} = default; // new {e.PropertyType}();\n";
          }
        }

        // TODO: should we assume all class is inherit from AbstractObject_Type, see Resources.ClassTemplateType inheritance
        // Debug.Assert(Inheritance == "AbstractObject_Type");

        string codeString = Resources.ClassTemplateType
          .Replace("@@dd@@/01/2023, @@hh@@:@@mm@@, @@Coder@@.", creationString)
          .Replace("NDSH.Geospatial.Metadata.V19136.Imagery.@@Namespace@@", @namespace)
          .Replace("@@Element@@", Name.Replace("_Type", ""))
          .Replace("@@Prefix@@", xmlPrefix)
          .Replace("@@XmlNamespace@@", xmlNamespace)
          .Replace("@@PropertiesList@@", propertiesListString)
          .Replace("@@PrivateVariablesList@@", privateVarListString)
          ;

        return codeString;

      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="xmlNs"></param>
      /// <param name="namespace"></param>
      /// <returns></returns>
      public string ToCode(string xmlPrefix = "", string xmlNamespace = "gmi", string @namespace = "NDSH.Geospatial.Metadata.V19136", string author = "XsdToCodeByString") {

        if (IsTypeWrapper) {
          return TypeWrapperToCode(
            xmlPrefix:xmlPrefix, 
            xmlNamespace: xmlNamespace, 
            @namespace: @namespace, 
            author: author);
        }

        if (IsCodeListWrapper) {
          return CodeListWrapperToCode(
            xmlPrefix: xmlPrefix,
            xmlNamespace: xmlNamespace,
            @namespace: @namespace,
            author: author);
        }

        return ClassToCode(
            xmlPrefix: xmlPrefix,
            xmlNamespace: xmlNamespace,
            @namespace: @namespace,
            author: author);
      }

    }

  }

}
