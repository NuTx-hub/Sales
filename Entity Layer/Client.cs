using System.Security.Cryptography;

namespace Entity_Layer
{
    public class Client
    {
        private long idClient = RandomNumberGenerator.GetInt32(9999999);
        private int ci = 0;
        private string name = string.Empty;
        private string lastName = string.Empty;
        private string email = string.Empty;

        public long IdClient { get => idClient;}
        public int Ci { get => ci; set => ci = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
    }
}
