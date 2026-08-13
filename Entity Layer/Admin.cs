using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Layer
{
    public class Admin
    {
        private int idAdmin = 0; //It will be assigned in the database.
        private int dni = 0;
        private string name = string.Empty;
        private string lastname = string.Empty;
        private string password = string.Empty;

        public int IdAdmin{ get { return idAdmin; } set { idAdmin = value; } }
        public int DNI { get { return dni; } set { dni = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public string Password { get { return password;  } set { password = value; }  }

        public Admin()
        {

        }

        public Admin(int id, int dni, string name, string lastname, string password)
        {
            this.IdAdmin = id;
            this.DNI = dni;
            this.Name = name;
            this.Lastname = lastname;
            this.Password= password;
        }

        public Admin(int dni, string name, string lastname, string password)
        {
            this.DNI = dni;
            this.Name = name;
            this.Lastname = lastname;
            this.Password = password;
        }
    }
}
