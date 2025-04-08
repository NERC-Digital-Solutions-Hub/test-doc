using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.DataQuality;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.DataQuality {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="AbstractDQ_Result_Type" />.
  /// </summary>
  public sealed class AbstractDqResultConfiguration : IEntityTypeConfiguration<AbstractDQ_Result_Type> {
    private const string TableName = "AbstractDQ_Result";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<AbstractDQ_Result_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();
    }
  }
}
