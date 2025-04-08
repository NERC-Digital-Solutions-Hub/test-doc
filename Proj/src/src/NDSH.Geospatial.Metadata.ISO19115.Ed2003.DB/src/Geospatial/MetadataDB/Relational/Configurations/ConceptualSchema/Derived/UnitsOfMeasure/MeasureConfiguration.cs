using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Gml.Measures;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.ConceptualSchema.Derived.UnitsOfMeasure {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MeasureType" />.
  /// </summary>
  public sealed class MeasureConfiguration : IEntityTypeConfiguration<MeasureType> {
    private const string TableName = "Measure";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MeasureType> builder) {
      builder.ToTable(TableName);
      builder.ApplyDbIdConfiguration();

      builder.Property(entity => entity.UnitOfMeasure)
        .IsRequired(false);

      builder.Property(entity => entity.Value);
    }
  }
}
