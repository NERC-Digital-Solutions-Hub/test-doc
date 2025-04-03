using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Identification;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Identification {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_DataIdentification_Type" />.
  /// </summary>
  public sealed class MdDataIdentificationConfiguration : IEntityTypeConfiguration<MD_DataIdentification_Type> {
    private const string TableName = "MD_DataIdentification";
    private const string SpatialRepresentationTypeTableName = "MD_DataIdentification_SpatialRepresentationType";
    private const string SpatialResolutionTableName = "MD_DataIdentification_SpatialResolution";
    private const string LanguageTableName = "MD_DataIdentification_Language";
    private const string CharacterSetTableName = "MD_DataIdentification_CharacterSet";
    private const string ExtentTableName = "MD_DataIdentification_Extent";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_DataIdentification_Type> builder) {
      builder.ToTable(TableName);

      builder.Property(entity => entity.EnvironmentDescription)
        .HasConversion(
          description => description.Value,
          value => new CharacterString(value))
        .IsRequired(false);


      builder.HasOne(entity => entity.SupplementalInformation)
        .WithMany()
        .HasForeignKey("SupplementalInformation_CharacterStringDbId")
        .IsRequired(false);

      builder.HasMany(entity => entity.SpatialRepresentationType)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(SpatialRepresentationTypeTableName));

      builder.HasMany(entity => entity.SpatialResolution)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(SpatialResolutionTableName));

      builder.HasMany(entity => entity.TopicCategory)
        .WithMany()
        .UsingEntity(entity => entity.ToTable("MD_DataIdentification_TopicCategory"));

      builder.HasMany(entity => entity.Language)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(LanguageTableName));

      builder.HasMany(entity => entity.CharacterSet)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(CharacterSetTableName));

      builder.HasMany(entity => entity.Extent)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(ExtentTableName));
    }
  }
}
