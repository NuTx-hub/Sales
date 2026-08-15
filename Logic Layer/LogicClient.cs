using Data_Layer;
using Entity_Layer;

namespace Logic_Layer
{
    public class LogicClient
    {
        readonly ClientRepository repositoryClient = new();
        public List<Client> clientList = new List<Client>();
        public bool LInsertClient(int dni, string name, string lastname, string email)
        {
            if (!LIsDNIClient(dni))
            {
                Client client = new(dni, name, lastname, email);
                return repositoryClient.InsertClient(client);
            }
            else return false;
        }

        public bool LIsDNIClient(int dni)
        {
            return repositoryClient.IsDNI(dni);
        }

        public Client LSelectClient(int DNI)
        {
            Client client = repositoryClient.SelectClient(DNI);
            return client;
        }

        
    }
}
