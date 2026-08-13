using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;
using Data_Layer;

namespace Logic_Layer
{
    //Class to create functions to validate data from the Admin entity.
    public class LogicAdmin
    {
        public static List<Admin> adminList;

        readonly AdminRepository adminData = new();
        public bool LInsertAdmin(int dni, string name, string lastname, string password)
        {
            Admin admin = new(dni, name, lastname, password);

            if (!adminData.IsDNI(dni))
            {
                return adminData.InsertAdmin(admin);
            }
            else return false;
        }

        public bool LDeleteAdmin(int idAdmin)
        {
            return adminData.DeleteAdmin(idAdmin);
        }

        //Verify that the DNI it's in the database
        public int GetId(int dni)
        {
            return adminData.SelectIdAdmin(dni);
        }

        public Admin SelectAdmin(int idAdmin)
        {
            //It returns null if there isn't 
            return adminData.SelectAdmin(idAdmin); 
        }

        public bool IsAdmin(int DNI, string password)
        {
            return adminData.IsAdmin(DNI, password);
        }
    }
}
