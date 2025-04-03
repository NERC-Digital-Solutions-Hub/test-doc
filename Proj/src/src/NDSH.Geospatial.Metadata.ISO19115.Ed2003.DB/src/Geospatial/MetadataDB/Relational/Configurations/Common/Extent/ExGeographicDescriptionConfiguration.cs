using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Extent;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Common.Extent {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="EX_GeographicDescription_Type" />.
  /// </summary>
  public sealed class ExGeographicDescriptionConfiguration : IEntityTypeConfiguration<EX_GeographicDescription_Type> {
    private const string TableName = "EX_GeographicDescription";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<EX_GeographicDescription_Type> builder) {
      builder.ToTable(TableName);

      builder.HasOne(entity => entity.GeographicIdentifier)
        .WithMany()
        .HasForeignKey("GeographicIdentifier_MD_IdentifierDbId")
        .IsRequired();
    }
  }
}
