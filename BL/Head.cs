using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_application.BL
{
    class Head : Muser
    {
        private string designation;

        public Head(string cetagory, string name, string fname, string dept, float aggrigate, string designation) : base(cetagory, name, fname, dept, aggrigate)
        {
            this.designation = designation;
        }
        public override string Designation
        {
            get { return designation; }
            set { designation = value; }
            
        }
    }
}
