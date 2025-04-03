using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Metadata.Maintenance;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Maintenance {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_MaintenanceInformation_Type" />.
  /// </summary>
  public sealed class MdMaintenanceInformationConfiguration : IEntityTypeConfiguration<MD_MaintenanceInformation_Type> {
    private const string TableName = "MD_MaintenanceInformation";
    private const string UpdateScopeTableName = "MD_MaintenanceInformation_UpdateScope";
    private const string UpdateScopeDescriptionTableName = "MD_MaintenanceInformation_UpdateScopeDescription";
    private const string MaintenanceNoteTableName = "MD_MaintenanceInformation_MaintenanceNote";
    private const string ContactTableName = "MD_MaintenanceInformation_Contact";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_MaintenanceInformation_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.MaintenanceAndUpdateFrequency)
        .WithMany()
        .HasForeignKey("MaintenanceAndUpdateFrequency_CodeListDbId")
        .IsRequired(false);

      builder.OwnsOne(entity => entity.DateOfNextUpdate, date => {
        date.WithOwner().HasForeignKey("DbId");
        date.Property(date => date.DateOrDateTime)
          .IsRequired(false);
        date.Property(date => date.DateVariant)
          .HasDefaultValue(DateVariant.FullDate)
          .HasConversion<int?>();
      });
      //builder.HasOne(entity => entity.DateOfNextUpdate)
      //    .WithMany()
      //    .HasForeignKey("DateOfNextUpdate_Date_PropertyTypeDbId")
      //    .IsRequired(false);

      builder.Ignore(entity => entity.UserDefinedMaintenanceFrequency); // TODO: TEMP
      //builder.HasOne(entity => entity.UserDefinedMaintenanceFrequency)
      //    .WithMany()
      //    .HasForeignKey("UserDefinedMaintenanceFrequency_TM_PeriodDuration_PropertyTypeDbId")
      //    .IsRequired(false);

      builder.HasMany(entity => entity.UpdateScope)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(UpdateScopeTableName));

      builder.HasMany(entity => entity.UpdateScopeDescription)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(UpdateScopeDescriptionTableName));

      builder.HasMany(entity => entity.MaintenanceNote)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(MaintenanceNoteTableName));

      builder.HasMany(entity => entity.Contact)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(ContactTableName));
    }
  }
}
