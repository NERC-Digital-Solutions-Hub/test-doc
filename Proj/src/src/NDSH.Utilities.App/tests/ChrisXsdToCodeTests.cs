using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace NDSH.Utilities.App.Tests.ChrisXsdToCodeTests {
  [TestClass]
  public class ChrisXsdToCodeTests {


    [TestMethod]
    public void ReadFileToStringTest() {
      string[] xsdFilenames = {
        "acquisitionInformation.xsd",
        "contentInformation.xsd",
        "dataQualityInformation.xsd",
        "gmi.xsd",
        "metadataEntitySet.xsd",
        "spatialRepresentationInformation.xsd"
      };

      foreach (string xsdFilename in xsdFilenames) {
        try {
          XsdToCodeByString.ReadFileToString($"..\\..\\..\\..\\..\\NDSH.Geospatial.Metadata\\src\\Schemas\\ISO\\2005\\gmi\\{xsdFilename}");
        }
        catch (Exception ex) {
          Assert.Fail("Expected no exception, but got: " + ex.Message);
        }
      }

    }

    [TestMethod]
    public void ChrisXsdToCodeTest() {
      // Arrange and Act
      var xc0 = new XsdToCodeByString();
      // Assert
      Assert.IsNotNull(xc0);
      Assert.AreEqual(xc0.XsdString, "");
      Assert.AreEqual(xc0.Author, "generated@ChrisXsdToCode");

      // Arrange and Act
      var xc1 = new XsdToCodeByString();
      // Assert
      Assert.IsNotNull(xc1);
      Assert.AreEqual(xc1.XsdString, "someXsdString");
      Assert.AreEqual(xc1.Author, "me");
    }

    [TestMethod]
    [DataRow("complexTag", "<xs:complexTag")]
    [DataRow("documentation", "<xs:documentation")]
    [DataRow("attribute", "<xs:attribute")]
    [DataRow("attributeGroup", "<xs:attributeGroup")]
    [DataRow("extension", "<xs:extension")]
    [DataRow("sequence", "<xs:sequence")]
    [DataRow("element", "<xs:element")]
    public void BeginTagTest(string input, string expectedOutput) {
      // Arrange 
      var xc = new XsdToCodeByString();

      // Action
      string beginTag = xc.BeginTag(input);

      // Assert
      Assert.AreEqual(beginTag, expectedOutput);

    }

    [TestMethod]
    [DataRow("complexTag", "</xs:complexTag>")]
    [DataRow("documentation", "</xs:documentation>")]
    [DataRow("attribute", "</xs:attribute>")]
    [DataRow("attributeGroup", "</xs:attributeGroup>")]
    [DataRow("extension", "</xs:extension>")]
    [DataRow("sequence", "</xs:sequence>")]
    [DataRow("element", "/>")]
    public void EndTagTest(string input, string expectedOutput) {
      // Arrange 
      var xc = new XsdToCodeByString();

      // Action
      string beginTag = xc.EndTag(input);

      // Assert
      Assert.AreEqual(beginTag, expectedOutput);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void FindTagIdxTest_ArgumentException() {
      var xc = new XsdToCodeByString();
      xc.FindTagIdx("", "");
      xc.FindTagIdx("complexTag", "");
      xc.FindTagIdx("<complexTag", "");
      xc.FindTagIdx("<complexTag>", "");
      xc.FindTagIdx("<xs:complexTag>", "");
    }

    [TestMethod]
    [DataRow("<xs:complexTag", "<xs:complexTag", 0, -1, false, 0)]
    [DataRow("<xs:complexTag", "<xs:complexTag", 0, 13, false, 0)]
    [DataRow("<xs:complexTag", "012<xs:complexTag", 0, -1, false, 3)]
    [DataRow("</xs:complexTag", "012</xs:complexTag", 0, -1, false, 3)]
    [DataRow("<xs:complexTag", "", 0, -1, false, -1)]
    [DataRow("</xs:complexTag", "", 0, -1, false, -1)]
    [DataRow("<xs:complexTag", "<xs:complexTag", 0, -1, true, 13)]
    [DataRow("<xs:complexTag", "012<xs:complexTag", 0, -1, true, 16)]
    [DataRow("<xs:complexTag", "012<xs:complexTag", 3, -1, false, 3)]
    [DataRow("<xs:complexTag", "012<xs:complexTag", 4, -1, false, -1)]
    [DataRow("<xs:complexTag", "012<xs:complexTag<xs:complexTag", 4, -1, false, 17)]
    [DataRow("<xs:complexTag", "012<xs:complexTag<xs:complexTag", 1, 0, false, -1)]
    public void FindTagIdxTest(string tag, string xsdString, int startIdx, int endIdx, bool lastIdx, int expectedOuput) {
      var xc = new XsdToCodeByString();
      int resultIdx = xc.FindTagIdx(
        tag: tag, xsdString: xsdString,
        startIdx: startIdx, endIdx: endIdx, lastIdx: lastIdx);
      Assert.AreEqual(resultIdx, expectedOuput);
    }


    [DataRow("complexType", "name", "<xs:complexType name=\"MI_Requirement_Type\"></xs:complexType>", 0, -1, "MI_Requirement_Type")]
    [DataRow("complexType", "name", "<xs:complexType name=\"MI_Requirement_Type\"></xs:complexType>", 0, 59, "MI_Requirement_Type")] // xsdString.Length == 60
    [DataRow("complexType", "name", "<xs:complexType name=\"MI_Requirement_Type\"></xs:complexType>", 1, -1, "")] // xsdString.Length == 60
    [DataRow("complexType", "name", "<xs:complexType name=\"MI_Requirement_Type\"></xs:complexType><xs:complexType name=\"ItShouldNotBeReturned\"></xs:complexType>", 0, 59, "MI_Requirement_Type")] // xsdString.Length == 60
    [DataRow("complexType", "name", "<xs:complexType name=\"MI_Requirement_Type\"></xs:complexType><xs:complexType name=\"ItShouldBeReturned\"></xs:complexType>", 59, -1, "ItShouldBeReturned")] // xsdString.Length == 119
    [DataRow("complexType", "name", "<xs:complexType name=\"MI_Requirement_Type\"></xs:complexType><xs:complexType name=\"ItShouldBeReturned\"></xs:complexType>", 59, 118, "ItShouldBeReturned")] // xsdString.Length == 119
    [DataRow("complexType", "name", "<xs:complexType name=\"MI_Requirement_Type\"></xs:complexType><xs:complexType name=\"ItShouldBeReturned\"></xs:complexType>", 1, -1, "ItShouldBeReturned")] // xsdString.Length == 119
    [DataRow("complexType", "name", "<xs:complexType name=\"MI_Requirement_Type\">", 0, -1, "", DisplayName = "Missing EndTag returns empty string")]
    [DataRow("element", "name", "<xs:element name=\"geolocationInformation\" type=\"gmi:MI_GeolocationInformation_PropertyType\" maxOccurs=\"unbounded\"/>", 0, -1, "geolocationInformation")]
    [DataRow("element", "minOccurs", "<xs:element name=\"geolocationInformation\" type=\"gmi:MI_GeolocationInformation_PropertyType\" maxOccurs=\"unbounded\"/>", 0, -1, "", DisplayName = "Unavailable attribute returns empty string")]
    [TestMethod]
    public void GetTagAttributeTest(string tagName, string attrName, string xsdString, int startIdx, int endIdx, string expectedOutput) {
      var xc = new XsdToCodeByString();
      string actualResult = xc.GetTagAttribute(
        tagName: tagName,
        attrName: attrName,
        xsdString: xsdString,
        startIdx: startIdx,
        endIdx: endIdx);
      Assert.AreEqual(actualResult, expectedOutput);
    }

    [DataRow("element", "<xs:element name=\"platformParameters\"/>", 0, -1, "")]
    [DataRow("documentation", "<xs:documentation>TagValue</xs:documentation>", 0, -1, "TagValue")]
    [DataRow("documentation", "<xs:documentation></xs:documentation>", 0, -1, "")]
    [DataRow("documentation", "<xs:documentation>TagValue</xs:documentation>", 1, -1, "")]
    [DataRow("documentation", "<xs:documentation>TagValue</xs:documentation>", 0, 44, "TagValue")]
    [DataRow("documentation", "<xs:documentation>TagValue</xs:documentation>", 1, 44, "")]

    [TestMethod]
    public void GetTagValueTest(string tagName, string xsdString, int startIdx, int endIdx, string expectedOutput) {
      var xc = new XsdToCodeByString();
      string actualResult = xc.GetTagValue(tagName: tagName,
        xsdString: xsdString, startIdx: startIdx, endIdx: endIdx);
      Assert.AreEqual(actualResult, expectedOutput);
    }

    // for loading test data see https://stackoverflow.com/questions/51345370/unit-testing-sending-complex-object-as-a-input-parameter-to-my-test-method-usin
    // it is an integrated test, finish the unit tests in XSDClassTests and XSDClassElementTests before this.
    [TestMethod]
    public void ParseXsdStringTest(string xsdString, int startIdx, bool recursive, List<XsdToCodeByString.XSDClass> expectedClasses) {
      var xc = new XsdToCodeByString();
      xc.ParseXsdString(xsdString: xsdString, startIdx: startIdx, recursive: recursive);
      Assert.AreEqual(expectedClasses.Count, xc.XsdClasses.Count);
      Assert.AreEqual(expectedClasses, xc.XsdClasses); // not sure if it works?
    }

    [TestMethod]
    public void AddXmlIncludeAttributeTest() {
      Assert.Fail();
    }

    [TestMethod]
    public void ToCsFileTest() {
      Assert.Fail();
    }

    [TestMethod]
    public void ToCsFilesTest() {
      Assert.Fail();
    }

    [TestMethod]
    public void RunTest() {
      Assert.Fail();
    }
  }
}