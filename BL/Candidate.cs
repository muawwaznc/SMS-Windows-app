using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_application.BL
{
    class Candidate : Muser
    {
        private string password;

        public Candidate(string cetagory, string name, string fname, string dept, float aggrigate, string password) : base(cetagory, name, fname, dept, aggrigate) 
        {
            this.password = password;
        }
        public override string Password
        {
            get { return password; }
            set { password = value; }

        }
    }
}
