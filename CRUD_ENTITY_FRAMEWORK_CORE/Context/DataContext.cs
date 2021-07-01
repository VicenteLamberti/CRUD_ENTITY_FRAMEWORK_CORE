﻿using CRUD_ENTITY_FRAMEWORK_CORE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }


        //protected override OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Categoria>()
        //        .Property(p => p.Nome)
        //        .HasColumnType("varchar(100)");

        //    Esse método aqui é para mapear, porém se fizer tudo aqui, fica desorganizado. Então é bom criar varias classes
        //}




        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
