using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.DataQuality.Lineage;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.DataQuality.Lineage {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="LI_Lineage_Type" />.
  /// </summary>
  public sealed class LiLineageConfiguration : IEntityTypeConfiguration<LI_Lineage_Type> {
    private const string TableName = "LI_Lineage";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<LI_Lineage_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.Ignore(entity => entity.ProcessStep); // TODO:
      builder.Ignore(entity => entity.Source); // TODO:

      builder.HasOne(entity => entity.Statement)
        .WithMany()
        .HasForeignKey("Statement_CharacterStringDbId")
        .IsRequired(false);
    }
  }
}
