using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Permissao { get; set; }

        public UserModel()
        {

        }

        public UserModel(int id, string userName, string password, string email, string permissao)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Email = email;
            Permissao = permissao;
        }
        public UserModel( string userName, string password, string email, string permissao)
        {
            
            UserName = userName;
            Password = password;
            Email = email;
            Permissao = permissao;
        }
    }
}
