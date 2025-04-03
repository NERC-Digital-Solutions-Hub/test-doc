
namespace NDSH.Geospatial.Metadata.Serializers.Tests.GeoNetworkGmd2005 {

  /// <summary>
  /// The unit test for objects in CitationInformation.
  /// </summary>
  public class CitationInformationUnitTest {

    /// <summary>
    /// Tests the serialization of <see cref="CI_Telephone"/>.
    /// </summary>
    [Fact]
    public void CI_Telephone_Type_SerializationTest() {

      string fact = CitationInformationResources.CI_Telephone_Type_Compact;

      CI_Telephone telephone = new() {
        Id = "id-1",
        Uuid = "uuid-1",
        Facsimile = new List<string>(1),
        Voice = new List<string>(1)
      };
      telephone.Facsimile.Add("0115 936 3276");
      telephone.Voice.Add("0115 936 3143");

      Entity entity = new() {
        Item = telephone
      };

      string test = XElement.Parse(Serializer.SerializeXml(entity, false, ""))
                            .Elements()
                            .First()
                            .ToString(SaveOptions.DisableFormatting);

      Assert.Equal(fact, test);

    }

    /// <summary>
    /// Tests the serialization of <see cref="CI_Telephone"/> (2).
    /// </summary>
    [Fact]
    public void CI_Telephone_Type2_SerializationTest() {

      string fact = CitationInformationResources.CI_Telephone_Type2_Compact;

      CI_Telephone telephone = new() {
        Id = "id-2",
        Uuid = "uuid-2",
        Voice = new List<string>(1)
      };
      telephone.Voice.Add("+44 115 936 3100");

      Entity entity = new() {
        Item = telephone
      };

      string test = XElement.Parse(Serializer.SerializeXml(entity, false, ""))
                            .Elements()
                            .First()
                            .ToString(SaveOptions.DisableFormatting);

      Assert.Equal(fact, test);

    }

  }

}