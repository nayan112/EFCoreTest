using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserDomain.Entity;
using UserDomain.Extensions;

namespace UserDomain.Mappings
{
    public class UserMap : EntityTypeConfiguration<Users>
    {
        public override void Map(EntityTypeBuilder<Users> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .HasMaxLength(11)
                .IsRequired();
        }
    }
}