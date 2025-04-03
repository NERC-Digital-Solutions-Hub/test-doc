using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Citation;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Common.Citation {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="CI_Contact_Type" />.
  /// </summary>
  public sealed class CiContactConfiguration : IEntityTypeConfiguration<CI_Contact_Type> {
    private const string TableName = "CI_Contact";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<CI_Contact_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(contact => contact.Phone)
        .WithMany()
        .HasForeignKey("Phone_CI_TelephoneDbId")
        .IsRequired(false);

      builder.HasOne(contact => contact.Address)
        .WithMany()
        .HasForeignKey("Address_CI_AddressDbId")
        .IsRequired(false);

      builder.HasOne(contact => contact.OnlineResource)
        .WithMany()
        .HasForeignKey("OnlineResource_CI_OnlineResourceDbId")
        .IsRequired(false);

      builder.HasOne(contact => contact.HoursOfService)
        .WithMany()
        .HasForeignKey("HoursOfService_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(contact => contact.ContactInstructions)
        .WithMany()
        .HasForeignKey("ContactInstructions_CharacterStringDbId")
        .IsRequired(false);
    }
  }
}
