using System;
using System.Collections.Generic;
using System.Text;
using Entity_Layer;
using Data_Layer;

namespace Logic_Layer
{
    // Logic layer
    public static class CurrentSession
    {
        //MUST BE STATIC, BECAUSE IT'S A SINGLETON. IT'S THE CURRENT CLIENT SESSION.
        ClientRepository ClientData = new ClientRepository();
        public static Client CurrentClient { get; private set; }

        public static bool LogIn(int DNI)
        {
            Client client = ClientData.SelectClient(DNI);
            if (client == null) return false;

            CurrentClient = client;
            return true;
        }

        public static void LogOut()
        {
            CurrentClient = null;
        }
    }


}
