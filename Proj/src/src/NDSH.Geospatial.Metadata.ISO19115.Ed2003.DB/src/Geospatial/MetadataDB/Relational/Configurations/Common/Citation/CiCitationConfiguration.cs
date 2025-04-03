using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Common.Citation {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="CI_Citation_Type" />.
  /// </summary>
  public sealed class CiCitationConfiguration : IEntityTypeConfiguration<CI_Citation_Type> {
    private const string TableName = "CI_Citation";
    private const string AlternativeTitlesTableName = "CI_Citation_AlternateTitles";
    private const string PresentationFormTableName = "CI_Citation_PresentationForm";
    private const string CitedResponsiblePartyTableName = "CI_Citation_CitedResponsibleParty";
    private const string DateTableName = "CI_Citation_Date";
    private const string IdentifierTableName = "CI_Citation_Identifier";


    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<CI_Citation_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.Property(entity => entity.Title) // No repeats were found, so foreign key unnecessary.
        .HasConversion(
          title => title.Value,
          value => new CharacterString(value))
        .IsRequired(false);

      builder.HasOne(entity => entity.Edition)
        .WithMany()
        .HasForeignKey("Edition_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.CollectiveTitle)
        .WithMany()
        .HasForeignKey("CollectiveTitle_CharacterStringDbId")
        .IsRequired(false);

      builder.Property(entity => entity.OtherCitationDetails) // No repeats were found, so foreign key unnecessary.
        .HasConversion(
          details => details!.Value,
          value => new CharacterString(value))
        .IsRequired(false);

      builder.HasOne(entity => entity.Series)
        .WithMany()
        .HasForeignKey("Series_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.ISBN)
        .WithMany()
        .HasForeignKey("ISBN_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.ISSN)
        .WithMany()
        .HasForeignKey("ISSN_CharacterStringDbId")
        .IsRequired(false);

      builder.HasMany(entity => entity.AlternateTitle)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(AlternativeTitlesTableName));

      builder.HasMany(entity => entity.Date)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(DateTableName));

      builder.HasMany(entity => entity.CitedResponsibleParty)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(CitedResponsiblePartyTableName));

      builder.HasMany(entity => entity.Identifier)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(IdentifierTableName));

      builder.HasMany(entity => entity.PresentationForm)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(PresentationFormTableName));

      builder.OwnsOne(entity => entity.EditionDate, date => {
        date.WithOwner().HasForeignKey("DbId");
        date.Property(date => date.DateOrDateTime)
          .IsRequired(false);
        date.Property(date => date.DateVariant)
          .HasDefaultValue(DateVariant.FullDate)
          .HasConversion<int?>();
      });
    }
  }
}
