using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharma_Libarary.Model
{
    public class User
    {
        private string username;
        private string password;
        private string nom;
        private string prenom;

        public User(string username, string password, string nom, string prenom)
        {
            Username = username;
            Password = password;
            Nom = nom;
            Prenom = prenom;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
    }
}
