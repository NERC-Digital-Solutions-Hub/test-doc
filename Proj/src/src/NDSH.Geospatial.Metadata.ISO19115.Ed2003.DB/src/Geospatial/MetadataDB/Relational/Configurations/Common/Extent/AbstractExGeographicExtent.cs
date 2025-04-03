using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Extent;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Common.Extent {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="AbstractEX_GeographicExtent_Type" />.
  /// </summary>
  public sealed class AbstractExGeographicExtentConfiguration : IEntityTypeConfiguration<AbstractEX_GeographicExtent_Type> {
    private const string TableName = "AbstractEX_GeographicExtent";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<AbstractEX_GeographicExtent_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();
    }
  }
}
