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
            Client client = new(dni, name, lastname, email);

            if (repositoryClient.InsertClient(client))
            {
                clientList.Add(client);
                return true;
            }
            return false;
        }

        public Client LSelectClient(int DNI)
        {
            Client client = repositoryClient.SelectClient(DNI);
            if(client != null)
            {
                clientList.Add(client);
                return client;
            }
            return null;
        }

        public bool IsDNIClient(int DNI)
        {
            return repositoryClient.IsDNI(DNI);
        }
    }
}
