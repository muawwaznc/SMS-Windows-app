using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace business_application.BL
{
    class Alumni
    {
        private string name;
        private string session;

        public Alumni(string name, string session)
        {
            this.name = name;
            this.session = session;
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public string Session
        {
            get { return session; }
            set { session = value; }
        }
    }
}
