using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.ReferenceSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.ReferenceSystem {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_ReferenceSystem_Type" />.
  /// </summary>
  public sealed class MdReferenceSystemConfiguration : IEntityTypeConfiguration<MD_ReferenceSystem_Type> {
    private const string TableName = "MD_ReferenceSystem";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_ReferenceSystem_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.ReferenceSystemIdentifier)
        .WithMany()
        .HasForeignKey("ReferenceSystemIdentifier_RS_IdentifierDbId")
        .IsRequired(false);
    }
  }
}
