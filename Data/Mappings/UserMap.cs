using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);
            
            builder.Property(x => x.Slug)
                .IsRequired()
                .HasColumnName("Slug")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);
            
            builder.HasIndex(x => x.Slug, "IX_User_Slug")
                .IsUnique();
        }
    }
}