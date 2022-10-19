using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using business_application.BL;
using System.IO;
using System.Windows.Forms;

namespace business_application.DL
{
    class Muser_DL
    {
        private static List<Muser> users = new List<Muser>();



        public static List<Muser> Get_users_list()
        {
            return users;
        }

        public static void Add_into_list(Muser c)
        {
            users.Add(c);
        }

        public static void Read_user_file()
        {
            if (File.Exists("users.txt"))
            {
                StreamReader file = new StreamReader("users.txt");
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] data = line.Split(',');                    
                    if (data[0] == "member")
                    {
                        string cetagory = data[0];
                        string name = data[1];
                        string fname = data[2];
                        string dept = data[3];
                        float aggrigate = float.Parse(data[4]);
                        Muser a = new Muser(cetagory, name, fname, dept, aggrigate);
                        Add_into_list(a);
                    }
                    else if (data[0] == "candidate")
                    {
                        string cetagory = data[0];
                        string name = data[1];
                        string fname = data[2];
                        string dept = data[3];
                        float aggrigate = float.Parse(data[4]);
                        string password = data[5];
                        Muser a = new Candidate(cetagory, name, fname, dept, aggrigate, password);
                        Add_into_list(a);
                    }
                    else if (data[0] == "head")
                    {
                        string cetagory = data[0];
                        string name = data[1];
                        string fname = data[2];
                        string dept = data[3];
                        float aggrigate = float.Parse(data[4]);
                        string designation = data[5];
                        Muser a = new Head(cetagory, name, fname, dept, aggrigate, designation);
                        Add_into_list(a);
                    }
                }
                file.Close();
            }
        }
        
        public static void Add_into_file(Muser a)
        {
            StreamWriter file = new StreamWriter("users.txt", true);
            string line = "";
            if (a.Category == "member")
            {
                string cetagory = a.Category;
                string name = a.Name;
                string fname = a.Fname;
                string dept = a.Dept;
                float aggrigate = a.Aggrigate;
                line = cetagory + "," + name + "," + fname + "," + dept + "," + aggrigate;
            }
            else if (a.Category == "candidate")
            {
                string cetagory = a.Category;
                string name = a.Name;
                string fname = a.Fname;
                string dept = a.Dept;
                float aggrigate = a.Aggrigate;
                string password = a.Password;
                line = cetagory + "," + name + "," + fname + "," + dept + "," + aggrigate + "," + password;
            }
            else if (a.Category == "head")
            {
                string cetagory = a.Category;
                string name = a.Name;
                string fname = a.Fname;
                string dept = a.Dept;
                float aggrigate = a.Aggrigate;
                string designation = a.Designation;
                line = cetagory + "," + name + "," + fname + "," + dept + "," + aggrigate + "," + designation;
            }
            file.WriteLine(line);
            file.Flush();
            file.Close();
        }
        
        public static void Store_into_file()
        {
            StreamWriter file = new StreamWriter("users.txt", false);
            foreach(Muser a in users)
            {
                string line = "";
                if (a.Category == "member")
                {
                    string cetagory = a.Category;
                    string name = a.Name;
                    string fname = a.Fname;
                    string dept = a.Dept;
                    float aggrigate = a.Aggrigate;
                    line = cetagory + "," + name + "," + fname + "," + dept + "," + aggrigate;
                }
                else if (a.Category == "candidate")
                {
                    string cetagory = a.Category;
                    string name = a.Name;
                    string fname = a.Fname;
                    string dept = a.Dept;
                    float aggrigate = a.Aggrigate;
                    string password = a.Password;
                    line = cetagory + "," + name + "," + fname + "," + dept + "," + aggrigate + "," + password;
                }
                else if (a.Category == "head")
                {
                    string cetagory = a.Category;
                    string name = a.Name;
                    string fname = a.Fname;
                    string dept = a.Dept;
                    float aggrigate = a.Aggrigate;
                    string designation = a.Designation;
                    line = cetagory + "," + name + "," + fname + "," + dept + "," + aggrigate + "," + designation;
                }
                file.WriteLine(line);
                file.Flush();
            }
            file.Close();
        }
                
        public static bool Remove_member(Muser a)
        {
            if(users.Remove(a))
            {
                return true;
            }
            return false;
        }
          
        public static List<string> Get_members_name(List<Muser> users)
        {
            List<string> names = new List<string>();
            foreach (Muser a in users)
            {
                names.Add(a.Name);
            }
            return names;
        }
                
        public static List<Muser> Get_members()
        {
            List<Muser> members = new List<Muser>();
            foreach (Muser a in users)
            {
                if (a.Category == "member")
                {
                    members.Add(a);
                }
            }
            return members;
        }        
    }
}
