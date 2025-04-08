using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.ConceptualSchema.Primitive.Text {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="CharacterString" />.
  /// </summary>
  public sealed class CharacterStringConfiguration : IEntityTypeConfiguration<CharacterString> {
    private const string TableName = "CharacterString";
    private const string AdditionalInfoTableName = "CharacterString_AdditionalInfo";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<CharacterString> builder) {
      builder.ToTable(TableName);
      builder.ApplyDbIdConfiguration();

      builder.Property(entity => entity.Value)
        .IsRequired(false);
    }
  }
}
