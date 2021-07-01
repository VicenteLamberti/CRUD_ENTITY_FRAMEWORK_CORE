using CRUD_ENTITY_FRAMEWORK_CORE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            //builder.HasKey(p => p.Id);  //COMO O NOME É ID O EF JA ENTENDE QUE É PK, SE FOSSE CATEGORIAID TAMBÉM

            builder.Property(p => p.Nome)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.HasData(
                new Categoria(1,"Software")
            );
        }
    }
}
