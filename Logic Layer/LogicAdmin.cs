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
        public bool IsDNIAdmin(int dni)
        {
            AdminRepository adminData = new();
            return adminData.IsDNI(dni);
        }
    }
}
