using NDSH.Geospatial.Metadata;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Utilities.App {

  /// <summary>
  /// Check the XmlInclude of NDSH.Geospatial.Metadata and NDSH.Geospatial.Metadata.V19136
  /// </summary>
  public class XmlIncludeChecker {

    public List<Type> MdPublicTypes => GetMdPublicTypes();

    public List<Type> MdV19136PublicTypes => GetMdV19136PublicTypes();

    private Logger typeLogger = null;
    private Logger xmlIncludeLogger = null;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="typelogFilePath"></param>
    /// <param name="xmlIncludeLogFilePath"></param>
    public XmlIncludeChecker(string typelogFilePath = null, string xmlIncludeLogFilePath = null) {
      typeLogger = InitLogger(typelogFilePath);
      xmlIncludeLogger = InitLogger(xmlIncludeLogFilePath);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="fp"></param>
    /// <returns></returns>
    public Logger InitLogger(string fp) {
      if (string.IsNullOrEmpty(fp)) {
        return new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console().CreateLogger();
      }
      else {
        return new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console().WriteTo.File(fp).CreateLogger();
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NullReferenceException"></exception>
    public List<Type> GetMdPublicTypes() {
      Assembly assembly = Assembly.GetAssembly(typeof(NDSH.Geospatial.Metadata.AbstractCRSType)); // whatever
      if (assembly == null) {
        throw new NullReferenceException("NDSH.Geospatial.Metadata.Test assembly failed.");
      }
      List<Type> types = assembly.GetTypes().Where(t => t.IsPublic).ToList();
      return types;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NullReferenceException"></exception>
    public List<Type> GetMdV19136PublicTypes() {
      Assembly assembly = Assembly.GetAssembly(typeof(NDSH.Geospatial.Metadata.V2003.Common.AbstractObject_Type)); //whatever
      if (assembly == null) {
        throw new NullReferenceException("NDSH.Geospatial.Metadata.Test assembly failed.");
      }
      List<Type> types = assembly.GetTypes().Where(t => t.IsPublic).ToList();
      return types;
    }

    /// <summary>
    /// Iterate the <see cref="XmlIncludeChecker.MdPublicTypes"/>:
    /// check if the PublicType Name in <see cref="XmlIncludeChecker.MdV19136PublicTypes"/>
    /// If it is a 1 to 1 match => process to <see cref="CheckXmlIncludes(Type, Type)"/>
    /// If it is not found => log
    /// If it is found but more than 1 => log
    /// </summary>
    public void Check() {
      List<Type> commonNameTypes = new();
      foreach (Type md in MdPublicTypes) {
        List<Type> matchTypes = MdV19136PublicTypes.Where(v => v.Name == md.Name).ToList();
        int matchCount = matchTypes.Count;

        if (matchCount == 0) {
          typeLogger.Error("[{Namespace}::{TypeName}] not found in V19136", md.Namespace, md.Name);
        }

        if (matchCount > 1) {
          string foundNamespaces = string.Join(", ", matchTypes);
          typeLogger.Error(
            "[{Namespace}::{TypeName}] found more than once in V19136, see namespace: [{foundNamespaces}]",
            md.Namespace, md.Name, foundNamespaces);
        }

        if (matchTypes.Count == 1) {
          Type mdv = matchTypes.First();
          CheckXmlIncludes(md, mdv);
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="type"></param>
    /// <returns>
    /// Returns a <see cref="List{string}"/> with the names of <see cref="XmlIncludeAttribute.Type"/>
    /// </returns>
    public List<string> GetXmlIncludes(Type type) {
      List<string> r = new();
      List<object> ls = type.GetCustomAttributes(false).Where(a => a.GetType() == typeof(XmlIncludeAttribute)).ToList();

      foreach (object obj in ls) {
        XmlIncludeAttribute attr = obj as XmlIncludeAttribute;
        Debug.Assert(attr != null && attr.Type != null);
        string tn = attr.Type.Name;
        r.Add(tn);
      }
      return r;
    }


    /// <summary>
    /// Iterate through metadata.xmlInclude: check if there is any not in the v19136.
    /// </summary>
    /// <param name="md"></param>
    /// <param name="mdv"></param>
    private void CheckXmlIncludes(Type md, Type mdv) {

      List<string> mdXmlIncludes = GetXmlIncludes(md);
      List<string> mdvXmlIncludes = GetXmlIncludes(mdv);

      foreach (string mdx in mdXmlIncludes) {
        if (mdvXmlIncludes.IndexOf(mdx) == -1) {
          xmlIncludeLogger.Error("XmlIncludeAttribute [{mdx}] not found in V19136 [{mdvNs}::{mdvName}]",
            mdx, mdv.Namespace, mdv.Name);
        }
      }

    }

  }

}
