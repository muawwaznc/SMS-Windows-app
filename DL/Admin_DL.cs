using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using business_application.BL;
using System.IO;

namespace business_application.DL
{
    class Admin_DL
    {
        private static Admin login = new Admin("admin", "admin");

        public static Admin Get_login()
        {
            return login;
        }

        public static void Read_file()
        {
            if(File.Exists("login_details.txt"))
            {
                StreamReader file = new StreamReader("login_details.txt");
                string line = file.ReadLine();
                string[] data = line.Split(',');
                string username = data[0];
                string password = data[1];
                login.Name = username;
                login.Password = password;
                file.Close();
            }
        }
        public static void Store_file(string username, string password)
        {
            StreamWriter file = new StreamWriter("login_details.txt", false);
            string line = username + "," + password;
            file.WriteLine(line);
            file.Close();
        }
    }
}
