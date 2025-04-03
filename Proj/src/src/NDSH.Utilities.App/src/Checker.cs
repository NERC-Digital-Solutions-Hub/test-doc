using Microsoft.VisualBasic;
using NDSH.Geospatial.Metadata;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NDSH.Utilities.App {
  /// <summary>
  /// check the XmlInclude of NDSH.Geospatial.Metadata and NDSH.Geospatial.Metadata.V19136
  /// </summary>
  public class Checker {
    public List<Type> MdPublicTypes => GetMdPublicTypes();
    public List<Type> MdV19136PublicTypes => GetMdV19136PublicTypes();
    public string[] iso2005XsdSubDirs = { "gco", "gfc", "gmd", "gmi", "gml", "gmx", "gsr", "gss", "gts", "srv" };
    public string Iso2005Directory => GetIso2005Directory();
    private Logger typeLogger = null;
    private Logger xmlIncludeLogger = null;

    public Checker(string typelogFilePath = null, string xmlIncludeLogFilePath = null) {
      typeLogger = InitLogger(typelogFilePath);
      xmlIncludeLogger = InitLogger(xmlIncludeLogFilePath);
    }

    /// <summary>
    /// Iterate the <see cref="Checker.MdPublicTypes"/>: check if the PublicType Name in <see cref="Checker.MdV19136PublicTypes"/>
    /// If it is a 1 to 1 match =>  process to <see cref="CheckXmlIncludes(Type, Type)"/>
    /// If it is not found => typelog
    /// If it is found but more than 1 => typelog
    /// </summary>
    public void Check() {
      List<Type> commonNameTypes = new();
      foreach (Type md in MdPublicTypes) {
        List<Type> matchTypes = MdV19136PublicTypes.Where(v => v.Name == md.Name).ToList();
        int matchCount = matchTypes.Count;

        // check if md class exists in v19136
        if (matchCount == 0) {
          typeLogger.Error(
            "[{mdFullName}] not found in V19136", md.FullName);
          continue;
        }

        if (matchCount > 1) {
          string foundNamespaces = string.Join(", ", matchTypes.Select(t => t.Namespace));
          typeLogger.Error(
            "[{mdFullName}] found more than once in V19136, see namespace: [{foundNamespaces}]",
            md.FullName, foundNamespaces);
          continue;
        }


        if (matchTypes.Count == 1) {
          Type mdv = matchTypes.First();
          CheckXmlIncludes(md, mdv);
          continue;
        }
      }
    }
    public Logger InitLogger(string fp) {
      if (string.IsNullOrEmpty(fp)) {
        return new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();
      }
      else {
        string outputTemplate = "[{Level:u3}] {Message:lj}{NewLine}{Exception}";
        return new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File(fp, outputTemplate: outputTemplate)
                .CreateLogger();
      }
    }
    public List<Type> GetMdPublicTypes() {
      Assembly assembly = Assembly.GetAssembly(typeof(NDSH.Geospatial.Metadata.AbstractCRSType)); // whatever
      if (assembly is null)
        throw new NullReferenceException("NDSH.Geospatial.Metadata.Test assembly failed.");
      List<Type> types = assembly.GetTypes().Where(t => t.IsPublic).ToList();
      return types;
    }
    public List<Type> GetMdV19136PublicTypes() {
      Assembly assembly = Assembly.GetAssembly(typeof(NDSH.Geospatial.Metadata.V2003.Common.AbstractObject_Type)); //whatever
      if (assembly is null)
        throw new NullReferenceException("NDSH.Geospatial.Metadata.Test assembly failed.");
      List<Type> types = assembly.GetTypes().Where(t => t.IsPublic).ToList();
      return types;
    }

    /// <summary>
    /// get all XmlInclude argument in the 
    /// </summary>
    /// <param name="t"></param>
    /// <returns>
    /// Returns a <see cref="List{string}"/> with the names of <see cref="XmlIncludeAttribute.Type"/>
    /// </returns>
    public List<string> GetXmlIncludes(Type t) {
      List<string> r = t.GetCustomAttributes(inherit: false)
              .Where(a => a.GetType() == typeof(XmlIncludeAttribute))
              .Select(attr => (attr as XmlIncludeAttribute).Type.Name)
              .ToList();
      return r;
    }

    /// <summary>
    /// Iterate throught metadata.xmlInclude: check if any not in the v19136 class xmlInclude.
    /// </summary>
    /// <param name="md"></param>
    /// <param name="mdv"></param>
    private void CheckXmlIncludes(Type md, Type mdv) {
      Debug.Assert(md.Name == mdv.Name, $"Cannot compare their XmlIncludeAttribute: [{md.Name}] and [{mdv.Name}] are different classes.");
      List<string> mdXmlIncludes = GetXmlIncludes(md);
      if (mdXmlIncludes.Count == 0) {
        return;
      }


      List<string> mdvXmlIncludes = GetXmlIncludes(mdv);
      foreach (string mdx in mdXmlIncludes) {
        if (mdvXmlIncludes.IndexOf(mdx) == -1) {
          xmlIncludeLogger.Error(
            "XmlInclude[typeof({mdx})] not found in {mdvFullName}",
            mdx, mdv.FullName);
        }
      }

    }



    /// <summary>
    /// Go through all XSD files that were used to implement the classes of V19136 and check for substitutionGroups
    /// - check which class is defined as a substitutionGroup
    /// - check its inheritance path
    /// - find out if the correct [XmlInclude] related to the subsitutionGroup has been added all the way up to the inheritance path
    /// - otherwise log it
    /// </summary>
    public void CheckSubstitutionGroup() {
      throw new NotImplementedException();
    }

    public string GetIso2005Directory() {
      string cd = Directory.GetCurrentDirectory();
      string iso2005Dir = Path.Combine(cd.Substring(0, cd.IndexOf("DotNet") + "DotNet".Length), @"Proj\src\NDSH.Geospatial.Metadata\src\Schemas\ISO\2005");
      return iso2005Dir;
    }

    public List<string> GetIso2005XsdFilePaths() {
      List<string> xsdFilePaths= new();
      
      foreach (var xsdSubDir in iso2005XsdSubDirs) {
        string xsdDir = Path.Combine(Iso2005Directory, xsdSubDir);
        Debug.Assert(Directory.Exists(xsdDir));
        Directory.EnumerateFiles(xsdDir)
          .Where(fp => fp.EndsWith(".xsd"))
          .ToList()
          .ForEach(xsdFilePaths.Add);
      }
      
      return xsdFilePaths;
    }

    public List<Type> GetInheritances(Type t) {
      Debug.Assert(t is not null);
      List<Type> inheritances = new();
      while (true) {
        t = t.BaseType;
        if (t is null) {
          return inheritances;
        }
        inheritances.Add(t);
      }
    }

    public List<XElement> GetElementsWithAttribute(string xsdFilePath, string attribute) {
      var x = XElement.Load(xsdFilePath);
      var elements = x.Descendants();
      List<XElement> ret = new();
      foreach (var e in elements) {
        var attrNames = e.Attributes().Select(a => a.Name.LocalName);
        if (attrNames.Contains(attribute)) {
          ret.Add(e);
        }
      }
      return ret;

    }
  }
}
