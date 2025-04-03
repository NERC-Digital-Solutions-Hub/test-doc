using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Database.Entities;
using NDSH.Geospatial.Metadata.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations {
  /// <summary>
  ///   The extensions for the <see cref="EntityTypeBuilder{TEntity}" />.
  /// </summary>
  public static class EntityTypeBuilderExtensions {
    /// <summary>
    ///   Applies the base configuration for the <see cref="ObservableDbEntity" />.
    /// </summary>
    /// <typeparam name="T">The <see cref="ObservableDbEntity" /> <see cref="Type" />.</typeparam>
    /// <param name="builder">The <see cref="EntityTypeBuilder{TEntity}" /> instance.</param>
    public static void ApplyDbIdConfiguration<T>(this EntityTypeBuilder<T> builder) where T : ObservableDbEntity {
      builder.HasKey(entity => entity.DbId);
      builder.Property(entity => entity.DbId)
        .HasColumnName("DbId")
        .ValueGeneratedOnAdd();
    }

    /// <summary>
    ///   Applies the base configuration for the <see cref="IdentifiableObject" />. This includes setting the
    ///   primary key to the <see cref="ObservableDbEntity.DbId" /> and ignoring the <see cref="IdentifiableObject.Id" />,
    ///   <see cref="IdentifiableObject.Uuid" />, <see cref="IdentifiableObject.PropertyAttributes" />, and
    ///   <see cref="IdentifiableObject.ReferencedObjects" />.
    /// </summary>
    /// <typeparam name="T">The <see cref="IdentifiableObject" /> <see cref="Type" />.</typeparam>
    /// <param name="builder">The <see cref="EntityTypeBuilder{TEntity}" /> instance.</param>
    public static void ApplyBaseConfiguration<T>(this EntityTypeBuilder<T> builder) where T : IdentifiableObject {
      builder.ApplyDbIdConfiguration();

      builder.Ignore(entity => entity.Id);
      builder.Ignore(entity => entity.Uuid);
      builder.Ignore(entity => entity.PropertyAttributes);
      builder.Ignore(entity => entity.ReferencedObjects);
    }
  }
}
