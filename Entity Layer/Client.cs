using System.Security.Cryptography;

namespace Entity_Layer
{
    public class Client
    {
        private long idClient = 0;
        private int dni = 0;
        private string name = string.Empty;
        private string lastname = string.Empty;
        private string email = string.Empty;

        public long IdClient { get => idClient; set => idClient = value; } 
        public int DNI { get => dni; set => dni = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }

        public Client(int dni, string name, string lastName, string email)
        {
            this.DNI = dni;
            this.Name = name;
            this.Lastname = lastname;
            this.Email = email;
        }
    }
}
