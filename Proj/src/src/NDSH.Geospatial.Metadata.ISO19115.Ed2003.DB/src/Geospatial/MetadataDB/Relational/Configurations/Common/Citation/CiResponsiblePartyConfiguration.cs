using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Citation;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Common.Citation {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="CI_ResponsibleParty_Type" />.
  /// </summary>
  public sealed class CiResponsiblePartyConfiguration : IEntityTypeConfiguration<CI_ResponsibleParty_Type> {
    private const string TableName = "CI_ResponsibleParty";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<CI_ResponsibleParty_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.IndividualName)
        .WithMany()
        .HasForeignKey("IndividualName_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.OrganisationName)
        .WithMany()
        .HasForeignKey("OrganisationName_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.PositionName)
        .WithMany()
        .HasForeignKey("PositionName_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.ContactInfo)
        .WithMany()
        .HasForeignKey("ContactInfo_CI_ContactDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.Role)
        .WithMany()
        .HasForeignKey("Role_CodeListValueDbId")
        .IsRequired(false);
    }
  }
}
