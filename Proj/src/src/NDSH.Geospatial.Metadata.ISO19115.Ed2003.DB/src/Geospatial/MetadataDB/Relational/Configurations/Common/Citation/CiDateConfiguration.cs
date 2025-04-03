using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Metadata.Citation;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Common.Citation {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="CI_Date_Type" />.
  /// </summary>
  public sealed class CiDateConfiguration : IEntityTypeConfiguration<CI_Date_Type> {
    private const string TableName = "CI_Date";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<CI_Date_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.OwnsOne(date => date.Date, date => {
        date.WithOwner().HasForeignKey("DbId");
        date.Property(date => date.DateOrDateTime)
          .IsRequired(false);
        date.Property(date => date.DateVariant)
          .HasDefaultValue(DateVariant.FullDate)
          .HasConversion<int?>();
      });

      builder.HasOne(date => date.DateType)
        .WithMany()
        .IsRequired(false);
    }
  }
}
