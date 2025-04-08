using Microsoft.VisualStudio.TestTools.UnitTesting;
using NDSH.Utilities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDSH.Utilities.App.Tests {
  [TestClass]
  public class CharacherStringCheckerTests {
    [TestMethod]
    public void GetMdV2003PublicTypesTest() {

      List<Type> ts = CharacherStringChecker.GetMdV2003ThinPublicTypes();
      Assert.IsNotNull(ts);
      Assert.IsTrue(ts.Count > 0);
    }

    [TestMethod]
    public void GetCharacterStringPropertiesTest() {
      List<System.Reflection.PropertyInfo> props = CharacherStringChecker.GetCharacterStringProperties();
      Assert.IsNotNull(props);
      Assert.IsTrue(props.Count > 0);
      Assert.IsTrue(props.Where(p => p.Name == "FileIdentifier").Count() > 0);
    }

    [TestMethod]
    public void ClassWithCharaterStringProptiesTest() {
      var dict = CharacherStringChecker.PublicClassWithCharaterStringProperties();
      Assert.IsNotNull(dict);
      Assert.IsTrue(dict.Count > 0);
      Assert.IsTrue(dict.Select(pair => pair.Value.Where(pi => pi.Name == "FileIdentifier")).Count() > 0);

    }

    [TestMethod]
    public void CapFirstCharTest() {
      //arrange 
      string s = "fileIdentifier";
      // action & assert
      Assert.IsTrue(CharacherStringChecker.CapFirstChar(s) == "FileIdentifier");
    }

    [TestMethod]
    public void LowFirstCharTest() {
      //arrange 
      string s = "FileIdentifier";
      // action & assert
      Assert.IsTrue(CharacherStringChecker.LowFirstChar(s) == "fileIdentifier");
    }

    [TestMethod()]
    public void XmlCharacterStringSubsubitionTest() {
      Dictionary<string, List<string>> dict = new();
      var xmlFilkePaths = Directory.GetFiles(@"C:\Users\ChrisLam\Downloads\NERC-2023-02-18\2023-02-18\2.0.2\GMD", "*.xml");
      foreach (var xmlFilePath in xmlFilkePaths) {
        var sub_dict = CharacherStringChecker.XmlCharacterStringSubsubition(xmlFilePath, dict);
        
        foreach( var pair in sub_dict) {
          var ls = dict.GetValueOrDefault(pair.Key);
          if (ls is null) {
            dict.Add(pair.Key, pair.Value);
          }
          else {
            dict[pair.Key].AddRange(pair.Value);
            dict[pair.Key].Distinct();
          }
        }
      }

      Console.WriteLine(dict.ToString());
    }

    [TestMethod()]
    public void GetPublicClassXmlRootNameTest() {
      //arrange
      List<Type> ts = CharacherStringChecker.GetMdV2003ThinPublicTypes();
      List<string> xmlRootNames = ts.Select(t => CharacherStringChecker.GetPublicClassXmlRootName(t)).ToList();
      Assert.IsNotNull(xmlRootNames);
      Assert.IsTrue(xmlRootNames.Count > 0);
      Assert.IsTrue(xmlRootNames.Contains("MD_Metadata"));
      Assert.IsTrue(xmlRootNames.Contains("CI_Citation"));
    }
  }
}