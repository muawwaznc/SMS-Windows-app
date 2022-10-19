using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_application.BL
{
    class Admin
    {
        private string name;
        private string password;

        public Admin(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
