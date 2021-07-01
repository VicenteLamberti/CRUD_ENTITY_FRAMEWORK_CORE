using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Models
{
    public class Categoria
    {
        public Categoria()
        {

        }
        public Categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; } //COMO O NOME É ID O EF JA ENTENDE QUE É PK, SE FOSSE CATEGORIAID TAMBÉM
        public string Nome { get; set; }
        public ICollection <Livro> Livros { get; set; }
    }
}
