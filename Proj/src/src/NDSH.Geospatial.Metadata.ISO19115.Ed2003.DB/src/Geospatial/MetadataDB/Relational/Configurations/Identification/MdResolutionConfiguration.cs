using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Identification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Identification {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_Resolution_Type" />.
  /// </summary>
  public sealed class MdResolutionConfiguration : IEntityTypeConfiguration<MD_Resolution_Type> {
    private const string TableName = "MD_Resolution";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_Resolution_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyDbIdConfiguration();

      builder.HasOne(resolution => resolution.EquivalentScale)
        .WithMany()
        .HasForeignKey("EquivalentScale_MD_RepresentativeFactionDbId")
        .IsRequired(false);

      builder.HasOne(resolution => resolution.Distance)
        .WithMany()
        .HasForeignKey("Distance_DistanceDbId")
        .IsRequired(false);
    }
  }
}
