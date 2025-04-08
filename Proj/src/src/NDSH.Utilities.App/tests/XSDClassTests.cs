//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using static NDSH.Utilities.App.XsdToCodeByString;

//namespace NDSH.Utilities.App.Tests.XSDClassTests {
//  [TestClass]
//  public class XSDClassTests {
//    [TestMethod]
//    public void HeaderToCodeTest() {
//      Assert.Fail();
//    }

//    [TestMethod]
//    public void NameSpaceToCodeTest() {
//      Assert.Fail();
//    }


//    [TestMethod]
//    [DataRow("gco:AbstractObject_Type", ": AbstractObject_Type")]
//    [DataRow("AbstractObject_Type", ": AbstractObject_Type")]
//    public void InheritanceToCodeTest(string input, string expectedOutput) {
      
//      var xsdClass = new XSDClass();
//      xsdClass.Extension = input;
//      Assert.AreEqual(xsdClass.InheritanceToCode(), expectedOutput);

//    }

//    [TestMethod]
//    public void SummaryToCodeTest() {
//      Assert.Fail();
//    }

//    [TestMethod]
//    public void CtorToCodeTest() {
//      Assert.Fail();
//    }

//    [TestMethod]
//    public void TypeWrapperToCodeTest() {
//      Assert.Fail();
//    }

//    [TestMethod]
//    public void CodeListWrapperToCodeTest() {
//      Assert.Fail();
//    }

//    [TestMethod]
//    public void ElementsToPropertiesCodeTest() {
//      Assert.Fail();
//    }

//    [TestMethod]
//    public void ClassToCodeTest() {
//      Assert.Fail();
//    }

//    [TestMethod]
//    public void ToCodeTest() {
//      Assert.Fail();
//    }
//  }
//}