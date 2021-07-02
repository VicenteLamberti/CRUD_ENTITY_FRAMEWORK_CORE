using CRUD_ENTITY_FRAMEWORK_CORE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Mappings
{
    public class UserModelMap : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.ToTable("User");
            builder.Property(p => p.Id)
                .HasColumnType("INTEGER");

            builder.HasKey(p => p.Id);


            builder.Property(p => p.UserName)
                .HasColumnType("VARCHAR(100)");

            builder.Property(p => p.Password)
                .HasColumnType("VARCHAR(100)");

            builder.Property(p => p.Email)
                .HasColumnType("VARCHAR(100)");

            builder.Property(p => p.Permissao)
                .HasColumnType("VARCHAR(100)");


            builder.HasData(

                new UserModel(1,"vicente", "123", "vicente@", "admin")

            );
        }
       
    }
}
