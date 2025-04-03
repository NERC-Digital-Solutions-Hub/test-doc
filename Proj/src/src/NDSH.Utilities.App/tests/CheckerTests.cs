//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace NDSH.Utilities.App.Tests.CheckerTests {
//  [TestClass]
//  public class CheckerTestsTests {
//    [TestMethod]
//    public void CheckerTestsTest() {
//      var xc = new Checker();
//      var mdPublicTypes = xc.MdPublicTypes;
//      var mdV19136PublicTypes = xc.MdV19136PublicTypes;

//      Assert.IsTrue(xc.MdPublicTypes.Count > 0);
//      Assert.IsTrue(xc.MdV19136PublicTypes.Count > 0);

//      xc.Check();

//    }

//    [TestMethod]
//    [DataRow("C:\\Users\\ChrisLam\\Documents\\nerc-digital-solutions-hub\\Hub\\DotNet\\Proj\\src\\NDSH.Geospatial.Metadata\\src\\Schemas\\ISO\\19139_2007_04_17_5_v_2022_05_26\\gmd\\content.xsd", "substitutionGroup", 6)]
//    [DataRow("C:\\Users\\ChrisLam\\Documents\\nerc-digital-solutions-hub\\Hub\\DotNet\\Proj\\src\\NDSH.Geospatial.Metadata\\src\\Schemas\\ISO\\19139_2007_04_17_5_v_2022_05_26\\gmd\\dataQuality.xsd", "substitutionGroup", 23)]
//    public void GetXmlElementsWithAttributeTest(string fp, string attributeName, int expectedCount) {
//      var x = new Checker();
//      var l = x.GetElementsWithAttribute(fp, attributeName);
//      Assert.IsNotNull(l);
//      Assert.IsTrue(l.Count == expectedCount);
//    }


//  }


//}