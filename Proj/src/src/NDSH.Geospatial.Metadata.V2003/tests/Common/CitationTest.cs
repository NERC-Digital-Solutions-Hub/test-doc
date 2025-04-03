using Xunit;
using NDSH.Geospatial.Metadata.V2003.Tests;

namespace NDSH.Geospatial.Metadata.V2003.Common.Citation.Tests {


  /// <summary>
  /// 
  /// </summary>
  public class CitationTest {

    [Theory]
    [InlineData(typeof(CI_Address_Type))]
    [InlineData(typeof(CI_Citation_Type))]
    [InlineData(typeof(CI_Contact_Type))]
    [InlineData(typeof(CI_Date_Type))]
    [InlineData(typeof(CI_OnlineResource_Type))]
    [InlineData(typeof(CI_ResponsibleParty_Type))]
    [InlineData(typeof(CI_Series_Type))]
    [InlineData(typeof(CI_Telephone_Type))]

    public void InitializationTypeTest(Type type) {
      var instance = Helper.GetDummyObject(type);
    }

    

  }
}