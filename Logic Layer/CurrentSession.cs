using System;
using System.Collections.Generic;
using System.Text;
using Entity_Layer;
using Data_Layer;

namespace Logic_Layer
{
    public static class CurrentClientSession
    {
        //MUST BE STATIC, BECAUSE IT'S A SINGLETON. IT'S THE CURRENT CLIENT SESSION.
        static ClientRepository ClientData = new ClientRepository();
        public static Client CurrentClient { get; private set; } = null;

        public static bool LogIn(int DNI)
        {
            Client client = ClientData.SelectClient(DNI);
            if (client == null) return false;
            else CurrentClient = client;
            return true;
        }

        public static void LogOut()
        {
            CurrentClient = null;
        }
    }

    public static class CurrentAdminSession
    {
        static AdminRepository AdminData = new AdminRepository();
        public static Admin CurrentAdmin { get; private set; } = null;

        public static bool LogIn(int DNI, string password)
        {
            Admin admin = AdminData.SelectAdmin(DNI, password);
            if (admin == null) return false;
            else CurrentAdmin = admin;
            return true;
        }

        public static void LogOut()
        {
            CurrentAdmin = null;
        }
    }

}
