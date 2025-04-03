using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.ConceptualSchema.Implementation.Names {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="TypeName_Type" />.
  /// </summary>
  public sealed class TypeNameConfiguration : IEntityTypeConfiguration<TypeName_Type> {
    private const string TableName = "TypeName";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<TypeName_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.Name)
        .WithMany()
        .HasForeignKey("Name_CharacterStringDbId")
        .IsRequired(false);
    }
  }
}
