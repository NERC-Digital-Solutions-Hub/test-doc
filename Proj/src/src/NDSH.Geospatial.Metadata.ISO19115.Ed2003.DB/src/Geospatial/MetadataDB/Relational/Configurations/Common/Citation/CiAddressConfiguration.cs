using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Citation;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Common.Citation {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="CI_Address_Type" />.
  /// </summary>
  public sealed class CiAddressConfiguration : IEntityTypeConfiguration<CI_Address_Type> {
    private const string TableName = "CI_Address";
    private const string DeliveryPointTableName = "CI_Address_DeliveryPoints";
    private const string ElectronicMailAddressTableName = "CI_Address_ElectronicMailAddresses";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<CI_Address_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasMany(entity => entity.DeliveryPoint)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(DeliveryPointTableName));

      builder.HasMany(entity => entity.ElectronicMailAddress)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(ElectronicMailAddressTableName));

      builder.HasOne(entity => entity.City)
        .WithMany()
        .HasForeignKey("CityDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.AdministrativeArea)
        .WithMany()
        .HasForeignKey("AdministrativeArea_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.PostalCode)
        .WithMany()
        .HasForeignKey("PostalCode_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.Country)
        .WithMany()
        .HasForeignKey("Country_CharacterStringDbId")
        .IsRequired(false);
    }
  }
}
