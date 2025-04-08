using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Citation;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Common.Citation {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="CI_Series_Type" />.
  /// </summary>
  public sealed class CiSeriesConfiguration : IEntityTypeConfiguration<CI_Series_Type> {
    private const string TableName = "CI_Series";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<CI_Series_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.Name)
        .WithMany()
        .HasForeignKey("Name_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.IssueIdentification)
        .WithMany()
        .HasForeignKey("IssueIdentification_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.Page)
        .WithMany()
        .HasForeignKey("Page_CharacterStringDbId")
        .IsRequired(false);
    }
  }
}
