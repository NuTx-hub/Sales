using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Layer
{
    public class Admin
    {
        private int idEmployee = 0; //It will be assigned in the database.
        private int ci = 0;
        private string name = string.Empty;
        private string lastname = string.Empty;
        private string password = string.Empty;

        public int IdEmployee { get { return idEmployee; } set { idEmployee = value; } }
        public int Ci { get { return ci; } set { ci = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public string Password { get { return password;  } set { password = value; }  }

        public Admin()
        {

        }
    }
}
