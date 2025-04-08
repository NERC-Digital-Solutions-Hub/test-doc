using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Constraint;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Constraint {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_Constraints_Type" />.
  /// </summary>
  public sealed class MdConstraintsConfiguration : IEntityTypeConfiguration<MD_Constraints_Type> {
    private const string TableName = "MD_Constraints";
    private const string UseLimitationTableName = "MD_Constraints_UseLimitation";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_Constraints_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasDiscriminator<string>("Discriminator")
        .HasValue<MD_LegalConstraints_Type>("MD_LegalConstraints");

      builder.HasMany(entity => entity.UseLimitation)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(UseLimitationTableName));
    }
  }
}
