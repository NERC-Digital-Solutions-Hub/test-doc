using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Identification;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Identification {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_Usage_Type" />.
  /// </summary>
  public sealed class MdUsageConfiguration : IEntityTypeConfiguration<MD_Usage_Type> {
    private const string TableName = "MD_Usage";
    private const string UserContactInfoTableName = "MD_Usage_UserContactInfo";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_Usage_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.SpecificUsage)
        .WithMany()
        .HasForeignKey("SpecificUsage_CharacterStringDbId")
        .IsRequired(false);

      builder.OwnsOne(entity => entity.UsageDateTime, owned => {
        owned.Property<DateTime?>("UsageDateTime");
      });

      builder.HasOne(entity => entity.UserDeterminedLimitations)
        .WithMany()
        .HasForeignKey("UserDeterminedLimitations_CharacterStringDbId")
        .IsRequired(false);

      builder.HasMany(entity => entity.UserContactInfo)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(UserContactInfoTableName));
    }
  }
}
