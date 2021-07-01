using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Models
{
    public class Livro
    {
        public Livro() =>
          DataEntrada = DateTime.Now;
        public Livro(int id, int categoriaId, string titulo, string autor, int quantidade, decimal preco, DateTime dataEntrada) : this()
        {
            Id = id;
            CategoriaId = categoriaId;
            Titulo = titulo;
            Autor = autor;
            Quantidade = quantidade;
            Preco = preco;
            DataEntrada = dataEntrada;
        }

        public Livro(int id, int categoriaId, string titulo, string autor, int quantidade, decimal preco) : this()
        {
            Id = id;
            CategoriaId = categoriaId;
            Titulo = titulo;
            Autor = autor;
            Quantidade = quantidade;
            Preco = preco;
        }





        public int Id { get; set; }
        public int CategoriaId { get; set; } // Nao preciso desse atributo porque o EF já criaria uma relação só com o atributo Categoria
        public Categoria Categoria { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataEntrada { get; set; }


    }
}
