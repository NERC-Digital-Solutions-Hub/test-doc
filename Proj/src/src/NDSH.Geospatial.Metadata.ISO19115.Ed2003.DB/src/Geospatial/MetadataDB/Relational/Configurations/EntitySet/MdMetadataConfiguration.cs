using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.EntitySet;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.EntitySet {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_Metadata_Type" />.
  /// </summary>
  public sealed class MdMetadataConfiguration : IEntityTypeConfiguration<MD_Metadata_Type> {
    private const string TableName = "MD_Metadata";
    private const string HierarchyLevelTableName = "MD_Metadata_HierarchyLevel";
    private const string HierarchyLevelNameTableName = "MD_Metadata_HierarchyLevelName";
    private const string ContactTableName = "MD_Metadata_Contact";
    private const string ReferenceSystemInfoTableName = "MD_Metadata_ReferenceSystemInfo";
    private const string IdentificationInfoTableName = "MD_Metadata_IdentificationInfo";
    private const string DataQualityInfoTableName = "MD_Metadata_DataQualityInfo";
    private const string MetadataConstraintsTableName = "MD_Metadata_MetadataConstraints";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_Metadata_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.Property(entity => entity.FileIdentifier)
        .HasConversion(
          characterString => characterString.Value,
          value => new CharacterString(value));

      builder.Property(entity => entity.ParentIdentifier)
        .HasConversion(
          characterString => characterString.Value,
          value => new CharacterString(value));

      builder.Property(entity => entity.DataSetURI)
        .HasConversion(
          characterString => characterString.Value,
          value => new CharacterString(value));

      builder.HasIndex(entity => entity.FileIdentifier)
        .IsUnique();

      builder.Property(entity => entity.FileIdentifier)
        .IsRequired();

      builder.Property(entity => entity.ParentIdentifier)
        .IsRequired(false);

      builder.Property(entity => entity.DataSetURI)
        .IsRequired(false);

      builder.HasOne(entity => entity.CharacterSet)
        .WithMany()
        .HasForeignKey("CharacterSet_CharacterStringDbId")
        .IsRequired(false);

      builder.HasMany(entity => entity.HierarchyLevel)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(HierarchyLevelTableName));

      builder.HasMany(entity => entity.HierarchyLevelName)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(HierarchyLevelNameTableName));

      builder.HasOne(entity => entity.MetadataStandardName)
        .WithMany()
        .HasForeignKey("MetadataStandardName_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.MetadataStandardVersion)
        .WithMany()
        .HasForeignKey("MetadataStandardVersion_CharacterStringDbId")
        .IsRequired(false);

      builder.HasMany(entity => entity.Contact)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(ContactTableName));

      builder.HasMany(entity => entity.ReferenceSystemInfo)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(ReferenceSystemInfoTableName));

      builder.HasMany(entity => entity.IdentificationInfo)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(IdentificationInfoTableName));

      builder.HasOne(entity => entity.DistributionInfo)
        .WithMany()
        .HasForeignKey("DistributionInfo_MD_DistributionDbId")
        .IsRequired(false);

      builder.HasMany(entity => entity.DataQualityInfo)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(DataQualityInfoTableName));

      builder.HasMany(entity => entity.MetadataConstraints)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(MetadataConstraintsTableName));

      builder.HasOne(entity => entity.MetadataMaintenance)
        .WithMany()
        .HasForeignKey("MetadataMaintenance_MD_MaintenanceInformationDbId")
        .IsRequired(false);

      builder.OwnsOne(entity => entity.DateStamp, date => {
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
