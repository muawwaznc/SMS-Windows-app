using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using business_application.BL;
using System.Windows.Forms;
using System.IO;

namespace business_application.DL
{
    class Alumni_DL
    {
        private static List<Alumni> alumni = new List<Alumni>();

        public static List<Alumni> Get_list()
        {
            return alumni;
        }

        public static void Add_into_list(Alumni a)
        {
            alumni.Add(a);
        }
        public static void Read_file()
        {
            if(File.Exists("alumni.txt"))
            {
                StreamReader file = new StreamReader("alumni.txt");
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    string name = data[0];
                    string session = data[1];
                    Alumni a = new Alumni(name, session);
                    Add_into_list(a);
                }
            }
        }
    }
}
