using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Identification;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Identification {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_RepresentativeFraction_Type" />.
  /// </summary>
  public sealed class MdRepresentativeFractionConfiguration : IEntityTypeConfiguration<MD_RepresentativeFraction_Type> {
    private const string TableName = "MD_RepresentativeFraction";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_RepresentativeFraction_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();
    }
  }
}
