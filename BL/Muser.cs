using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_application.BL
{
    class Muser
    {
        protected string cetagory;
        protected string name;
        protected string fname;
        protected string dept;
        protected float aggrigate;
        
        public Muser(string cetagory, string name, string fname, string dept, float aggrigate)
        {
            this.cetagory = cetagory;
            this.name = name;
            this.fname = fname;
            this.dept = dept;
            this.aggrigate = aggrigate;
        }
        public string Category
        {
            get { return cetagory; }
            set { cetagory = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        public float Aggrigate
        {
            get { return aggrigate; }
            set { aggrigate = value; }
        }
        public virtual string Designation
        {
            get { return null; }
            set { }
        }
        public virtual string Password
        {
            get { return null; }
            set { }
        }
    }
}
