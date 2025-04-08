using Xunit;
using NDSH.Geospatial.Metadata.V2003.Tests;

namespace NDSH.Geospatial.Metadata.V2003.Common.Extent.Test {
  public class ExtentTest {
    [Theory]
    [InlineData(typeof(AbstractEX_GeographicExtent_Type))]
    public void InitializationTypeTest(Type type) {
      var instance = Helper.GetDummyObject(type);
    }
  }
}