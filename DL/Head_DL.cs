using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using business_application.BL;

namespace business_application.DL
{
    class Head_DL
    {
        public static List<Muser> Get_heads()
        {
            List<Muser> users = Muser_DL.Get_users_list();
            List <Muser> heads = new List<Muser>();
            foreach (Muser a in users)
            {
                if (a.Designation == "President")
                {
                    heads.Add(a);
                    break;
                }
            }
            foreach (Muser a in users)
            {
                if (a.Designation == "Vice President")
                {
                    heads.Add(a);
                    break;
                }
            }
            foreach (Muser a in users)
            {
                if (a.Category == "head" && a.Designation != "President" && a.Designation != "Vice President")
                {
                    heads.Add(a);
                }
            }
            return heads;
        }

        public static Muser Remove_previous_head(string designation)
        {
            foreach (Muser a in Get_heads())
            {
                if (a.Designation == designation)
                {
                    Muser mem = new Muser("member", a.Name, a.Fname, a.Dept, a.Aggrigate);
                    Muser_DL.Add_into_list(mem);
                    return a;
                }
            }
            return null;
        }

        public static Muser Add_new_head(string name, string designation)
        {
            string cetagory = "head";
            foreach (Muser a in Muser_DL.Get_members())
            {
                if (a.Name == name)
                {
                    Head new_head = new Head(cetagory, name, a.Fname, a.Dept, a.Aggrigate, designation);
                    Muser_DL.Add_into_list(new_head);
                    return a;
                }
            }
            return null;
        }

        public static List<string> Get_designations(List<Muser> heads)
        {
            List<string> dept = new List<string>();
            foreach (Muser a in heads)
            {
                dept.Add(a.Designation);
            }
            return dept;
        }
    }
}
