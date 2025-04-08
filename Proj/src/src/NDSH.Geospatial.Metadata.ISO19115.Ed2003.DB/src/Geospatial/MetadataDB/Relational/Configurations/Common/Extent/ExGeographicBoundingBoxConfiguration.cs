using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Extent;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Common.Extent {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="EX_GeographicBoundingBox_Type" />.
  /// </summary>
  public sealed class ExGeographicBoundingBoxConfiguration : IEntityTypeConfiguration<EX_GeographicBoundingBox_Type> {
    private const string TableName = "EX_GeographicBoundingBox";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<EX_GeographicBoundingBox_Type> builder) => builder.ToTable(TableName);
  }
}
