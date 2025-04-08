using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NDSH.Utilities.App {
  public class CharacherStringChecker {
    // find all the CharacterString variable name
    // go to the xml check if the variable is an xml object
    public static string CapFirstChar(string s) {
      if (s is null || s.Length < 1)
        return s;
      return char.ToUpper(s[0]) + s.Substring(1);
    }

    public static string LowFirstChar(string s) {
      if (s is null || s.Length < 1)
        return s;
      return char.ToLower(s[0]) + s.Substring(1);
    }

    static public List<Type> MdV2003ThinPublicTypes => GetMdV2003ThinPublicTypes();
    static public List<PropertyInfo> CharacterStringProperties => GetCharacterStringProperties();
    static public List<string> CharacterStringPropertyNames => GetCharacterStringPropertyXmlNames();

    public static List<string> GetCharacterStringPropertyXmlNames() {
      return GetCharacterStringProperties().Select(p => GetPropertyXmlElementName(p)).Distinct().ToList();
    }

    public static string GetPropertyXmlElementName(PropertyInfo pi) { 
      return pi.GetCustomAttribute<XmlElementAttribute>()!.ElementName;
    }

    public static string? GetPublicClassXmlRootName(Type type) {
      return type.GetCustomAttribute<XmlRootAttribute>()?.ElementName;
    }
    
    public static string? GetPublicClassXmlTypeName(Type type) {
      return type.GetCustomAttribute<XmlTypeAttribute>()?.TypeName;
    }

    static public List<Type> GetMdV2003ThinPublicTypes() {
      Assembly assembly = Assembly.GetAssembly(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.AbstractObject_Type)); //whatever
      if (assembly is null)
        throw new NullReferenceException("NDSH.Geospatial.Metadata.V2003.Thin assembly failed.");
      List<Type> types = assembly.GetTypes().Where(t => t.IsPublic).ToList();
      return types;
    }

    static public List<PropertyInfo> GetCharacterStringProperties() {
      return MdV2003ThinPublicTypes.Select(t => t.GetProperties().Where(p => p.PropertyType == typeof(CharacterString))).SelectMany(t => t).ToList();
    }

    static public Dictionary<Type, List<PropertyInfo>> PublicClassWithCharaterStringProperties() {
      Dictionary<Type, List<PropertyInfo>> ClassWithCharaterString = new();
      foreach (Type type in MdV2003ThinPublicTypes) {
        List<PropertyInfo> ps = type.GetProperties().Where(p => p.PropertyType == typeof(CharacterString)).
          ToList();
        if (ps.Count() > 0) {
          Debug.Assert(type.FullName is not null);
          ClassWithCharaterString.Add(type, ps);
        }
      }
      return ClassWithCharaterString;
    }

    

    static public Dictionary<string, List<string>> XmlCharacterStringSubsubition(string xmlFilePath, Dictionary<string, List<string>> dict) {
      
      Dictionary<string, List<string>> polyCsProps = new ();

      var xml = XElement.Load(xmlFilePath);
      var pairs = PublicClassWithCharaterStringProperties();
      
      var keys_xml_root = pairs.Keys.Select(k=>GetPublicClassXmlRootName(k)).Where(k => !string.IsNullOrEmpty(k)).ToList();  //n = 86
      var class_xml_root_null = pairs.Keys.Where(k => string.IsNullOrEmpty(GetPublicClassXmlRootName(k))).Select(k => k.FullName).ToList(); //n = 20
      
      var keys_xml_type = pairs.Keys.Select(k=>GetPublicClassXmlTypeName(k)).Where(k => !string.IsNullOrEmpty(k)).ToList();  //n = 87
      var class_xml_type_null = pairs.Keys.Where(k => string.IsNullOrEmpty(GetPublicClassXmlTypeName(k))).Select(k => k.FullName).ToList(); //n = 19
      
      foreach (KeyValuePair<Type, List<PropertyInfo>> pair in pairs) {
        string? xRootName =  GetPublicClassXmlRootName(pair.Key)?? GetPublicClassXmlTypeName(pair.Key);
        if (string.IsNullOrEmpty(xRootName)) {
          continue;
        }

        XElement? xRoot = xml.Descendants().Where(xe => xe.Name.LocalName == xRootName).FirstOrDefault();
        if (xRoot == null) {
          //Debug.Print($"xRoot not found, xRootName: [{xRootName}]");
          continue;
        }
        var xProps = xRoot.Elements();

        foreach (PropertyInfo csProp in pair.Value) {
          string xCsPropName = GetPropertyXmlElementName(csProp);
          IEnumerable<XElement> xCsProps = xProps.Where(xp=>xp.Name.LocalName == xCsPropName);
          if (!xCsProps.Any()) {
            //Debug.Print($"Expected xCsProp not found: [{xRootName}.{xCsPropName}] ");
            continue;
          }

          foreach (XElement? xCsProp in xCsProps) {
            if (xCsProp is null) {
              Debug.Fail("xCsProp is null");
            }
            
            IEnumerable<XElement> children = xCsProp.Elements();
            if (children.Count() > 1) {
              Debug.Fail($"more than one child is found in xCsProp: [{xRootName}.{xCsPropName}]");
            }
            
            if (children.Count() == 1) {
              XElement xe = children.First();
              if (xe.Name.LocalName != "CharacterString") {
                // found polymorphism: <sth><!cs>V</!cs></sth>
                string k = $"{xRootName}.{xCsPropName}";
                string v = xe.Name.LocalName;
                Debug.Print($"[FOUND POLY] {k}, {v}");
                
                var ls = polyCsProps.GetValueOrDefault(k);
                
                if (ls is null) {
                  polyCsProps.Add(k, new List<string> { v });
                  continue;
                }
                
                if (!ls.Contains(xe.Name.LocalName)) {
                    ls.Add(xe.Name.LocalName);
                }
                
              }
              continue;
            }
            if (children.Count() == 0) {
              if (xCsProp.Attributes().Select(attr => attr.Name.LocalName).Contains("nilReason")) {
                // good
                continue;
              }
              else {
                // shit <sth>V</sth>
                Debug.Fail($"xRoot: {xRootName}.{xCsPropName} has no children");
              }
            }
          }
        }
      }
      return polyCsProps;

    }






  }
}