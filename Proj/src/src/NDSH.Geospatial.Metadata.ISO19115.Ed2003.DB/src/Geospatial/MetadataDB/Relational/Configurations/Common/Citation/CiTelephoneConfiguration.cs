using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Citation;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Common.Citation {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="CI_Telephone_Type" />.
  /// </summary>
  public sealed class CiTelephoneConfiguration : IEntityTypeConfiguration<CI_Telephone_Type> {
    private const string TableName = "CI_Telephone";
    private const string VoiceNumbersTableName = "CI_Telephone_VoiceNumbers";
    private const string FacsimileNumbersTableName = "CI_Telephone_FacsimileNumbers";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<CI_Telephone_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasMany(entity => entity.Voice)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(VoiceNumbersTableName));

      builder.HasMany(entity => entity.Facsimile)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(FacsimileNumbersTableName));
    }
  }
}
