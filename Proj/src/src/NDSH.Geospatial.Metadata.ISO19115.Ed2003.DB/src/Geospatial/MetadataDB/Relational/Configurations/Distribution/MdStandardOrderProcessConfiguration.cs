using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Distribution;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Distribution {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_StandardOrderProcess_Type" />.
  /// </summary>
  public sealed class MdStandardOrderProcessConfiguration : IEntityTypeConfiguration<MD_StandardOrderProcess_Type> {
    private const string TableName = "MD_StandardOrderProcess";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_StandardOrderProcess_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.Fees)
        .WithMany()
        .HasForeignKey("Fees_CharacterStringDbId")
        .IsRequired(false);

      builder.OwnsOne(entity => entity.PlannedAvailableDateTime, owned => {
        owned.Property<DateTime?>("PlannedAvailableDateTime");
      });

      builder.HasOne(entity => entity.OrderingInstructions)
        .WithMany()
        .HasForeignKey("OrderingInstructions_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.Turnaround)
        .WithMany()
        .HasForeignKey("Turnaround_CharacterStringDbId")
        .IsRequired(false);
    }
  }
}
