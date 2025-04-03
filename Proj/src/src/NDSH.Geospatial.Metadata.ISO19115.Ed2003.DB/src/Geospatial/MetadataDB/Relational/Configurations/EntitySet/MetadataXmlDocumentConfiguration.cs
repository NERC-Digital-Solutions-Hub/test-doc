using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.EntitySet;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.EntitySet {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MetadataDocument" />.
  /// </summary>
  public sealed class MetadataXmlDocumentConfiguration : IEntityTypeConfiguration<MetadataDocument> {
    private const string TableName = "MetadataDocuments";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MetadataDocument> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.Property(entity => entity.Schema)
        .IsRequired()
        .HasMaxLength(50);

      builder.Property(entity => entity.UniqueIdentifier)
          .IsRequired();

      builder.Property(entity => entity.Data)
        .HasConversion(
          metadata => Encoding.UTF8.GetBytes(metadata),
          blob => Encoding.UTF8.GetString(blob))
        .HasColumnType("BLOB");

      builder.Property(entity => entity.CreateDate)
          .IsRequired();

      builder.Property(entity => entity.UpdateDate)
          .IsRequired();
    }
  }
}
