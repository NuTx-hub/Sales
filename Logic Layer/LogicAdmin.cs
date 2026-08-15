using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;
using Data_Layer;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Logic_Layer
{
    //Class to create functions to validate data from the Admin entity.
    public class LogicAdmin
    {
        public List<Admin> adminList = new List<Admin>();

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

        public Admin LSelectAdmin(int dni, string password)
        {
            Admin admin = adminData.SelectAdmin(dni, password);

            if (admin == null) return null;
            else return admin;
        }

        public bool IsAdmin(int DNI, string password)
        {
            return adminData.IsAdmin(DNI, password);
        }
    }
}
