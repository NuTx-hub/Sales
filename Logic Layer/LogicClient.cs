using Data_Layer;
using Entity_Layer;

namespace Logic_Layer
{
    public class LogicClient
    {
        readonly ClientRepository repositoryClient = new();

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
    }
}
