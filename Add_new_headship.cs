using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using business_application.DL;
using business_application.BL;

namespace business_application
{
    public partial class Add_new_headship : Form
    {
        public Add_new_headship()
        {
            InitializeComponent();
        }

        private void btn_approve_candidate_Click(object sender, EventArgs e)
        {
            Approve_candidate New_form = new Approve_candidate();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_sorted_candidate_Click(object sender, EventArgs e)
        {
            Sorted_candidate New_form = new Sorted_candidate();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_Remove_member_Click(object sender, EventArgs e)
        {
            Remove_member New_form = new Remove_member();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_list_heads_Click(object sender, EventArgs e)
        {
            List_of_heads New_form = new List_of_heads();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_change_head_Click(object sender, EventArgs e)
        {
            Change_head New_form = new Change_head();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Head_main_menu New_form = new Head_main_menu(); 
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_dept.Text = "";
            txt_name.Text = "";
            lbl_Warning.Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_dept.Text == "" || txt_name.Text == "")
            {
                lbl_Warning.Visible = true;
            }
            else
            {
                string designation = "Head of " + txt_dept.Text + " department";
                string name = txt_name.Text;
                Muser a = Head_DL.Add_new_head(name, designation);
                Muser_DL.Remove_member(a);
                Muser_DL.Store_into_file();
                btn_Reset_Click(sender, e);
            }
        }
        private void Load_members()
        {
            List<Muser> users = Muser_DL.Get_members();
            List<string> names = Muser_DL.Get_members_name(users);
            foreach (string a in names)
            {
                txt_name.Items.Add(a);
            }
        }

        private void Add_new_headship_Load(object sender, EventArgs e)
        {
            Load_members();
        }
    }
}
