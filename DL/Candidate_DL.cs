using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using business_application.BL;

namespace business_application.DL
{
    class Candidate_DL
    {
        public static void Approve_candidate(Muser a)
        {
            string cetagory = "member";
            string name = a.Name;
            string fname = a.Fname;
            string dept = a.Dept;
            float aggrigate = a.Aggrigate;
            if (Muser_DL.Remove_member(a))
            {
                Muser new_member = new Muser(cetagory, name, fname, dept, aggrigate);
                Muser_DL.Add_into_list(new_member);
            }
        }

        public static List<Muser> Get_candidates()
        {
            List<Muser> candidates = new List<Muser>();
            foreach (Muser a in Muser_DL.Get_users_list())
            {
                if (a.Category == "candidate")
                {
                    candidates.Add(a);
                }
            }
            return candidates;
        }

        public static bool Leave_society(string name, string password)
        {
            foreach (Muser a in Muser_DL.Get_users_list())
            {
                if (a.Name == name && a.Password == password)
                {
                    Muser_DL.Remove_member(a);
                    return true;
                }
            }
            return false;
        }

        public static List<Muser> Sort_candidate(List<Muser> u)
        {
            List<Muser> sorted;
            sorted = u.OrderByDescending(o => o.Aggrigate).ToList();
            return sorted;
        }
    }
}
