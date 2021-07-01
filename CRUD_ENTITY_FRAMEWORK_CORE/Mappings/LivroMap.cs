using CRUD_ENTITY_FRAMEWORK_CORE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Mappings
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.Property(p => p.Id)
                .ValueGeneratedNever() //COM ISSO O ID NAO  É SERIAL, QUE É O PADRÃO
                .HasColumnType("INTEGER");

            builder.Property(p => p.CategoriaId)
                .HasColumnType("INTEGER");

            builder.Property(p => p.Titulo)
                .HasColumnType("VARCHAR(150)")
                .IsRequired();

            builder.Property(p => p.Autor)
                .HasColumnType("VARCHAR(151)")
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasColumnType("NUMERIC(38,2)");

            builder.Property(p => p.DataEntrada)
                .HasColumnType("DATETIME");

            builder.HasIndex(p => p.Titulo)
                .HasDatabaseName("IX_Livro_Titulo");

            builder.HasOne(p => p.Categoria)
                .WithMany(p => p.Livros)
                .OnDelete(DeleteBehavior.NoAction) //SE NÃO COLOCAR ESSE MAPEAMENTO, O DEFAULT  É CASCADE, ENTÃO SE DELETAR UMA CATEGORIA, DELETE TODOS OS LIVROS DA
                .HasForeignKey(p => p.CategoriaId);


            //builder.HasOne(p => p.Categoria) //COM ESSE MAPEAMENTO FICA EXPLICITO A RELACAO ENTRE LIVROS E CATEGORIAS, MAS COMO ADICIONAMOS  CATEGORIA DENTRO DE LIVRO , e  ICOLLECTION DE LIVROS DENTRO DE CATEGORIA, ENTAO JA ESTA CERTO
            //    .WithMany()
            //    .HasForeignKey(p => p.CategoriaId);


            builder.HasData(
                new Livro(1, 1, "Titulo 1", "Autor 1", 10, 50),
                new Livro(2, 1, "Titulo 2", "Autor 2", 10, 770),
                new Livro(3, 1, "Titulo 3", "Autor 3", 10, 580),
                new Livro(4, 1, "Titulo 4", "Autor 4", 10, 30),
                new Livro(5, 1, "Titulo 5", "Autor 5", 10, 250),
                new Livro(6, 1, "Titulo 6", "Autor 6", 10, 505)

            );
        }
    }
}
