using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Citation;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Common.Citation {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="CI_OnlineResource_Type" />.
  /// </summary>
  public sealed class CiOnlineResourceConfiguration : IEntityTypeConfiguration<CI_OnlineResource_Type> {
    private const string TableName = "CI_OnlineResource";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<CI_OnlineResource_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.Property(onlineResource => onlineResource.Linkage)
        .HasConversion(
          url => url.Url,
          value => new URL_PropertyType { Url = value })
        .IsRequired(false);

      builder.HasOne(onlineResource => onlineResource.Protocol)
        .WithMany()
        .HasForeignKey("Protocol_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(onlineResource => onlineResource.ApplicationProfile)
        .WithMany()
        .HasForeignKey("ApplicationProfile_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(onlineResource => onlineResource.Name)
        .WithMany()
        .HasForeignKey("Name_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(onlineResource => onlineResource.Description)
        .WithMany()
        .HasForeignKey("Description_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(onlineResource => onlineResource.Function)
        .WithMany()
        .HasForeignKey("Function_CodeListValueDbId")
        .IsRequired(false);
    }
  }
}
